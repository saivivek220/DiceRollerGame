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
                    pictureBox1.ImageLocation = @"C:\Users\saije\Desktop\Dice\d1.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox1.ImageLocation = @"C:\Users\saije\Desktop\Dice\d2.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox1.ImageLocation = @"C:\Users\saije\Desktop\Dice\d3.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox1.ImageLocation = @"C:\Users\saije\Desktop\Dice\d4.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox1.ImageLocation = @"C:\Users\saije\Desktop\Dice\d5.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox1.ImageLocation = @"C:\Users\saije\Desktop\Dice\d6.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                default:
                    pictureBox1.ImageLocation = @"C:\Users\saije\Desktop\Dice\dice_red.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

            }

            switch (randomNumber2)
            {
                case 1:
                    pictureBox3.ImageLocation = @"C:\Users\saije\Desktop\Dice\d1.jpg";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox3.ImageLocation = @"C:\Users\saije\Desktop\Dice\d2.jpg";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox3.ImageLocation = @"C:\Users\saije\Desktop\Dice\d3.png";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pictureBox3.ImageLocation = @"C:\Users\saije\Desktop\Dice\d4.png";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pictureBox3.ImageLocation = @"C:\Users\saije\Desktop\Dice\d5.png";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pictureBox3.ImageLocation = @"C:\Users\saije\Desktop\Dice\d6.jpg";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                default:
                    pictureBox3.ImageLocation = @"C:\Users\saije\Desktop\Dice\dice_red.png";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

            }

            if (randomNumber1 > randomNumber2)
            {
                
                Console.WriteLine("Player 1 scored: " + randomNumber1 + " and Player 1 is the winner");
            }

            else if (randomNumber2 > randomNumber1)
            {
                Console.WriteLine("Player 2 scored: " + randomNumber2 + " and Player 2 is the winner");
            }
            else if (randomNumber1 == randomNumber2)
                Console.WriteLine("Match Draw !");




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox1 = new TextBox();
           textBox1.Text="hi";

        }
    }
    }
