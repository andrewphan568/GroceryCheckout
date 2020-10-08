namespace OrderFromCSharp
{
    partial class GroceryBank
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.NewRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.HouseholdDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoveHouseholdMemberButton = new System.Windows.Forms.Button();
            this.AddHouseholdMemberButton = new System.Windows.Forms.Button();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.HouseholdMembers = new System.Windows.Forms.ListBox();
            this.PersonalDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.Contact = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.FullName = new System.Windows.Forms.TextBox();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.VolunteerCartCostPanel = new System.Windows.Forms.Panel();
            this.volunteerDetailsGB = new System.Windows.Forms.GroupBox();
            this.volunteerEditablePanel = new System.Windows.Forms.Panel();
            this.newVolunteerName = new System.Windows.Forms.TextBox();
            this.volunteerCancelBtn = new System.Windows.Forms.Button();
            this.newVolunteerPhone = new System.Windows.Forms.TextBox();
            this.volunteerSaveBtn = new System.Windows.Forms.Button();
            this.phoneLb = new System.Windows.Forms.Label();
            this.nameLb = new System.Windows.Forms.Label();
            this.volunteerRemoveBtn = new System.Windows.Forms.Button();
            this.volunteerEditBtn = new System.Windows.Forms.Button();
            this.VolunteerPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.volunteerAddBtn = new System.Windows.Forms.Button();
            this.VolunteerName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkOutBtn = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.CostGroupBox = new System.Windows.Forms.GroupBox();
            this.Total = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.Shipping = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ShippingLabel = new System.Windows.Forms.Label();
            this.shoppingCartGB = new System.Windows.Forms.GroupBox();
            this.shoppingCartListBox = new System.Windows.Forms.ListBox();
            this.ProductTableLP = new System.Windows.Forms.TableLayoutPanel();
            this.MenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.HouseholdDetailsGroupBox.SuspendLayout();
            this.PersonalDetailsGroupBox.SuspendLayout();
            this.VolunteerCartCostPanel.SuspendLayout();
            this.volunteerDetailsGB.SuspendLayout();
            this.volunteerEditablePanel.SuspendLayout();
            this.CostGroupBox.SuspendLayout();
            this.shoppingCartGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewRecord,
            this.Quit});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(46, 26);
            this.File.Text = "File";
            // 
            // NewRecord
            // 
            this.NewRecord.Name = "NewRecord";
            this.NewRecord.Size = new System.Drawing.Size(122, 26);
            this.NewRecord.Text = "New";
            this.NewRecord.Click += new System.EventHandler(this.NewRecord_Click);
            // 
            // Quit
            // 
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(122, 26);
            this.Quit.Text = "Quit";
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(982, 30);
            this.MenuStrip1.TabIndex = 44;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.Controls.Add(this.Panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.VolunteerCartCostPanel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ProductTableLP, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 643);
            this.tableLayoutPanel1.TabIndex = 45;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Panel1.Controls.Add(this.HouseholdDetailsGroupBox);
            this.Panel1.Controls.Add(this.PersonalDetailsGroupBox);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(3, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(239, 637);
            this.Panel1.TabIndex = 3;
            // 
            // HouseholdDetailsGroupBox
            // 
            this.HouseholdDetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HouseholdDetailsGroupBox.Controls.Add(this.RemoveHouseholdMemberButton);
            this.HouseholdDetailsGroupBox.Controls.Add(this.AddHouseholdMemberButton);
            this.HouseholdDetailsGroupBox.Controls.Add(this.Gender);
            this.HouseholdDetailsGroupBox.Controls.Add(this.GenderLabel);
            this.HouseholdDetailsGroupBox.Controls.Add(this.AgeLabel);
            this.HouseholdDetailsGroupBox.Controls.Add(this.Age);
            this.HouseholdDetailsGroupBox.Controls.Add(this.HouseholdMembers);
            this.HouseholdDetailsGroupBox.Location = new System.Drawing.Point(10, 232);
            this.HouseholdDetailsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.HouseholdDetailsGroupBox.Name = "HouseholdDetailsGroupBox";
            this.HouseholdDetailsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.HouseholdDetailsGroupBox.Size = new System.Drawing.Size(225, 401);
            this.HouseholdDetailsGroupBox.TabIndex = 44;
            this.HouseholdDetailsGroupBox.TabStop = false;
            this.HouseholdDetailsGroupBox.Text = "Household Details";
            // 
            // RemoveHouseholdMemberButton
            // 
            this.RemoveHouseholdMemberButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveHouseholdMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveHouseholdMemberButton.Location = new System.Drawing.Point(123, 153);
            this.RemoveHouseholdMemberButton.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveHouseholdMemberButton.Name = "RemoveHouseholdMemberButton";
            this.RemoveHouseholdMemberButton.Size = new System.Drawing.Size(88, 28);
            this.RemoveHouseholdMemberButton.TabIndex = 6;
            this.RemoveHouseholdMemberButton.Text = "Remove";
            this.RemoveHouseholdMemberButton.UseVisualStyleBackColor = true;
            this.RemoveHouseholdMemberButton.Click += new System.EventHandler(this.RemoveHouseholdMemberButton_Click);
            // 
            // AddHouseholdMemberButton
            // 
            this.AddHouseholdMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddHouseholdMemberButton.Location = new System.Drawing.Point(23, 153);
            this.AddHouseholdMemberButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddHouseholdMemberButton.Name = "AddHouseholdMemberButton";
            this.AddHouseholdMemberButton.Size = new System.Drawing.Size(87, 28);
            this.AddHouseholdMemberButton.TabIndex = 6;
            this.AddHouseholdMemberButton.Text = "Add";
            this.AddHouseholdMemberButton.UseVisualStyleBackColor = true;
            this.AddHouseholdMemberButton.Click += new System.EventHandler(this.AddHouseholdMemberButton_Click);
            // 
            // Gender
            // 
            this.Gender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gender.BackColor = System.Drawing.Color.White;
            this.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Unknown",
            "Female",
            "Male",
            "Other"});
            this.Gender.Location = new System.Drawing.Point(23, 109);
            this.Gender.Margin = new System.Windows.Forms.Padding(4);
            this.Gender.MaxDropDownItems = 4;
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(188, 24);
            this.Gender.TabIndex = 5;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(22, 75);
            this.GenderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(56, 17);
            this.GenderLabel.TabIndex = 0;
            this.GenderLabel.Text = "Gender";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(20, 28);
            this.AgeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(33, 17);
            this.AgeLabel.TabIndex = 0;
            this.AgeLabel.Text = "Age";
            // 
            // Age
            // 
            this.Age.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Age.Location = new System.Drawing.Point(23, 49);
            this.Age.Margin = new System.Windows.Forms.Padding(4);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(188, 22);
            this.Age.TabIndex = 4;
            this.Age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTextBox_KeyPress);
            // 
            // HouseholdMembers
            // 
            this.HouseholdMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HouseholdMembers.FormattingEnabled = true;
            this.HouseholdMembers.ItemHeight = 16;
            this.HouseholdMembers.Location = new System.Drawing.Point(8, 190);
            this.HouseholdMembers.Margin = new System.Windows.Forms.Padding(4);
            this.HouseholdMembers.Name = "HouseholdMembers";
            this.HouseholdMembers.Size = new System.Drawing.Size(209, 164);
            this.HouseholdMembers.TabIndex = 0;
            // 
            // PersonalDetailsGroupBox
            // 
            this.PersonalDetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PersonalDetailsGroupBox.Controls.Add(this.Contact);
            this.PersonalDetailsGroupBox.Controls.Add(this.Address);
            this.PersonalDetailsGroupBox.Controls.Add(this.FullName);
            this.PersonalDetailsGroupBox.Controls.Add(this.ContactLabel);
            this.PersonalDetailsGroupBox.Controls.Add(this.AddressLabel);
            this.PersonalDetailsGroupBox.Controls.Add(this.FullNameLabel);
            this.PersonalDetailsGroupBox.Location = new System.Drawing.Point(10, 17);
            this.PersonalDetailsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.PersonalDetailsGroupBox.Name = "PersonalDetailsGroupBox";
            this.PersonalDetailsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.PersonalDetailsGroupBox.Size = new System.Drawing.Size(225, 211);
            this.PersonalDetailsGroupBox.TabIndex = 43;
            this.PersonalDetailsGroupBox.TabStop = false;
            this.PersonalDetailsGroupBox.Text = "Personal Details";
            // 
            // Contact
            // 
            this.Contact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Contact.Location = new System.Drawing.Point(25, 185);
            this.Contact.Margin = new System.Windows.Forms.Padding(4);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(186, 22);
            this.Contact.TabIndex = 2;
            this.Contact.TextChanged += new System.EventHandler(this.PersonalDetailsEntered);
            this.Contact.Leave += new System.EventHandler(this.PersonalDetailsEntered);
            // 
            // Address
            // 
            this.Address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Address.Location = new System.Drawing.Point(24, 95);
            this.Address.Margin = new System.Windows.Forms.Padding(4);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(187, 65);
            this.Address.TabIndex = 1;
            this.Address.Leave += new System.EventHandler(this.PersonalDetailsEntered);
            // 
            // FullName
            // 
            this.FullName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullName.Location = new System.Drawing.Point(24, 44);
            this.FullName.Margin = new System.Windows.Forms.Padding(4);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(187, 22);
            this.FullName.TabIndex = 0;
            this.FullName.Leave += new System.EventHandler(this.PersonalDetailsEntered);
            // 
            // ContactLabel
            // 
            this.ContactLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Location = new System.Drawing.Point(22, 164);
            this.ContactLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(110, 17);
            this.ContactLabel.TabIndex = 0;
            this.ContactLabel.Text = "Contact Number";
            // 
            // AddressLabel
            // 
            this.AddressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(20, 75);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(60, 17);
            this.AddressLabel.TabIndex = 0;
            this.AddressLabel.Text = "Address";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(20, 25);
            this.FullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(45, 17);
            this.FullNameLabel.TabIndex = 0;
            this.FullNameLabel.Text = "Name";
            // 
            // VolunteerCartCostPanel
            // 
            this.VolunteerCartCostPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.VolunteerCartCostPanel.Controls.Add(this.volunteerDetailsGB);
            this.VolunteerCartCostPanel.Controls.Add(this.checkOutBtn);
            this.VolunteerCartCostPanel.Controls.Add(this.NewButton);
            this.VolunteerCartCostPanel.Controls.Add(this.CostGroupBox);
            this.VolunteerCartCostPanel.Controls.Add(this.shoppingCartGB);
            this.VolunteerCartCostPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VolunteerCartCostPanel.Location = new System.Drawing.Point(709, 3);
            this.VolunteerCartCostPanel.Name = "VolunteerCartCostPanel";
            this.VolunteerCartCostPanel.Size = new System.Drawing.Size(270, 637);
            this.VolunteerCartCostPanel.TabIndex = 4;
            // 
            // volunteerDetailsGB
            // 
            this.volunteerDetailsGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volunteerDetailsGB.Controls.Add(this.volunteerEditablePanel);
            this.volunteerDetailsGB.Controls.Add(this.volunteerRemoveBtn);
            this.volunteerDetailsGB.Controls.Add(this.volunteerEditBtn);
            this.volunteerDetailsGB.Controls.Add(this.VolunteerPhone);
            this.volunteerDetailsGB.Controls.Add(this.label2);
            this.volunteerDetailsGB.Controls.Add(this.volunteerAddBtn);
            this.volunteerDetailsGB.Controls.Add(this.VolunteerName);
            this.volunteerDetailsGB.Controls.Add(this.label1);
            this.volunteerDetailsGB.Location = new System.Drawing.Point(9, 3);
            this.volunteerDetailsGB.Name = "volunteerDetailsGB";
            this.volunteerDetailsGB.Size = new System.Drawing.Size(239, 236);
            this.volunteerDetailsGB.TabIndex = 45;
            this.volunteerDetailsGB.TabStop = false;
            this.volunteerDetailsGB.Text = "Volunteer Details";
            // 
            // volunteerEditablePanel
            // 
            this.volunteerEditablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volunteerEditablePanel.Controls.Add(this.newVolunteerName);
            this.volunteerEditablePanel.Controls.Add(this.volunteerCancelBtn);
            this.volunteerEditablePanel.Controls.Add(this.newVolunteerPhone);
            this.volunteerEditablePanel.Controls.Add(this.volunteerSaveBtn);
            this.volunteerEditablePanel.Controls.Add(this.phoneLb);
            this.volunteerEditablePanel.Controls.Add(this.nameLb);
            this.volunteerEditablePanel.Location = new System.Drawing.Point(6, 130);
            this.volunteerEditablePanel.Name = "volunteerEditablePanel";
            this.volunteerEditablePanel.Size = new System.Drawing.Size(227, 96);
            this.volunteerEditablePanel.TabIndex = 0;
            this.volunteerEditablePanel.Visible = false;
            // 
            // newVolunteerName
            // 
            this.newVolunteerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newVolunteerName.Location = new System.Drawing.Point(57, 4);
            this.newVolunteerName.Margin = new System.Windows.Forms.Padding(4);
            this.newVolunteerName.Name = "newVolunteerName";
            this.newVolunteerName.Size = new System.Drawing.Size(166, 22);
            this.newVolunteerName.TabIndex = 55;
            // 
            // volunteerCancelBtn
            // 
            this.volunteerCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volunteerCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volunteerCancelBtn.Location = new System.Drawing.Point(130, 64);
            this.volunteerCancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.volunteerCancelBtn.Name = "volunteerCancelBtn";
            this.volunteerCancelBtn.Size = new System.Drawing.Size(93, 28);
            this.volunteerCancelBtn.TabIndex = 6;
            this.volunteerCancelBtn.Text = "Cancel";
            this.volunteerCancelBtn.UseVisualStyleBackColor = true;
            this.volunteerCancelBtn.Click += new System.EventHandler(this.VolunteerCancelBtn_Click);
            // 
            // newVolunteerPhone
            // 
            this.newVolunteerPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newVolunteerPhone.Location = new System.Drawing.Point(57, 34);
            this.newVolunteerPhone.Margin = new System.Windows.Forms.Padding(4);
            this.newVolunteerPhone.Name = "newVolunteerPhone";
            this.newVolunteerPhone.Size = new System.Drawing.Size(166, 22);
            this.newVolunteerPhone.TabIndex = 55;
            // 
            // volunteerSaveBtn
            // 
            this.volunteerSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volunteerSaveBtn.Location = new System.Drawing.Point(57, 64);
            this.volunteerSaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.volunteerSaveBtn.Name = "volunteerSaveBtn";
            this.volunteerSaveBtn.Size = new System.Drawing.Size(66, 28);
            this.volunteerSaveBtn.TabIndex = 6;
            this.volunteerSaveBtn.Text = "Save";
            this.volunteerSaveBtn.UseVisualStyleBackColor = true;
            this.volunteerSaveBtn.Click += new System.EventHandler(this.VolunteerSaveBtn_Click);
            // 
            // phoneLb
            // 
            this.phoneLb.AutoSize = true;
            this.phoneLb.Location = new System.Drawing.Point(1, 37);
            this.phoneLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLb.Name = "phoneLb";
            this.phoneLb.Size = new System.Drawing.Size(53, 17);
            this.phoneLb.TabIndex = 54;
            this.phoneLb.Text = "Phone ";
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Location = new System.Drawing.Point(4, 9);
            this.nameLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(45, 17);
            this.nameLb.TabIndex = 53;
            this.nameLb.Text = "Name";
            // 
            // volunteerRemoveBtn
            // 
            this.volunteerRemoveBtn.Enabled = false;
            this.volunteerRemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volunteerRemoveBtn.Location = new System.Drawing.Point(13, 95);
            this.volunteerRemoveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.volunteerRemoveBtn.Name = "volunteerRemoveBtn";
            this.volunteerRemoveBtn.Size = new System.Drawing.Size(85, 28);
            this.volunteerRemoveBtn.TabIndex = 6;
            this.volunteerRemoveBtn.Text = "Remove";
            this.volunteerRemoveBtn.UseVisualStyleBackColor = true;
            this.volunteerRemoveBtn.Click += new System.EventHandler(this.VolunteerRemoveBtn_Click);
            // 
            // volunteerEditBtn
            // 
            this.volunteerEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volunteerEditBtn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.volunteerEditBtn.Enabled = false;
            this.volunteerEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volunteerEditBtn.Location = new System.Drawing.Point(106, 95);
            this.volunteerEditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.volunteerEditBtn.Name = "volunteerEditBtn";
            this.volunteerEditBtn.Size = new System.Drawing.Size(54, 28);
            this.volunteerEditBtn.TabIndex = 6;
            this.volunteerEditBtn.Text = "Edit";
            this.volunteerEditBtn.UseVisualStyleBackColor = true;
            this.volunteerEditBtn.Click += new System.EventHandler(this.VolunteerEditBtn_Click);
            // 
            // VolunteerPhone
            // 
            this.VolunteerPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VolunteerPhone.Location = new System.Drawing.Point(58, 65);
            this.VolunteerPhone.Margin = new System.Windows.Forms.Padding(4);
            this.VolunteerPhone.Name = "VolunteerPhone";
            this.VolunteerPhone.Size = new System.Drawing.Size(174, 22);
            this.VolunteerPhone.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Phone ";
            // 
            // volunteerAddBtn
            // 
            this.volunteerAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volunteerAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volunteerAddBtn.Location = new System.Drawing.Point(168, 95);
            this.volunteerAddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.volunteerAddBtn.Name = "volunteerAddBtn";
            this.volunteerAddBtn.Size = new System.Drawing.Size(60, 28);
            this.volunteerAddBtn.TabIndex = 6;
            this.volunteerAddBtn.Text = "Add";
            this.volunteerAddBtn.UseVisualStyleBackColor = true;
            this.volunteerAddBtn.Click += new System.EventHandler(this.VolunteerAddBtn_Click);
            // 
            // VolunteerName
            // 
            this.VolunteerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VolunteerName.FormattingEnabled = true;
            this.VolunteerName.Location = new System.Drawing.Point(58, 28);
            this.VolunteerName.Name = "VolunteerName";
            this.VolunteerName.Size = new System.Drawing.Size(175, 24);
            this.VolunteerName.TabIndex = 50;
            this.VolunteerName.SelectedIndexChanged += new System.EventHandler(this.VolunteerName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkOutBtn.Location = new System.Drawing.Point(135, 590);
            this.checkOutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Size = new System.Drawing.Size(102, 28);
            this.checkOutBtn.TabIndex = 49;
            this.checkOutBtn.Text = "Check Out";
            this.checkOutBtn.UseVisualStyleBackColor = true;
            this.checkOutBtn.Click += new System.EventHandler(this.CheckOutBtn_Click);
            // 
            // NewButton
            // 
            this.NewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewButton.Location = new System.Drawing.Point(13, 590);
            this.NewButton.Margin = new System.Windows.Forms.Padding(4);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(89, 28);
            this.NewButton.TabIndex = 49;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewRecord_Click);
            // 
            // CostGroupBox
            // 
            this.CostGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CostGroupBox.Controls.Add(this.Total);
            this.CostGroupBox.Controls.Add(this.TotalLabel);
            this.CostGroupBox.Controls.Add(this.Cost);
            this.CostGroupBox.Controls.Add(this.Shipping);
            this.CostGroupBox.Controls.Add(this.CostLabel);
            this.CostGroupBox.Controls.Add(this.ShippingLabel);
            this.CostGroupBox.Location = new System.Drawing.Point(13, 465);
            this.CostGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.CostGroupBox.Name = "CostGroupBox";
            this.CostGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.CostGroupBox.Size = new System.Drawing.Size(235, 117);
            this.CostGroupBox.TabIndex = 42;
            this.CostGroupBox.TabStop = false;
            this.CostGroupBox.Text = "Cost";
            // 
            // Total
            // 
            this.Total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Total.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Total.ForeColor = System.Drawing.Color.DarkRed;
            this.Total.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Total.Location = new System.Drawing.Point(102, 90);
            this.Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(123, 24);
            this.Total.TabIndex = 0;
            this.Total.Text = "0";
            this.Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(18, 90);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(40, 17);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "Total";
            // 
            // Cost
            // 
            this.Cost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cost.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cost.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Cost.Location = new System.Drawing.Point(102, 60);
            this.Cost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(123, 20);
            this.Cost.TabIndex = 0;
            this.Cost.Text = "0";
            this.Cost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Shipping
            // 
            this.Shipping.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Shipping.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Shipping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Shipping.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Shipping.Location = new System.Drawing.Point(102, 28);
            this.Shipping.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Shipping.Name = "Shipping";
            this.Shipping.Size = new System.Drawing.Size(123, 22);
            this.Shipping.TabIndex = 0;
            this.Shipping.Text = "$5.00";
            this.Shipping.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(17, 63);
            this.CostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(36, 17);
            this.CostLabel.TabIndex = 0;
            this.CostLabel.Text = "Cost";
            // 
            // ShippingLabel
            // 
            this.ShippingLabel.AutoSize = true;
            this.ShippingLabel.Location = new System.Drawing.Point(17, 33);
            this.ShippingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShippingLabel.Name = "ShippingLabel";
            this.ShippingLabel.Size = new System.Drawing.Size(63, 17);
            this.ShippingLabel.TabIndex = 0;
            this.ShippingLabel.Text = "Shipping";
            // 
            // shoppingCartGB
            // 
            this.shoppingCartGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shoppingCartGB.Controls.Add(this.shoppingCartListBox);
            this.shoppingCartGB.Location = new System.Drawing.Point(9, 245);
            this.shoppingCartGB.Name = "shoppingCartGB";
            this.shoppingCartGB.Size = new System.Drawing.Size(239, 213);
            this.shoppingCartGB.TabIndex = 0;
            this.shoppingCartGB.TabStop = false;
            this.shoppingCartGB.Text = "Shopping Cart";
            // 
            // shoppingCartListBox
            // 
            this.shoppingCartListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shoppingCartListBox.FormattingEnabled = true;
            this.shoppingCartListBox.ItemHeight = 16;
            this.shoppingCartListBox.Location = new System.Drawing.Point(6, 26);
            this.shoppingCartListBox.Name = "shoppingCartListBox";
            this.shoppingCartListBox.Size = new System.Drawing.Size(227, 148);
            this.shoppingCartListBox.TabIndex = 0;
            // 
            // ProductTableLP
            // 
            this.ProductTableLP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductTableLP.BackColor = System.Drawing.Color.Aqua;
            this.ProductTableLP.ColumnCount = 2;
            this.ProductTableLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ProductTableLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ProductTableLP.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.ProductTableLP.Location = new System.Drawing.Point(248, 3);
            this.ProductTableLP.Name = "ProductTableLP";
            this.ProductTableLP.RowCount = 2;
            this.ProductTableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ProductTableLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ProductTableLP.Size = new System.Drawing.Size(455, 637);
            this.ProductTableLP.TabIndex = 5;
            // 
            // GroceryBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 673);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MenuStrip1);
            this.MinimumSize = new System.Drawing.Size(1000, 720);
            this.Name = "GroceryBank";
            this.Text = "Form1";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.HouseholdDetailsGroupBox.ResumeLayout(false);
            this.HouseholdDetailsGroupBox.PerformLayout();
            this.PersonalDetailsGroupBox.ResumeLayout(false);
            this.PersonalDetailsGroupBox.PerformLayout();
            this.VolunteerCartCostPanel.ResumeLayout(false);
            this.volunteerDetailsGB.ResumeLayout(false);
            this.volunteerDetailsGB.PerformLayout();
            this.volunteerEditablePanel.ResumeLayout(false);
            this.volunteerEditablePanel.PerformLayout();
            this.CostGroupBox.ResumeLayout(false);
            this.CostGroupBox.PerformLayout();
            this.shoppingCartGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.ToolStripMenuItem File;
        internal System.Windows.Forms.ToolStripMenuItem NewRecord;
        internal System.Windows.Forms.ToolStripMenuItem Quit;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.GroupBox PersonalDetailsGroupBox;
        internal System.Windows.Forms.TextBox Contact;
        internal System.Windows.Forms.TextBox Address;
        internal System.Windows.Forms.TextBox FullName;
        internal System.Windows.Forms.Label ContactLabel;
        internal System.Windows.Forms.Label AddressLabel;
        internal System.Windows.Forms.Label FullNameLabel;
        internal System.Windows.Forms.GroupBox HouseholdDetailsGroupBox;
        internal System.Windows.Forms.Button RemoveHouseholdMemberButton;
        internal System.Windows.Forms.Button AddHouseholdMemberButton;
        internal System.Windows.Forms.ComboBox Gender;
        internal System.Windows.Forms.Label GenderLabel;
        internal System.Windows.Forms.Label AgeLabel;
        internal System.Windows.Forms.TextBox Age;
        internal System.Windows.Forms.ListBox HouseholdMembers;
        internal System.Windows.Forms.GroupBox volunteerDetailsGB;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button volunteerRemoveBtn;
        internal System.Windows.Forms.Button volunteerAddBtn;
        internal System.Windows.Forms.ComboBox VolunteerName;
        internal System.Windows.Forms.Button volunteerEditBtn;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox VolunteerPhone;
        internal System.Windows.Forms.TextBox newVolunteerName;
        internal System.Windows.Forms.TextBox newVolunteerPhone;
        internal System.Windows.Forms.Label phoneLb;
        internal System.Windows.Forms.Label nameLb;
        internal System.Windows.Forms.Button volunteerSaveBtn;
        internal System.Windows.Forms.Button NewButton;
        internal System.Windows.Forms.Button volunteerCancelBtn;
        internal System.Windows.Forms.GroupBox CostGroupBox;
        internal System.Windows.Forms.Label Total;
        internal System.Windows.Forms.Label TotalLabel;
        internal System.Windows.Forms.Label Cost;
        internal System.Windows.Forms.Label Shipping;
        internal System.Windows.Forms.Label CostLabel;
        internal System.Windows.Forms.Label ShippingLabel;
        internal System.Windows.Forms.Button checkOutBtn;
        private System.Windows.Forms.GroupBox shoppingCartGB;
        private System.Windows.Forms.Panel volunteerEditablePanel;
        private System.Windows.Forms.ListBox shoppingCartListBox;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel VolunteerCartCostPanel;
        private System.Windows.Forms.TableLayoutPanel ProductTableLP;
    }
}

