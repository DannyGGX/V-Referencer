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
    public partial class FormWebsite : Form
    {
        string name;
        string title;
        DateTime publishDate;
        int publishYear;
        string url;
        DateTime accessDate;

        private Website website;
        private UIController controller;
        public FormWebsite()
        {
            InitializeComponent();
            controller = new UIController();
            lblYear.Visible = false;
            txtYear.Visible = false;
            panelCitation.Visible = false;

            rtxtReference.Font = controller.NormalFont;
            rtxtInText.Font = controller.NormalFont;

            lblTitleWarning.Hide();
        }

        private void checkNoDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = !checkNoDate.Checked;
            lblYear.Visible = checkNoDate.Checked;
            txtYear.Visible = checkNoDate.Checked;
        }

        private void btnCreateCitiation_Click(object sender, EventArgs e)
        {
            //Clear
            controller.ResetCopyButtons(btnCopyInText, btnCopyReference);
            rtxtReference.Clear();
            rtxtInText.Clear();

            name = txtWebsiteName.Text;
            title = txtArticleTitle.Text;
            url = txtLink.Text;
            accessDate = dateTimePicker2.Value;
            if (checkNoDate.Checked)
            {
                publishYear = int.Parse(txtYear.Text);
                website = new Website(name, title, publishYear, url, accessDate);
            }
            else
            {
                publishDate = dateTimePicker1.Value;
                website = new Website(name, title, publishDate, url, accessDate);
            }

            rtxtReference.Text = website.CreateCitation(!checkNoDate.Checked);
            rtxtInText.Text = website.CreateInText();

            panelCitation.Visible = true;
        }

        private void txtYear_Validated(object sender, EventArgs e)
        {
            if(txtYear.TextLength != 4)
            {
                MessageBox.Show("Year is not 4 digits long");
                return;
            }
            if (!int.TryParse(txtYear.Text, out int year))
            {
                MessageBox.Show("the value for Year is not a number");
                return;
            }
        }

        private void btnCopyReference_Click(object sender, EventArgs e)
        {
            controller.Copy(rtxtReference, btnCopyReference);
        }

        private void btnCopyInText_Click(object sender, EventArgs e)
        {
            controller.Copy(rtxtInText, btnCopyInText);
        }

        private void rtxtConvertCitation_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConvertHarvard_Click(object sender, EventArgs e)
        {
            ConvertCitation convertCitation = new ConvertCitation(txtConvertCitation.Text);
            txtWebsiteName.Text = convertCitation.WebsiteName;

            convertCitation.Title = convertCitation.ToSentenceCase(convertCitation.Title);
            txtArticleTitle.Text = convertCitation.Title;
            lblTitleWarning.Show();

            txtLink.Text = convertCitation.Url;

            checkNoDate.Checked = true;
            dateTimePicker1.Visible = false;
            lblYear.Visible = true;
            txtYear.Visible = true;
            txtYear.Text = convertCitation.PublishYear.ToString();
            dateTimePicker2.Value = convertCitation.AccessDate;
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            controller.PasteRegularHarvardCitation(txtConvertCitation);
        }

        private void btnClearCitation_Click(object sender, EventArgs e)
        {
            txtConvertCitation.Clear();
            txtWebsiteName.Clear();
            txtArticleTitle.Clear();
            txtYear.Clear();
            txtLink.Clear();
            dateTimePicker2.Value = DateTime.Today;
            checkNoDate.Checked = false;
            txtYear.Hide();
            dateTimePicker1.Show();
            lblTitleWarning.Hide();
        }
    }
}
