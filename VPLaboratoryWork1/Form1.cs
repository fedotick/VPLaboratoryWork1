using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace VPLaboratoryWork1
{
    public partial class Form1 : Form
    {
        private float alpha = 0.9f;
        private Label lastActiveLabel = new Label();


        public Form1()
        {
            InitializeComponent();
        }

        private void AmericanAvocet_Click(object sender, EventArgs e)
        {
            lastActiveLabel.ForeColor = Color.White;

            Image image = Image.FromFile(@"..\..\Resources/Images/Birds/AmericanAvocet.jpg");

            pictureBox1.Image = image;
            this.BackgroundImage = ApplyDarkOverlay(image, alpha);

            AmericanAvocet.ForeColor = Color.Gray;
            lastActiveLabel = AmericanAvocet;
        }

        private void AmericanKestrel_Click(object sender, EventArgs e)
        {
            lastActiveLabel.ForeColor = Color.White;

            Image image = Image.FromFile(@"..\..\Resources/Images/Birds/AmericanKestrel.jpg");

            pictureBox1.Image = image;
            this.BackgroundImage = ApplyDarkOverlay(image, alpha);

            AmericanKestrel.ForeColor = Color.Gray;
            lastActiveLabel = AmericanKestrel;
        }

        private void AtlanticPuffin_Click(object sender, EventArgs e)
        {
            lastActiveLabel.ForeColor = Color.White;

            Image image = Image.FromFile(@"..\..\Resources/Images/Birds/AtlanticPuffin.jpg");

            pictureBox1.Image = image;
            this.BackgroundImage = ApplyDarkOverlay(image, alpha);

            AtlanticPuffin.ForeColor = Color.Gray;
            lastActiveLabel = AtlanticPuffin;
        }

        private void BaltimoreOriole_Click(object sender, EventArgs e)
        {
            lastActiveLabel.ForeColor = Color.White;

            Image image = Image.FromFile(@"..\..\Resources/Images/Birds/BaltimoreOriole.jpg");

            pictureBox1.Image = image;
            this.BackgroundImage = ApplyDarkOverlay(image, alpha);

            BaltimoreOriole.ForeColor = Color.Gray;
            lastActiveLabel = BaltimoreOriole;
        }

        private void CrownedCrane_Click(object sender, EventArgs e)
        {
            lastActiveLabel.ForeColor = Color.White;

            Image image = Image.FromFile(@"..\..\Resources/Images/Birds/CrownedCrane.jpg");

            pictureBox1.Image = image;
            this.BackgroundImage = ApplyDarkOverlay(image, alpha);

            CrownedCrane.ForeColor = Color.Gray;
            lastActiveLabel = CrownedCrane;
        }

        private void GouldianFinch_Click(object sender, EventArgs e)
        {
            lastActiveLabel.ForeColor = Color.White;

            Image image = Image.FromFile(@"..\..\Resources/Images/Birds/GouldianFinch.jpg");

            pictureBox1.Image = image;
            this.BackgroundImage = ApplyDarkOverlay(image, alpha);

            GouldianFinch.ForeColor = Color.Gray;
            lastActiveLabel = GouldianFinch;
        }

        private void Kingfisher_Click(object sender, EventArgs e)
        {
            lastActiveLabel.ForeColor = Color.White;

            Image image = Image.FromFile(@"..\..\Resources/Images/Birds/Kingfisher.jpg");

            pictureBox1.Image = image;
            this.BackgroundImage = ApplyDarkOverlay(image, alpha);

            Kingfisher.ForeColor = Color.Gray;
            lastActiveLabel = Kingfisher;
        }

        private void NorthernCardinal_Click(object sender, EventArgs e)
        {
            lastActiveLabel.ForeColor = Color.White;

            Image image = Image.FromFile(@"..\..\Resources/Images/Birds/NorthernCardinal.jpg");

            pictureBox1.Image = image;
            this.BackgroundImage = ApplyDarkOverlay(image, alpha);

            NorthernCardinal.ForeColor = Color.Gray;
            lastActiveLabel = NorthernCardinal;
        }

        private void Peacock_Click(object sender, EventArgs e)
        {
            lastActiveLabel.ForeColor = Color.White;

            Image image = Image.FromFile(@"..\..\Resources/Images/Birds/Peacock.jpg");

            pictureBox1.Image = image;
            this.BackgroundImage = ApplyDarkOverlay(image, alpha);

            Peacock.ForeColor = Color.Gray;
            lastActiveLabel = Peacock;
        }

        private void RedMacawParrot_Click(object sender, EventArgs e)
        {
            lastActiveLabel.ForeColor = Color.White;

            Image image = Image.FromFile(@"..\..\Resources/Images/Birds/RedMacawParrot.jpg");

            pictureBox1.Image = image;
            this.BackgroundImage = ApplyDarkOverlay(image, alpha);

            RedMacawParrot.ForeColor = Color.Gray;
            lastActiveLabel = RedMacawParrot;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static Bitmap ApplyDarkOverlay(Image originalImage, float overlayAlpha)
        {
            Bitmap resultImage = new Bitmap(originalImage);

            using (Graphics g = Graphics.FromImage(resultImage))
            {
                using (Brush brush = new SolidBrush(Color.FromArgb((int)(255 * overlayAlpha), Color.Black)))
                {
                    g.FillRectangle(brush, 0, 0, resultImage.Width, resultImage.Height);
                }
            }

            return resultImage;
        }
    }
}
