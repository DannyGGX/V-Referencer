namespace V_Referencer
{
    partial class FormYouTubeVideo
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
            this.lblLink = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnCreateReference = new System.Windows.Forms.Button();
            this.lblReference = new System.Windows.Forms.Label();
            this.rtxtReference = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtInText = new System.Windows.Forms.RichTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnCopyReference = new System.Windows.Forms.Button();
            this.btnCopyInText = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnClearLink = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLink.Location = new System.Drawing.Point(49, 43);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(74, 40);
            this.lblLink.TabIndex = 0;
            this.lblLink.Text = "Link:";
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLink.Location = new System.Drawing.Point(129, 40);
            this.txtLink.Name = "txtLink";
            this.txtLink.PlaceholderText = "Paste link here";
            this.txtLink.Size = new System.Drawing.Size(773, 46);
            this.txtLink.TabIndex = 1;
            // 
            // btnCreateReference
            // 
            this.btnCreateReference.Location = new System.Drawing.Point(287, 232);
            this.btnCreateReference.Name = "btnCreateReference";
            this.btnCreateReference.Size = new System.Drawing.Size(384, 60);
            this.btnCreateReference.TabIndex = 2;
            this.btnCreateReference.Text = "Create Reference";
            this.btnCreateReference.UseVisualStyleBackColor = true;
            this.btnCreateReference.Click += new System.EventHandler(this.btnCreateReference_Click);
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReference.Location = new System.Drawing.Point(49, 333);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(155, 40);
            this.lblReference.TabIndex = 3;
            this.lblReference.Text = "Reference: ";
            // 
            // rtxtReference
            // 
            this.rtxtReference.Location = new System.Drawing.Point(49, 376);
            this.rtxtReference.Name = "rtxtReference";
            this.rtxtReference.Size = new System.Drawing.Size(853, 179);
            this.rtxtReference.TabIndex = 4;
            this.rtxtReference.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "In-Text Reference:";
            // 
            // rtxtInText
            // 
            this.rtxtInText.Location = new System.Drawing.Point(49, 601);
            this.rtxtInText.Name = "rtxtInText";
            this.rtxtInText.Size = new System.Drawing.Size(853, 95);
            this.rtxtInText.TabIndex = 5;
            this.rtxtInText.Text = "";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(49, 120);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(215, 40);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Date Accessed: ";
            // 
            // btnCopyReference
            // 
            this.btnCopyReference.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCopyReference.Location = new System.Drawing.Point(908, 409);
            this.btnCopyReference.Name = "btnCopyReference";
            this.btnCopyReference.Size = new System.Drawing.Size(109, 60);
            this.btnCopyReference.TabIndex = 35;
            this.btnCopyReference.Text = "Copy";
            this.btnCopyReference.UseVisualStyleBackColor = false;
            this.btnCopyReference.Click += new System.EventHandler(this.btnCopyReference_Click);
            // 
            // btnCopyInText
            // 
            this.btnCopyInText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCopyInText.Location = new System.Drawing.Point(908, 613);
            this.btnCopyInText.Name = "btnCopyInText";
            this.btnCopyInText.Size = new System.Drawing.Size(109, 60);
            this.btnCopyInText.TabIndex = 36;
            this.btnCopyInText.Text = "Copy";
            this.btnCopyInText.UseVisualStyleBackColor = false;
            this.btnCopyInText.Click += new System.EventHandler(this.btnCopyInText_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(502, 121);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(400, 39);
            this.dateTimePicker1.TabIndex = 38;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnClearLink
            // 
            this.btnClearLink.Location = new System.Drawing.Point(908, 40);
            this.btnClearLink.Name = "btnClearLink";
            this.btnClearLink.Size = new System.Drawing.Size(109, 46);
            this.btnClearLink.TabIndex = 37;
            this.btnClearLink.Text = "Clear";
            this.btnClearLink.UseVisualStyleBackColor = true;
            this.btnClearLink.Click += new System.EventHandler(this.btnClearLink_Click);
            // 
            // FormYouTubeVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1190, 1079);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnClearLink);
            this.Controls.Add(this.btnCopyInText);
            this.Controls.Add(this.btnCopyReference);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.rtxtInText);
            this.Controls.Add(this.rtxtReference);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblReference);
            this.Controls.Add(this.btnCreateReference);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.lblLink);
            this.Name = "FormYouTubeVideo";
            this.Text = "YouTube Video";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLink;
        private TextBox txtLink;
        private Button btnCreateReference;
        private Label lblReference;
        private RichTextBox rtxtReference;
        private Label label1;
        private RichTextBox rtxtInText;
        private Label lblDate;
        private Button btnCopyReference;
        private Button btnCopyInText;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DateTimePicker dateTimePicker1;
        private Button btnClearLink;
    }
}