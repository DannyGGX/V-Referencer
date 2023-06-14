namespace V_Referencer
{
    partial class FormBook
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
            this.panelAuthors = new System.Windows.Forms.Panel();
            this.lblNumOfAuthors = new System.Windows.Forms.Label();
            this.NumOfAuthorSelector = new System.Windows.Forms.NumericUpDown();
            this.lblAuthors = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnCreateCitation = new System.Windows.Forms.Button();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblPublicationPlace = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtPublicationPlace = new System.Windows.Forms.TextBox();
            this.lblEdition = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.panelCitation = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopyInText2 = new System.Windows.Forms.Button();
            this.btnCopyInText1 = new System.Windows.Forms.Button();
            this.rtxtInText2 = new System.Windows.Forms.RichTextBox();
            this.rtxtInText1 = new System.Windows.Forms.RichTextBox();
            this.lblInText = new System.Windows.Forms.Label();
            this.btnCopyReference = new System.Windows.Forms.Button();
            this.rtxtReference = new System.Windows.Forms.RichTextBox();
            this.lblReference = new System.Windows.Forms.Label();
            this.lblCitation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfAuthorSelector)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.panelCitation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAuthors
            // 
            this.panelAuthors.Controls.Add(this.lblNumOfAuthors);
            this.panelAuthors.Controls.Add(this.NumOfAuthorSelector);
            this.panelAuthors.Controls.Add(this.lblAuthors);
            this.panelAuthors.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAuthors.Location = new System.Drawing.Point(0, 0);
            this.panelAuthors.Name = "panelAuthors";
            this.panelAuthors.Size = new System.Drawing.Size(1216, 300);
            this.panelAuthors.TabIndex = 0;
            // 
            // lblNumOfAuthors
            // 
            this.lblNumOfAuthors.AutoSize = true;
            this.lblNumOfAuthors.Location = new System.Drawing.Point(396, 22);
            this.lblNumOfAuthors.Name = "lblNumOfAuthors";
            this.lblNumOfAuthors.Size = new System.Drawing.Size(233, 32);
            this.lblNumOfAuthors.TabIndex = 2;
            this.lblNumOfAuthors.Text = "Number of Authors: ";
            // 
            // NumOfAuthorSelector
            // 
            this.NumOfAuthorSelector.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumOfAuthorSelector.Location = new System.Drawing.Point(635, 16);
            this.NumOfAuthorSelector.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumOfAuthorSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumOfAuthorSelector.Name = "NumOfAuthorSelector";
            this.NumOfAuthorSelector.Size = new System.Drawing.Size(90, 43);
            this.NumOfAuthorSelector.TabIndex = 1;
            this.NumOfAuthorSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumOfAuthorSelector.ValueChanged += new System.EventHandler(this.NumOfAuthorSelector_ValueChanged);
            // 
            // lblAuthors
            // 
            this.lblAuthors.AutoSize = true;
            this.lblAuthors.Location = new System.Drawing.Point(41, 9);
            this.lblAuthors.Name = "lblAuthors";
            this.lblAuthors.Size = new System.Drawing.Size(97, 32);
            this.lblAuthors.TabIndex = 0;
            this.lblAuthors.Text = "Authors";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.btnCreateCitation);
            this.panel1.Controls.Add(this.lblPublisher);
            this.panel1.Controls.Add(this.lblPublicationPlace);
            this.panel1.Controls.Add(this.txtPublisher);
            this.panel1.Controls.Add(this.txtPublicationPlace);
            this.panel1.Controls.Add(this.lblEdition);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 476);
            this.panel1.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(285, 29);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(110, 39);
            this.txtYear.TabIndex = 4;
            this.txtYear.Validated += new System.EventHandler(this.txtYear_Validated);
            // 
            // btnCreateCitation
            // 
            this.btnCreateCitation.Location = new System.Drawing.Point(312, 397);
            this.btnCreateCitation.Name = "btnCreateCitation";
            this.btnCreateCitation.Size = new System.Drawing.Size(325, 46);
            this.btnCreateCitation.TabIndex = 9;
            this.btnCreateCitation.Text = "Create Citation";
            this.btnCreateCitation.UseVisualStyleBackColor = true;
            this.btnCreateCitation.Click += new System.EventHandler(this.btnCreateCitation_Click);
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(41, 326);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(184, 32);
            this.lblPublisher.TabIndex = 8;
            this.lblPublisher.Text = "Publisher name:";
            // 
            // lblPublicationPlace
            // 
            this.lblPublicationPlace.AutoSize = true;
            this.lblPublicationPlace.Location = new System.Drawing.Point(41, 256);
            this.lblPublicationPlace.Name = "lblPublicationPlace";
            this.lblPublicationPlace.Size = new System.Drawing.Size(215, 32);
            this.lblPublicationPlace.TabIndex = 7;
            this.lblPublicationPlace.Text = "City of publication:";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(312, 323);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(496, 39);
            this.txtPublisher.TabIndex = 8;
            // 
            // txtPublicationPlace
            // 
            this.txtPublicationPlace.Location = new System.Drawing.Point(312, 253);
            this.txtPublicationPlace.Name = "txtPublicationPlace";
            this.txtPublicationPlace.Size = new System.Drawing.Size(496, 39);
            this.txtPublicationPlace.TabIndex = 7;
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Location = new System.Drawing.Point(41, 191);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(195, 32);
            this.lblEdition.TabIndex = 4;
            this.lblEdition.Text = "Edition Number: ";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown2.Location = new System.Drawing.Point(285, 185);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(87, 43);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(41, 123);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(1026, 39);
            this.txtTitle.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(41, 88);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(72, 32);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title: ";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(41, 32);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(224, 32);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "Year of Publication: ";
            // 
            // panelCitation
            // 
            this.panelCitation.Controls.Add(this.label2);
            this.panelCitation.Controls.Add(this.label1);
            this.panelCitation.Controls.Add(this.btnCopyInText2);
            this.panelCitation.Controls.Add(this.btnCopyInText1);
            this.panelCitation.Controls.Add(this.rtxtInText2);
            this.panelCitation.Controls.Add(this.rtxtInText1);
            this.panelCitation.Controls.Add(this.label3);
            this.panelCitation.Controls.Add(this.lblInText);
            this.panelCitation.Controls.Add(this.btnCopyReference);
            this.panelCitation.Controls.Add(this.rtxtReference);
            this.panelCitation.Controls.Add(this.lblReference);
            this.panelCitation.Controls.Add(this.lblCitation);
            this.panelCitation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCitation.Location = new System.Drawing.Point(0, 776);
            this.panelCitation.Name = "panelCitation";
            this.panelCitation.Size = new System.Drawing.Size(1216, 664);
            this.panelCitation.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 32);
            this.label2.TabIndex = 46;
            this.label2.Text = "End of sentence:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 32);
            this.label1.TabIndex = 46;
            this.label1.Text = "Start or middle of sentence:";
            // 
            // btnCopyInText2
            // 
            this.btnCopyInText2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCopyInText2.Location = new System.Drawing.Point(958, 436);
            this.btnCopyInText2.Name = "btnCopyInText2";
            this.btnCopyInText2.Size = new System.Drawing.Size(109, 71);
            this.btnCopyInText2.TabIndex = 45;
            this.btnCopyInText2.Text = "Copy";
            this.btnCopyInText2.UseVisualStyleBackColor = false;
            this.btnCopyInText2.Click += new System.EventHandler(this.btnCopyInText2_Click);
            // 
            // btnCopyInText1
            // 
            this.btnCopyInText1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCopyInText1.Location = new System.Drawing.Point(958, 312);
            this.btnCopyInText1.Name = "btnCopyInText1";
            this.btnCopyInText1.Size = new System.Drawing.Size(109, 71);
            this.btnCopyInText1.TabIndex = 45;
            this.btnCopyInText1.Text = "Copy";
            this.btnCopyInText1.UseVisualStyleBackColor = false;
            this.btnCopyInText1.Click += new System.EventHandler(this.btnCopyInText1_Click);
            // 
            // rtxtInText2
            // 
            this.rtxtInText2.Location = new System.Drawing.Point(41, 436);
            this.rtxtInText2.Name = "rtxtInText2";
            this.rtxtInText2.Size = new System.Drawing.Size(911, 71);
            this.rtxtInText2.TabIndex = 44;
            this.rtxtInText2.Text = "";
            // 
            // rtxtInText1
            // 
            this.rtxtInText1.Location = new System.Drawing.Point(41, 312);
            this.rtxtInText1.Name = "rtxtInText1";
            this.rtxtInText1.Size = new System.Drawing.Size(911, 71);
            this.rtxtInText1.TabIndex = 44;
            this.rtxtInText1.Text = "";
            // 
            // lblInText
            // 
            this.lblInText.AutoSize = true;
            this.lblInText.Location = new System.Drawing.Point(41, 244);
            this.lblInText.Name = "lblInText";
            this.lblInText.Size = new System.Drawing.Size(225, 32);
            this.lblInText.TabIndex = 43;
            this.lblInText.Text = "In-text Paraphrased:";
            // 
            // btnCopyReference
            // 
            this.btnCopyReference.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCopyReference.Location = new System.Drawing.Point(958, 90);
            this.btnCopyReference.Name = "btnCopyReference";
            this.btnCopyReference.Size = new System.Drawing.Size(109, 71);
            this.btnCopyReference.TabIndex = 42;
            this.btnCopyReference.Text = "Copy";
            this.btnCopyReference.UseVisualStyleBackColor = false;
            this.btnCopyReference.Click += new System.EventHandler(this.btnCopyReference_Click);
            // 
            // rtxtReference
            // 
            this.rtxtReference.Location = new System.Drawing.Point(41, 69);
            this.rtxtReference.Name = "rtxtReference";
            this.rtxtReference.Size = new System.Drawing.Size(911, 137);
            this.rtxtReference.TabIndex = 41;
            this.rtxtReference.Text = "";
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Location = new System.Drawing.Point(41, 34);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(132, 32);
            this.lblReference.TabIndex = 40;
            this.lblReference.Text = "Reference: ";
            // 
            // lblCitation
            // 
            this.lblCitation.AutoSize = true;
            this.lblCitation.Location = new System.Drawing.Point(375, 12);
            this.lblCitation.Name = "lblCitation";
            this.lblCitation.Size = new System.Drawing.Size(97, 32);
            this.lblCitation.TabIndex = 1;
            this.lblCitation.Text = "Citation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 32);
            this.label3.TabIndex = 43;
            this.label3.Text = "In-text Paraphrased:";
            // 
            // FormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 1537);
            this.Controls.Add(this.panelCitation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAuthors);
            this.Name = "FormBook";
            this.Text = "Book";
            this.panelAuthors.ResumeLayout(false);
            this.panelAuthors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfAuthorSelector)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.panelCitation.ResumeLayout(false);
            this.panelCitation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelAuthors;
        private Label lblNumOfAuthors;
        private NumericUpDown NumOfAuthorSelector;
        private Label lblAuthors;
        private Panel panel1;
        private Label lblEdition;
        private TextBox txtTitle;
        private Label lblTitle;
        private Label lblYear;
        private NumericUpDown numericUpDown2;
        private Label lblPublisher;
        private Label lblPublicationPlace;
        private TextBox txtPublisher;
        private TextBox txtPublicationPlace;
        private Button btnCreateCitation;
        private Panel panelCitation;
        private Label lblCitation;
        private Button btnCopyInText2;
        private Button btnCopyInText1;
        private RichTextBox rtxtInText2;
        private RichTextBox rtxtInText1;
        private Label lblInText;
        private Button btnCopyReference;
        private RichTextBox rtxtReference;
        private Label lblReference;
        private Label label2;
        private Label label1;
        private TextBox txtYear;
        private Label label3;
    }
}