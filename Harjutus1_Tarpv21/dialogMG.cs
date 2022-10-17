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

        Label fail = new Label
        {
            Text = " ",
            Location = new Point(230, 240),
            Size = new Size(120, 30),
            BackColor = Color.LightPink,
            BorderStyle = BorderStyle.FixedSingle,
        };

        public dialogMG()
        {



            Text = "Dialog Matching Game";
            Size = new Size(450, 240);
            BackColor = Color.LightPink;
            button1 = new Button 
            {
                Text = "Matching game ( Algaja )",
                Location = new Point(50, 50),
                BackColor = Color.Pink,
                Size = new Size(170, 70)
            };
            button1.Click += Button1_Click;

            button2 = new Button 
            {
                Text = "Matching game ( Professionaalne )",
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
            MatchingGame_1 game1 = new MatchingGame_1();
            game1.Show();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // dialogMG
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "dialogMG";
            this.Load += new System.EventHandler(this.dialogMG_Load);
            this.ResumeLayout(false);

        }

        private void dialogMG_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MatchingGame game = new MatchingGame();
            game.Show();
        }
    }
}
