using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjutus1_Tarpv21
{
    public class EsimeneVorm : Form
    {
        public EsimeneVorm() { }
        public EsimeneVorm(string Pealkiri)
        {
            this.ClientSize = new System.Drawing.Size(380, 300);
            this.Text = Pealkiri;
            Button nupp = new Button
            {
                Text = String.Format("Picture Viewer"),
                Location = new System.Drawing.Point(50, 50),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,

            };
            nupp.Click += Nupp_Click;
            Button nupp1 = new Button
            {
                Text = String.Format("Math Quiz"),
                Location = new System.Drawing.Point(150, 50),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,
            };
            nupp1.Click += Nupp_Click1;

            Button nupp2 = new Button
            {
                Text = String.Format("Matching Game"),
                Location = new System.Drawing.Point(250, 50),
                Size = new System.Drawing.Size(100, 50),
                BackColor = System.Drawing.Color.White,
            };
            nupp2.Click += Nupp_Click2;


            Controls.Add(nupp);
            Controls.Add(nupp1);
            Controls.Add(nupp2);

        }


        private void Nupp_Click(object sender, EventArgs e)
        {

        }

        private void Nupp_Click1(object sender, EventArgs e)
        {



        }

        private void Nupp_Click2(object sender, EventArgs e)
        {

        }


    }
}
