using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjutus1_Tarpv21
{
    public class EsimeneVorm : Form
    {
        

        Button button1;
        Button button2;
        Button button3;

        public EsimeneVorm()
        {
            this.Text = "Esimene Vorm";
            this.Size = new Size(600, 400);
            this.BackColor = Color.White;

            button1 = new Button
            {
                Text = "PictureViewer",
                Location = new Point(100, 50),
                BackColor = Color.White,
                Size = new Size(120, 70)
            };

            button2 = new Button
            {
                Text = "Math Quiz",
                Location = new Point(230, 50),
                BackColor = Color.White,
                Size = new Size(120, 70)
            };

            button3 = new Button
            {
                Text = "Matching Game",
                Location = new Point(360, 50),
                BackColor = Color.White,
                Size = new Size(120, 70),
            };

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;

            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(button3);


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MatchingGame game = new MatchingGame();
            game.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MathQuiz mathquiz = new MathQuiz();
            mathquiz.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Pildid pildid = new Pildid();
            pildid.Show();
        }
    }
}
