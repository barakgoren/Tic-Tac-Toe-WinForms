using NewTicTacToe.Comps;
using System.Diagnostics;
using System.Drawing.Design;
using System.Windows.Forms;

namespace NewTicTacToe
{
    public partial class Form1 : Form
    {
        UserInput inputPlayerOne;
        UserInput inputPlayerTwo;
        public Form1()
        {
            InitializeComponent();
            inputPlayerOne = new UserInput(240, 320, "Player 1");
            inputPlayerTwo = new UserInput(240, 600, "Player 2");
            inputPlayerOne.button1.Click += colorChoosing;
            inputPlayerTwo.button1.Click += colorChoosing;
            this.Controls.Add(inputPlayerOne);
            this.Controls.Add(inputPlayerTwo);
        }

        private void colorChoosing(object sender, EventArgs e)
        {
            UserInput currentInput = null;
            if (sender.GetType() == typeof(Button))
            {
                Button button = (Button)sender;
                currentInput = (UserInput)button.Tag;
            }
            if (inputPlayerOne.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the selected color
                Color selectedColor = inputPlayerOne.colorDialog1.Color;

                if (currentInput != null)
                {
                    currentInput.BackColor = selectedColor;
                }

            }
        }
    }
}