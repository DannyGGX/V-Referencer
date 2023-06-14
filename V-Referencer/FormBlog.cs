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
    public partial class FormBlog : Form
    {
        string author;
        string websiteName;
        string title;
        DateTime publishDate;
        string url;
        DateTime accessDate;
        bool authorNameNeedFormatting = false;

        Blog blog;
        UIController controller;

        public FormBlog()
        {
            InitializeComponent();

            controller = new UIController();
            rtxtReference.Font = controller.NormalFont;
            rtxtInText.Font = controller.NormalFont;

            lblPublishDateWarning.Hide();
            lblTitleWarning.Hide();
            lblAuthorWarning.Hide();
        }

        private void btnConvertHarvard_Click(object sender, EventArgs e)
        {
            ConvertCitation convertCitation = new ConvertCitation(txtConvertCitation.Text);
            if (convertCitation.Name != convertCitation.WebsiteName)
            {
                txtAuthorNoFormatting.Text = convertCitation.Name;
            }
            else
            {
                txtAuthorNoFormatting.Clear();
                lblAuthorWarning.Show();
            }
            txtWebsiteName.Text = convertCitation.WebsiteName;

            convertCitation.Title = convertCitation.ToSentenceCase(convertCitation.Title);
            txtTitle.Text = convertCitation.Title;

            txtLink.Text = convertCitation.Url;
            if (convertCitation.PublishYear != 0) // for handling exceptions
            {
                dateTimePicker1.Value = Convert.ToDateTime($"{DateTime.Today.Month}/{DateTime.Today.Day}/{convertCitation.PublishYear}");
            }
            else
            {
                MessageBox.Show("Couldn't find the publish year");
            }
            dateTimePicker2.Value = convertCitation.AccessDate;
            lblPublishDateWarning.Show();
            lblTitleWarning.Show();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            controller.PasteRegularHarvardCitation(txtConvertCitation);
        }

        private void btnClearCitation_Click(object sender, EventArgs e)
        {
            txtConvertCitation.Clear();
            txtAuthorNoFormatting.Clear();
            txtAuthorNeedsFormatting.Clear();
            txtTitle.Clear();
            txtWebsiteName.Clear();
            txtLink.Clear();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            lblPublishDateWarning.Hide();
            lblTitleWarning.Hide();
            lblAuthorWarning.Hide();
        }

        private void btnCreateCitiation_Click(object sender, EventArgs e)
        {
            //Clear
            controller.ResetCopyButtons(btnCopyInText, btnCopyReference);
            rtxtInText.Clear();
            rtxtReference.Clear();

            if (txtAuthorNoFormatting.Text == "" && txtAuthorNeedsFormatting.Text == "")
            {
                MessageBox.Show("Nothing was entered for the author");
                return;
            }
            else if (txtAuthorNoFormatting.Text == "" && txtAuthorNeedsFormatting.Text != "")
            {
                authorNameNeedFormatting = true;
                if(controller.NameValidation(txtAuthorNeedsFormatting.Text) == false)
                {
                    return;
                }
                author = txtAuthorNeedsFormatting.Text;
            }
            else if (txtAuthorNoFormatting.Text != "" && txtAuthorNeedsFormatting.Text == "")
            {
                authorNameNeedFormatting = false;
                author = txtAuthorNoFormatting.Text;
            }
            else // both aren't empty
            {
                MessageBox.Show($"Only 1 author textbox can have text.{Environment.NewLine}Choose if you want the author's name formatted or not changed at all");
                return;
            }
            websiteName = txtWebsiteName.Text;
            title = txtTitle.Text;
            url = txtLink.Text;
            publishDate = dateTimePicker1.Value;
            accessDate = dateTimePicker2.Value;

            blog = new Blog(author, websiteName, title, url, publishDate, accessDate);
            rtxtReference.Text = blog.CreateCitation(authorNameNeedFormatting);
            rtxtInText.Text = blog.CreateInText(authorNameNeedFormatting);
        }

        private void btnCopyReference_Click(object sender, EventArgs e)
        {
            controller.Copy(rtxtReference, btnCopyReference);
        }

        private void btnCopyInText_Click(object sender, EventArgs e)
        {
            controller.Copy(rtxtInText, btnCopyInText);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblPublishDateWarning.Hide();
        }

        private void dateTimePicker1_Validated(object sender, EventArgs e)
        {
        }
    }
}
