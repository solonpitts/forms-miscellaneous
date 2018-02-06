namespace Asg3_sxp146230
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
            this.filenameLabel = new System.Windows.Forms.Label();
            this.numRecordLabel = new System.Windows.Forms.Label();
            this.mintimelabel = new System.Windows.Forms.Label();
            this.maxtimelabel = new System.Windows.Forms.Label();
            this.avgentrylabel = new System.Windows.Forms.Label();
            this.mininterlabel = new System.Windows.Forms.Label();
            this.maxinterlabel = new System.Windows.Forms.Label();
            this.avginterlabel = new System.Windows.Forms.Label();
            this.totaltimelabel = new System.Windows.Forms.Label();
            this.backspacesLabel = new System.Windows.Forms.Label();
            this.filenameBox = new System.Windows.Forms.TextBox();
            this.numRecordBox = new System.Windows.Forms.TextBox();
            this.minEntryBox = new System.Windows.Forms.TextBox();
            this.maxEntryBox = new System.Windows.Forms.TextBox();
            this.avgEntryBox = new System.Windows.Forms.TextBox();
            this.minInterBox = new System.Windows.Forms.TextBox();
            this.maxInterBox = new System.Windows.Forms.TextBox();
            this.avgInterBox = new System.Windows.Forms.TextBox();
            this.totalTimeBox = new System.Windows.Forms.TextBox();
            this.backBox = new System.Windows.Forms.TextBox();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.debugLabel = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.outLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filenameLabel.Location = new System.Drawing.Point(53, 47);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(353, 16);
            this.filenameLabel.TabIndex = 0;
            this.filenameLabel.Text = "Enter the name of the file to analyze (Ex: \"CS6326Asg2.txt\"):";
            // 
            // numRecordLabel
            // 
            this.numRecordLabel.AutoSize = true;
            this.numRecordLabel.Location = new System.Drawing.Point(53, 219);
            this.numRecordLabel.Name = "numRecordLabel";
            this.numRecordLabel.Size = new System.Drawing.Size(140, 13);
            this.numRecordLabel.TabIndex = 1;
            this.numRecordLabel.Text = "The total number of records:";
            // 
            // mintimelabel
            // 
            this.mintimelabel.AutoSize = true;
            this.mintimelabel.Location = new System.Drawing.Point(94, 253);
            this.mintimelabel.Name = "mintimelabel";
            this.mintimelabel.Size = new System.Drawing.Size(99, 13);
            this.mintimelabel.TabIndex = 2;
            this.mintimelabel.Text = "Minimum entry time:";
            // 
            // maxtimelabel
            // 
            this.maxtimelabel.AutoSize = true;
            this.maxtimelabel.Location = new System.Drawing.Point(91, 287);
            this.maxtimelabel.Name = "maxtimelabel";
            this.maxtimelabel.Size = new System.Drawing.Size(102, 13);
            this.maxtimelabel.TabIndex = 3;
            this.maxtimelabel.Text = "Maximum entry time:";
            // 
            // avgentrylabel
            // 
            this.avgentrylabel.AutoSize = true;
            this.avgentrylabel.Location = new System.Drawing.Point(95, 321);
            this.avgentrylabel.Name = "avgentrylabel";
            this.avgentrylabel.Size = new System.Drawing.Size(98, 13);
            this.avgentrylabel.TabIndex = 4;
            this.avgentrylabel.Text = "Average entry time:";
            // 
            // mininterlabel
            // 
            this.mininterlabel.AutoSize = true;
            this.mininterlabel.Location = new System.Drawing.Point(64, 355);
            this.mininterlabel.Name = "mininterlabel";
            this.mininterlabel.Size = new System.Drawing.Size(129, 13);
            this.mininterlabel.TabIndex = 5;
            this.mininterlabel.Text = "Minimum inter-record time:";
            // 
            // maxinterlabel
            // 
            this.maxinterlabel.AutoSize = true;
            this.maxinterlabel.Location = new System.Drawing.Point(61, 389);
            this.maxinterlabel.Name = "maxinterlabel";
            this.maxinterlabel.Size = new System.Drawing.Size(132, 13);
            this.maxinterlabel.TabIndex = 6;
            this.maxinterlabel.Text = "Maximum inter-record time:";
            // 
            // avginterlabel
            // 
            this.avginterlabel.AutoSize = true;
            this.avginterlabel.Location = new System.Drawing.Point(65, 423);
            this.avginterlabel.Name = "avginterlabel";
            this.avginterlabel.Size = new System.Drawing.Size(128, 13);
            this.avginterlabel.TabIndex = 7;
            this.avginterlabel.Text = "Average inter-record time:";
            // 
            // totaltimelabel
            // 
            this.totaltimelabel.AutoSize = true;
            this.totaltimelabel.Location = new System.Drawing.Point(137, 457);
            this.totaltimelabel.Name = "totaltimelabel";
            this.totaltimelabel.Size = new System.Drawing.Size(56, 13);
            this.totaltimelabel.TabIndex = 8;
            this.totaltimelabel.Text = "Total time:";
            // 
            // backspacesLabel
            // 
            this.backspacesLabel.AutoSize = true;
            this.backspacesLabel.Location = new System.Drawing.Point(99, 491);
            this.backspacesLabel.Name = "backspacesLabel";
            this.backspacesLabel.Size = new System.Drawing.Size(94, 13);
            this.backspacesLabel.TabIndex = 9;
            this.backspacesLabel.Text = "Backspace count:";
            // 
            // filenameBox
            // 
            this.filenameBox.Location = new System.Drawing.Point(56, 66);
            this.filenameBox.Name = "filenameBox";
            this.filenameBox.Size = new System.Drawing.Size(402, 20);
            this.filenameBox.TabIndex = 1;
            this.filenameBox.TextChanged += new System.EventHandler(this.Box_TextChanged);
            // 
            // numRecordBox
            // 
            this.numRecordBox.Location = new System.Drawing.Point(199, 212);
            this.numRecordBox.Name = "numRecordBox";
            this.numRecordBox.ReadOnly = true;
            this.numRecordBox.Size = new System.Drawing.Size(106, 20);
            this.numRecordBox.TabIndex = 10;
            this.numRecordBox.TabStop = false;
            // 
            // minEntryBox
            // 
            this.minEntryBox.Location = new System.Drawing.Point(199, 246);
            this.minEntryBox.Name = "minEntryBox";
            this.minEntryBox.ReadOnly = true;
            this.minEntryBox.Size = new System.Drawing.Size(106, 20);
            this.minEntryBox.TabIndex = 11;
            this.minEntryBox.TabStop = false;
            // 
            // maxEntryBox
            // 
            this.maxEntryBox.Location = new System.Drawing.Point(199, 280);
            this.maxEntryBox.Name = "maxEntryBox";
            this.maxEntryBox.ReadOnly = true;
            this.maxEntryBox.Size = new System.Drawing.Size(106, 20);
            this.maxEntryBox.TabIndex = 12;
            this.maxEntryBox.TabStop = false;
            // 
            // avgEntryBox
            // 
            this.avgEntryBox.Location = new System.Drawing.Point(199, 314);
            this.avgEntryBox.Name = "avgEntryBox";
            this.avgEntryBox.ReadOnly = true;
            this.avgEntryBox.Size = new System.Drawing.Size(106, 20);
            this.avgEntryBox.TabIndex = 13;
            this.avgEntryBox.TabStop = false;
            // 
            // minInterBox
            // 
            this.minInterBox.Location = new System.Drawing.Point(199, 348);
            this.minInterBox.Name = "minInterBox";
            this.minInterBox.ReadOnly = true;
            this.minInterBox.Size = new System.Drawing.Size(106, 20);
            this.minInterBox.TabIndex = 14;
            this.minInterBox.TabStop = false;
            // 
            // maxInterBox
            // 
            this.maxInterBox.Location = new System.Drawing.Point(199, 382);
            this.maxInterBox.Name = "maxInterBox";
            this.maxInterBox.ReadOnly = true;
            this.maxInterBox.Size = new System.Drawing.Size(106, 20);
            this.maxInterBox.TabIndex = 15;
            this.maxInterBox.TabStop = false;
            // 
            // avgInterBox
            // 
            this.avgInterBox.Location = new System.Drawing.Point(199, 416);
            this.avgInterBox.Name = "avgInterBox";
            this.avgInterBox.ReadOnly = true;
            this.avgInterBox.Size = new System.Drawing.Size(106, 20);
            this.avgInterBox.TabIndex = 16;
            this.avgInterBox.TabStop = false;
            // 
            // totalTimeBox
            // 
            this.totalTimeBox.Location = new System.Drawing.Point(199, 450);
            this.totalTimeBox.Name = "totalTimeBox";
            this.totalTimeBox.ReadOnly = true;
            this.totalTimeBox.Size = new System.Drawing.Size(106, 20);
            this.totalTimeBox.TabIndex = 17;
            this.totalTimeBox.TabStop = false;
            // 
            // backBox
            // 
            this.backBox.Location = new System.Drawing.Point(199, 484);
            this.backBox.Name = "backBox";
            this.backBox.ReadOnly = true;
            this.backBox.Size = new System.Drawing.Size(106, 20);
            this.backBox.TabIndex = 18;
            this.backBox.TabStop = false;
            // 
            // analyzeButton
            // 
            this.analyzeButton.Enabled = false;
            this.analyzeButton.Location = new System.Drawing.Point(56, 543);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(106, 37);
            this.analyzeButton.TabIndex = 19;
            this.analyzeButton.Text = "Analyze";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeBox_Click);
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(56, 170);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(0, 13);
            this.debugLabel.TabIndex = 20;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(56, 124);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(402, 20);
            this.outputBox.TabIndex = 22;
            this.outputBox.TextChanged += new System.EventHandler(this.Box_TextChanged);
            // 
            // outLabel
            // 
            this.outLabel.AutoSize = true;
            this.outLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outLabel.Location = new System.Drawing.Point(53, 105);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(328, 16);
            this.outLabel.TabIndex = 21;
            this.outLabel.Text = "Enter the name of the output file (Ex: \"CS6326Asg3.txt\"):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 608);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.outLabel);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.analyzeButton);
            this.Controls.Add(this.backBox);
            this.Controls.Add(this.totalTimeBox);
            this.Controls.Add(this.avgInterBox);
            this.Controls.Add(this.maxInterBox);
            this.Controls.Add(this.minInterBox);
            this.Controls.Add(this.avgEntryBox);
            this.Controls.Add(this.maxEntryBox);
            this.Controls.Add(this.minEntryBox);
            this.Controls.Add(this.numRecordBox);
            this.Controls.Add(this.filenameBox);
            this.Controls.Add(this.backspacesLabel);
            this.Controls.Add(this.totaltimelabel);
            this.Controls.Add(this.avginterlabel);
            this.Controls.Add(this.maxinterlabel);
            this.Controls.Add(this.mininterlabel);
            this.Controls.Add(this.avgentrylabel);
            this.Controls.Add(this.maxtimelabel);
            this.Controls.Add(this.mintimelabel);
            this.Controls.Add(this.numRecordLabel);
            this.Controls.Add(this.filenameLabel);
            this.Name = "Form1";
            this.Text = "Analyze Records";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filenameLabel;
        private System.Windows.Forms.Label numRecordLabel;
        private System.Windows.Forms.Label mintimelabel;
        private System.Windows.Forms.Label maxtimelabel;
        private System.Windows.Forms.Label avgentrylabel;
        private System.Windows.Forms.Label mininterlabel;
        private System.Windows.Forms.Label maxinterlabel;
        private System.Windows.Forms.Label avginterlabel;
        private System.Windows.Forms.Label totaltimelabel;
        private System.Windows.Forms.Label backspacesLabel;
        private System.Windows.Forms.TextBox filenameBox;
        private System.Windows.Forms.TextBox numRecordBox;
        private System.Windows.Forms.TextBox minEntryBox;
        private System.Windows.Forms.TextBox maxEntryBox;
        private System.Windows.Forms.TextBox avgEntryBox;
        private System.Windows.Forms.TextBox minInterBox;
        private System.Windows.Forms.TextBox maxInterBox;
        private System.Windows.Forms.TextBox avgInterBox;
        private System.Windows.Forms.TextBox totalTimeBox;
        private System.Windows.Forms.TextBox backBox;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label outLabel;
    }
}

