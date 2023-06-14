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
    public partial class FormOnlineImage : Form
    {
        int publishYear;
        string publishYearStr; // for s.a. if year unavailable
        int websiteYear;
        string publisherName;
        string websiteName;
        string title;
        string url;
        DateTime accessDate;
        bool hasArtist;

        private OnlineImage image;
        private UIController controller;
        private SaveSettings save;


        public FormOnlineImage()
        {
            InitializeComponent();
            controller = new UIController();
            save = new SaveSettings();

            if (save.SpecificSaveExists((int)SaveSettings.Data.FigureNum))
            {
                numericSelectFigure.Value = save.FigureNum;
            }

            checkBoxFigureNum.Checked = true;
            groupBoxCitation.Visible = false;
        }

        private void btnConvertHarvard_Click(object sender, EventArgs e)
        {
            ConvertCitation convertCitation = new ConvertCitation(txtConvertCitation.Text);
            txtWebsiteName.Text = convertCitation.Name;
            txtTitle.Text = convertCitation.Title;
            txtLink.Text = convertCitation.Url;
            txtPublishYear.Text = convertCitation.PublishYear.ToString();
            publishYear = convertCitation.PublishYear;
            dateTimePickAccessDate.Value = convertCitation.AccessDate;
            
        }

        private void btnCreateCitation_Click(object sender, EventArgs e)
        {
            // Clear
            controller.ResetCopyButtons(btnCopyFigure, btnCopyListOfFigures, btnCopyReference, btnCopyInText);
            rtxtFigure.Clear();
            rtxtListOfFigures.Clear();
            rtxtReference.Clear();
            rtxtInTextReference.Clear();

            websiteName = txtWebsiteName.Text;
            title = txtTitle.Text;
            url = txtLink.Text;
            accessDate = dateTimePickAccessDate.Value;

            if (checkBoxNoDate.Checked)
            {
                publishYearStr = "s.a.";
            }
            else
            {
                publishYearStr = publishYear.ToString();
            }
            if(txtPublisher.Text == "" && checkBoxNoArtist.Checked == false)
            {
                MessageBox.Show("Type an Artist's name if it is available, else check \"Unavailable\"");
                return;
            }
            if (txtWebsiteYear.Text == "")
            {
                MessageBox.Show("No website year was given");
                return;
            }
            if (checkBoxNoArtist.Checked)
            {
                image = new OnlineImage(title, publishYearStr, websiteName, url, accessDate, websiteYear);
                hasArtist = false;
            }
            else
            {
                publisherName = txtPublisher.Text;
                image = new OnlineImage(publisherName, title, publishYearStr, websiteName, url, accessDate, websiteYear);
                hasArtist = true;
            }

            

            // Caption
            if (checkBoxFigureNum.Checked)
            {
                image.CreateCaption(hasArtist, (int)numericSelectFigure.Value);
                WriteFormattedText(rtxtFigure, image.captionText.BeforeItalics, image.captionText.Italics, image.captionText.AfterItalics);
            }
            else
            {
                image.CreateCaption(hasArtist);
                WriteFormattedText(rtxtFigure, "", image.captionText.Italics, image.captionText.AfterItalics);
            }

            // List of Figures entry
            if (checkBoxFigureNum.Checked)
            {
                image.CreateFigure(hasArtist, (int)numericSelectFigure.Value);
                WriteFormattedText(rtxtListOfFigures, image.figureText.BeforeItalics, image.figureText.Italics, image.figureText.AfterItalics);
            }
            else
            {
                image.CreateFigure(hasArtist);
                WriteFormattedText(rtxtListOfFigures, image.figureText.BeforeItalics, image.figureText.Italics, image.figureText.AfterItalics);
            }

            // Reference
            image.CreateReference();
            WriteFormattedText(rtxtReference, image.referenceText.BeforeItalics, image.referenceText.Italics, image.referenceText.AfterItalics);

            // In-text
            image.CreateInText();
            controller.WriteFormattedText(rtxtInTextReference, image.inText.BeforeItalics, image.inText.Italics, " ");

            groupBoxCitation.Visible = true;
        }
        private void WriteFormattedText(RichTextBox rtxt, string beforeItalics, string italics, string afterItalics)
        {
            controller.WriteNormalText(rtxt, beforeItalics);
            controller.WriteItalics(rtxt, italics);
            controller.WriteNormalText(rtxt, afterItalics);
        }

        private void checkBoxNoDate_CheckedChanged(object sender, EventArgs e)
        {
            txtPublishYear.Visible = !checkBoxNoDate.Checked;
        }

        private void btnCopyFigure_Click(object sender, EventArgs e)
        {
            controller.Copy(rtxtFigure, btnCopyFigure);
        }

        private void btnCopyListOfFigures_Click(object sender, EventArgs e)
        {
            controller.Copy(rtxtListOfFigures, btnCopyListOfFigures);
        }

        private void btnCopyReference_Click(object sender, EventArgs e)
        {
            controller.Copy(rtxtReference, btnCopyReference);
        }

        private void btnCopyInText_Click(object sender, EventArgs e)
        {
            controller.Copy(rtxtInTextReference, btnCopyInText);
        }


        private void checkBoxFigureNum_CheckedChanged(object sender, EventArgs e)
        {
            numericSelectFigure.Visible = checkBoxFigureNum.Checked;
            btnSaveFigureNum.Visible = checkBoxFigureNum.Checked;
        }

        private void txtPublishYear_Validated(object sender, EventArgs e)
        {
            publishYear = controller.YearValidation(txtPublishYear);
        }

        private void checkBoxNoArtist_CheckedChanged(object sender, EventArgs e)
        {
            txtPublisher.Visible = !checkBoxNoArtist.Checked;
        }

        private void txtWebsiteYear_Validated(object sender, EventArgs e)
        {
            websiteYear = controller.YearValidation(txtWebsiteYear);
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            controller.PasteRegularHarvardCitation(txtConvertCitation);
        }

        private void btnClearCitation_Click(object sender, EventArgs e)
        {
            txtConvertCitation.Clear();
            txtPublisher.Clear();
            txtTitle.Clear();
            txtWebsiteName.Clear();
            txtPublishYear.Clear();
            txtWebsiteYear.Clear();
            txtLink.Clear();
            dateTimePickAccessDate.Value = DateTime.Today;
            checkBoxNoArtist.Checked = false;
            checkBoxNoDate.Checked = false;
            checkBoxThisYear.Checked = false;
        }

        private void checkBoxThisYear_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxThisYear.Checked == true)
            {
                txtWebsiteYear.Text = DateTime.Today.Year.ToString();
                websiteYear = DateTime.Today.Year;
            }
            else
            {
                txtWebsiteYear.Clear();
                websiteYear = 0;
            }
        }


        private void btnSaveFigureNum_Click(object sender, EventArgs e)
        {
            save.SaveFigureNum((int)numericSelectFigure.Value);
        }

        
    }
}
