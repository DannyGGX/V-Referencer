using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Referencer
{
    public class UIController
    {
        public FormMain formMain = new FormMain();
        public Form ActiveForm { get; set; } = new FormHome();

        public string TitleText { get; set; }

        SaveSettings save;

        public UIController(Form callingForm)
        {
            //TitleText = callingForm.
        }
        public UIController()
        {
            save = new SaveSettings();
            if(!save.SpecificSaveExists(0))
            {
                NormalFont = new Font(SaveSettings.DefaultFontName, SaveSettings.DefaultFontSize, FontStyle.Regular);
                ItalicFont = new Font(SaveSettings.DefaultFontName, SaveSettings.DefaultFontSize, FontStyle.Italic);
            }
            else
            {
                NormalFont = new Font(save.FontName, save.FontSize, FontStyle.Regular);
                ItalicFont = new Font(save.FontName, save.FontSize, FontStyle.Italic);
            }
        }

        private Button? PressedCopyButton;

        public Font NormalFont { get; set; } 
        public Font ItalicFont { get; set; }
        //public bool DefaultFontChanged { get; set; }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            formMain.OpenChildForm(childForm);
        }

        public void Copy(RichTextBox rtxt, Button btn)
        {
            CopyToCipboard(rtxt);
            ChangeCopyButtonStatus(btn);
        }
        private void CopyToCipboard(RichTextBox richTextBox)
        {
            richTextBox.SelectAll();
            richTextBox.Copy();
            richTextBox.DeselectAll();
        }
        private void ChangeCopyButtonStatus(Button button)
        {
            button.Text = "Copied";
            button.BackColor = Color.Green;
            button.ForeColor = Color.White;
            if (PressedCopyButton != null && PressedCopyButton != button)
            {
                ResetCopyButton(PressedCopyButton); // Reset previous copy button in "Copied" state. Only 1 button can be in "Copied" state at a time
            }
            PressedCopyButton = button;
        }
        private void ResetCopyButton(Button button)
        {
            button.Text = "Copy";
            button.BackColor = SystemColors.ScrollBar;
            button.ForeColor = Color.Black;
        }
        public void ResetCopyButtons(params Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                ResetCopyButton(button);
            }
            PressedCopyButton = null;
        }

        public void PasteRegularHarvardCitation(TextBox txt)
        {
            txt.Clear();
            txt.Paste();
            bool hasLines = true;
            do
            {
                if(txt.Text.Contains("\n") || txt.Text.Contains("\r"))
                {
                    txt.Text = txt.Text.Remove(txt.Text.Length - 1); // to remove the excess lines ("\r\n") so that all of the text can be seen
                }
                else hasLines = false;
            } while (hasLines);
        }

        public void WriteItalics(RichTextBox rtxt, string italicsText)
        {
            WriteRichText(rtxt, italicsText, true);
        }
        public void WriteNormalText(RichTextBox rtxt, string text)
        {
            WriteRichText(rtxt, text, false);
        }
        private void WriteRichText(RichTextBox rtxt, string text, bool isItalic)
        {
            rtxt.AppendText(text); // rtxt.Text += text; // += breaks the font and resets it
            rtxt.Select(rtxt.TextLength - text.Length, text.Length);
            if (isItalic)
            {
                rtxt.SelectionFont = ItalicFont;
                //rtxt.SelectionColor = Color.Orange; // for debugging
            }
            else
            {
                rtxt.SelectionFont = NormalFont;
                //rtxt.SelectionColor = Color.Green; // for debugging
            }
            rtxt.DeselectAll();
        }
        public void WriteFormattedText(RichTextBox rtxt, string beforeItalics, string italics, string afterItalics)
        {
            WriteNormalText(rtxt, beforeItalics);
            WriteItalics(rtxt, italics);
            WriteNormalText(rtxt, afterItalics);
        }

        public int YearValidation(TextBox txt) // also returns the year
        {
            if (txt.TextLength != 4)
            {
                MessageBox.Show("Year is not 4 digits long");
                return DateTime.Today.Year; // Maybe change this
            }
            if (!int.TryParse(txt.Text, out int year))
            {
                MessageBox.Show("the value for Year is not a number");
            }
            else if (year > DateTime.Today.Year)
            {
                MessageBox.Show("The year entered is greater than the current year");
            }
            else
            {
                return year;
            }
            return DateTime.Today.Year; // Maybe change this
        }
        public bool NameValidation(string name)
        {
            bool isWrong = false;
            try
            {
                if(Char.IsUpper(name[0]) == false)
                {
                    isWrong = true;
                }
                if(name.Contains(' ') == false)
                {
                    isWrong = true;
                }

                if(isWrong)
                {
                    MessageBox.Show($"Invalid format of person's name");
                }
                return !isWrong;
            }
            catch
            {
                MessageBox.Show("Invalid format of person's name");
            }
            return false;
        }

        // Copy of this method in Citation
        public string EnumNameToString(Enum enumName) // puts spaces after capital letters
        {
            string enumStr = enumName.ToString();
            string manipulatedStr = enumStr;
            int changes = 0;
            for (int index = 1; index < enumStr.Length; index++) // index = 1 because no space before first letter
            {
                if (Char.IsUpper(enumStr[index]))
                {
                    manipulatedStr = manipulatedStr.Insert(index + changes, " ");
                    changes++;
                }
            }
            return manipulatedStr;
        }

        // TODO:
        // Dynamically change richtextbox height according to number of text lines
        // Stop scroll getting caught up on rich textboxes
    }
}
