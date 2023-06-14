namespace V_Referencer
{
    partial class FormWebsite
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
            this.panelInput = new System.Windows.Forms.Panel();
            this.lblTitleWarning = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnCreateCitiation = new System.Windows.Forms.Button();
            this.txtWebsiteName = new System.Windows.Forms.TextBox();
            this.txtArticleTitle = new System.Windows.Forms.TextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.checkNoDate = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDateAccessed = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblPublishDate = new System.Windows.Forms.Label();
            this.lblArticleTitle = new System.Windows.Forms.Label();
            this.lblWebsiteName = new System.Windows.Forms.Label();
            this.panelCitation = new System.Windows.Forms.Panel();
            this.btnCopyInText = new System.Windows.Forms.Button();
            this.rtxtInText = new System.Windows.Forms.RichTextBox();
            this.lblInText = new System.Windows.Forms.Label();
            this.btnCopyReference = new System.Windows.Forms.Button();
            this.rtxtReference = new System.Windows.Forms.RichTextBox();
            this.lblReference = new System.Windows.Forms.Label();
            this.lblCitation = new System.Windows.Forms.Label();
            this.panelConvertCitation = new System.Windows.Forms.Panel();
            this.txtConvertCitation = new System.Windows.Forms.TextBox();
            this.btnClearCitation = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnConvertHarvard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelInput.SuspendLayout();
            this.panelCitation.SuspendLayout();
            this.panelConvertCitation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.lblTitleWarning);
            this.panelInput.Controls.Add(this.dateTimePicker2);
            this.panelInput.Controls.Add(this.btnCreateCitiation);
            this.panelInput.Controls.Add(this.txtWebsiteName);
            this.panelInput.Controls.Add(this.txtArticleTitle);
            this.panelInput.Controls.Add(this.txtLink);
            this.panelInput.Controls.Add(this.lblYear);
            this.panelInput.Controls.Add(this.txtYear);
            this.panelInput.Controls.Add(this.checkNoDate);
            this.panelInput.Controls.Add(this.dateTimePicker1);
            this.panelInput.Controls.Add(this.lblDateAccessed);
            this.panelInput.Controls.Add(this.lblLink);
            this.panelInput.Controls.Add(this.lblPublishDate);
            this.panelInput.Controls.Add(this.lblArticleTitle);
            this.panelInput.Controls.Add(this.lblWebsiteName);
            this.panelInput.Location = new System.Drawing.Point(0, 242);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1326, 582);
            this.panelInput.TabIndex = 0;
            // 
            // lblTitleWarning
            // 
            this.lblTitleWarning.AutoSize = true;
            this.lblTitleWarning.Location = new System.Drawing.Point(820, 184);
            this.lblTitleWarning.Name = "lblTitleWarning";
            this.lblTitleWarning.Size = new System.Drawing.Size(375, 32);
            this.lblTitleWarning.TabIndex = 17;
            this.lblTitleWarning.Text = "^Check if sentence case is correct";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(330, 422);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(400, 39);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // btnCreateCitiation
            // 
            this.btnCreateCitiation.Location = new System.Drawing.Point(346, 499);
            this.btnCreateCitiation.Name = "btnCreateCitiation";
            this.btnCreateCitiation.Size = new System.Drawing.Size(384, 46);
            this.btnCreateCitiation.TabIndex = 12;
            this.btnCreateCitiation.Text = "Create Citation";
            this.btnCreateCitiation.UseVisualStyleBackColor = true;
            this.btnCreateCitiation.Click += new System.EventHandler(this.btnCreateCitiation_Click);
            // 
            // txtWebsiteName
            // 
            this.txtWebsiteName.Location = new System.Drawing.Point(233, 39);
            this.txtWebsiteName.Name = "txtWebsiteName";
            this.txtWebsiteName.Size = new System.Drawing.Size(845, 39);
            this.txtWebsiteName.TabIndex = 5;
            // 
            // txtArticleTitle
            // 
            this.txtArticleTitle.Location = new System.Drawing.Point(233, 103);
            this.txtArticleTitle.Multiline = true;
            this.txtArticleTitle.Name = "txtArticleTitle";
            this.txtArticleTitle.PlaceholderText = "In sentence case";
            this.txtArticleTitle.Size = new System.Drawing.Size(845, 78);
            this.txtArticleTitle.TabIndex = 6;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(120, 307);
            this.txtLink.Multiline = true;
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(958, 90);
            this.txtLink.TabIndex = 10;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(615, 258);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(63, 32);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Year:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(684, 255);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(132, 39);
            this.txtYear.TabIndex = 9;
            this.txtYear.Validated += new System.EventHandler(this.txtYear_Validated);
            // 
            // checkNoDate
            // 
            this.checkNoDate.AutoSize = true;
            this.checkNoDate.Location = new System.Drawing.Point(362, 257);
            this.checkNoDate.Name = "checkNoDate";
            this.checkNoDate.Size = new System.Drawing.Size(218, 36);
            this.checkNoDate.TabIndex = 8;
            this.checkNoDate.Text = "No specific date";
            this.checkNoDate.UseVisualStyleBackColor = true;
            this.checkNoDate.CheckedChanged += new System.EventHandler(this.checkNoDate_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(362, 206);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(411, 39);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // lblDateAccessed
            // 
            this.lblDateAccessed.AutoSize = true;
            this.lblDateAccessed.Location = new System.Drawing.Point(52, 422);
            this.lblDateAccessed.Name = "lblDateAccessed";
            this.lblDateAccessed.Size = new System.Drawing.Size(173, 32);
            this.lblDateAccessed.TabIndex = 4;
            this.lblDateAccessed.Text = "Date Accessed:";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(52, 319);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(62, 32);
            this.lblLink.TabIndex = 3;
            this.lblLink.Text = "Link:";
            // 
            // lblPublishDate
            // 
            this.lblPublishDate.AutoSize = true;
            this.lblPublishDate.Location = new System.Drawing.Point(52, 206);
            this.lblPublishDate.Name = "lblPublishDate";
            this.lblPublishDate.Size = new System.Drawing.Size(223, 32);
            this.lblPublishDate.TabIndex = 2;
            this.lblPublishDate.Text = "Date of Publication:";
            // 
            // lblArticleTitle
            // 
            this.lblArticleTitle.AutoSize = true;
            this.lblArticleTitle.Location = new System.Drawing.Point(52, 106);
            this.lblArticleTitle.Name = "lblArticleTitle";
            this.lblArticleTitle.Size = new System.Drawing.Size(139, 32);
            this.lblArticleTitle.TabIndex = 1;
            this.lblArticleTitle.Text = "Article Title:";
            // 
            // lblWebsiteName
            // 
            this.lblWebsiteName.AutoSize = true;
            this.lblWebsiteName.Location = new System.Drawing.Point(52, 42);
            this.lblWebsiteName.Name = "lblWebsiteName";
            this.lblWebsiteName.Size = new System.Drawing.Size(175, 32);
            this.lblWebsiteName.TabIndex = 0;
            this.lblWebsiteName.Text = "Website Name:";
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
            this.panelCitation.Location = new System.Drawing.Point(0, 830);
            this.panelCitation.Name = "panelCitation";
            this.panelCitation.Size = new System.Drawing.Size(1326, 400);
            this.panelCitation.TabIndex = 1;
            // 
            // btnCopyInText
            // 
            this.btnCopyInText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCopyInText.Location = new System.Drawing.Point(969, 260);
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
            this.rtxtInText.Size = new System.Drawing.Size(911, 60);
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
            this.panelConvertCitation.Size = new System.Drawing.Size(1219, 236);
            this.panelConvertCitation.TabIndex = 2;
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
            // FormWebsite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 1352);
            this.Controls.Add(this.panelConvertCitation);
            this.Controls.Add(this.panelCitation);
            this.Controls.Add(this.panelInput);
            this.Name = "FormWebsite";
            this.Text = "Website";
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelCitation.ResumeLayout(false);
            this.panelCitation.PerformLayout();
            this.panelConvertCitation.ResumeLayout(false);
            this.panelConvertCitation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelInput;
        private TextBox txtWebsiteName;
        private TextBox txtArticleTitle;
        private TextBox txtLink;
        private Label lblYear;
        private TextBox txtYear;
        private CheckBox checkNoDate;
        private DateTimePicker dateTimePicker1;
        private Label lblDateAccessed;
        private Label lblLink;
        private Label lblPublishDate;
        private Label lblArticleTitle;
        private Label lblWebsiteName;
        private Panel panelCitation;
        private Label lblReference;
        private Label lblCitation;
        private RichTextBox rtxtReference;
        private Label lblInText;
        private Button btnCopyReference;
        private RichTextBox rtxtInText;
        private Button btnCopyInText;
        private Button btnCreateCitiation;
        private DateTimePicker dateTimePicker2;
        private Panel panelConvertCitation;
        private Label label1;
        private Button btnConvertHarvard;
        private Button btnClearCitation;
        private Button btnPaste;
        private TextBox txtConvertCitation;
        private Label lblTitleWarning;
    }
}