namespace Asg2_sxp146230
{
    partial class Form1
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.proofOfPurchaseCheckbox = new System.Windows.Forms.CheckBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.zipBox = new System.Windows.Forms.TextBox();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.address2Box = new System.Windows.Forms.TextBox();
            this.address1Box = new System.Windows.Forms.TextBox();
            this.middleIntitialBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.proofOfPurchaseLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.address2Label = new System.Windows.Forms.Label();
            this.address1Label = new System.Windows.Forms.Label();
            this.initialLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.recordList = new System.Windows.Forms.ListView();
            this.warningLabel = new System.Windows.Forms.Label();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.optionalLabel = new System.Windows.Forms.Label();
            this.inputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(107, 29);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.optionalLabel);
            this.inputPanel.Controls.Add(this.warningLabel);
            this.inputPanel.Controls.Add(this.deleteButton);
            this.inputPanel.Controls.Add(this.clearButton);
            this.inputPanel.Controls.Add(this.saveButton);
            this.inputPanel.Controls.Add(this.datePicker);
            this.inputPanel.Controls.Add(this.proofOfPurchaseCheckbox);
            this.inputPanel.Controls.Add(this.emailBox);
            this.inputPanel.Controls.Add(this.phoneBox);
            this.inputPanel.Controls.Add(this.zipBox);
            this.inputPanel.Controls.Add(this.stateBox);
            this.inputPanel.Controls.Add(this.cityBox);
            this.inputPanel.Controls.Add(this.address2Box);
            this.inputPanel.Controls.Add(this.address1Box);
            this.inputPanel.Controls.Add(this.middleIntitialBox);
            this.inputPanel.Controls.Add(this.lastNameBox);
            this.inputPanel.Controls.Add(this.firstNameBox);
            this.inputPanel.Controls.Add(this.dateLabel);
            this.inputPanel.Controls.Add(this.proofOfPurchaseLabel);
            this.inputPanel.Controls.Add(this.emailLabel);
            this.inputPanel.Controls.Add(this.phoneLabel);
            this.inputPanel.Controls.Add(this.zipLabel);
            this.inputPanel.Controls.Add(this.stateLabel);
            this.inputPanel.Controls.Add(this.cityLabel);
            this.inputPanel.Controls.Add(this.address2Label);
            this.inputPanel.Controls.Add(this.address1Label);
            this.inputPanel.Controls.Add(this.initialLabel);
            this.inputPanel.Controls.Add(this.lastNameLabel);
            this.inputPanel.Controls.Add(this.firstNameLabel);
            this.inputPanel.Location = new System.Drawing.Point(12, 12);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(577, 593);
            this.inputPanel.TabIndex = 1;
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(170, 396);
            this.datePicker.MaxDate = new System.DateTime(2909, 12, 27, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(98, 20);
            this.datePicker.TabIndex = 11;
            this.datePicker.Value = new System.DateTime(2017, 9, 23, 0, 0, 0, 0);
            // 
            // proofOfPurchaseCheckbox
            // 
            this.proofOfPurchaseCheckbox.AutoSize = true;
            this.proofOfPurchaseCheckbox.Location = new System.Drawing.Point(170, 368);
            this.proofOfPurchaseCheckbox.Name = "proofOfPurchaseCheckbox";
            this.proofOfPurchaseCheckbox.Size = new System.Drawing.Size(157, 17);
            this.proofOfPurchaseCheckbox.TabIndex = 10;
            this.proofOfPurchaseCheckbox.Text = "Proof of Purchase Attached";
            this.proofOfPurchaseCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.proofOfPurchaseCheckbox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.proofOfPurchaseCheckbox.UseVisualStyleBackColor = true;
            this.proofOfPurchaseCheckbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.proofOfPurchaseCheckbox_KeyPress);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(170, 328);
            this.emailBox.MaxLength = 60;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(374, 20);
            this.emailBox.TabIndex = 9;
            this.emailBox.TextChanged += new System.EventHandler(this.Box_TextChanged);
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(170, 294);
            this.phoneBox.MaxLength = 21;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(201, 20);
            this.phoneBox.TabIndex = 8;
            this.phoneBox.TextChanged += new System.EventHandler(this.Box_TextChanged);
            this.phoneBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numbersOnlyBox_KeyDown);
            this.phoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputSensitiveBox_KeyPress);
            // 
            // zipBox
            // 
            this.zipBox.Location = new System.Drawing.Point(170, 260);
            this.zipBox.MaxLength = 9;
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(82, 20);
            this.zipBox.TabIndex = 7;
            this.zipBox.TextChanged += new System.EventHandler(this.Box_TextChanged);
            this.zipBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numbersOnlyBox_KeyDown);
            this.zipBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputSensitiveBox_KeyPress);
            // 
            // stateBox
            // 
            this.stateBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.stateBox.Location = new System.Drawing.Point(170, 226);
            this.stateBox.MaxLength = 2;
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(27, 20);
            this.stateBox.TabIndex = 6;
            this.stateBox.TextChanged += new System.EventHandler(this.Box_TextChanged);
            this.stateBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.charOnlyBox_KeyDown);
            this.stateBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputSensitiveBox_KeyPress);
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(170, 192);
            this.cityBox.MaxLength = 25;
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(240, 20);
            this.cityBox.TabIndex = 5;
            this.cityBox.TextChanged += new System.EventHandler(this.Box_TextChanged);
            this.cityBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.charWithSpacesBox_KeyDown);
            this.cityBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputSensitiveBox_KeyPress);
            // 
            // address2Box
            // 
            this.address2Box.Location = new System.Drawing.Point(170, 158);
            this.address2Box.MaxLength = 35;
            this.address2Box.Name = "address2Box";
            this.address2Box.Size = new System.Drawing.Size(285, 20);
            this.address2Box.TabIndex = 4;
            this.address2Box.Tag = "Optional";
            // 
            // address1Box
            // 
            this.address1Box.Location = new System.Drawing.Point(170, 124);
            this.address1Box.MaxLength = 35;
            this.address1Box.Name = "address1Box";
            this.address1Box.Size = new System.Drawing.Size(285, 20);
            this.address1Box.TabIndex = 3;
            this.address1Box.TextChanged += new System.EventHandler(this.Box_TextChanged);
            // 
            // middleIntitialBox
            // 
            this.middleIntitialBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.middleIntitialBox.Location = new System.Drawing.Point(170, 90);
            this.middleIntitialBox.MaxLength = 1;
            this.middleIntitialBox.Name = "middleIntitialBox";
            this.middleIntitialBox.Size = new System.Drawing.Size(27, 20);
            this.middleIntitialBox.TabIndex = 2;
            this.middleIntitialBox.Tag = "Optional";
            this.middleIntitialBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.charOnlyBox_KeyDown);
            this.middleIntitialBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputSensitiveBox_KeyPress);
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(170, 56);
            this.lastNameBox.MaxLength = 20;
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(201, 20);
            this.lastNameBox.TabIndex = 1;
            this.lastNameBox.WordWrap = false;
            this.lastNameBox.TextChanged += new System.EventHandler(this.Box_TextChanged);
            this.lastNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.charOnlyBox_KeyDown);
            this.lastNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputSensitiveBox_KeyPress);
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(170, 22);
            this.firstNameBox.MaxLength = 20;
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(201, 20);
            this.firstNameBox.TabIndex = 0;
            this.firstNameBox.WordWrap = false;
            this.firstNameBox.TextChanged += new System.EventHandler(this.Box_TextChanged);
            this.firstNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.charOnlyBox_KeyDown);
            this.firstNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputSensitiveBox_KeyPress);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(85, 403);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(79, 13);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "Date Received";
            // 
            // proofOfPurchaseLabel
            // 
            this.proofOfPurchaseLabel.AutoSize = true;
            this.proofOfPurchaseLabel.Location = new System.Drawing.Point(26, 369);
            this.proofOfPurchaseLabel.Name = "proofOfPurchaseLabel";
            this.proofOfPurchaseLabel.Size = new System.Drawing.Size(0, 13);
            this.proofOfPurchaseLabel.TabIndex = 10;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(91, 335);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(73, 13);
            this.emailLabel.TabIndex = 9;
            this.emailLabel.Text = "Email Address";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(86, 301);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneLabel.TabIndex = 8;
            this.phoneLabel.Text = "Phone Number";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(118, 267);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(46, 13);
            this.zipLabel.TabIndex = 7;
            this.zipLabel.Text = "Zipcode";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(132, 233);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(32, 13);
            this.stateLabel.TabIndex = 6;
            this.stateLabel.Text = "State";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(140, 199);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 5;
            this.cityLabel.Text = "City";
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Location = new System.Drawing.Point(83, 165);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(81, 13);
            this.address2Label.TabIndex = 4;
            this.address2Label.Text = "Address Line 2*";
            // 
            // address1Label
            // 
            this.address1Label.AutoSize = true;
            this.address1Label.Location = new System.Drawing.Point(87, 131);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(77, 13);
            this.address1Label.TabIndex = 3;
            this.address1Label.Text = "Address Line 1";
            // 
            // initialLabel
            // 
            this.initialLabel.AutoSize = true;
            this.initialLabel.Location = new System.Drawing.Point(95, 97);
            this.initialLabel.Name = "initialLabel";
            this.initialLabel.Size = new System.Drawing.Size(69, 13);
            this.initialLabel.TabIndex = 2;
            this.initialLabel.Text = "Middle Initial*";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(106, 63);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(170, 529);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 32);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(340, 529);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(95, 32);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(452, 529);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(92, 32);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // recordList
            // 
            this.recordList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.columnHeader1});
            this.recordList.Location = new System.Drawing.Point(595, 12);
            this.recordList.Name = "recordList";
            this.recordList.Size = new System.Drawing.Size(408, 561);
            this.recordList.TabIndex = 2;
            this.recordList.TabStop = false;
            this.recordList.UseCompatibleStateImageBehavior = false;
            this.recordList.View = System.Windows.Forms.View.Details;
            this.recordList.ItemActivate += new System.EventHandler(this.recordList_ItemActivate);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(170, 474);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 13);
            this.warningLabel.TabIndex = 15;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 200;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Phone Number";
            this.columnHeader1.Width = 200;
            // 
            // optionalLabel
            // 
            this.optionalLabel.AutoSize = true;
            this.optionalLabel.Location = new System.Drawing.Point(116, 444);
            this.optionalLabel.Name = "optionalLabel";
            this.optionalLabel.Size = new System.Drawing.Size(48, 13);
            this.optionalLabel.TabIndex = 16;
            this.optionalLabel.Text = "*optional";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 610);
            this.Controls.Add(this.recordList);
            this.Controls.Add(this.inputPanel);
            this.Name = "Form1";
            this.Text = "Rebate Entry";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label proofOfPurchaseLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.Label address1Label;
        private System.Windows.Forms.Label initialLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox zipBox;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox address2Box;
        private System.Windows.Forms.TextBox address1Box;
        private System.Windows.Forms.TextBox middleIntitialBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.CheckBox proofOfPurchaseCheckbox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListView recordList;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label optionalLabel;
    }
}

