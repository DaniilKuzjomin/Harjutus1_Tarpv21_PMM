using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Windows.Forms.Timer;
using System.Media;



namespace Harjutus1_Tarpv21
{
    partial class MathQuiz_1 : Form
    {
        Label lblScore;
        Label lblNumA;
        Label lblSymbol;
        Label lblNumB;
        Label label5;
        Label lblAnswer;
        TextBox txtAnswer;
        Button button1;

        Random rnd = new Random();
        string[] Maths = { "Add", "Subtract", "Multiply" };
        int total;
        int score;

        public MathQuiz_1()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void InitializeComponent()
        {


            lblScore = new Label
            {
                AutoSize = true,
                ForeColor = System.Drawing.Color.Maroon,
                Location = new System.Drawing.Point(13, 13),
                Name = "lblScore",
                Size = new System.Drawing.Size(47, 13),
                TabIndex = 0,
                Text = "Score: 0",
            };

            lblNumA = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new System.Drawing.Point(13, 41),
                Name = "lblNumA",
                Size = new System.Drawing.Size(49, 33),
                TabIndex = 1,
                Text = "00",
            };

            lblSymbol = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new System.Drawing.Point(87, 41),
                Name = "lblSymbol",
                Size = new System.Drawing.Size(33, 33),
                TabIndex = 2,
                Text = "+",
            };

            lblNumB = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new System.Drawing.Point(146, 41),
                Name = "lblNumB",
                Size = new System.Drawing.Size(49, 33),
                TabIndex = 1,
                Text = "00",
            };

            label5 = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new System.Drawing.Point(216, 41),
                Name = "label5",
                Size = new System.Drawing.Size(33, 33),
                TabIndex = 4,
                Text = "=",
            };



            lblAnswer = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.Teal,
                Location = new System.Drawing.Point(15, 92),
                Name = "lblAnswer",
                Size = new System.Drawing.Size(58, 20),
                TabIndex = 5,
                Text = "correct",
            };


            txtAnswer = new TextBox
            {
                Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new System.Drawing.Point(255, 41),
                Name = "txtAnswer",
                Size = new System.Drawing.Size(71, 40),
                TabIndex = 6,

            };
            TextChanged += CheckAnswer;



            button1 = new Button
            {
                Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Location = new System.Drawing.Point(345, 41),
                Name = "button1",
                Size = new System.Drawing.Size(75, 40),
                TabIndex = 7,
                Text = "Check",
                UseVisualStyleBackColor = true,
            };
            button1.Click += new System.EventHandler(this.CheckButtonClickEvent);


            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(442, 132);
            Controls.Add(this.button1);
            Controls.Add(this.txtAnswer);
            Controls.Add(this.lblAnswer);
            Controls.Add(this.label5);
            Controls.Add(this.lblNumB);
            Controls.Add(this.lblSymbol);
            Controls.Add(this.lblNumA);
            Controls.Add(this.lblScore);
            Name = "MathQuiz_1";
            Text = "MathQuiz Game";
            ResumeLayout(false);
            PerformLayout();


        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAnswer.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers!");
                txtAnswer.Text = txtAnswer.Text.Remove(txtAnswer.Text.Length - 1);
            }
        }

        private void CheckButtonClickEvent(object sender, EventArgs e)
        {

            int userEntered = Convert.ToInt32(txtAnswer.Text);

            if (userEntered == total)
            {
                lblAnswer.Text = "Correct";
                lblAnswer.ForeColor = Color.Green;
                score += 1;
                lblScore.Text = "Score: " + score;
                SetUpGame();

            }
            else
            {
                lblAnswer.Text = "Incorrect";
                lblAnswer.ForeColor = Color.Red;
            }

        }

        private void SetUpGame()
        {
            int numA = rnd.Next(10, 20);
            int numB = rnd.Next(0, 9);

            txtAnswer.Text = null;

            switch (Maths[rnd.Next(0, Maths.Length)])
            {
                case "Add":
                    total = numA + numB;
                    lblSymbol.Text = "+";
                    lblSymbol.ForeColor = Color.DarkGreen;
                    break;

                case "Subtract":
                    total = numA - numB;
                    lblSymbol.Text = "-";
                    lblSymbol.ForeColor = Color.Maroon;
                    break;

                case "Multiply":
                    total = numA * numB;
                    lblSymbol.Text = "x";
                    lblSymbol.ForeColor = Color.Purple;
                    break;
            }

            lblNumA.Text = numA.ToString();
            lblNumB.Text = numB.ToString();
        }
    }
}