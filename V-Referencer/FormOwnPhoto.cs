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
    public partial class FormOwnPhoto : Form
    {
        private string name;
        private string title;
        private int year = DateTime.Today.Year;

        private OwnPhoto ownPhoto;
        private UIController controller;
        private SaveSettings save;

        public FormOwnPhoto()
        {
            InitializeComponent();
            controller = new UIController();
            save = new SaveSettings();
        }

        private void FormOwnPhoto_Load(object sender, EventArgs e)
        {
            txtYear.Text = year.ToString();
            groupBoxCitation.Visible = false;

            rtxtFigure.Font          = controller.NormalFont;
            rtxtListOfFigures.Font   = controller.NormalFont;
            rtxtReference.Font       = controller.NormalFont;
            rtxtInTextReference.Font = controller.NormalFont;
            rtxtInTextStart.Font = controller.NormalFont;

            checkBoxFigureNum.Checked = true;

            if(save.SpecificSaveExists((int)SaveSettings.Data.Username))
            {
                txtYourName.Text = save.Username;
            }
            if (save.SpecificSaveExists((int)SaveSettings.Data.FigureNum))
            {
                numericSelectFigure.Value = save.FigureNum;
            }
        }

        private void btnCreateCitation_Click(object sender, EventArgs e)
        {
            // Clear
            controller.ResetCopyButtons(btnCopyFigure, btnCopyInText, btnCopyReference, btnCopyListOfFigures);
            rtxtFigure.Clear();
            rtxtListOfFigures.Clear();
            rtxtReference.Clear();
            rtxtInTextReference.Clear();
            rtxtInTextStart.Clear();

            name = txtYourName.Text;
            title = rtxtReferenceTitle.Text;
            year = int.Parse(txtYear.Text);
            if (!controller.NameValidation(name))
            {
                return;
            }
            ownPhoto = new OwnPhoto(name, title, year);

            groupBoxCitation.Visible = true;
            numericSelectFigure.Visible = checkBoxFigureNum.Checked;

            // Figure
            if (checkBoxFigureNum.Checked)
            {
                ownPhoto.CreateFigure((int)numericSelectFigure.Value);
                controller.WriteFormattedText(rtxtFigure, ownPhoto.figureText.BeforeItalics, ownPhoto.figureText.Italics, ownPhoto.figureText.AfterItalics);
            }
            else
            {
                ownPhoto.CreateFigure();
                controller.WriteFormattedText(rtxtFigure, "", ownPhoto.figureText.Italics, ownPhoto.figureText.AfterItalics);
            }

            // List of Figures entry
            if (checkBoxFigureNum.Checked)
            {
                ownPhoto.CreateFigure((int)numericSelectFigure.Value);
                controller.WriteFormattedText(rtxtListOfFigures, ownPhoto.figureText.BeforeItalics, ownPhoto.figureText.Italics, ownPhoto.figureText.AfterItalics);
            }
            else
            {
                ownPhoto.CreateFigure();
                controller.WriteFormattedText(rtxtListOfFigures, ownPhoto.figureText.BeforeItalics, ownPhoto.figureText.Italics, ownPhoto.figureText.AfterItalics);
            }

            // Reference
            ownPhoto.CreateReference();
            controller.WriteFormattedText(rtxtReference, ownPhoto.referenceText.BeforeItalics, ownPhoto.referenceText.Italics, ownPhoto.referenceText.AfterItalics);

            // In-text
            rtxtInTextReference.Text = ownPhoto.InTextPersonSentenceEnd;
            rtxtInTextStart.Text = ownPhoto.InTextPersonSentenceStart;
        }

        private void checkBoxFigureNum_CheckedChanged(object sender, EventArgs e)
        {
            numericSelectFigure.Visible = checkBoxFigureNum.Checked;
            btnSaveFigureNum.Visible = checkBoxFigureNum.Checked;
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

        private void txtYear_Validated(object sender, EventArgs e)
        {
            year = controller.YearValidation(txtYear);
        }

        private void btnSaveName_Click(object sender, EventArgs e)
        {
            if (controller.NameValidation(name))
                save.SaveName(name);
        }

        private void txtYourName_TextChanged(object sender, EventArgs e)
        {
            name = txtYourName.Text;
        }

        private void btnSaveFigureNum_Click(object sender, EventArgs e)
        {
            save.SaveFigureNum((int)numericSelectFigure.Value);
        }

        private void btnCopyInTextStart_Click(object sender, EventArgs e)
        {
            controller.Copy(rtxtInTextStart, btnCopyInTextStart);
        }
    }
}
