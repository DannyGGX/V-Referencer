namespace V_Referencer
{
    partial class FormOnlineSound
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
            this.btnCreateCitiation = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.txtPublishYear = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelConvertCitation = new System.Windows.Forms.Panel();
            this.txtConvertCitation = new System.Windows.Forms.TextBox();
            this.btnClearCitation = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnConvertHarvard = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panelCitation = new System.Windows.Forms.Panel();
            this.btnCopyInText = new System.Windows.Forms.Button();
            this.rtxtInText = new System.Windows.Forms.RichTextBox();
            this.lblInText = new System.Windows.Forms.Label();
            this.btnCopyReference = new System.Windows.Forms.Button();
            this.rtxtReference = new System.Windows.Forms.RichTextBox();
            this.lblReference = new System.Windows.Forms.Label();
            this.lblCitation = new System.Windows.Forms.Label();
            this.panelInput.SuspendLayout();
            this.panelConvertCitation.SuspendLayout();
            this.panelCitation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.btnCreateCitiation);
            this.panelInput.Controls.Add(this.dateTimePicker1);
            this.panelInput.Controls.Add(this.txtLink);
            this.panelInput.Controls.Add(this.txtPublishYear);
            this.panelInput.Controls.Add(this.txtTitle);
            this.panelInput.Controls.Add(this.txtPublisher);
            this.panelInput.Controls.Add(this.label5);
            this.panelInput.Controls.Add(this.label4);
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Location = new System.Drawing.Point(0, 242);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1329, 561);
            this.panelInput.TabIndex = 0;
            // 
            // btnCreateCitiation
            // 
            this.btnCreateCitiation.Location = new System.Drawing.Point(384, 490);
            this.btnCreateCitiation.Name = "btnCreateCitiation";
            this.btnCreateCitiation.Size = new System.Drawing.Size(384, 46);
            this.btnCreateCitiation.TabIndex = 16;
            this.btnCreateCitiation.Text = "Create Citation";
            this.btnCreateCitiation.UseVisualStyleBackColor = true;
            this.btnCreateCitiation.Click += new System.EventHandler(this.btnCreateCitiation_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 424);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(400, 39);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(180, 299);
            this.txtLink.Multiline = true;
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(858, 78);
            this.txtLink.TabIndex = 8;
            // 
            // txtPublishYear
            // 
            this.txtPublishYear.Location = new System.Drawing.Point(180, 239);
            this.txtPublishYear.Name = "txtPublishYear";
            this.txtPublishYear.Size = new System.Drawing.Size(167, 39);
            this.txtPublishYear.TabIndex = 7;
            this.txtPublishYear.Validated += new System.EventHandler(this.txtPublishYear_Validated);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(180, 135);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(858, 78);
            this.txtTitle.TabIndex = 6;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(180, 61);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(858, 39);
            this.txtPublisher.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Access Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Link:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Publish Year:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Composer:";
            // 
            // panelConvertCitation
            // 
            this.panelConvertCitation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelConvertCitation.Controls.Add(this.txtConvertCitation);
            this.panelConvertCitation.Controls.Add(this.btnClearCitation);
            this.panelConvertCitation.Controls.Add(this.btnPaste);
            this.panelConvertCitation.Controls.Add(this.btnConvertHarvard);
            this.panelConvertCitation.Controls.Add(this.label6);
            this.panelConvertCitation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConvertCitation.Location = new System.Drawing.Point(0, 0);
            this.panelConvertCitation.Name = "panelConvertCitation";
            this.panelConvertCitation.Size = new System.Drawing.Size(1341, 236);
            this.panelConvertCitation.TabIndex = 4;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(80, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Citation Converter";
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
            this.panelCitation.Location = new System.Drawing.Point(3, 809);
            this.panelCitation.Name = "panelCitation";
            this.panelCitation.Size = new System.Drawing.Size(1326, 400);
            this.panelCitation.TabIndex = 6;
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
            // FormOnlineSound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 1380);
            this.Controls.Add(this.panelCitation);
            this.Controls.Add(this.panelConvertCitation);
            this.Controls.Add(this.panelInput);
            this.Name = "FormOnlineSound";
            this.Text = "Online Sound";
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelConvertCitation.ResumeLayout(false);
            this.panelConvertCitation.PerformLayout();
            this.panelCitation.ResumeLayout(false);
            this.panelCitation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelInput;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox txtLink;
        private TextBox txtPublishYear;
        private TextBox txtTitle;
        private TextBox txtPublisher;
        private Panel panelConvertCitation;
        private TextBox txtConvertCitation;
        private Button btnClearCitation;
        private Button btnPaste;
        private Button btnConvertHarvard;
        private Label label6;
        private Button btnCreateCitiation;
        private Panel panelCitation;
        private Button btnCopyInText;
        private RichTextBox rtxtInText;
        private Label lblInText;
        private Button btnCopyReference;
        private RichTextBox rtxtReference;
        private Label lblReference;
        private Label lblCitation;
    }
}