using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Collections;
using System.Threading;

namespace OrderFromCSharp
{   
    public partial class GroceryBank : Form
    {
        private CsvWriter writer;                        // the object to handle  write to file
        private CsvReader reader;                        // the object to handle reader from file
        private List<Volunteer> volunteers;              // store list of volunteer in VolunteersList.csv
        private List<Product> products;                  // store list of product in ProductsList.csv
        private ShoppingCart shoppingCart;               // store list of selected products
        private BasicShoppingCartCalculator calculator;  // cost calculator
        private Customer customer;                       // store customer information
        private Volunteer volunteer;                     // store volunteer information
        private double totalCost = 0;                    // tracking total cost        
        private List<CheckBox> checkBoxList;             // store CheckBox of Product to list       
        private List<TextBox> productTBList;             // store TextBox of Product to list
        private List<ComboBox> productCBList;            // store ComboBox of Product to list
        
        public GroceryBank()
        {
            InitializeComponent();
            writer = new CsvWriter();
            reader = new CsvReader();
            volunteers = new List<Volunteer>();
            products = new List<Product>();
            shoppingCart = new ShoppingCart();
            calculator = new BasicShoppingCartCalculator();
            customer = new Customer();
            volunteer = new Volunteer();
            checkBoxList = new List<CheckBox>();
            productTBList = new List<TextBox>();
            productCBList = new List<ComboBox>();
            this.ImportVolunteerData();
            this.ImportProductData();           
            this.Reset();
        }

        // ++++++++ First Column (Person Details, Householde Details-------------------------------------------------

        /// <summary>
        /// RemoveHouseholdMemberButton_Click event, just remove the selected member
        /// </summary>
        /// <param name="sender">The object that called the method</param>
        /// <param name="e">Information about the calling event</param>
        private void RemoveHouseholdMemberButton_Click(object sender, EventArgs e)
        {
            HouseholdMembers.Items.Remove(HouseholdMembers.SelectedItem);
        }

        /// <summary>
        /// EventHandle for AddHouseholdMemberButton_Click
        /// Add a recod to the list of householders. Very simple job.    
        /// </summary> 
        /// <param name="sender">The object that called the method</param>
        /// <param name="e">Information about the calling event</param>
        private void AddHouseholdMemberButton_Click(object sender, EventArgs e)
        {
            // If they press "Add" without entering any data, do nothing. Otherwise ....
            if ((this.Gender.Text != "" && this.Age.Text != ""))
            {
                // Add the details to the list box. Nothing elegant here.
                this.HouseholdMembers.Items.Add(this.Gender.Text + ", " + this.Age.Text);

                // Clear the boxes ready for the next record
                this.Age.Text = "";
                this.Gender.Text = "Unknown";

                // Move the focus back to the first box
                this.Age.Select();

                // In case this was an additional member after a preliminary cost was calculated, 
                //update the cost and quantity
                shoppingCart.UpdateQuantityRef(HouseholdMembers.Items.Count);
                CalculateCost();
            }
        }

        

        /// <summary>
        /// EventHandle for PersonalDetailsEntered
        /// I don't what anything to be entered unless there is at least some basic details.   
        /// </summary>   
        /// <param name="sender">The object that called the method</param>
        /// <param name="e">Information about the calling event</param>
        private void PersonalDetailsEntered(object sender, EventArgs e)
        {
            // Have basic contact details been entered? If so ...
            if ((this.FullName.Text != "" && this.Address.Text != "" && this.Contact.Text != ""))
            {
                // Enable the household details & volunteer details group box
                this.HouseholdDetailsGroupBox.Enabled = true;
                VolunteerCartCostPanel.Enabled = true;
                ProductTableLP.Enabled = true;

                // store customer informations
                customer.Name = FullName.Text;
                customer.Address = Address.Text;
                customer.Phone = Contact.Text;

                // ... and move the focus to the first text box
                // this.Age.Select();
            }
        }

        // +++++++++ Second Column (Product Table) ---------------------------------------------------------------------------

