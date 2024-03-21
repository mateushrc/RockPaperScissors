using System;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        private int clicks = 0;
        private int imageIndex = 0;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            UpdateImage();
        }

        private void UpdateImage()
        {
            switch (imageIndex)
            {
                case 0:
                    pictureBox.Image = Properties.Resources.scissor;
                    break;
                case 1:
                    pictureBox.Image = Properties.Resources.rock;
                    break;
                case 2:
                    pictureBox.Image = Properties.Resources.paper;
                    break;
            }
        }

        private void UpdateClicks(int change)
        {
            clicks += change;
            label1.Text = $"{clicks}";
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            imageIndex = random.Next(3);
            UpdateImage();
        }

        private void buttonPaper_Click(object sender, EventArgs e)
        {
            if (imageIndex == 0)
                UpdateClicks(-1);
            else if (imageIndex == 1)
                UpdateClicks(1);

            imageIndex = random.Next(3);
            UpdateImage();
        }

        private void buttonRock_Click(object sender, EventArgs e)
        {
            if (imageIndex == 0)
                UpdateClicks(1);
            else if (imageIndex == 2)
                UpdateClicks(-1);

            imageIndex = random.Next(3);
            UpdateImage();
        }

        private void buttonScissor_Click(object sender, EventArgs e)
        {
            if (imageIndex == 1)
                UpdateClicks(-1);
            else if (imageIndex == 2)
                UpdateClicks(1);

            imageIndex = random.Next(3);
            UpdateImage();
        }
    }
}
