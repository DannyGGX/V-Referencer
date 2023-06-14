using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Referencer
{
    public class TextBoxAdder
    {
        private const int TextBoxWidth = 400;
        private const int TextBoxLength = 39; // TODO: take into account the font size or find an autosize property

        private const int SpacingBetweenTextboxes = 8;

        public int StartingXPos { get; }
        public int StartingYPos { get; }
        public int AmountControlsBeforeTextBoxes { get; }

        public List<TextBox> TextBoxes { get; set; }

        public Panel panelForEditting { get; }

        public TextBoxAdder(int startingXPos, int startingYPos, int amountControlsBeforeTextBoxes, Panel panelForEditting)
        {
            StartingXPos = startingXPos;
            StartingYPos = startingYPos;
            AmountControlsBeforeTextBoxes = amountControlsBeforeTextBoxes;
            this.panelForEditting = panelForEditting;

            AddFirstTextBox();
        }

        public string[] TextBoxValues
        {
            get
            {
                return GetTextboxValues();
            }
            set
            {

            }
        }

        public void AddFirstTextBox()
        {
            TextBoxes = new List<TextBox>();
            panelForEditting.AutoSize = true;
            PlaceTextbox(StartingXPos, StartingYPos);
        }

        private void PlaceTextbox(int xPos, int yPos)
        {
            TextBox thisTextBox = new TextBox();
            thisTextBox.Location = new System.Drawing.Point(xPos, yPos);
            thisTextBox.Size = new System.Drawing.Size(TextBoxWidth, TextBoxLength);
            thisTextBox.TabIndex = AmountControlsBeforeTextBoxes + TextBoxes.Count + 1;
            thisTextBox.PlaceholderText = "Name Surname";
            panelForEditting.Controls.Add(thisTextBox);
            TextBoxes.Add(thisTextBox);
        }
        public void AddTextbox()
        {
            int yPos = StartingYPos + ((TextBoxLength + SpacingBetweenTextboxes) * TextBoxes.Count);
            PlaceTextbox(StartingXPos, yPos);
        }
        public virtual void RemoveLastTextbox()
        {
            panelForEditting.Controls.Remove(TextBoxes[TextBoxes.Count - 1]);
            TextBoxes.RemoveAt(TextBoxes.Count - 1);

        }

        public string[] GetTextboxValues()
        {
            string[] values = new string[TextBoxes.Count];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = TextBoxes[i].Text;
            }
            return values;
        }

        //public void SetTextboxValues(string[] values)
        //{

        //}

    }
}
