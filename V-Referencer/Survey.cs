using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace V_Referencer
{
    public class Survey
    {
        private string SurveyUrl = "https://docs.google.com/forms/d/e/1FAIpQLSfY2psJOj8XqJIeUJB9ejClqMGDpN4rRpYrxTPUILJo7YdACg/viewform?usp=sf_link";
        public Survey()
        {
            ShowConfirmation();
        }

        private void ShowConfirmation()
        {
            DialogResult dialogResult1 = MessageBox.Show("Open survey in your browser?", "Confirmation", MessageBoxButtons.OKCancel);
            try
            {
                if(dialogResult1 == DialogResult.OK)
                {
                    Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", SurveyUrl);
                }
            }
            catch
            {
                DialogResult dialogResult2 = MessageBox.Show($"Could not find chrome.exe{Environment.NewLine}Would you like to have the survey link copied?", "Error", MessageBoxButtons.OKCancel);
                if(dialogResult2 == DialogResult.OK)
                {
                    Clipboard.SetText(SurveyUrl);
                    MessageBox.Show("Survey link has been copied");
                }
            }
        }
    }
}
