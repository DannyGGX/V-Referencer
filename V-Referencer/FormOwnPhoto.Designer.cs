﻿namespace V_Referencer
{
    partial class FormOwnPhoto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveFigureNum = new System.Windows.Forms.Button();
            this.numericSelectFigure = new System.Windows.Forms.NumericUpDown();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnCreateCitation = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.rtxtReferenceTitle = new System.Windows.Forms.RichTextBox();
            this.btnSaveName = new System.Windows.Forms.Button();
            this.txtYourName = new System.Windows.Forms.TextBox();
            this.lblReferenceTitle = new System.Windows.Forms.Label();
            this.lblYourName = new System.Windows.Forms.Label();
            this.checkBoxFigureNum = new System.Windows.Forms.CheckBox();
            this.groupBoxCitation = new System.Windows.Forms.GroupBox();
            this.btnCopyInText = new System.Windows.Forms.Button();
            this.rtxtInTextReference = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCopyReference = new System.Windows.Forms.Button();
            this.rtxtReference = new System.Windows.Forms.RichTextBox();
            this.lblReference = new System.Windows.Forms.Label();
            this.btnCopyListOfFigures = new System.Windows.Forms.Button();
            this.rtxtListOfFigures = new System.Windows.Forms.RichTextBox();
            this.lblListOfFigures = new System.Windows.Forms.Label();
            this.btnCopyFigure = new System.Windows.Forms.Button();
            this.rtxtFigure = new System.Windows.Forms.RichTextBox();
            this.lblFigure = new System.Windows.Forms.Label();
            this.btnCopyInTextStart = new System.Windows.Forms.Button();
            this.rtxtInTextStart = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSelectFigure)).BeginInit();
            this.groupBoxCitation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSaveFigureNum);
            this.panel1.Controls.Add(this.numericSelectFigure);
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.btnCreateCitation);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.rtxtReferenceTitle);
            this.panel1.Controls.Add(this.btnSaveName);
            this.panel1.Controls.Add(this.txtYourName);
            this.panel1.Controls.Add(this.lblReferenceTitle);
            this.panel1.Controls.Add(this.lblYourName);
            this.panel1.Controls.Add(this.checkBoxFigureNum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 421);
            this.panel1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 32);
            this.label3.TabIndex = 40;
            this.label3.Text = "Figure:";
            // 
            // btnSaveFigureNum
            // 
            this.btnSaveFigureNum.Location = new System.Drawing.Point(852, 248);
            this.btnSaveFigureNum.Name = "btnSaveFigureNum";
            this.btnSaveFigureNum.Size = new System.Drawing.Size(167, 39);
            this.btnSaveFigureNum.TabIndex = 6;
            this.btnSaveFigureNum.Text = "Save Number";
            this.btnSaveFigureNum.UseVisualStyleBackColor = true;
            this.btnSaveFigureNum.Click += new System.EventHandler(this.btnSaveFigureNum_Click);
            // 
            // numericSelectFigure
            // 
            this.numericSelectFigure.Location = new System.Drawing.Point(541, 250);
            this.numericSelectFigure.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSelectFigure.Name = "numericSelectFigure";
            this.numericSelectFigure.Size = new System.Drawing.Size(95, 39);
            this.numericSelectFigure.TabIndex = 5;
            this.numericSelectFigure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericSelectFigure.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(286, 170);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(138, 39);
            this.txtYear.TabIndex = 3;
            this.txtYear.Validated += new System.EventHandler(this.txtYear_Validated);
            // 
            // btnCreateCitation
            // 
            this.btnCreateCitation.Location = new System.Drawing.Point(400, 343);
            this.btnCreateCitation.Name = "btnCreateCitation";
            this.btnCreateCitation.Size = new System.Drawing.Size(325, 46);
            this.btnCreateCitation.TabIndex = 7;
            this.btnCreateCitation.Text = "Create Citation";
            this.btnCreateCitation.UseVisualStyleBackColor = true;
            this.btnCreateCitation.Click += new System.EventHandler(this.btnCreateCitation_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(113, 173);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(63, 32);
            this.lblYear.TabIndex = 15;
            this.lblYear.Text = "Year:";
            // 
            // rtxtReferenceTitle
            // 
            this.rtxtReferenceTitle.Location = new System.Drawing.Point(286, 93);
            this.rtxtReferenceTitle.Name = "rtxtReferenceTitle";
            this.rtxtReferenceTitle.Size = new System.Drawing.Size(733, 51);
            this.rtxtReferenceTitle.TabIndex = 2;
            this.rtxtReferenceTitle.Text = "";
            // 
            // btnSaveName
            // 
            this.btnSaveName.Location = new System.Drawing.Point(809, 22);
            this.btnSaveName.Name = "btnSaveName";
            this.btnSaveName.Size = new System.Drawing.Size(210, 46);
            this.btnSaveName.TabIndex = 1;
            this.btnSaveName.Text = "Save";
            this.btnSaveName.UseVisualStyleBackColor = true;
            this.btnSaveName.Click += new System.EventHandler(this.btnSaveName_Click);
            // 
            // txtYourName
            // 
            this.txtYourName.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtYourName.Location = new System.Drawing.Point(286, 20);
            this.txtYourName.Margin = new System.Windows.Forms.Padding(4);
            this.txtYourName.Name = "txtYourName";
            this.txtYourName.PlaceholderText = "Name Surname";
            this.txtYourName.Size = new System.Drawing.Size(516, 46);
            this.txtYourName.TabIndex = 0;
            this.txtYourName.TextChanged += new System.EventHandler(this.txtYourName_TextChanged);
            // 
            // lblReferenceTitle
            // 
            this.lblReferenceTitle.AutoSize = true;
            this.lblReferenceTitle.Location = new System.Drawing.Point(113, 96);
            this.lblReferenceTitle.Name = "lblReferenceTitle";
            this.lblReferenceTitle.Size = new System.Drawing.Size(65, 32);
            this.lblReferenceTitle.TabIndex = 11;
            this.lblReferenceTitle.Text = "Title:";
            // 
            // lblYourName
            // 
            this.lblYourName.AutoSize = true;
            this.lblYourName.Location = new System.Drawing.Point(113, 22);
            this.lblYourName.Name = "lblYourName";
            this.lblYourName.Size = new System.Drawing.Size(133, 32);
            this.lblYourName.TabIndex = 10;
            this.lblYourName.Text = "Your name:";
            // 
            // checkBoxFigureNum
            // 
            this.checkBoxFigureNum.AutoSize = true;
            this.checkBoxFigureNum.Location = new System.Drawing.Point(289, 250);
            this.checkBoxFigureNum.Name = "checkBoxFigureNum";
            this.checkBoxFigureNum.Size = new System.Drawing.Size(249, 36);
            this.checkBoxFigureNum.TabIndex = 4;
            this.checkBoxFigureNum.Text = "include \"Figure #: \"";
            this.checkBoxFigureNum.UseVisualStyleBackColor = true;
            this.checkBoxFigureNum.CheckedChanged += new System.EventHandler(this.checkBoxFigureNum_CheckedChanged);
            // 
            // groupBoxCitation
            // 
            this.groupBoxCitation.Controls.Add(this.btnCopyInTextStart);
            this.groupBoxCitation.Controls.Add(this.rtxtInTextStart);
            this.groupBoxCitation.Controls.Add(this.label2);
            this.groupBoxCitation.Controls.Add(this.btnCopyInText);
            this.groupBoxCitation.Controls.Add(this.rtxtInTextReference);
            this.groupBoxCitation.Controls.Add(this.label1);
            this.groupBoxCitation.Controls.Add(this.btnCopyReference);
            this.groupBoxCitation.Controls.Add(this.rtxtReference);
            this.groupBoxCitation.Controls.Add(this.lblReference);
            this.groupBoxCitation.Controls.Add(this.btnCopyListOfFigures);
            this.groupBoxCitation.Controls.Add(this.rtxtListOfFigures);
            this.groupBoxCitation.Controls.Add(this.lblListOfFigures);
            this.groupBoxCitation.Controls.Add(this.btnCopyFigure);
            this.groupBoxCitation.Controls.Add(this.rtxtFigure);
            this.groupBoxCitation.Controls.Add(this.lblFigure);
            this.groupBoxCitation.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCitation.Location = new System.Drawing.Point(0, 421);
            this.groupBoxCitation.Name = "groupBoxCitation";
            this.groupBoxCitation.Size = new System.Drawing.Size(1157, 860);
            this.groupBoxCitation.TabIndex = 25;
            this.groupBoxCitation.TabStop = false;
            this.groupBoxCitation.Text = "Citation";
            // 
            // btnCopyInText
            // 
            this.btnCopyInText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCopyInText.Location = new System.Drawing.Point(967, 784);
            this.btnCopyInText.Name = "btnCopyInText";
            this.btnCopyInText.Size = new System.Drawing.Size(109, 60);
            this.btnCopyInText.TabIndex = 11;
            this.btnCopyInText.Text = "Copy";
            this.btnCopyInText.UseVisualStyleBackColor = false;
            this.btnCopyInText.Click += new System.EventHandler(this.btnCopyInText_Click);
            // 
            // rtxtInTextReference
            // 
            this.rtxtInTextReference.Location = new System.Drawing.Point(63, 784);
            this.rtxtInTextReference.Name = "rtxtInTextReference";
            this.rtxtInTextReference.Size = new System.Drawing.Size(898, 60);
            this.rtxtInTextReference.TabIndex = 15;
            this.rtxtInTextReference.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 734);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 32);
            this.label1.TabIndex = 35;
            this.label1.Text = "In-text (end of sentence):";
            // 
            // btnCopyReference
            // 
            this.btnCopyReference.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCopyReference.Location = new System.Drawing.Point(967, 490);
            this.btnCopyReference.Name = "btnCopyReference";
            this.btnCopyReference.Size = new System.Drawing.Size(109, 60);
            this.btnCopyReference.TabIndex = 10;
            this.btnCopyReference.Text = "Copy";
            this.btnCopyReference.UseVisualStyleBackColor = false;
            this.btnCopyReference.Click += new System.EventHandler(this.btnCopyReference_Click);
            // 
            // rtxtReference
            // 
            this.rtxtReference.Location = new System.Drawing.Point(63, 470);
            this.rtxtReference.Name = "rtxtReference";
            this.rtxtReference.Size = new System.Drawing.Size(898, 104);
            this.rtxtReference.TabIndex = 14;
            this.rtxtReference.Text = "";
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Location = new System.Drawing.Point(63, 423);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(132, 32);
            this.lblReference.TabIndex = 32;
            this.lblReference.Text = "Reference: ";
            // 
            // btnCopyListOfFigures
            // 
            this.btnCopyListOfFigures.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCopyListOfFigures.Location = new System.Drawing.Point(967, 302);
            this.btnCopyListOfFigures.Name = "btnCopyListOfFigures";
            this.btnCopyListOfFigures.Size = new System.Drawing.Size(109, 60);
            this.btnCopyListOfFigures.TabIndex = 9;
            this.btnCopyListOfFigures.Text = "Copy";
            this.btnCopyListOfFigures.UseVisualStyleBackColor = false;
            this.btnCopyListOfFigures.Click += new System.EventHandler(this.btnCopyListOfFigures_Click);
            // 
            // rtxtListOfFigures
            // 
            this.rtxtListOfFigures.Location = new System.Drawing.Point(63, 279);
            this.rtxtListOfFigures.Name = "rtxtListOfFigures";
            this.rtxtListOfFigures.Size = new System.Drawing.Size(898, 116);
            this.rtxtListOfFigures.TabIndex = 13;
            this.rtxtListOfFigures.Text = "";
            // 
            // lblListOfFigures
            // 
            this.lblListOfFigures.AutoSize = true;
            this.lblListOfFigures.Location = new System.Drawing.Point(63, 212);
            this.lblListOfFigures.Name = "lblListOfFigures";
            this.lblListOfFigures.Size = new System.Drawing.Size(236, 32);
            this.lblListOfFigures.TabIndex = 29;
            this.lblListOfFigures.Text = "List of Figures entry: ";
            // 
            // btnCopyFigure
            // 
            this.btnCopyFigure.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCopyFigure.Location = new System.Drawing.Point(967, 123);
            this.btnCopyFigure.Name = "btnCopyFigure";
            this.btnCopyFigure.Size = new System.Drawing.Size(109, 60);
            this.btnCopyFigure.TabIndex = 8;
            this.btnCopyFigure.Text = "Copy";
            this.btnCopyFigure.UseVisualStyleBackColor = false;
            this.btnCopyFigure.Click += new System.EventHandler(this.btnCopyFigure_Click);
            // 
            // rtxtFigure
            // 
            this.rtxtFigure.Location = new System.Drawing.Point(63, 123);
            this.rtxtFigure.Name = "rtxtFigure";
            this.rtxtFigure.Size = new System.Drawing.Size(898, 60);
            this.rtxtFigure.TabIndex = 12;
            this.rtxtFigure.Text = "";
            // 
            // lblFigure
            // 
            this.lblFigure.AutoSize = true;
            this.lblFigure.Location = new System.Drawing.Point(63, 52);
            this.lblFigure.Name = "lblFigure";
            this.lblFigure.Size = new System.Drawing.Size(86, 32);
            this.lblFigure.TabIndex = 24;
            this.lblFigure.Text = "Figure:";
            // 
            // btnCopyInTextStart
            // 
            this.btnCopyInTextStart.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCopyInTextStart.Location = new System.Drawing.Point(967, 655);
            this.btnCopyInTextStart.Name = "btnCopyInTextStart";
            this.btnCopyInTextStart.Size = new System.Drawing.Size(109, 60);
            this.btnCopyInTextStart.TabIndex = 36;
            this.btnCopyInTextStart.Text = "Copy";
            this.btnCopyInTextStart.UseVisualStyleBackColor = false;
            this.btnCopyInTextStart.Click += new System.EventHandler(this.btnCopyInTextStart_Click);
            // 
            // rtxtInTextStart
            // 
            this.rtxtInTextStart.Location = new System.Drawing.Point(63, 655);
            this.rtxtInTextStart.Name = "rtxtInTextStart";
            this.rtxtInTextStart.Size = new System.Drawing.Size(898, 60);
            this.rtxtInTextStart.TabIndex = 37;
            this.rtxtInTextStart.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 605);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 32);
            this.label2.TabIndex = 38;
            this.label2.Text = "In-text (start or middle of sentence):";
            // 
            // FormOwnPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1157, 1354);
            this.Controls.Add(this.groupBoxCitation);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1170, 0);
            this.Name = "FormOwnPhoto";
            this.Text = "Own Photograph";
            this.Load += new System.EventHandler(this.FormOwnPhoto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSelectFigure)).EndInit();
            this.groupBoxCitation.ResumeLayout(false);
            this.groupBoxCitation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Button btnCreateCitation;
        private Label lblYear;
        private RichTextBox rtxtReferenceTitle;
        private Button btnSaveName;
        private TextBox txtYourName;
        private Label lblReferenceTitle;
        private Label lblYourName;
        private GroupBox groupBoxCitation;
        private Button btnCopyInText;
        private RichTextBox rtxtInTextReference;
        private Label label1;
        private Button btnCopyReference;
        private RichTextBox rtxtReference;
        private Label lblReference;
        private Button btnCopyListOfFigures;
        private RichTextBox rtxtListOfFigures;
        private Label lblListOfFigures;
        private Button btnCopyFigure;
        private RichTextBox rtxtFigure;
        private CheckBox checkBoxFigureNum;
        private Label lblFigure;
        private TextBox txtYear;
        private NumericUpDown numericSelectFigure;
        private Button btnSaveFigureNum;
        private Label label3;
        private Button btnCopyInTextStart;
        private RichTextBox rtxtInTextStart;
        private Label label2;
    }
}