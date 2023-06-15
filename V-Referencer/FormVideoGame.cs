using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_Referencer
{
    public partial class FormVideoGame : Form
    {
        VideoGame videoGame;
        UIController controller;

        public FormVideoGame()
        {
            InitializeComponent();

            controller = new UIController();
            rtxtInText.Font = controller.NormalFont;
            rtxtInTextStart.Font = controller.NormalFont;

            for(int i = 0; i < Enum.GetValues(typeof(VideoGame.Websites)).Length; i++)
            {
                cmbWebsiteChoices.Items.Add(controller.EnumNameToString((VideoGame.Websites)i));
            }
            cmbWebsiteChoices.SelectedIndex = 0;

            for(int j = 0; j < VideoGame.Platforms.Length; j++)
            {
                cmbPlatform.Items.Add(VideoGame.Platforms[j]);
            }

            cmbGameType.SelectedIndex = 0;

            panelCitation.Visible = false;
        }

        private void btnScrapeWebsite_Click(object sender, EventArgs e)
        {
            string url = txtLink.Text;
            int websiteChoice = cmbWebsiteChoices.SelectedIndex;
            switch(websiteChoice)
            {
                case 0:
                    videoGame = new SteamVideoGame(url);
                    break;
                
            }
            txtTitle.Text = videoGame.Title;
            txtDevName.Text = videoGame.Name;
            txtPublisher.Text = videoGame.Publisher;
            txtYear.Text = videoGame.PublishYear.ToString();
            cmbPlatform.SelectedIndex = 0;
        }

        private void btnCreateCitation_Click(object sender, EventArgs e)
        {
            //Clear
            controller.ResetCopyButtons(btnCopyInText, btnCopyReference);
            rtxtInText.Clear();
            rtxtInTextStart.Clear();
            rtxtReference.Clear();

            CreateCitation(videoGame);
            panelCitation.Visible = true;
        }

        private void CreateCitation(VideoGame videoGame)
        {
            videoGame.Title = txtTitle.Text;
            videoGame.Name = txtDevName.Text;
            videoGame.Publisher = txtPublisher.Text;
            videoGame.PublishCity = txtPublishCity.Text;
            videoGame.Platform = VideoGame.Platforms[cmbPlatform.SelectedIndex];
            videoGame.PublishYear = controller.YearValidation(txtYear);

            videoGame.CreateCitation();
            controller.WriteFormattedText(rtxtReference, videoGame.BeforeItalics, videoGame.Italics, videoGame.AfterItalics);
            rtxtInText.Text = videoGame.InTextNoSurnameSentenceEnd;
            rtxtInTextStart.Text = videoGame.InTextNoSurnameSentenceStart;
        }

        private void btnFindCity_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult1 = MessageBox.Show("Search on chrome?", "Confirmation", MessageBoxButtons.OKCancel);
            try
            {
                if (dialogResult1 == DialogResult.OK)
                {
                    Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", CreateGoogleSearch(txtPublisher.Text));
                }
            }
            catch
            {
                DialogResult dialogResult2 = MessageBox.Show($"Could not find chrome.exe{Environment.NewLine}Would you like to have the link copied?", "Error", MessageBoxButtons.OKCancel);
                if (dialogResult2 == DialogResult.OK)
                {
                    Clipboard.SetText(CreateGoogleSearch(txtPublisher.Text));
                    MessageBox.Show("Link has been copied");
                }
            }
        }

        private string CreateGoogleSearch(string subjectToFind)
        {
            string search = "https://www.google.com/search?q=where+is+";
            subjectToFind = subjectToFind.Replace(" ", "+");
            subjectToFind = subjectToFind.ToLower();
            search += $"{subjectToFind}+located";
            return search;
        }

        private void btnClearLink_Click(object sender, EventArgs e)
        {
            txtLink.Clear();

            txtTitle.Clear();
            txtPublisher.Clear();
            txtPublishCity.Clear();
            txtDevName.Clear();
            txtYear.Clear();
        }

        private void btnCopyReference_Click(object sender, EventArgs e)
        {
            controller.Copy(rtxtReference, btnCopyReference);
        }

        private void btnCopyInText_Click(object sender, EventArgs e)
        {
            controller.Copy(rtxtInText, btnCopyInText);
        }

        private void btnInTextStart_Click(object sender, EventArgs e)
        {
            controller.Copy(rtxtInTextStart, btnInTextStart);
        }
    }
}
