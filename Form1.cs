namespace DiceGame
{
    public partial class Form1 : Form
    {
        Random dice = new Random();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int randomNumber1 = dice.Next(1, 7);
            int randomNumber2 = dice.Next(1, 7);

            
            switch (randomNumber1)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.d1;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.d2;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.d3;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.d4;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.d5;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.d6;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                default:
                    pictureBox1.Image = Properties.Resources.d6;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

            }

            switch (randomNumber2)
            {
                case 1:
                    pictureBox3.Image = Properties.Resources.d1;
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox3.Image = Properties.Resources.d2;
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox3.Image = Properties.Resources.d3;
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox3.Image = Properties.Resources.d4;
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox3.Image = Properties.Resources.d5;
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox3.Image = Properties.Resources.d6;
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                default:
                    pictureBox3.Image = Properties.Resources.d6;
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

            }

        }

    }
    }