        /// <summary>
        /// Dynamically add products from ProductsList.csv to form and add product to products list.
        /// Add EventHanlde to caculate cost for checkbox checkchanged and textbox changed
        /// Add Anchor to make fluid layout
        /// </summary>     
        private void ImportProductData()
        {
            products = reader.ReadProductList();    // add product from file to list
            GroupBox categoryGB = new GroupBox();   // create groupbox for catagory
            int col = 0;                            // tracking column number of ProductTableLP                  
            int row = 0;                            // tracking row number of ProductTableLP
            int y = 21;                             // tracking position y of each product(Checkbox, Textbox,ComboBox,...)

            // add each product 
            for (int i = 0; i < products.Count; i++)
            {
                // change to another column 
                if (row > 1)
                {
                    col += 1;
                    row = 0;
                }

                // make sure only create one category groupbox for each kind of category
                if (i > 0)
                {
                    if (!products[i - 1].Category.Equals(products[i].Category))
                    {
                        y = 21;                                            // set position y
                        categoryGB = new GroupBox();
                        categoryGB.Text = products[i].Category;
                        categoryGB.Anchor = (AnchorStyles.Top | AnchorStyles.Left 
                            | AnchorStyles.Right | AnchorStyles.Bottom);
                        ProductTableLP.Controls.Add(categoryGB, col, row);   // add to ProductTableLP table                      
                        row += 1;                                          // change another row
                    }
                }
                else  // first group box
                {
                    categoryGB = new GroupBox();
                    categoryGB.Text = products[i].Category;
                    categoryGB.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
                    ProductTableLP.Controls.Add(categoryGB, col, row);    // add to ProductTableLP table           
                    row += 1;                                           // change another row
                }

                // create checkBox for each product
                CheckBox checkbox = new CheckBox();
                checkbox.Name = products[i].Name;
                checkbox.Text = products[i].Name;
                checkbox.Location = new Point(5, y);
                categoryGB.Controls.Add(checkbox);      // add CheckBox to category GroupBOx
                checkBoxList.Add(checkbox);             // add CheckBox to list
                y += 21;                                // change position y


                Product item = products[i];
                // add TextBox, Label, ComboBox for specical products
                if (products[i].Name.Equals("Sanitary products"))
                {
                    y += 5;
                    Label typeLB = new Label();
                    typeLB.Text = "Type";
                    typeLB.Location = new Point(5, y);
                    typeLB.Size = new Size(45, 20);
                    categoryGB.Controls.Add(typeLB);

                    TextBox SanitaryProductsType = new TextBox();
                    SanitaryProductsType.Size = new Size(80, 20);
                    SanitaryProductsType.Location = new Point(70, y);
                    SanitaryProductsType.Name = products[i].Name + "_type";
                    SanitaryProductsType.Enabled = false;
                    categoryGB.Controls.Add(SanitaryProductsType);
                    productTBList.Add(SanitaryProductsType);
                    SanitaryProductsType.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                    y += 25;

                    Label numberLB = new Label();
                    numberLB.Text = "Number";
                    numberLB.Size = new Size(60, 20);
                    numberLB.Location = new Point(5, y);
                    categoryGB.Controls.Add(numberLB);

                    TextBox ProductsNumber = new TextBox();
                    ProductsNumber.Size = new Size(80, 20);
                    ProductsNumber.Name = products[i].Name + "_number";
                    ProductsNumber.Enabled = false;
                    ProductsNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTextBox_KeyPress);
                    ProductsNumber.TextChanged += delegate (object s, EventArgs e1) { NumberBox_Changed(s, e1, item); };
                    ProductsNumber.Location = new Point(70, y);
                    categoryGB.Controls.Add(ProductsNumber);
                    productTBList.Add(ProductsNumber);
                    ProductsNumber.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                    y += 21;
                }
                else if (products[i].Name.Equals("Laundry detergent"))
                {
                    y += 5;
                    ComboBox WashingMachineType = new ComboBox();
                    WashingMachineType.Size = new Size(130, 20);
                    WashingMachineType.Location = new Point(20, y);
                    WashingMachineType.Name = products[i].Name + "_WMType";
                    WashingMachineType.SelectedIndex = -1;
                    WashingMachineType.Enabled = false;
                    WashingMachineType.Items.AddRange(new object[] { "Front Loader", "Top Loader" });
                    categoryGB.Controls.Add(WashingMachineType);
                    productCBList.Add(WashingMachineType);
                    WashingMachineType.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                    y += 25;

                    ComboBox LaundaryDetergentType = new ComboBox();
                    LaundaryDetergentType.Size = new Size(130, 20);
                    LaundaryDetergentType.Location = new Point(20, y);
                    LaundaryDetergentType.Name = products[i].Name + "_LDType";
                    LaundaryDetergentType.SelectedIndex = -1;
                    LaundaryDetergentType.Enabled = false;
                    LaundaryDetergentType.Items.AddRange(new object[] { "Liquid", "Powder" });
                    categoryGB.Controls.Add(LaundaryDetergentType);
                    productCBList.Add(LaundaryDetergentType);
                    LaundaryDetergentType.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                    y += 21;
                }
                else if (products[i].Name.Equals("Acne cream") || products[i].Name.Equals("Iron tablets")
                    || products[i].Name.Equals("Throat lozenges"))
                {
                    y += 5;
                    Label numberLB = new Label();
                    numberLB.Text = "Number";
                    numberLB.Size = new Size(60, 20);
                    numberLB.Location = new Point(5, y);
                    categoryGB.Controls.Add(numberLB);

                    TextBox ProductsNumber = new TextBox();
                    ProductsNumber.Name = products[i].Name + "_number";
                    ProductsNumber.Size = new Size(80, 20);
                    ProductsNumber.Location = new Point(70, y);
                    ProductsNumber.Enabled = false;
                    ProductsNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTextBox_KeyPress);
                    ProductsNumber.TextChanged += delegate (object s, EventArgs e1) { NumberBox_Changed(s, e1, item); };
                    categoryGB.Controls.Add(ProductsNumber);
                    productTBList.Add(ProductsNumber);
                    ProductsNumber.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                    y += 21;
                }

