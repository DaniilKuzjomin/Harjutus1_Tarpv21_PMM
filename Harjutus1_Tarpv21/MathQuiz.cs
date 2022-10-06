using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Windows.Forms.Timer;



// Looge matemaatikutele 3 erinevat režiimi, nagu algaja, keskmine, edasijõudnud
//
//

namespace Harjutus1_Tarpv21
{
    public class MathQuiz : Form
    {
        
        Random rnd = new Random();
        string[] Maths = { "Lisa", "Lahuta", "Korruta" };
        int total1, total2, total3, total4, score, correct;
        private int counter = 60;
        private Timer timer1;
        private Label lblScore;
        private Label lblTimer, lblSymbol1, lblSymbol2, lblSymbol3, lblSymbol4, lblNumB1, lblNumB2, lblNumB3, lblNumB4, lblEquals1, lblEquals2, lblEquals3, lblEquals4, lblAnswer, lblNumA1, lblNumA2, lblNumA3, lblNumA4;
        private NumericUpDown txtAnswer1, txtAnswer2, txtAnswer3, txtAnswer4;
        private Button button1, buttonTimer;
        Label[] labelSymArray = { }, lblNumArrayA = { }, lblNumArrayB = { }, lblEqualsArray = { };
        NumericUpDown[] txtAnswerArray = { };
        int[] totalArray = { };

        TableLayoutPanel tableLayoutPanel1;

        public MathQuiz()
        {
            InitializeComponent();

        }
        internal void InitializeComponent()
        {
            SuspendLayout();
            ClientSize = new Size(320, 300);
            Name = "MathQuiz";
            Text = "Maths Quiz Game";
            ResumeLayout(false);
            PerformLayout();
            labelSymArray = new Label[] { lblSymbol1, lblSymbol2, lblSymbol3, lblSymbol4 };
            lblNumArrayA = new Label[] { lblNumA1, lblNumA2, lblNumA3, lblNumA4 };
            lblNumArrayB = new Label[] { lblNumB1, lblNumB2, lblNumB3, lblNumB4 };
            lblEqualsArray = new Label[] { lblEquals1, lblEquals2, lblEquals3, lblEquals4 };
            txtAnswerArray = new NumericUpDown[] { txtAnswer1, txtAnswer2, txtAnswer3, txtAnswer4 };
            totalArray = new int[] { total1, total2, total3, total4 };

            int i = 0;


            tableLayoutPanel1 = new TableLayoutPanel
            {
                ColumnCount = 5,
                RowCount = 5,
                Size = new Size(310, 280),
                TabIndex = 0,
                Name = "tableLayoutPanel1",
                Dock = DockStyle.Fill,
                Location = new Point(0, 0),
            };

            lblScore = new Label
            {
                AutoSize = true,
                ForeColor = Color.Maroon,
                Location = new Point(10, 10),
                Name = "lblScore",
                Size = new Size(50, 15),
                TabIndex = 0,
                Text = "Punktid: 0"
            };

            foreach (Label sym in lblNumArrayA)
            {
                lblNumArrayA[i] = new Label
                {
                    AutoSize = true,
                    Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 200),
                    Name = "lblNumA",
                    Size = new Size(50, 35),
                    TabIndex = 1,
                    Text = "?"
                };
                i++;
            }
            i = 0;

            foreach (Label sym in labelSymArray)
            {
                labelSymArray[i] = new Label
                {
                    AutoSize = true,
                    Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 200),
                    Name = "lblSymbol",
                    Size = new Size(35, 35),
                    TabIndex = 2,
                    Text = "*"
                };
                i++;
            }
            i = 0;

