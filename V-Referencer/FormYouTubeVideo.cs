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
    public partial class FormYouTubeVideo : Form
    {
        private string name;
        private string title;
        private DateTime date = DateTime.Today;

        private YouTubeVideo videoReference;
        private UIController controller = new UIController();

        public FormYouTubeVideo()
        {
            InitializeComponent();
            dateTimePicker1.Visible = false;

            rtxtReference.Font = controller.NormalFont;
            rtxtInText.Font = controller.NormalFont;

            FormMain main = (FormMain)Application.OpenForms["FormMain"];
            main.TitleText = "YouTube Video";
        }

        private void btnCreateReference_Click(object sender, EventArgs e)
        {
            // Clear all
            controller.ResetCopyButtons(btnCopyReference, btnCopyInText);
            rtxtReference.Clear();
            rtxtInText.Clear();

            videoReference = new YouTubeVideo(date, txtLink.Text);
            controller.WriteItalics(rtxtReference, videoReference.ItalicsText());
            controller.WriteNormalText(rtxtReference, videoReference.AfterItalicsText());

            rtxtInText.Text = videoReference.InText();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value;
        }

        private void btnCopyReference_Click(object sender, EventArgs e)
        {
            controller.Copy(rtxtReference, btnCopyReference);
        }

        private void btnCopyInText_Click(object sender, EventArgs e)
        {
            controller.Copy(rtxtInText, btnCopyInText);
        }

        private void btnClearLink_Click(object sender, EventArgs e)
        {
            txtLink.Clear();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtLink.Paste();
        }
    }
}
