using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjutus1_Tarpv21
{
    internal class dialogMG : Form
    {

        Button button1, button2;

        public dialogMG()
        {
            ClientSize = new Size(450, 250);
            button1 = new Button 
            {
                Text = "Matching game ( Starter )",
                Location = new Point(50, 50),
                BackColor = Color.White,
                Size = new Size(170, 70)
            };
            button1.Click += Button1_Click;

            button2 = new Button 
            {
                Text = "Matching game ( Professional )",
                Location = new Point(230, 50),
                BackColor = Color.White,
                Size = new Size(170, 70)
            };
            button2.Click += Button2_Click;


            this.Controls.Add(button1);
            this.Controls.Add(button2);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MatchingGame_1 game1 = new MatchingGame_1();
            game1.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MatchingGame game = new MatchingGame();
            game.Show();
        }
    }
}
