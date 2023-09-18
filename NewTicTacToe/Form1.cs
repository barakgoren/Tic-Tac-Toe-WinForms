using NewTicTacToe.Comps;
using System.Diagnostics;
using System.Windows.Forms;

namespace NewTicTacToe
{
    public partial class Form1 : Form
    {
        UserInput inputPlayerOne;
        public Form1()
        {
            InitializeComponent();
            inputPlayerOne = new UserInput();
            inputPlayerOne.button1.Click += button1_Click;
            this.Controls.Add(inputPlayerOne);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputPlayerOne.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the selected color
                Color selectedColor = inputPlayerOne.colorDialog1.Color;

                inputPlayerOne.button1.BackColor = selectedColor;
                inputPlayerOne.label1.ForeColor = selectedColor;
                inputPlayerOne.label3.ForeColor = selectedColor;
            }
        }
    }
}