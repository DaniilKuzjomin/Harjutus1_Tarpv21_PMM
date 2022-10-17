using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjutus1_Tarpv21
{
    internal class dialogMQ : Form
    {

        Button button1, button2;

        Label fail = new Label
        {
            Text = " ",
            Location = new Point(230, 240),
            Size = new Size(120, 30),
            BackColor = Color.LightPink,
            BorderStyle = BorderStyle.FixedSingle,
        };

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new Size(284, 261);
            this.Name = "dialogMQ";
            this.Load += new System.EventHandler(this.dialogMQ_Load);
            this.ResumeLayout(false);

        }

        private void dialogMQ_Load(object sender, EventArgs e)
        {

        }

        public dialogMQ()
        {

            Text = "Dialog Math Quiz";
            BackColor = Color.LightPink;
            ClientSize = new Size(450, 250);
            button1 = new Button
            {
                Text = "Math Quiz ( Treening )",
                Location = new Point(50, 50),
                BackColor = Color.Pink,
                Size = new Size(170, 70)
            };
            button1.Click += Button1_Click;

            button2 = new Button
            {
                Text = "Math game ( Pea režiim )",
                Location = new Point(230, 50),
                BackColor = Color.Pink,
                Size = new Size(170, 70)
            };
            button2.Click += Button2_Click;



            this.Controls.Add(button1);
            this.Controls.Add(button2);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MathQuiz game = new MathQuiz();
            game.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MathQuiz_1 game = new MathQuiz_1();
            game.Show();
        }
    }
}
