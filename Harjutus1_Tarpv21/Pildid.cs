using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// kui lisate faili, et kuvada selle nimi vormis

namespace Harjutus1_Tarpv21
{
    public class Pildid : Form
    {
        TableLayoutPanel tableLayoutPanel;
        PictureBox picturebox;
        CheckBox checkBox;
        Button close, backgroundcolor, clear, showapicture, gray, mirror, slide, stop, rotate;
        ColorDialog colordialog;
        OpenFileDialog openfiledialog1;
        FlowLayoutPanel flowlayoutpanel;
        TrackBar trackBar;
        Timer timer1;
        FolderBrowserDialog fold;
        int imgNum = 1;





        public Pildid()
        {
            this.Size = new Size(1000, 800); // akna paraametrid
            this.Text = "Picture Viewer";
            tableLayoutPanel = new TableLayoutPanel // tableLayoutPanel paraametrid
            {
                AutoSize = true,
                ColumnCount = 2,
                RowCount = 2,
                Location = new Point(0, 0),
                Size = new Size(534, 311),
                TabIndex = 0,
                BackColor = Color.White,
            };
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle
                (SizeType.Percent, 15F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle
                (SizeType.Percent, 85F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.RowStyle
                (SizeType.Percent, 90F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.RowStyle
                (SizeType.Percent, 5F));
            tableLayoutPanel.ResumeLayout(false);

            this.Controls.Add(tableLayoutPanel);


                picturebox = new PictureBox // PictureBox paraametrid
                {
                
                    BorderStyle = BorderStyle.Fixed3D,
                    Dock = DockStyle.Fill,
                    Location = new Point(2, 2),
                    Size = new Size(528, 269),
                    TabIndex = 0,
                    TabStop = false,
                };
            tableLayoutPanel.Controls.Add(picturebox, 0, 0);
            tableLayoutPanel.SetCellPosition(picturebox, new TableLayoutPanelCellPosition(0, 0));
            tableLayoutPanel.SetColumnSpan(picturebox, 2);


            checkBox = new CheckBox // Checkbox paraametrid
            {
                AutoSize = true,
                Location = new Point(3, 278),
                Size = new Size(117, 30),
                TabIndex = 1,
                UseVisualStyleBackColor = true,
                Text = "Stretch",
                Dock = DockStyle.Fill,
            };
            checkBox.CheckedChanged += new EventHandler(checkBox_CheckedChanged);
            tableLayoutPanel.Controls.Add(checkBox, 1, 0);




            this.Controls.Add(tableLayoutPanel); // vormi lisamine tableLayoutPanel


            close = new Button // button paraametrid
            {
                AutoSize = true,
                Location = new Point(3, 3),
                Size = new Size(75, 23),
                TabIndex = 0,
                Text = "Close",
                UseVisualStyleBackColor = true,


            };
            close.Click += new EventHandler(close_Click);
            tableLayoutPanel.Controls.Add(close); // vormis lisamine button



            colordialog = new ColorDialog // Colordialog paraametrid
            {
                AllowFullOpen = true,
                AnyColor = true,
                SolidColorOnly = false,
                Color = Color.Red,
            };

            gray = new Button
            {
                AutoSize = true,
                Location = new Point(373, 3),
                Size = new Size(75, 23),
                TabIndex = 5,
                Text = "Change photo color to Gray",
                UseVisualStyleBackColor = true,
            };
            gray.Click += new EventHandler(Gray_Click);

            mirror = new Button
            {
                AutoSize = true,
                Location = new Point(454, 3),
                Size = new Size(75, 23),
                TabIndex = 6,
                Text = "Mirror picture",
                UseVisualStyleBackColor = true,
            };
            mirror.Click += new EventHandler(Mirror);

            rotate = new Button
            {
                AutoSize = true,
                Location = new Point(697, 3),
                Size = new Size(75, 23),
                TabIndex = 9,
                Text = "Rotate picture",
                UseVisualStyleBackColor = true,
            };
            rotate.Click += Rotate_Click;

            slide = new Button
            {
                AutoSize = true,
                Location = new Point(535, 3),
                Size = new Size(75, 23),
                TabIndex = 7,
                Text = "Slide Show",
                UseVisualStyleBackColor = true,
            };
            slide.Click += new EventHandler(SLideStart);

            stop = new Button
            {
                AutoSize = true,
                Location = new Point(616, 3),
                Size = new Size(75, 23),
                TabIndex = 8,
                Text = "Slide Show Stop",
                UseVisualStyleBackColor = true,
            };
            stop.Click += new EventHandler(stop_Click);



            backgroundcolor = new Button // button paraametrid
            {
                AutoSize = true,
                Location = new Point(84, 3),
                Size = new Size(121, 23),
                TabIndex = 1,
                Text = "Set Background Color",
                UseVisualStyleBackColor = true,

            };
            tableLayoutPanel.Controls.Add(backgroundcolor); // vormis lisamine button
            this.backgroundcolor.Click += new EventHandler(this.backgroundcolor_Click);


            clear = new Button // button paraametrid
            {
                AutoSize = true,
                Location = new Point(211, 3),
                Size = new Size(75, 23),
                TabIndex = 2,
                Text = "Clear",
                UseVisualStyleBackColor = true,
            };
            tableLayoutPanel.Controls.Add(clear); // vormis lisamine button
            this.clear.Click += new EventHandler(this.clear_Click);

            showapicture = new Button // button paraametrid
            {
                AutoSize = true,
                Location = new Point(292, 3),
                Size = new Size(102, 23),
                TabIndex = 3,
                Text = "Show The Picture",
                UseVisualStyleBackColor = true,

            };
            tableLayoutPanel.Controls.Add(showapicture); // vormis lisamine button
            this.showapicture.Click += new EventHandler(this.showapicture_Click);

            openfiledialog1 = new OpenFileDialog // OpenFileDialog paraametrid
            {
                RestoreDirectory = true,
                Title = "Browse Text Files",
                Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" + "s (*.*)|*.*",

            };

            trackBar = new TrackBar
            {


            };
            tableLayoutPanel.Controls.Add(trackBar);

            timer1 = new Timer
            {
                Interval = 1000,
            };
            timer1.Tick += timer1_Tick;


            Button[] buttons = { clear, showapicture, close, backgroundcolor, gray, mirror, slide, stop, rotate }; // list
            flowlayoutpanel = new FlowLayoutPanel // flowLayoutPanel paraametrid
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                Size = new Size(200, 50),
            };
            flowlayoutpanel.Controls.AddRange(buttons); // flowLayoutPanelisse buttoni lisamine
            tableLayoutPanel.Controls.Add(flowlayoutpanel, 1, 1); // asukohta seadistus
            Controls.Add(tableLayoutPanel); // vormis lisamine tableLayoutPanel
        }


        private void SLideStart(object sender, EventArgs e)
        {
            fold = new FolderBrowserDialog();
            fold.ShowDialog();
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            picturebox.ImageLocation = string.Format(fold.SelectedPath + "\\img{0}.jpg", imgNum);
            imgNum++;
            if (imgNum == 4)
                imgNum = 1;
        }


        private void clear_Click(object sender, EventArgs e)
        {
            picturebox.Image = null;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            picturebox.Image = null;
        }



        private void backgroundcolor_Click(object sender, EventArgs e)
        {
            if (colordialog.ShowDialog() == DialogResult.OK)
            {
                picturebox.BackColor = colordialog.Color;
            }
        }

        private void InitializeComponent()
        {
            SuspendLayout();

            ClientSize = new Size(284, 261);
            Name = "Pildid";
            Load += new EventHandler(Pildid_Load);
            ResumeLayout(false);

        }

        private void Pildid_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            picturebox.Image = null;
        }