                // add eventhanlde for checkbox checkedchanged
                if (products[i].PricePer.Equals("quantity"))
                {
                    checkbox.CheckedChanged += delegate (object s, EventArgs e1) { EnabledNumberType(s, e1, item); };
                }
                else if (products[i].Name.Equals("Laundry detergent"))
                {
                    checkbox.CheckedChanged += delegate (object s, EventArgs e1) { EnabledNumberType(s, e1, item); };
                    checkbox.CheckedChanged += delegate (object s, EventArgs e1) { Product_Changed(s, e1, item); };
                }
                else
                {
                    checkbox.CheckedChanged += delegate (object s, EventArgs e1) { Product_Changed(s, e1, item); };
                }
            }
        }

        /// <summary>
        /// EventHandle for Product_Changed
        /// Update the running cost
        /// Update the shopping cart and display it
        /// </summary>      
        /// <param name="sender">The object that called the method</param>
        /// <param name="e">Information about the calling event</param>   
        /// <param name="item">product object of NumberBox</param> 
        private void Product_Changed(object sender, EventArgs e, Product item)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                shoppingCart.AddToCart(item, HouseholdMembers.Items.Count);
            }
            else
            {
                shoppingCart.RemoveFromCart(item);
            }
            ViewShoppingCart();
            this.CalculateCost();
        }

        /// <summary>
        /// EventHandle for NumberBox_Changed
        /// Update the running cost
        /// Update the shopping cart and display it
        /// </summary>  
        /// <param name="sender">The object that called the method</param>
        /// <param name="e">Information about the calling event</param>   
        /// <param name="item">product object of NumberBox</param> 
        private void NumberBox_Changed(object sender, EventArgs e, Product item)
        {
            TextBox numberBox = (TextBox)sender;
           
            if (!String.IsNullOrEmpty(numberBox.Text))
            {
                shoppingCart.AddToCart(item, Convert.ToInt32(numberBox.Text));
            }
            ViewShoppingCart();
            this.CalculateCost();
        }

        /// <summary>
        /// EventHandle for EnabledNumberType
        /// Set Enabled and Text,etc of related components of special products       
        /// </summary>
        /// <param name="sender">The object that called the method</param>
        /// <param name="e">Information about the calling event</param>
        /// <param name="item">product object of NumberBox</param> 
        private void EnabledNumberType(object sender, EventArgs e, Product item)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Name.Equals("Sanitary products"))
            {
                TextBox type = new TextBox();
                TextBox number = new TextBox();
                // looking the textbox for type and number
                foreach (TextBox tb in productTBList)
                {
                    if (tb.Name.Equals(checkBox.Name + "_type"))
                    {
                        type = tb;
                    }
                    else if (tb.Name.Equals(checkBox.Name + "_number"))
                    {
                        number = tb;
                    }
                }

                if (checkBox.Checked)
                {
                    type.Enabled = true;
                    number.Enabled = true;
                    type.Select();
                }
                else
                {
                    type.Enabled = false;
                    number.Enabled = false;
                    type.Text = "";
                    number.Text = "";
                    shoppingCart.RemoveFromCart(item);
                    ViewShoppingCart();
                    this.CalculateCost();
                }
            }
            else if (checkBox.Name.Equals("Laundry detergent"))
            {
                ComboBox LaundaryDetergentType = new ComboBox();
                ComboBox WashingMachineType = new ComboBox();
                // looking the textboxes
                foreach (ComboBox cb in productCBList)
                {
                    if (cb.Name.Equals(checkBox.Name + "_LDType"))
                    {
                        LaundaryDetergentType = cb;
                    }
                    else if (cb.Name.Equals(checkBox.Name + "_WMType"))
                    {
                        WashingMachineType = cb;
                    }
                }

                if (checkBox.Checked)
                {
                    LaundaryDetergentType.SelectedIndex = 0;
                    WashingMachineType.SelectedIndex = 0;
                    LaundaryDetergentType.Enabled = true;
                    WashingMachineType.Enabled = true;
                }
                else
                {
                    LaundaryDetergentType.SelectedIndex = -1;
                    WashingMachineType.SelectedIndex = -1;
                    LaundaryDetergentType.Enabled = false;
                    WashingMachineType.Enabled = false;
                }

            }
            else if (checkBox.Name.Equals("Throat lozenges") || checkBox.Name.Equals("Iron tablets")
                    || checkBox.Name.Equals("Acne cream"))
            {
                TextBox textBox = new TextBox();
                // looking the textbox
                foreach (TextBox tb in productTBList)
                {
                    if (tb.Name.Equals(checkBox.Name + "_number"))
                    {
                        textBox = tb;
                        break;
                    }
                }

                if (checkBox.Checked)
                {
                    textBox.Enabled = true;
                    textBox.Select();
                }
                else
                {
                    textBox.Enabled = false;
                    textBox.Text = "";
                    shoppingCart.RemoveFromCart(item);
                    ViewShoppingCart();
                    this.CalculateCost();
                }

            }
        }

        /// <summary>
        /// EventHandle for NumberTextBox_KeyPress 
        /// Method to limit entry into boxes that should only hold numbers    
        /// </summary> 
        /// <param name="sender">The object that called the method</param>
        /// <param name="e">Information about the calling event</param>
        private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check what key was pressed. If it wasn't a number or a control (return, delete, etc) ...
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                // ... handle it by doing nothing, aka "don't add it to the box"
                e.Handled = true;
        }

        // +++++++++ Third Column (Volunteer Details, Shopping Cart, Cost, Key Buttons)----------------------------

        /// <summary>
        /// Dynamically add volunterr form VolunteerList.csv to comboBox
        /// And add to volunteers list       
        /// </summary>                
        private void ImportVolunteerData()
        {
            VolunteerName.Items.Clear();                    // clear the old data
            volunteers = reader.ReadVolunteerList();  // store list of volunteers
            foreach (Volunteer person in volunteers)
            {
                VolunteerName.Items.Add(person.Name);       // Set volunteer name in the VolunnteerName combo box    
            }
        }

        /// <summary>
        /// EventHandle for VolunteerName_SelectedIndexChanged
        /// Store volunteer person, enable related Buttons    
        /// </summary>
        /// <param name="sender">The object that called the method</param>
        /// <param name="e">Information about the calling event</param>
        private void VolunteerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Volunteer v in volunteers)
            {
                if (v.Name.Equals(VolunteerName.Text))
                {
                    volunteer = v;                      // store volunteer
                    VolunteerPhone.Text = v.Phone;
                    break;
                }
            }            
            volunteerEditBtn.Enabled = true;
            volunteerRemoveBtn.Enabled = true;
        }

        /// <summary>
        /// EventHandle for VolunteerAddBtn_Click
        /// set enable related Buttons
        /// set visiable for related Panel
        /// </summary> 
        /// <param name="sender">The object that called the method</param>
        /// <param name="e">Information about the calling event</param>
        private void VolunteerAddBtn_Click(object sender, EventArgs e)
        {
            volunteerEditBtn.Enabled = false;
            volunteerRemoveBtn.Enabled = false;
            volunteerEditablePanel.Visible = true;
        }

        /// <summary>
        /// EventHandle for VolunteerEditBtn_Click
        /// set enable related Buttons
        /// set visiable for related Panel
        /// </summary>  
        /// <param name="sender">The object that called the method</param>
        /// <param name="e">Information about the calling event</param>
        private void VolunteerEditBtn_Click(object sender, EventArgs e)
        {
            volunteerAddBtn.Enabled = false;
            volunteerRemoveBtn.Enabled = false;
            volunteerEditablePanel.Visible = true;
            newVolunteerName.Text = volunteer.Name;
            newVolunteerPhone.Text = volunteer.Phone;
        }

        /// <summary>
        /// EventHandle for VolunteerRemoveBtn_Click
        /// remove volunteer from list and file      
        /// </summary>  
        /// <param name="sender">The object that called the method</param>
        /// <param name="e">Information about the calling event</param>
        private void VolunteerRemoveBtn_Click(object sender, EventArgs e)
        {
            volunteers.Remove(volunteer);
            writer.CreateNewVolunteerList(volunteers);
            ImportVolunteerData();
            VolunteerName.SelectedIndex = 0;
            VolunteerName.Select();
        }

        /// <summary>
        /// EventHandle for VolunteerSaveBtn_Click
        /// add new volunteer or edited volunteer to list and file    
        /// </summary>  
        /// <param name="sender">The object that called the method</param>
        /// <param name="e">Information about the calling event</param>
        private void VolunteerSaveBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(newVolunteerName.Text) && !String.IsNullOrWhiteSpace(newVolunteerPhone.Text))
            {
                if (volunteerEditBtn.Enabled && !volunteerAddBtn.Enabled)
                {
                    volunteers.Remove(volunteer);
                }
                Volunteer person = new Volunteer(newVolunteerName.Text, newVolunteerPhone.Text);
                volunteers.Add(person);
                writer.CreateNewVolunteerList(volunteers);
                ImportVolunteerData();
                VolunteerName.Select();
                volunteer = person;
                VolunteerName.Text = person.Name;
                VolunteerPhone.Text = person.Phone;
                VolunteerCancelBtn_Click(sender, e); // reset and hide unnecessary items
            }
            else if (!String.IsNullOrWhiteSpace(newVolunteerName.Text) && String.IsNullOrWhiteSpace(newVolunteerPhone.Text))
            {
                newVolunteerPhone.Select();
            }
            else if (String.IsNullOrWhiteSpace(newVolunteerName.Text) && !String.IsNullOrWhiteSpace(newVolunteerPhone.Text))
            {
                newVolunteerName.Select();
            }
        }
        
        /// <summary>
        /// EventHandle for VVolunteerCancelBtn_Click
        /// set enable related Buttons
        /// set visiable for related Panel
        /// </summary>  
        /// <param name="sender">The object that called the method</param>
        /// <param name="e">Information about the calling event</param>
        private void VolunteerCancelBtn_Click(object sender, EventArgs e)
        {
            // reset and hide unnecessary items
            volunteerEditablePanel.Visible = false;
            volunteerAddBtn.Enabled = true;
            volunteerEditBtn.Enabled = true;
            volunteerRemoveBtn.Enabled = true;
            newVolunteerName.Text = "";
            newVolunteerPhone.Text = "";
        }

        /// <summary>
        /// Show selected products to list box  
        /// </summary>  
        private void ViewShoppingCart()
        {
            shoppingCartListBox.Items.Clear();

            foreach (Product item in shoppingCart.MyBasket.Keys)
            {
                shoppingCartListBox.Items.Add(item.Name);
            }
        }

        /// <summary>
        /// CalculateCost is another brute force method to run through each of the fields, see if it is selected, and 
        /// get a running total that is updated as each entry is changed. I wouldn't be upset if this was refactored to be  
        /// less bruite force and more elegant, but it works as is
        /// </summary>  
        private void CalculateCost()
        {
            totalCost = calculator.CalculateBasicCost(shoppingCart);
            // Display the raw cost (before adding shipping) in the box, formatted to be currency
            this.Cost.Text = totalCost.ToString("C", CultureInfo.CurrentCulture);

            // Add shipping if there is something to be sent
            if ((totalCost > 0))
                totalCost = calculator.TotalCostWithDelivery(shoppingCart);

            // Display the final cost (with shipping) in the box, formatted to be currency
            this.Total.Text = totalCost.ToString("C", CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// EventHandle for NewRecord_Click
        /// just reset the form    
        /// </summary>   
        /// <param name="sender">The object that called the method</param>
        /// <param name="e">Information about the calling event</param>
        private void NewRecord_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        /// <summary>
        /// EventHandle for CheckOutBtn_Click
        /// Print shopping list to file
        /// Append new order OrderRecord file
        /// reset the form    
        /// </summary>  
        /// <param name="sender">The object that called the method</param>
        /// <param name="e">Information about the calling event</param>
        private void CheckOutBtn_Click(object sender, EventArgs e)
        {
            if (HouseholdMembers.Items.Count == 0)
            {
                MessageBox.Show("Please add household member");
                Age.Select();
            }
            else
            {
                if (!String.IsNullOrEmpty(volunteer.Name))
                {
                    writer.WriteShoppingList(shoppingCart, customer, volunteer, HouseholdMembers.Items.Count);
                    writer.WriteOrderRecord(customer, totalCost, volunteer);
                    MessageBox.Show("Shopping List printed. Order recorded.\n Please check updated files in bin/Debug");
                    this.Reset();
                }
                else
                {
                    MessageBox.Show("Please choose a volunteer");
                    VolunteerName.Select();
                }
            }
        }

        // +++++++++ Other necessary method and eventhandle------------------------------------------------------------------

        /// <summary>
        /// EventHandle for Quit_Click
        /// exit the form    
        /// </summary>
        /// <param name="sender">The object that called the method</param>
        /// <param name="e">Information about the calling event</param>
        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            System.Environment.Exit(0);
        }

        /// <summary>
        /// This is a brute-force method of clearing all of the form elements, enabling or disabling regions, 
        /// and preparing the form to accept a new record.      
        /// </summary>          
        public void Reset()
        {
            // it should already be enabled, but just to be sure, enable the personal details groupbox
            this.PersonalDetailsGroupBox.Enabled = true;

            // disable the unecessary groupboxes
            this.HouseholdDetailsGroupBox.Enabled = false;
            VolunteerCartCostPanel.Enabled = false;
            ProductTableLP.Enabled = false;

            // blank the personal details fields
            this.FullName.Text = "";
            this.Address.Text = "";
            this.Contact.Text = "";

            // blank the list of householders
            this.Age.Text = "";
            this.Gender.Text = "Unknown";
            this.HouseholdMembers.Items.Clear();

            // reset checkbox  in product
            foreach (CheckBox cb in checkBoxList)
            {
                cb.Checked = false;
            }
            // reset textbox in product
            foreach (TextBox tb in productTBList)
            {
                tb.Text = "";
            }
            //reset combobox
            foreach (ComboBox cb in productCBList)
            {
                cb.SelectedIndex = -1;
            }

            // Reset the cost box
            this.Shipping.Text = "$5.00";
            this.Cost.Text = "$0.00";
            this.Total.Text = "$0.00";

            // move the focus to the first text box
            this.FullName.Select();

            // reset volunteer groupb box
            volunteerAddBtn.Enabled = true;
            volunteerEditBtn.Enabled = false;
            volunteerRemoveBtn.Enabled = false;
            newVolunteerName.Text = "";
            newVolunteerPhone.Text = "";
            VolunteerName.Text = "";
            VolunteerPhone.Text = "";

            //reset variables
            shoppingCart = new ShoppingCart();
            customer = new Customer();
            volunteer = new Volunteer();
            shoppingCartListBox.Items.Clear();
        }
    }
}


