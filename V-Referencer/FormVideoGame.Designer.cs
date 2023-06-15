namespace V_Referencer
{
    partial class FormVideoGame
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
            this.panelPrimaryInput = new System.Windows.Forms.Panel();
            this.btnScrapeWebsite = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnClearLink = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbWebsiteChoices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCreateCitation = new System.Windows.Forms.Button();
            this.cmbPlatform = new System.Windows.Forms.ComboBox();
            this.cmbGameType = new System.Windows.Forms.ComboBox();
            this.btnFindCity = new System.Windows.Forms.Button();
            this.txtPublishCity = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtDevName = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCitation = new System.Windows.Forms.Panel();
            this.btnCopyInText = new System.Windows.Forms.Button();
            this.rtxtInText = new System.Windows.Forms.RichTextBox();
            this.lblInText = new System.Windows.Forms.Label();
            this.btnCopyReference = new System.Windows.Forms.Button();
            this.rtxtReference = new System.Windows.Forms.RichTextBox();
            this.lblReference = new System.Windows.Forms.Label();
            this.lblCitation = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnInTextStart = new System.Windows.Forms.Button();
            this.rtxtInTextStart = new System.Windows.Forms.RichTextBox();
            this.panelPrimaryInput.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCitation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrimaryInput
            // 
            this.panelPrimaryInput.Controls.Add(this.btnScrapeWebsite);
            this.panelPrimaryInput.Controls.Add(this.txtLink);
            this.panelPrimaryInput.Controls.Add(this.btnClearLink);
            this.panelPrimaryInput.Controls.Add(this.label2);
            this.panelPrimaryInput.Controls.Add(this.cmbWebsiteChoices);
            this.panelPrimaryInput.Controls.Add(this.label1);
            this.panelPrimaryInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrimaryInput.Location = new System.Drawing.Point(0, 0);
            this.panelPrimaryInput.Name = "panelPrimaryInput";
            this.panelPrimaryInput.Size = new System.Drawing.Size(1188, 253);
            this.panelPrimaryInput.TabIndex = 0;
            // 
            // btnScrapeWebsite
            // 
            this.btnScrapeWebsite.Location = new System.Drawing.Point(279, 173);
            this.btnScrapeWebsite.Name = "btnScrapeWebsite";
            this.btnScrapeWebsite.Size = new System.Drawing.Size(475, 56);
            this.btnScrapeWebsite.TabIndex = 11;
            this.btnScrapeWebsite.Text = "Scrape Website";
            this.btnScrapeWebsite.UseVisualStyleBackColor = true;
            this.btnScrapeWebsite.Click += new System.EventHandler(this.btnScrapeWebsite_Click);
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLink.Location = new System.Drawing.Point(190, 109);
            this.txtLink.Name = "txtLink";
            this.txtLink.PlaceholderText = "Paste link here";
            this.txtLink.Size = new System.Drawing.Size(773, 46);
            this.txtLink.TabIndex = 39;
            // 
            // btnClearLink
            // 
            this.btnClearLink.Location = new System.Drawing.Point(985, 111);
            this.btnClearLink.Name = "btnClearLink";
            this.btnClearLink.Size = new System.Drawing.Size(109, 46);
            this.btnClearLink.TabIndex = 38;
            this.btnClearLink.Text = "Clear";
            this.btnClearLink.UseVisualStyleBackColor = true;
            this.btnClearLink.Click += new System.EventHandler(this.btnClearLink_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Link:";
            // 
            // cmbWebsiteChoices
            // 
            this.cmbWebsiteChoices.FormattingEnabled = true;
            this.cmbWebsiteChoices.Location = new System.Drawing.Point(680, 40);
            this.cmbWebsiteChoices.Name = "cmbWebsiteChoices";
            this.cmbWebsiteChoices.Size = new System.Drawing.Size(283, 40);
            this.cmbWebsiteChoices.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Where are you looking for the game?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnCreateCitation);
            this.panel1.Controls.Add(this.cmbPlatform);
            this.panel1.Controls.Add(this.cmbGameType);
            this.panel1.Controls.Add(this.btnFindCity);
            this.panel1.Controls.Add(this.txtPublishCity);
            this.panel1.Controls.Add(this.txtPublisher);
            this.panel1.Controls.Add(this.txtDevName);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 554);
            this.panel1.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(279, 290);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(132, 39);
            this.txtYear.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 32);
            this.label9.TabIndex = 11;
            this.label9.Text = "Publish year:";
            // 
            // btnCreateCitation
            // 
            this.btnCreateCitation.Location = new System.Drawing.Point(279, 470);
            this.btnCreateCitation.Name = "btnCreateCitation";
            this.btnCreateCitation.Size = new System.Drawing.Size(684, 67);
            this.btnCreateCitation.TabIndex = 2;
            this.btnCreateCitation.Text = "Create Citation";
            this.btnCreateCitation.UseVisualStyleBackColor = true;
            this.btnCreateCitation.Click += new System.EventHandler(this.btnCreateCitation_Click);
            // 
            // cmbPlatform
            // 
            this.cmbPlatform.FormattingEnabled = true;
            this.cmbPlatform.Location = new System.Drawing.Point(279, 419);
            this.cmbPlatform.Name = "cmbPlatform";
            this.cmbPlatform.Size = new System.Drawing.Size(310, 40);
            this.cmbPlatform.TabIndex = 2;
            // 
            // cmbGameType
            // 
            this.cmbGameType.FormattingEnabled = true;
            this.cmbGameType.Items.AddRange(new object[] {
            "Digital Game"});
            this.cmbGameType.Location = new System.Drawing.Point(279, 368);
            this.cmbGameType.Name = "cmbGameType";
            this.cmbGameType.Size = new System.Drawing.Size(310, 40);
            this.cmbGameType.TabIndex = 10;
            // 
            // btnFindCity
            // 
            this.btnFindCity.Location = new System.Drawing.Point(696, 231);
            this.btnFindCity.Name = "btnFindCity";
            this.btnFindCity.Size = new System.Drawing.Size(267, 46);
            this.btnFindCity.TabIndex = 9;
            this.btnFindCity.Text = "Find city";
            this.btnFindCity.UseVisualStyleBackColor = true;
            this.btnFindCity.Click += new System.EventHandler(this.btnFindCity_Click);
            // 
            // txtPublishCity
            // 
            this.txtPublishCity.Location = new System.Drawing.Point(279, 235);
            this.txtPublishCity.Name = "txtPublishCity";
            this.txtPublishCity.Size = new System.Drawing.Size(411, 39);
            this.txtPublishCity.TabIndex = 8;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(279, 181);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(411, 39);
            this.txtPublisher.TabIndex = 7;
            // 
            // txtDevName
            // 
            this.txtDevName.Location = new System.Drawing.Point(279, 99);
            this.txtDevName.Name = "txtDevName";
            this.txtDevName.Size = new System.Drawing.Size(684, 39);
            this.txtDevName.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(279, 24);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(684, 39);
            this.txtTitle.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 32);
            this.label8.TabIndex = 4;
            this.label8.Text = "Publish city:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 32);
            this.label7.TabIndex = 3;
            this.label7.Text = "Platform:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Type of game:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Publisher:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Developer:";
            // 
            // panelCitation
            // 
            this.panelCitation.Controls.Add(this.btnInTextStart);
            this.panelCitation.Controls.Add(this.rtxtInTextStart);
            this.panelCitation.Controls.Add(this.btnCopyInText);
            this.panelCitation.Controls.Add(this.rtxtInText);
            this.panelCitation.Controls.Add(this.label10);
            this.panelCitation.Controls.Add(this.lblInText);
            this.panelCitation.Controls.Add(this.btnCopyReference);
            this.panelCitation.Controls.Add(this.rtxtReference);
            this.panelCitation.Controls.Add(this.lblReference);
            this.panelCitation.Controls.Add(this.lblCitation);
            this.panelCitation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCitation.Location = new System.Drawing.Point(0, 807);
            this.panelCitation.Name = "panelCitation";
            this.panelCitation.Size = new System.Drawing.Size(1188, 468);
            this.panelCitation.TabIndex = 2;
            // 
            // btnCopyInText
            // 
            this.btnCopyInText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCopyInText.Location = new System.Drawing.Point(941, 375);
            this.btnCopyInText.Name = "btnCopyInText";
            this.btnCopyInText.Size = new System.Drawing.Size(109, 60);
            this.btnCopyInText.TabIndex = 43;
            this.btnCopyInText.Text = "Copy";
            this.btnCopyInText.UseVisualStyleBackColor = false;
            this.btnCopyInText.Click += new System.EventHandler(this.btnCopyInText_Click);
            // 
            // rtxtInText
            // 
            this.rtxtInText.Location = new System.Drawing.Point(24, 375);
            this.rtxtInText.Name = "rtxtInText";
            this.rtxtInText.Size = new System.Drawing.Size(911, 60);
            this.rtxtInText.TabIndex = 42;
            this.rtxtInText.Text = "";
            // 
            // lblInText
            // 
            this.lblInText.AutoSize = true;
            this.lblInText.Location = new System.Drawing.Point(24, 340);
            this.lblInText.Name = "lblInText";
            this.lblInText.Size = new System.Drawing.Size(283, 32);
            this.lblInText.TabIndex = 44;
            this.lblInText.Text = "In-text (end of sentence):";
            // 
            // btnCopyReference
            // 
            this.btnCopyReference.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCopyReference.Location = new System.Drawing.Point(1058, 123);
            this.btnCopyReference.Name = "btnCopyReference";
            this.btnCopyReference.Size = new System.Drawing.Size(109, 60);
            this.btnCopyReference.TabIndex = 41;
            this.btnCopyReference.Text = "Copy";
            this.btnCopyReference.UseVisualStyleBackColor = false;
            this.btnCopyReference.Click += new System.EventHandler(this.btnCopyReference_Click);
            // 
            // rtxtReference
            // 
            this.rtxtReference.Location = new System.Drawing.Point(24, 96);
            this.rtxtReference.Name = "rtxtReference";
            this.rtxtReference.Size = new System.Drawing.Size(1026, 110);
            this.rtxtReference.TabIndex = 40;
            this.rtxtReference.Text = "";
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Location = new System.Drawing.Point(24, 61);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(132, 32);
            this.lblReference.TabIndex = 39;
            this.lblReference.Text = "Reference: ";
            // 
            // lblCitation
            // 
            this.lblCitation.AutoSize = true;
            this.lblCitation.Location = new System.Drawing.Point(444, 8);
            this.lblCitation.Name = "lblCitation";
            this.lblCitation.Size = new System.Drawing.Size(97, 32);
            this.lblCitation.TabIndex = 38;
            this.lblCitation.Text = "Citation";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(398, 32);
            this.label10.TabIndex = 44;
            this.label10.Text = "In-text (start or middle of sentence):";
            // 
            // btnInTextStart
            // 
            this.btnInTextStart.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnInTextStart.Location = new System.Drawing.Point(941, 262);
            this.btnInTextStart.Name = "btnInTextStart";
            this.btnInTextStart.Size = new System.Drawing.Size(109, 60);
            this.btnInTextStart.TabIndex = 46;
            this.btnInTextStart.Text = "Copy";
            this.btnInTextStart.UseVisualStyleBackColor = false;
            this.btnInTextStart.Click += new System.EventHandler(this.btnInTextStart_Click);
            // 
            // rtxtInTextStart
            // 
            this.rtxtInTextStart.Location = new System.Drawing.Point(24, 262);
            this.rtxtInTextStart.Name = "rtxtInTextStart";
            this.rtxtInTextStart.Size = new System.Drawing.Size(911, 60);
            this.rtxtInTextStart.TabIndex = 45;
            this.rtxtInTextStart.Text = "";
            // 
            // FormVideoGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 1361);
            this.Controls.Add(this.panelCitation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPrimaryInput);
            this.Name = "FormVideoGame";
            this.Text = "Video Game";
            this.panelPrimaryInput.ResumeLayout(false);
            this.panelPrimaryInput.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCitation.ResumeLayout(false);
            this.panelCitation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelPrimaryInput;
        private Label label2;
        private ComboBox cmbWebsiteChoices;
        private Label label1;
        private Button btnClearLink;
        private TextBox txtLink;
        private Panel panel1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnCreateCitation;
        private ComboBox cmbPlatform;
        private ComboBox cmbGameType;
        private Button btnFindCity;
        private TextBox txtPublishCity;
        private TextBox txtPublisher;
        private TextBox txtDevName;
        private TextBox txtTitle;
        private Panel panelCitation;
        private Button btnScrapeWebsite;
        private Button btnCopyInText;
        private RichTextBox rtxtInText;
        private Label lblInText;
        private Button btnCopyReference;
        private RichTextBox rtxtReference;
        private Label lblReference;
        private Label lblCitation;
        private TextBox txtYear;
        private Label label9;
        private Button btnInTextStart;
        private RichTextBox rtxtInTextStart;
        private Label label10;
    }
}