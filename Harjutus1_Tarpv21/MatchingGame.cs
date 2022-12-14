using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Teha erineva raskusastmega režiime
// piiratud aja ja taimeriga töötava režiimi lisamine


namespace Harjutus1_Tarpv21
{
    public class MatchingGame : Form
    {

        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        TableLayoutPanel tableLayoutPanel;
        Label label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16;
        Timer timer1;
        Form Form1;

        Random random = new Random();


        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();


            tableLayoutPanel = new TableLayoutPanel // tableLayoutPanel paraametrid
            {
                BackColor = Color.Pink,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset,
                ColumnCount = 4,
                Dock = DockStyle.Fill,
                Location = new Point(0, 0),
                Name = "tableLayoutPanel",
                RowCount = 4,
                Size = new Size(534, 511),
                TabIndex = 0,
            };
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));

            tableLayoutPanel.SuspendLayout();
            SuspendLayout();


            label16 = new Label // label paraametrid
            {
                Dock = DockStyle.Fill,
                Font = new Font("Webdings", 48F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(2))),
                Location = new Point(404, 383),
                Name = "label16",
                Size = new Size(125, 126),
                TabIndex = 15,
                Text = "c",
                TextAlign = ContentAlignment.MiddleCenter,

            };
            label16.Click += new EventHandler(this.label_Click);

            label15 = new Label // label paraametrid
            {
                Dock = DockStyle.Fill,
                Font = new Font("Webdings", 48F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(2))),
                Location = new Point(271, 383),
                Name = "label15",
                Size = new Size(125, 126),
                TabIndex = 14,
                Text = "c",
                TextAlign = ContentAlignment.MiddleCenter,

            };
            label15.Click += new EventHandler(label_Click);


            label14 = new Label // label paraametrid
            {
                Dock = DockStyle.Fill,
                Font = new Font("Webdings", 48F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(2))),
                Location = new Point(138, 383),
                Name = "label14",
                Size = new Size(125, 126),
                TabIndex = 13,
                Text = "c",
                TextAlign = ContentAlignment.MiddleCenter,

            };
            label14.Click += new EventHandler(label_Click);

            label13 = new Label // label paraametrid
            {
                Dock = DockStyle.Fill,
                Font = new Font("Webdings", 48F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(2))),
                Location = new Point(5, 383),
                Name = "label13",
                Size = new Size(125, 126),
                TabIndex = 12,
                Text = "c",
                TextAlign = ContentAlignment.MiddleCenter,

            };
            label13.Click += new EventHandler(label_Click);

            label12 = new Label // label paraametrid
            {
                Dock = DockStyle.Fill,
                Font = new Font("Webdings", 48F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2))),
                Location = new Point(404, 256),
                Name = "label12",
                Size = new Size(125, 126),
                TabIndex = 11,
                Text = "c",
                TextAlign = ContentAlignment.MiddleCenter,

            };
            label12.Click += new EventHandler(label_Click);

            label11 = new Label // label paraametrid
            {
                Dock = DockStyle.Fill,
                Font = new Font("Webdings", 48F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(2))),
                Location = new Point(271, 256),
                Name = "label11",
                Size = new Size(125, 126),
                TabIndex = 10,
                Text = "c",
                TextAlign = ContentAlignment.MiddleCenter,

            };
            label11.Click += new EventHandler(label_Click);

            label10 = new Label // label paraametrid
            {
                Dock = DockStyle.Fill,
                Font = new Font("Webdings", 48F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(2))),
                Location = new Point(138, 256),
                Name = "label10",
                Size = new Size(125, 126),
                TabIndex = 9,
                Text = "c",
                TextAlign = ContentAlignment.MiddleCenter,

            };
            label10.Click += new EventHandler(label_Click);

            label9 = new Label // label paraametrid
            {
                Dock = DockStyle.Fill,
                Font = new Font("Webdings", 48F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(2))),
                Location = new Point(5, 256),
                Name = "label9",
                Size = new Size(125, 126),
                TabIndex = 8,
                Text = "c",
                TextAlign = ContentAlignment.MiddleCenter,

            };
            label9.Click += new EventHandler(label_Click);

            label8 = new Label // label paraametrid
            {
                Dock = DockStyle.Fill,
                Font = new Font("Webdings", 48F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(2))),
                Location = new Point(404, 129),
                Name = "label8",
                Size = new Size(125, 126),
                TabIndex = 7,
                Text = "c",
                TextAlign = ContentAlignment.MiddleCenter,

            };
            label8.Click += new EventHandler(label_Click);

            label7 = new Label // label paraametrid 
            {
                Dock = DockStyle.Fill,
                Font = new Font("Webdings", 48F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(2))),
                Location = new Point(271, 129),
                Name = "label7",
                Size = new Size(125, 126),
                TabIndex = 6,
                Text = "c",
                TextAlign = ContentAlignment.MiddleCenter,

            };
            label7.Click += new EventHandler(label_Click);

            label6 = new Label // label paraametrid
            {
                Dock = DockStyle.Fill,
                Font = new Font("Webdings", 48F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(2))),
                Location = new Point(138, 129),
                Name = "label6",
                Size = new Size(125, 126),
                TabIndex = 5,
                Text = "c",
                TextAlign = ContentAlignment.MiddleCenter,

            };
            label6.Click += new EventHandler(label_Click);

            label5 = new Label // label paraametrid
            {
                Dock = DockStyle.Fill,
                Font = new Font("Webdings", 48F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(2))),
                Location = new Point(5, 129),
                Name = "label5",
                Size = new Size(125, 126),
                TabIndex = 4,
                Text = "c",
                TextAlign = ContentAlignment.MiddleCenter,

            };
            label5.Click += new EventHandler(label_Click);

            label4 = new Label // label paraametrid
            {
                Dock = DockStyle.Fill,
                Font = new Font("Webdings", 48F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(2))),
                Location = new Point(404, 2),
                Name = "label4",
                Size = new Size(125, 126),
                TabIndex = 3,
                Text = "c",
                TextAlign = ContentAlignment.MiddleCenter,

            };
            label4.Click += new System.EventHandler(label_Click);

            label3 = new Label // label paraametrid
            {
                Dock = DockStyle.Fill,
                Font = new Font("Webdings", 48F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(2))),
                Location = new Point(271, 2),
                Name = "label3",
                Size = new Size(125, 126),
                TabIndex = 2,
                Text = "c",
                TextAlign = ContentAlignment.MiddleCenter,

            };
            label3.Click += new System.EventHandler(label_Click);

            label2 = new Label // label paraametrid
            {
                Dock = DockStyle.Fill,
                Font = new Font("Webdings", 48F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(2))),
                Location = new Point(138, 2),
                Name = "label2",
                Size = new Size(138, 2),
                TabIndex = 1,
                Text = "c",
                TextAlign = ContentAlignment.MiddleCenter,

            };
            label2.Click += new EventHandler(label_Click);

            label1 = new Label // label paraametrid
            {
                Dock = DockStyle.Fill,
                Font = new Font("Webdings", 48F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(2))),
                Location = new Point(5, 2),
                Name = "label1",
                Size = new Size(138, 2),
                TabIndex = 0,
                Text = "c",
                TextAlign = ContentAlignment.MiddleCenter,

            };
            label1.Click += new EventHandler(label_Click);

            timer1 = new Timer // timer paraametrid
            {
                Interval = 750,

            };
            timer1.Tick += new EventHandler(timer1_Tick);

            Form1 = new Form // vormi paraametrid
            {
                AutoScaleDimensions = new SizeF(6F, 13F),
                AutoScaleMode = AutoScaleMode.Font,
                ClientSize = new Size(534, 511),
                Name = "Form1",
                Text = "Matching Game",
            };
            Load += new EventHandler(this.Form1_Load);
            tableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);

            Controls.Add(tableLayoutPanel); // tableLayoutPanel vormile lisamine
            tableLayoutPanel.Controls.Add(label16, 3, 3); // label vormile lisamine ja koha määramine
            tableLayoutPanel.Controls.Add(label15, 2, 3); // label vormile lisamine ja koha määramine
            tableLayoutPanel.Controls.Add(label14, 1, 3); // label vormile lisamine ja koha määramine
            tableLayoutPanel.Controls.Add(label13, 0, 3); // label vormile lisamine ja koha määramine
            tableLayoutPanel.Controls.Add(label12, 3, 2); // label vormile lisamine ja koha määramine
            tableLayoutPanel.Controls.Add(label11, 2, 2); // label vormile lisamine ja koha määramine
            tableLayoutPanel.Controls.Add(label10, 1, 2); // label vormile lisamine ja koha määramine
            tableLayoutPanel.Controls.Add(label9, 0, 2); // label vormile lisamine ja koha määramine
            tableLayoutPanel.Controls.Add(label8, 3, 1); // label vormile lisamine ja koha määramine
            tableLayoutPanel.Controls.Add(label7, 2, 1); // label vormile lisamine ja koha määramine
            tableLayoutPanel.Controls.Add(label6, 1, 1); // label vormile lisamine ja koha määramine
            tableLayoutPanel.Controls.Add(label5, 0, 1); // label vormile lisamine ja koha määramine
            tableLayoutPanel.Controls.Add(label4, 3, 0); // label vormile lisamine ja koha määramine
            tableLayoutPanel.Controls.Add(label3, 2, 0); // label vormile lisamine ja koha määramine
            tableLayoutPanel.Controls.Add(label2, 1, 0); // label vormile lisamine ja koha määramine
            tableLayoutPanel.Controls.Add(label1, 0, 0); // label vormile lisamine ja koha määramine

        }


        List<string> icons = new List<string>() // ikoonidega loendi lisamine
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };


        Label firstClicked = null;


        Label secondClicked = null;

        private void AssignIconsToSquares()
        {

            foreach (Control control in tableLayoutPanel.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        public MatchingGame()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                CheckForWinner();

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }


                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e) // timer
        {

            timer1.Stop();


            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;


            firstClicked = null;
            secondClicked = null;
        }

        private void CheckForWinner() // kontrollib, kas mäng on lõppenud
        {

            foreach (Control control in tableLayoutPanel.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }


            MessageBox.Show("You matched all the icons!", "Congratulations");
            Close();



            var vastus = MessageBox.Show("Kas sa tahad veel üks kord mängida?", "Küsimus", MessageBoxButtons.YesNo);
            if (vastus == DialogResult.Yes)
            {

                MatchingGame game = new MatchingGame();
                game.Show();
            }
            else
            {
                MessageBox.Show("500 EURO!");
            }

        }

    }
}