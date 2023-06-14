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
    public partial class FormBook : Form
    {
        UIController controller = new UIController();
        PhysicalBook book;
        TextBoxAdder textBoxAdder;

        private string[] authors;

        public FormBook()
        {
            InitializeComponent();
            textBoxAdder = new TextBoxAdder(90, 100, 1, panelAuthors);

            rtxtReference.Font = controller.NormalFont;
            rtxtInText1.Font = controller.NormalFont;
            rtxtInText2.Font = controller.NormalFont;

            panelCitation.Visible = false;

        }

        private void btnCreateCitation_Click(object sender, EventArgs e)
        {
            // Clear
            controller.ResetCopyButtons(btnCopyReference, btnCopyInText2, btnCopyInText1);
            rtxtReference.Clear();
            rtxtInText1.Clear();
            rtxtInText2.Clear();

            // Get Info
            int year = controller.YearValidation(txtYear);
            string title = txtTitle.Text;
            int edition = (int)numericUpDown2.Value;
            string publicationPlace = txtPublicationPlace.Text;
            string publisher = txtPublisher.Text;
            authors = new string[textBoxAdder.TextBoxes.Count];
            authors = textBoxAdder.TextBoxValues;
            book = new PhysicalBook(year, title, edition, publicationPlace, publisher, authors);

            // Add reference
            controller.WriteFormattedText(rtxtReference, book.BeforeItalics, book.Italics, book.AfterItalics);
            if (edition != 1)
                book.ToSuperscript(rtxtReference, book.GetOrdinalIndex(rtxtReference.Text));

            // In-Text Paraphrased
            rtxtInText1.Text = book.CreateInText(false);
            rtxtInText2.Text = book.CreateInText(true);

            // In-Text Quoted


            panelCitation.Visible = true;
        }

        

        private void btnCopyReference_Click(object sender, EventArgs e)
        {
            controller.Copy(rtxtReference, btnCopyReference);
        }

        private void btnCopyInText1_Click(object sender, EventArgs e)
        {
            controller.Copy(rtxtInText1, btnCopyInText1);
        }

        private void btnCopyInText2_Click(object sender, EventArgs e)
        {
            controller.Copy(rtxtInText2, btnCopyInText2);
        }

        private void NumOfAuthorSelector_ValueChanged(object sender, EventArgs e)
        {
            if (NumOfAuthorSelector.Value > textBoxAdder.TextBoxes.Count)
            {
                textBoxAdder.AddTextbox();
            }
            else if (NumOfAuthorSelector.Value < textBoxAdder.TextBoxes.Count)
            {
                textBoxAdder.RemoveLastTextbox();
            }
        }

        private void txtYear_Validated(object sender, EventArgs e)
        {
            controller.YearValidation(txtYear);
        }
    }
}