        private void showapicture_Click(object sender, EventArgs e)
        {
            if (openfiledialog1.ShowDialog() == DialogResult.OK)
            {
                picturebox.Image = new Bitmap(openfiledialog1.FileName);
            }
        }


        private void Gray_Click(object sender, EventArgs e)
        {
            Bitmap copyBitmap = new Bitmap((Bitmap)picturebox.Image);
            ProcessImage(copyBitmap);
            picturebox.Image = copyBitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar.Minimum = 1;
            trackBar.Maximum = 6;
            trackBar.SmallChange = 1;
            trackBar.LargeChange = 1;
            trackBar.UseWaitCursor = false;

            DoubleBuffered = true;

        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            if (trackBar.Value != 0)
            {
                picturebox.Image = null;
                picturebox.Image = ZoomPicture(picturebox.Image, new Size(trackBar.Value, trackBar.Value));
            }
        }

        Image ZoomPicture(Image img, Size size)
        {
            Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * size.Width), Convert.ToInt32(img.Height * size.Height));
            Graphics gpu = Graphics.FromImage(bm);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bm;
        }



        public bool ProcessImage(Bitmap bmp)
        {
            for(int i = 0; i<bmp.Width; i++)
            {
                for (int j = 0; j <bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j);
                    int red = bmpColor.R;
                    int green = bmpColor.G;
                    int blue = bmpColor.B;
                    int gray = (byte)(.299 * red + .587 * green + .114 * blue);
                    red = gray;
                    green = gray;
                    blue = gray;
                    bmp.SetPixel(i, j, Color.FromArgb(red, green, blue));
                }
            }
            return true;
        }




        private void Mirror(System.Object sender, System.EventArgs e) //funktsioon mis pöödrub pildi
        {
            Bitmap pic = new Bitmap(picturebox.Image);
            if (pic != null)
            {
                pic.RotateFlip(RotateFlipType.Rotate180FlipY);
                picturebox.Image = pic;
            }
        }



        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
                picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                picturebox.SizeMode = PictureBoxSizeMode.Normal;
        }


    }
}

// Zoom In & Zoom Out Image in PictureBox | C# Windows Form

