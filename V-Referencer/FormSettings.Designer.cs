namespace V_Referencer
{
    partial class FormSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSaveFont = new System.Windows.Forms.Label();
            this.txtFontExample = new System.Windows.Forms.TextBox();
            this.btnChangeFont = new System.Windows.Forms.Button();
            this.btnDeleteSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericFigureNum = new System.Windows.Forms.NumericUpDown();
            this.btnSaveFigureNum = new System.Windows.Forms.Button();
            this.lblSaveFigureNum = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbBrowserChoice = new System.Windows.Forms.ComboBox();
            this.lblSaveBrowser = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFigureNum)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSaveFont);
            this.groupBox1.Controls.Add(this.txtFontExample);
            this.groupBox1.Controls.Add(this.btnChangeFont);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Citations Font";
            // 
            // lblSaveFont
            // 
            this.lblSaveFont.AutoSize = true;
            this.lblSaveFont.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaveFont.Location = new System.Drawing.Point(264, 179);
            this.lblSaveFont.Name = "lblSaveFont";
            this.lblSaveFont.Size = new System.Drawing.Size(100, 32);
            this.lblSaveFont.TabIndex = 3;
            this.lblSaveFont.Text = "No save";
            // 
            // txtFontExample
            // 
            this.txtFontExample.Location = new System.Drawing.Point(33, 72);
            this.txtFontExample.Name = "txtFontExample";
            this.txtFontExample.Size = new System.Drawing.Size(980, 50);
            this.txtFontExample.TabIndex = 1;
            this.txtFontExample.Text = "Citation font will look like this.";
            // 
            // btnChangeFont
            // 
            this.btnChangeFont.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangeFont.Location = new System.Drawing.Point(33, 169);
            this.btnChangeFont.Name = "btnChangeFont";
            this.btnChangeFont.Size = new System.Drawing.Size(213, 52);
            this.btnChangeFont.TabIndex = 0;
            this.btnChangeFont.Text = "Change Font";
            this.btnChangeFont.UseVisualStyleBackColor = true;
            this.btnChangeFont.Click += new System.EventHandler(this.btnChangeFont_Click);
            // 
            // btnDeleteSave
            // 
            this.btnDeleteSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteSave.Location = new System.Drawing.Point(45, 989);
            this.btnDeleteSave.Name = "btnDeleteSave";
            this.btnDeleteSave.Size = new System.Drawing.Size(197, 46);
            this.btnDeleteSave.TabIndex = 1;
            this.btnDeleteSave.Text = "Delete Save File";
            this.btnDeleteSave.UseVisualStyleBackColor = true;
            this.btnDeleteSave.Click += new System.EventHandler(this.btnDeleteSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericFigureNum);
            this.groupBox2.Controls.Add(this.btnSaveFigureNum);
            this.groupBox2.Controls.Add(this.lblSaveFigureNum);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1034, 224);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Figure Number";
            // 
            // numericFigureNum
            // 
            this.numericFigureNum.Location = new System.Drawing.Point(33, 79);
            this.numericFigureNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericFigureNum.Name = "numericFigureNum";
            this.numericFigureNum.Size = new System.Drawing.Size(96, 50);
            this.numericFigureNum.TabIndex = 2;
            this.numericFigureNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericFigureNum.ValueChanged += new System.EventHandler(this.numericFigureNum_ValueChanged);
            // 
            // btnSaveFigureNum
            // 
            this.btnSaveFigureNum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveFigureNum.Location = new System.Drawing.Point(164, 79);
            this.btnSaveFigureNum.Name = "btnSaveFigureNum";
            this.btnSaveFigureNum.Size = new System.Drawing.Size(220, 50);
            this.btnSaveFigureNum.TabIndex = 1;
            this.btnSaveFigureNum.Text = "Save Number";
            this.btnSaveFigureNum.UseVisualStyleBackColor = true;
            this.btnSaveFigureNum.Click += new System.EventHandler(this.btnSaveFigureNum_Click);
            // 
            // lblSaveFigureNum
            // 
            this.lblSaveFigureNum.AutoSize = true;
            this.lblSaveFigureNum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaveFigureNum.Location = new System.Drawing.Point(33, 148);
            this.lblSaveFigureNum.Name = "lblSaveFigureNum";
            this.lblSaveFigureNum.Size = new System.Drawing.Size(100, 32);
            this.lblSaveFigureNum.TabIndex = 0;
            this.lblSaveFigureNum.Text = "No save";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbBrowserChoice);
            this.groupBox3.Controls.Add(this.lblSaveBrowser);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(12, 498);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1034, 224);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Webscrape Browser";
            // 
            // cmbBrowserChoice
            // 
            this.cmbBrowserChoice.FormattingEnabled = true;
            this.cmbBrowserChoice.Items.AddRange(new object[] {
            "Chrome",
            "Edge"});
            this.cmbBrowserChoice.Location = new System.Drawing.Point(33, 73);
            this.cmbBrowserChoice.Name = "cmbBrowserChoice";
            this.cmbBrowserChoice.Size = new System.Drawing.Size(351, 53);
            this.cmbBrowserChoice.TabIndex = 1;
            this.cmbBrowserChoice.SelectedIndexChanged += new System.EventHandler(this.cmbBrowserChoice_SelectedIndexChanged);
            // 
            // lblSaveBrowser
            // 
            this.lblSaveBrowser.AutoSize = true;
            this.lblSaveBrowser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaveBrowser.Location = new System.Drawing.Point(33, 148);
            this.lblSaveBrowser.Name = "lblSaveBrowser";
            this.lblSaveBrowser.Size = new System.Drawing.Size(100, 32);
            this.lblSaveBrowser.TabIndex = 0;
            this.lblSaveBrowser.Text = "No save";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 1084);
            this.Controls.Add(this.btnDeleteSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFigureNum)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private TextBox txtFontExample;
        private Button btnChangeFont;
        private Button btnDeleteSave;
        private Label lblSaveFont;
        private GroupBox groupBox2;
        private NumericUpDown numericFigureNum;
        private Button btnSaveFigureNum;
        private Label lblSaveFigureNum;
        private GroupBox groupBox3;
        private ComboBox cmbBrowserChoice;
        private Label lblSaveBrowser;
    }
}