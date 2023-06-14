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
    public partial class FormOwnDrawing : Form
    {
        string name, title;
        int year = DateTime.Today.Year;

        private OwnDrawing drawing;
        private UIController controller;
        private SaveSettings save;

        public FormOwnDrawing()
        {
            InitializeComponent();

            controller = new UIController();
            save = new SaveSettings();

            txtYear.Text = year.ToString();
            rtxtFigure.Font =           controller.NormalFont;
            rtxtListOfFigures.Font =    controller.NormalFont;
            rtxtReference.Font =        controller.NormalFont;
            rtxtInTextReference.Font =  controller.NormalFont;
            checkBoxFigureNum.Checked = true;

            if (save.SpecificSaveExists((int)SaveSettings.Data.Username))
            {
                txtYourName.Text = save.Username;
            }
            if (save.SpecificSaveExists((int)SaveSettings.Data.FigureNum))
            {
                numericSelectFigure.Value = save.FigureNum;
            }

            for (int i = 0; i < OwnDrawing.NumberOfPlaces; i++)
            {
                cmbPlaces.Items.Add(controller.EnumNameToString((OwnDrawing.Places)i));
            }
            cmbPlaces.SelectedIndex = 0;
            groupBoxCitation.Visible = false;
        }

        private void btnSaveName_Click(object sender, EventArgs e)
        {
            if (controller.NameValidation(txtYourName.Text))
                save.SaveName(txtYourName.Text);
        }

        private void btnCreateCitation_Click(object sender, EventArgs e)
        {
            // Clear
            controller.ResetCopyButtons(btnCopyFigure, btnCopyInText, btnCopyReference, btnCopyListOfFigures);
            rtxtFigure.Clear();
            rtxtListOfFigures.Clear();
            rtxtReference.Clear();

            name = txtYourName.Text;
            title = rtxtReferenceTitle.Text;
            year = int.Parse(txtYear.Text);
            int placeIndex = cmbPlaces.SelectedIndex;

            if (!controller.NameValidation(name))
            {
                return;
            }
            drawing = new OwnDrawing(title, name, year, placeIndex);

            // Figure (caption)
            if (checkBoxFigureNum.Checked)
            {
                drawing.CreateFigure((int)numericSelectFigure.Value);
                controller.WriteFormattedText(rtxtFigure, drawing.figureText.BeforeItalics, drawing.figureText.Italics, drawing.figureText.AfterItalics);
            }
            else
            {
                drawing.CreateFigure();
                controller.WriteFormattedText(rtxtFigure, "", drawing.figureText.Italics, drawing.figureText.AfterItalics);
            }

            // List of Figures entry
            if (checkBoxFigureNum.Checked)
            {
                drawing.CreateFigure((int)numericSelectFigure.Value);
                controller.WriteFormattedText(rtxtListOfFigures, drawing.figureText.BeforeItalics, drawing.figureText.Italics, drawing.figureText.AfterItalics);
            }
            else
            {
                drawing.CreateFigure();
                controller.WriteFormattedText(rtxtListOfFigures, "", drawing.figureText.Italics, drawing.figureText.AfterItalics);
            }

            // Reference
            drawing.CreateReference();
            rtxtReference.Text = drawing.BeforeItalics;

            // In-text
            rtxtInTextReference.Text = drawing.InTextPerson;

            groupBoxCitation.Visible = true;
        }

        private void checkBoxFigureNum_CheckedChanged(object sender, EventArgs e)
        {
            numericSelectFigure.Visible = checkBoxFigureNum.Checked;
            btnSaveFigureNum.Visible = checkBoxFigureNum.Checked;
        }


        private void btnSaveFigureNum_Click(object sender, EventArgs e)
        {
            save.SaveFigureNum((int)numericSelectFigure.Value);
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
            controller.YearValidation(txtYear);
        }

    }
}
