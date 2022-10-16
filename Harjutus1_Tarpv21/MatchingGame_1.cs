using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjutus1_Tarpv21
{
    public partial class MatchingGame_1 : Form
    {
        Random rnd = new Random();
        TableLayoutPanel tableLayoutPanel1;
        Label esimeneClicked = null;
        Label teineClicked = null;
        Timer timer1 = new Timer { Interval = 750 };
        List<string> icons = new List<string>()
        {
            "a", "a", "c", "c", "q", "q", "x", "x","p", "p", "j", "j", "y", "y", "b", "b","k", "k",
            "m", "m", "h", "h", "d", "d", "e", "e","l", "l", "f", "f", "v", "v", "w", "w","n", "n",
        };

        public MatchingGame_1()
        {
            timer1.Tick += timer1_Tick;
            Text = "Matching game";
            ClientSize = new Size(600, 600);
            tableLayoutPanel1 = new TableLayoutPanel
            {
                BackColor = Color.Pink,
                Dock = DockStyle.Fill,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset,
                RowCount = 6,
                ColumnCount = 6
            };
            this.Controls.Add(tableLayoutPanel1);
            for (int i = 0; i < 6; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
                for (int j = 0; j < 6; j++)
                {

                    Label lbl1 = new Label
                    {
                        BackColor = Color.Pink,
                        AutoSize = false,
                        Dock = DockStyle.Fill,
                        TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                        Text = "c",
                        Font = new Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2))),
                    };


                    tableLayoutPanel1.Controls.Add(lbl1, i, j);
                };

            }
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel1 = control as Label;
                if (iconLabel1 != null)
                {
                    int randomNumber = rnd.Next(icons.Count);
                    iconLabel1.Text = icons[randomNumber];
                    icons.RemoveAt(randomNumber);
                }
                iconLabel1.ForeColor = iconLabel1.BackColor;
                iconLabel1.Click += label1_Click;
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (esimeneClicked == null)
                {
                    esimeneClicked = clickedLabel;
                    esimeneClicked.ForeColor = Color.Black;
                    return;
                }

                teineClicked = clickedLabel;
                teineClicked.ForeColor = Color.Black;
                timer1.Start();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (esimeneClicked.Text == teineClicked.Text)
            {
                esimeneClicked.ForeColor = esimeneClicked.ForeColor;
                teineClicked.ForeColor = teineClicked.ForeColor;
            }
            else
            {
                esimeneClicked.ForeColor = esimeneClicked.BackColor;
                teineClicked.ForeColor = teineClicked.BackColor;
            }
            esimeneClicked = null;
            teineClicked = null;
            timer1.Stop();
            CheckForWinner();
        }
        private void AgainGame()
        {
            var vastus = MessageBox.Show("Kas sa tahad veel üks kord mängida?", "Küsimus", MessageBoxButtons.YesNo);
            if (vastus == DialogResult.Yes)
            {

                MatchingGame_1 game = new MatchingGame_1();
                game.Show();
            }
            else
            {
                MessageBox.Show("500 EURO!");
            }
        }
        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"..\..\music13.wav");
            player.Play();
            MessageBox.Show("Sa sobitasid kõik ikoonid!", "Palju õnne", 0, MessageBoxIcon.Information);
            AgainGame();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MatchingGame_1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "MatchingGame_1";
            this.Load += new System.EventHandler(this.MatchingGame_1_Load);
            this.ResumeLayout(false);

        }

        private void MatchingGame_1_Load(object sender, EventArgs e)
        {

        }
    }
}

