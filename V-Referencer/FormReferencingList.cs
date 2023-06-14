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
    public partial class FormReferencingList : Form
    {
        public FormReferencingList()
        {
            InitializeComponent();
        }

        private void FormReferencingList_Load(object sender, EventArgs e)
        {

        }
        public void OpenChildForm(Form childForm, object btnSender)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.ShowInTaskbar = false;
            childForm.Dock = DockStyle.Fill;
            this.panelFormContainer.Controls.Add(childForm);
            this.panelFormContainer.Tag = childForm;

            FormMain main = (FormMain)Application.OpenForms["FormMain"];
            main.TitleText = childForm.Text;

            //Hide everything on top of the Form container
            panelBooks.Hide();
            panelImages.Hide();
            panelOnlineSource.Hide();
            panelOther.Hide();
            btnOnlineSource.Hide();
            btnBooks.Hide();
            btnImages.Hide();
            btnOther.Hide();

            childForm.BringToFront();
            childForm.Show();
            this.AutoScrollPosition = new Point(0, 0); // to scroll up to the top of the form
        }

        private void btnOwnPhoto_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormOwnPhoto(), sender);
        }

        private void btnYouTubeVideo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormYouTubeVideo(), sender);
        }

        private void btnWebsite_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormWebsite(), sender);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBook(), sender);
        }

        private void btnBlog_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBlog(), sender);
        }

        private void btnOnlineImage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormOnlineImage(), sender);
        }

        private void btnSoundOnline_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormOnlineSound(), sender);
        }

        private void btnOwnDrawing_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormOwnDrawing(), sender);
        }

        private void btnVideoGame_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormVideoGame(), sender);
        }
    }
}
