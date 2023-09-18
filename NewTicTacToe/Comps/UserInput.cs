using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTicTacToe.Comps
{
    public class UserInput : Panel
    {
        public Label label1 {  get; set; }
        public TextBox textBox1 { get; set; }
        public Label label3 { get; set; }
        public ColorDialog colorDialog1 { get; set; }
        public Button button1 { get; set; }
        public UserInput(int x, int y, string label)
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            colorDialog1 = new ColorDialog();
            button1 = new Button();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 95);
            label1.Name = "label1";
            label1.Size = new Size(249, 36);
            label1.TabIndex = 2;
            label1.Text = $"{label}'s name:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(302, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 50);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(47, 151);
            label3.Name = "label3";
            label3.Size = new Size(238, 36);
            label3.TabIndex = 4;
            label3.Text = $"{label}'s color:";
            // 
            // button1
            // 
            button1.Location = new Point(302, 151);
            button1.Name = "button1";
            button1.Size = new Size(156, 36);
            button1.TabIndex = 5;
            button1.Text = "Choose color";
            button1.UseVisualStyleBackColor = true;
            button1.Tag = this;
            // 
            // this
            // 
            this.Controls.Add(label1);
            this.Controls.Add(button1);
            this.Controls.Add(textBox1);
            this.Controls.Add(label3);
            this.Location = new Point(x, y);
            this.Name = "this";
            this.Size = new Size(674, 282);
            this.TabIndex = 6;
        }
    }
}
