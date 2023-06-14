namespace V_Referencer
{
    partial class FormBlog
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
            this.panelConvertCitation = new System.Windows.Forms.Panel();
            this.txtConvertCitation = new System.Windows.Forms.TextBox();
            this.btnClearCitation = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnConvertHarvard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCitation = new System.Windows.Forms.Panel();
            this.btnCopyInText = new System.Windows.Forms.Button();
            this.rtxtInText = new System.Windows.Forms.RichTextBox();
            this.lblInText = new System.Windows.Forms.Label();
            this.btnCopyReference = new System.Windows.Forms.Button();
            this.rtxtReference = new System.Windows.Forms.RichTextBox();
            this.lblReference = new System.Windows.Forms.Label();
            this.lblCitation = new System.Windows.Forms.Label();
            this.panelInput = new System.Windows.Forms.Panel();
            this.lblAuthorWarning = new System.Windows.Forms.Label();
            this.lblTitleWarning = new System.Windows.Forms.Label();
            this.btnCreateCitiation = new System.Windows.Forms.Button();
            this.lblPublishDateWarning = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtWebsiteName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAuthorNeedsFormatting = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthorNoFormatting = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelConvertCitation.SuspendLayout();
            this.panelCitation.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConvertCitation
            // 
            this.panelConvertCitation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelConvertCitation.Controls.Add(this.txtConvertCitation);
            this.panelConvertCitation.Controls.Add(this.btnClearCitation);
            this.panelConvertCitation.Controls.Add(this.btnPaste);
            this.panelConvertCitation.Controls.Add(this.btnConvertHarvard);
            this.panelConvertCitation.Controls.Add(this.label1);
            this.panelConvertCitation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConvertCitation.Location = new System.Drawing.Point(0, 0);
            this.panelConvertCitation.Name = "panelConvertCitation";
            this.panelConvertCitation.Size = new System.Drawing.Size(1310, 236);
            this.panelConvertCitation.TabIndex = 3;
            // 
            // txtConvertCitation
            // 
            this.txtConvertCitation.Location = new System.Drawing.Point(12, 84);
            this.txtConvertCitation.Multiline = true;
            this.txtConvertCitation.Name = "txtConvertCitation";
            this.txtConvertCitation.PlaceholderText = "Paste citation here";
            this.txtConvertCitation.Size = new System.Drawing.Size(1026, 126);
            this.txtConvertCitation.TabIndex = 2;
            // 
            // btnClearCitation
            // 
            this.btnClearCitation.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClearCitation.ForeColor = System.Drawing.Color.White;
            this.btnClearCitation.Location = new System.Drawing.Point(1044, 164);
            this.btnClearCitation.Name = "btnClearCitation";
            this.btnClearCitation.Size = new System.Drawing.Size(112, 46);
            this.btnClearCitation.TabIndex = 4;
            this.btnClearCitation.Text = "Clear";
            this.btnClearCitation.UseVisualStyleBackColor = false;
            this.btnClearCitation.Click += new System.EventHandler(this.btnClearCitation_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPaste.ForeColor = System.Drawing.Color.White;
            this.btnPaste.Location = new System.Drawing.Point(1044, 84);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(112, 46);
            this.btnPaste.TabIndex = 3;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = false;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnConvertHarvard
            // 
            this.btnConvertHarvard.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConvertHarvard.ForeColor = System.Drawing.Color.White;
            this.btnConvertHarvard.Location = new System.Drawing.Point(633, 14);
            this.btnConvertHarvard.Name = "btnConvertHarvard";
            this.btnConvertHarvard.Size = new System.Drawing.Size(405, 46);
            this.btnConvertHarvard.TabIndex = 1;
            this.btnConvertHarvard.Text = "Convert from Regular Harvard";
            this.btnConvertHarvard.UseVisualStyleBackColor = false;
            this.btnConvertHarvard.Click += new System.EventHandler(this.btnConvertHarvard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Citation Converter";
            // 
            // panelCitation
            // 
            this.panelCitation.Controls.Add(this.btnCopyInText);
            this.panelCitation.Controls.Add(this.rtxtInText);
            this.panelCitation.Controls.Add(this.lblInText);
            this.panelCitation.Controls.Add(this.btnCopyReference);
            this.panelCitation.Controls.Add(this.rtxtReference);
            this.panelCitation.Controls.Add(this.lblReference);
            this.panelCitation.Controls.Add(this.lblCitation);
            this.panelCitation.Location = new System.Drawing.Point(0, 844);
            this.panelCitation.Name = "panelCitation";
            this.panelCitation.Size = new System.Drawing.Size(1326, 400);
            this.panelCitation.TabIndex = 5;
            // 
            // btnCopyInText
            // 
            this.btnCopyInText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCopyInText.Location = new System.Drawing.Point(1086, 260);
            this.btnCopyInText.Name = "btnCopyInText";
            this.btnCopyInText.Size = new System.Drawing.Size(109, 60);
            this.btnCopyInText.TabIndex = 16;
            this.btnCopyInText.Text = "Copy";
            this.btnCopyInText.UseVisualStyleBackColor = false;
            this.btnCopyInText.Click += new System.EventHandler(this.btnCopyInText_Click);
            // 
            // rtxtInText
            // 
            this.rtxtInText.Location = new System.Drawing.Point(52, 260);
            this.rtxtInText.Name = "rtxtInText";
            this.rtxtInText.Size = new System.Drawing.Size(1026, 60);
            this.rtxtInText.TabIndex = 15;
            this.rtxtInText.Text = "";
            // 
            // lblInText
            // 
            this.lblInText.AutoSize = true;
            this.lblInText.Location = new System.Drawing.Point(52, 225);
            this.lblInText.Name = "lblInText";
            this.lblInText.Size = new System.Drawing.Size(89, 32);
            this.lblInText.TabIndex = 37;
            this.lblInText.Text = "In-text:";
            // 
            // btnCopyReference
            // 
            this.btnCopyReference.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCopyReference.Location = new System.Drawing.Point(1086, 118);
            this.btnCopyReference.Name = "btnCopyReference";
            this.btnCopyReference.Size = new System.Drawing.Size(109, 60);
            this.btnCopyReference.TabIndex = 14;
            this.btnCopyReference.Text = "Copy";
            this.btnCopyReference.UseVisualStyleBackColor = false;
            this.btnCopyReference.Click += new System.EventHandler(this.btnCopyReference_Click);
            // 
            // rtxtReference
            // 
            this.rtxtReference.Location = new System.Drawing.Point(52, 91);
            this.rtxtReference.Name = "rtxtReference";
            this.rtxtReference.Size = new System.Drawing.Size(1026, 110);
            this.rtxtReference.TabIndex = 13;
            this.rtxtReference.Text = "";
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Location = new System.Drawing.Point(52, 56);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(132, 32);
            this.lblReference.TabIndex = 1;
            this.lblReference.Text = "Reference: ";
            // 
            // lblCitation
            // 
            this.lblCitation.AutoSize = true;
            this.lblCitation.Location = new System.Drawing.Point(472, 3);
            this.lblCitation.Name = "lblCitation";
            this.lblCitation.Size = new System.Drawing.Size(97, 32);
            this.lblCitation.TabIndex = 0;
            this.lblCitation.Text = "Citation";
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.lblAuthorWarning);
            this.panelInput.Controls.Add(this.lblTitleWarning);
            this.panelInput.Controls.Add(this.btnCreateCitiation);
            this.panelInput.Controls.Add(this.lblPublishDateWarning);
            this.panelInput.Controls.Add(this.dateTimePicker2);
            this.panelInput.Controls.Add(this.txtLink);
            this.panelInput.Controls.Add(this.label8);
            this.panelInput.Controls.Add(this.label7);
            this.panelInput.Controls.Add(this.label6);
            this.panelInput.Controls.Add(this.dateTimePicker1);
            this.panelInput.Controls.Add(this.txtWebsiteName);
            this.panelInput.Controls.Add(this.label5);
            this.panelInput.Controls.Add(this.txtTitle);
            this.panelInput.Controls.Add(this.label4);
            this.panelInput.Controls.Add(this.txtAuthorNeedsFormatting);
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.txtAuthorNoFormatting);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInput.Location = new System.Drawing.Point(0, 236);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1310, 602);
            this.panelInput.TabIndex = 6;
            // 
            // lblAuthorWarning
            // 
            this.lblAuthorWarning.AutoSize = true;
            this.lblAuthorWarning.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuthorWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAuthorWarning.Location = new System.Drawing.Point(597, 91);
            this.lblAuthorWarning.Name = "lblAuthorWarning";
            this.lblAuthorWarning.Size = new System.Drawing.Size(288, 37);
            this.lblAuthorWarning.TabIndex = 17;
            this.lblAuthorWarning.Text = "Find the author\'s name";
            // 
            // lblTitleWarning
            // 
            this.lblTitleWarning.AutoSize = true;
            this.lblTitleWarning.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleWarning.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitleWarning.Location = new System.Drawing.Point(597, 176);
            this.lblTitleWarning.Name = "lblTitleWarning";
            this.lblTitleWarning.Size = new System.Drawing.Size(410, 37);
            this.lblTitleWarning.TabIndex = 16;
            this.lblTitleWarning.Text = "^Check if sentence case is correct";
            // 
            // btnCreateCitiation
            // 
            this.btnCreateCitiation.Location = new System.Drawing.Point(378, 531);
            this.btnCreateCitiation.Name = "btnCreateCitiation";
            this.btnCreateCitiation.Size = new System.Drawing.Size(384, 46);
            this.btnCreateCitiation.TabIndex = 15;
            this.btnCreateCitiation.Text = "Create Citation";
            this.btnCreateCitiation.UseVisualStyleBackColor = true;
            this.btnCreateCitiation.Click += new System.EventHandler(this.btnCreateCitiation_Click);
            // 
            // lblPublishDateWarning
            // 
            this.lblPublishDateWarning.AutoSize = true;
            this.lblPublishDateWarning.BackColor = System.Drawing.SystemColors.Control;
            this.lblPublishDateWarning.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPublishDateWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPublishDateWarning.Location = new System.Drawing.Point(597, 315);
            this.lblPublishDateWarning.Name = "lblPublishDateWarning";
            this.lblPublishDateWarning.Size = new System.Drawing.Size(332, 37);
            this.lblPublishDateWarning.TabIndex = 14;
            this.lblPublishDateWarning.Text = "Find the DAY and MONTH!";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(168, 471);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(400, 39);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(168, 393);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(866, 39);
            this.txtLink.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 32);
            this.label8.TabIndex = 11;
            this.label8.Text = "Access date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 32);
            this.label7.TabIndex = 10;
            this.label7.Text = "Link:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Publish date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 315);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(401, 39);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.Validated += new System.EventHandler(this.dateTimePicker1_Validated);
            // 
            // txtWebsiteName
            // 
            this.txtWebsiteName.Location = new System.Drawing.Point(168, 230);
            this.txtWebsiteName.Name = "txtWebsiteName";
            this.txtWebsiteName.Size = new System.Drawing.Size(866, 39);
            this.txtWebsiteName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Blog Name:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(127, 137);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PlaceholderText = "In sentence case";
            this.txtTitle.Size = new System.Drawing.Size(907, 39);
            this.txtTitle.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Title:";
            // 
            // txtAuthorNeedsFormatting
            // 
            this.txtAuthorNeedsFormatting.Location = new System.Drawing.Point(670, 42);
            this.txtAuthorNeedsFormatting.Name = "txtAuthorNeedsFormatting";
            this.txtAuthorNeedsFormatting.PlaceholderText = "Name Surname";
            this.txtAuthorNeedsFormatting.Size = new System.Drawing.Size(364, 39);
            this.txtAuthorNeedsFormatting.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "or name in format:";
            // 
            // txtAuthorNoFormatting
            // 
            this.txtAuthorNoFormatting.Location = new System.Drawing.Point(127, 42);
            this.txtAuthorNoFormatting.Name = "txtAuthorNoFormatting";
            this.txtAuthorNoFormatting.Size = new System.Drawing.Size(318, 39);
            this.txtAuthorNoFormatting.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Author:";
            // 
            // FormBlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 1208);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelCitation);
            this.Controls.Add(this.panelConvertCitation);
            this.Name = "FormBlog";
            this.Text = "Blog";
            this.panelConvertCitation.ResumeLayout(false);
            this.panelConvertCitation.PerformLayout();
            this.panelCitation.ResumeLayout(false);
            this.panelCitation.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelConvertCitation;
        private TextBox txtConvertCitation;
        private Button btnClearCitation;
        private Button btnPaste;
        private Button btnConvertHarvard;
        private Label label1;
        private Panel panelCitation;
        private Button btnCopyInText;
        private RichTextBox rtxtInText;
        private Label lblInText;
        private Button btnCopyReference;
        private RichTextBox rtxtReference;
        private Label lblReference;
        private Label lblCitation;
        private Panel panelInput;
        private Label lblPublishDateWarning;
        private DateTimePicker dateTimePicker2;
        private TextBox txtLink;
        private Label label8;
        private Label label7;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private TextBox txtWebsiteName;
        private Label label5;
        private TextBox txtTitle;
        private Label label4;
        private TextBox txtAuthorNeedsFormatting;
        private Label label3;
        private TextBox txtAuthorNoFormatting;
        private Label label2;
        private Button btnCreateCitiation;
        private Label lblTitleWarning;
        private Label lblAuthorWarning;
    }
}