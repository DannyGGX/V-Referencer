using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_Referencer
{
    public partial class FormOnlineSound : Form
    {
        string publisher, title, url;
        int year;
        DateTime accessDate;

        UIController controller;
        OnlineSound sound;

        public FormOnlineSound()
        {
            InitializeComponent();

            controller = new UIController();
            rtxtInText.Font = controller.NormalFont;
        }

        private void btnConvertHarvard_Click(object sender, EventArgs e)
        {
            ConvertCitation convertCitation = new ConvertCitation(txtConvertCitation.Text);
            txtPublisher.Text = convertCitation.Name;
            txtTitle.Text = convertCitation.Title;
            txtPublishYear.Text = convertCitation.PublishYear.ToString();
            txtLink.Text = convertCitation.Url;
            dateTimePicker1.Value = convertCitation.AccessDate;
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            controller.PasteRegularHarvardCitation(txtConvertCitation);
        }

        private void btnClearCitation_Click(object sender, EventArgs e)
        {
            txtConvertCitation.Clear();
            txtPublisher.Clear();
            txtLink.Clear();
            txtPublishYear.Clear();
            txtTitle.Clear();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void btnCreateCitiation_Click(object sender, EventArgs e)
        {
            //Clear
            controller.ResetCopyButtons(btnCopyInText, btnCopyReference);
            rtxtReference.Clear();
            rtxtInText.Clear();

            publisher = txtPublisher.Text;
            title = txtTitle.Text;
            year = int.Parse(txtPublishYear.Text);
            url = txtLink.Text;
            accessDate = dateTimePicker1.Value;
            sound = new OnlineSound(publisher, title, year, url, accessDate);

            WriteFormattedText(rtxtReference, sound.BeforeItalics, sound.Italics, sound.AfterItalics);
            rtxtInText.Text = sound.CreateInText();
        }
        private void WriteFormattedText(RichTextBox rtxt, string beforeItalics, string italics, string afterItalics)
        {
            controller.WriteNormalText(rtxt, beforeItalics);
            controller.WriteItalics(rtxt, italics);
            controller.WriteNormalText(rtxt, afterItalics);
        }

        private void txtPublishYear_Validated(object sender, EventArgs e)
        {
            controller.YearValidation(txtPublishYear);
        }

        private void btnCopyReference_Click(object sender, EventArgs e)
        {
            controller.Copy(rtxtReference, btnCopyReference);
        }

        private void btnCopyInText_Click(object sender, EventArgs e)
        {
            controller.Copy(rtxtInText, btnCopyInText);
        }
    }
}
