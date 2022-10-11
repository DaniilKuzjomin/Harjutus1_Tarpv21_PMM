using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        Button close, backgroundcolor, clear, showapicture, gray;
        ColorDialog colordialog;
        OpenFileDialog openfiledialog1;
        FlowLayoutPanel flowlayoutpanel;
        TrackBar trackBar;

        public Pildid()
        {
            this.Size = new Size(920, 550); // akna paraametrid
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
                Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*",

            };

            trackBar = new TrackBar
            {


            };
            tableLayoutPanel.Controls.Add(trackBar);

            Button[] buttons = { clear, showapicture, close, backgroundcolor, gray }; // list
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






        private void clear_Click(object sender, EventArgs e)
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
            this.Close();
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



        Image ZoomPicture(Image img, Size size)
        {
            Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * size.Width), Convert.ToInt32(img.Height * size.Height));
            Graphics gpu = Graphics.FromImage(bm);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bm;
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            if (trackBar.Value !=0)
            {
                picturebox.Image = null;
                picturebox.Image = ZoomPicture(picturebox, new Size(trackBar.Value, trackBar.Value);
            }
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









        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
                picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                picturebox.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
