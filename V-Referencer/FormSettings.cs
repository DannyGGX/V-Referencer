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
    public partial class FormSettings : Form
    {
        UIController controller;
        FontDialog citationFontDialog;
        SaveSettings save;
        string fontName;
        float fontSize;
        private const string savePresentMessage = "Saved";
        private const string saveAbsentMessage = "No save";
        public FormSettings()
        {
            InitializeComponent();
            controller = new UIController();

            citationFontDialog = new FontDialog();
            citationFontDialog.ShowEffects = false;
            citationFontDialog.ShowColor = false;

            save = new SaveSettings();

            SetUIFont();
            SetSaveLabelStatus(lblSaveFont, SaveSettings.Data.FontName);
            numericFigureNum.Value = save.FigureNum;
            SetSaveLabelStatus(lblSaveFigureNum, SaveSettings.Data.FigureNum);
            cmbBrowserChoice.SelectedIndex = (int)save.BrowserChoice;
            SetSaveLabelStatus(lblSaveBrowser, SaveSettings.Data.BrowserChoice);
        }
        private void SetUIFont()
        {
            citationFontDialog.Font = controller.NormalFont;
            txtFontExample.Font = controller.NormalFont;
        }
        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            if (citationFontDialog.ShowDialog() == DialogResult.OK)
            {
                fontName = citationFontDialog.Font.Name;
                fontSize = citationFontDialog.Font.SizeInPoints;
                controller.NormalFont = new Font(fontName, fontSize, FontStyle.Regular);
                controller.ItalicFont = new Font(fontName, fontSize, FontStyle.Italic);
                SetUIFont();
                save.SaveCitationFont(fontName, fontSize);
                lblSaveFont.Text = savePresentMessage;
            }

        }
        private void btnSaveFont_Click(object sender, EventArgs e)
        {
            save.SaveCitationFont(fontName, fontSize);
        }
        private void btnDeleteSave_Click(object sender, EventArgs e)
        {
            save.DeleteSave();
            controller = new UIController();
            save = new SaveSettings();
            SetUIFont();
            lblSaveFont.Text = saveAbsentMessage;
            lblSaveFigureNum.Text = saveAbsentMessage;
            numericFigureNum.Value = save.FigureNum;
            cmbBrowserChoice.SelectedIndex = (int)save.BrowserChoice;
            lblSaveBrowser.Text = saveAbsentMessage;
        }

        private void btnSaveFigureNum_Click(object sender, EventArgs e)
        {
            save.SaveFigureNum((int)numericFigureNum.Value);
            lblSaveFigureNum.Text = savePresentMessage;
        }

        private void SetSaveLabelStatus(Label lbl, SaveSettings.Data specificSave)
        {
            if(save.SpecificSaveExists((int)specificSave))
            {
                lbl.Text = savePresentMessage;
            }
            else
            {
                lbl.Text = saveAbsentMessage;
            }
        }

        private void numericFigureNum_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numericFigureNum.Value == save.FigureNum)
            {
                lblSaveFigureNum.Text = savePresentMessage;
            }
            else
            {
                lblSaveFigureNum.Text = "Not saved";
            }
        }

        private void cmbBrowserChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            save.SaveBrowserChoice((Webscraper.BrowserChoices)cmbBrowserChoice.SelectedIndex);
            lblSaveBrowser.Text = savePresentMessage;
        }
    }
}
