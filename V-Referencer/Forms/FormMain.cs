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
    public partial class FormMain : Form
    {
        private Form activeForm = new FormHome();
        
        public FormMain()
        {
            InitializeComponent();
            //UIController controller = new UIController();
            //controller.ActiveForm = activeForm;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FormHome());
        }

        public void OpenChildForm(Form childForm)
        {
            activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.ShowInTaskbar = false;
            childForm.Dock = DockStyle.Fill;
            this.panelFormContainer.Controls.Add(childForm);
            this.panelFormContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            TitleText = childForm.Text;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHome());
        }

        private void btnReferenceList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormReferencingList());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSettings());
        }

        private void btnReportError_Click(object sender, EventArgs e)
        {
            Survey survey = new Survey();
        }

        public string TitleText
        {
            set { lblTitle.Text = value; }
        }
        public string Version { get { return lblVersion.Text; } }

    }
}