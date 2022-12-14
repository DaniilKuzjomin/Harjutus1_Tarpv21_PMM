using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// tahan teha muusikat seda vormis et kasutaja saab kuulata muusikat

namespace Harjutus1_Tarpv21
{
    public class EsimeneVorm : Form
    {

        


        Button button1, button2, button3, button4;

        Label fail = new Label
        {
            Text = " ",
            Location = new Point(230, 240),
            Size = new Size(120, 30),
            BackColor = Color.White,
            BorderStyle = BorderStyle.FixedSingle,
        };

        public EsimeneVorm()
        {
            this.Text = "Esimene Vorm";
            this.Size = new Size(600, 400);
            this.BackColor = Color.LightPink;

            button1 = new Button // nupp mis teeb lahti Picture Viewer
            {
                Text = "PictureViewer",
                Location = new Point(100, 50),
                BackColor = Color.Pink,
                Size = new Size(120, 70),

            };

            button2 = new Button // nupp mis teeb lahti Math Quiz
            {
                Text = "Math Quiz",
                Location = new Point(230, 50),
                BackColor = Color.Pink,
                Size = new Size(120, 70)
            };

            button3 = new Button // nupp mis teeb lahti Matching game
            {
                Text = "Matching Game",
                Location = new Point(360, 50),
                BackColor = Color.Pink,
                Size = new Size(120, 70),
            };

            button4 = new Button // nupp millega kasutaja saab muusikat kuulata
            {
                Text = "Muusika",
                Location = new Point(230, 150),
                BackColor = Color.Pink,
                Size = new Size(120, 70),
            };


            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            button4.Click += Button4_Click;

            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(button3);
            this.Controls.Add(button4);
            this.Controls.Add(fail);


        }

        private void Button4_Click(object sender, EventArgs e) // Kood millega saab muusikat kuulata
        {

            using (var muusika = new SoundPlayer(@"..\..\Drillhoven.wav"))
            {

                muusika.Play();
                fail.Text = String.Format("Drillhoven - Fur elise drill remix"); // Labelis kuvatav tekst
                MessageBox.Show("M??ngib muusika - Drillhoven - Fur elise drill remix(1)");
                    
            }
           
        }

        private void Button3_Click(object sender, EventArgs e) // Kood millega saab avata Matching game
        {
            dialogMG game = new dialogMG();
            game.Show();

        }

        private void Button2_Click(object sender, EventArgs e) // Kood millega saab avata Math Quiz
        {
            dialogMQ game = new dialogMQ();
            game.Show();

        }

        private void Button1_Click(object sender, EventArgs e) // Kood millega saab avata Picture Viewer
        {
            Pildid pildid = new Pildid();
            pildid.Show();

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new Size(284, 261);
            this.Name = "EsimeneVorm";
            this.Load += new System.EventHandler(this.EsimeneVorm_Load);
            this.ResumeLayout(false);

        }

        private void EsimeneVorm_Load(object sender, EventArgs e)
        {

        }
    }
}
