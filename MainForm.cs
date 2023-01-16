using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikWinKep
{

    public partial class MainForm : Form
    {

        int SorSzam = 4;
        int OszlopSzam = 4;
        int InsertSize = 60;
        List<Image> images = new List<Image>();
        Random random = new Random();

        public MainForm()
        {

            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            images.Add(Image.FromFile("majom.jpg"));
            images.Add(Image.FromFile("majom2.jpg"));
            images.Add(Image.FromFile("majom3.jfif"));

            Button button = new Button();
            button.SetBounds(280, 280, 60, 60);
            button.Text = "Kep";
            button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button.AutoSize = true;
            TaroloPan.Controls.Add(button);

            for (int i = 0; i < SorSzam; i++)
            {

                for (int j = 0; j < OszlopSzam; j++)
                {

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = images[random.Next(images.Count)];
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.SetBounds(j * InsertSize, i * InsertSize, InsertSize, InsertSize);
                    pictureBox.Click += (o, ev) =>
                    {

                        PictureBox picture = (PictureBox)o;
                        button.Image = picture.Image;

                    };
                    TaroloPan.Controls.Add(pictureBox);

                }

            }


        }

    }

}