            foreach (Label sym in lblNumArrayB)
            {
                lblNumArrayB[i] = new Label
                {
                    AutoSize = true,
                    Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 200),
                    Name = "lblNumB",
                    Size = new Size(50, 35),
                    TabIndex = 3,
                    Text = "?"
                };
                i++;
            }
            i = 0;

            foreach (Label sym in lblEqualsArray)
            {
                lblEqualsArray[i] = new Label
                {
                    AutoSize = true,
                    Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 200),
                    Name = "label4",
                    Size = new Size(35, 35),
                    TabIndex = 4,
                    Text = "="
                };
                i++;
            }
            i = 0;

            lblAnswer = new Label
            {
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 200),
                ForeColor = Color.Green,
                Name = "lblAnswer",
                Size = new Size(50, 15),
                TabIndex = 5,
                Text = ""
            };

            foreach (NumericUpDown sym in txtAnswerArray)
            {
                txtAnswerArray[i] = new NumericUpDown
                {
                    Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 200),
                    Name = "txtAnswer",
                    Size = new Size(80, 35),
                    TabIndex = 6
                };
                i++;
            }
            i = 0;

            button1 = new Button
            {
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 200),
                Location = new Point(290, 40),
                Name = "button1",
                Size = new Size(75, 35),
                TabIndex = 7,
                Text = "Kontrolli",
                UseVisualStyleBackColor = true,
                Enabled = false
            };

            buttonTimer = new Button
            {
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 200),
                Location = new Point(290, 40),
                Name = "button1",
                Size = new Size(75, 35),
                TabIndex = 7,
                Text = "Alusta",
                UseVisualStyleBackColor = true
            };

            lblTimer = new Label
            {
                AutoSize = true,
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 200),
                Name = "lblAnswer",
                Size = new Size(50, 15),
                TabIndex = 5,
                Text = "--"
            };
            timer1 = new Timer
            {
                Interval = 1000
            };


            Controls.Add(tableLayoutPanel1);

            timer1.Tick += timer1_Tick;
            buttonTimer.Click += ButtonTimer_Click;

            button1.Click += new EventHandler(CheckButtonClickEvent);

            tableLayoutPanel1.Controls.Add(lblNumArrayA[0], 0, 0);
            tableLayoutPanel1.Controls.Add(lblNumArrayA[1], 0, 1);
            tableLayoutPanel1.Controls.Add(lblNumArrayA[2], 0, 2);
            tableLayoutPanel1.Controls.Add(lblNumArrayA[3], 0, 3);

            tableLayoutPanel1.Controls.Add(labelSymArray[0], 1, 0);
            tableLayoutPanel1.Controls.Add(labelSymArray[1], 1, 1);
            tableLayoutPanel1.Controls.Add(labelSymArray[2], 1, 2);
            tableLayoutPanel1.Controls.Add(labelSymArray[3], 1, 3);

            tableLayoutPanel1.Controls.Add(lblNumArrayB[0], 1, 0);
            tableLayoutPanel1.Controls.Add(lblNumArrayB[1], 1, 1);
            tableLayoutPanel1.Controls.Add(lblNumArrayB[2], 1, 2);
            tableLayoutPanel1.Controls.Add(lblNumArrayB[3], 1, 3);

            tableLayoutPanel1.Controls.Add(txtAnswerArray[0], 4, 0);
            tableLayoutPanel1.Controls.Add(txtAnswerArray[1], 4, 1);
            tableLayoutPanel1.Controls.Add(txtAnswerArray[2], 4, 2);
            tableLayoutPanel1.Controls.Add(txtAnswerArray[3], 4, 3);

            tableLayoutPanel1.Controls.Add(lblEqualsArray[0], 3, 0);
            tableLayoutPanel1.Controls.Add(lblEqualsArray[1], 3, 1);
            tableLayoutPanel1.Controls.Add(lblEqualsArray[2], 3, 2);
            tableLayoutPanel1.Controls.Add(lblEqualsArray[3], 3, 3);

            tableLayoutPanel1.Controls.Add(lblAnswer, 4, 4);
            tableLayoutPanel1.Controls.Add(lblScore, 0, 4);
            tableLayoutPanel1.Controls.Add(button1, 4, 4);
            tableLayoutPanel1.Controls.Add(buttonTimer, 6, 5);
            tableLayoutPanel1.Controls.Add(lblTimer);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter = counter - 1;
                lblTimer.Text = counter + " sekundit";
            }
            else
            {
                timer1.Stop();
                lblTimer.Text = "Rohkem aega ei ole!";
                foreach (var item in txtAnswerArray)
                {
                    item.Enabled = false;
                }
                ClientSize = new Size(370, 300);
            }
        }
        private void ButtonTimer_Click(object sender, EventArgs e)
        {
            Game();
            buttonTimer.Enabled = false;
            button1.Enabled = true;

            timer1.Start();
        }

        private void CheckButtonClickEvent(object sender, EventArgs e)
        {

            for (int i = 0; i < 4; i++)
            {
                int userEntered = 0;
                try
                {
                    userEntered = Convert.ToInt32(txtAnswerArray[i].Text);
                }
                catch (FormatException)
                {

                }

                if (userEntered == totalArray[i])
                {
                    correct += 1;
                }
                else
                {
                }

            }

            if (correct >= 4)
            {
                lblAnswer.Text = "Õige!";
                lblAnswer.ForeColor = Color.Green;
                score += 1;
                lblScore.Text = "Punktid: " + score;
                Game();
            }
            else
            {
                lblAnswer.Text = "Vale!";
                lblAnswer.ForeColor = Color.Red;
            }
            correct = 0;
        }

        private void Game()
        {
            for (int ii = 0; ii < 4; ii++)
            {

                int numA = rnd.Next(0, 10);
                int numB = rnd.Next(0, 9);

                txtAnswerArray[ii].Text = null;


                string Tsym = "";
                Color colorSym = Color.Black;
                switch (Maths[rnd.Next(0, Maths.Length)])
                {
                    case "Lisa":
                        totalArray[ii] = numA + numB;
                        Tsym = "+";
                        colorSym = Color.Green;
                        break;

                    case "Lahuta":
                        totalArray[ii] = numA - numB;
                        Tsym = "-";
                        colorSym = Color.Maroon;
                        break;

                    case "Korruta":
                        totalArray[ii] = numA * numB;
                        Tsym = "x";
                        colorSym = Color.Purple;
                        break;
                }
                labelSymArray[ii].Text = Tsym;


                lblNumArrayA[ii].Text = numA.ToString();
                lblNumArrayB[ii].Text = numB.ToString();

            }
        }

    }
}
