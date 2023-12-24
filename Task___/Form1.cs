using System.Windows.Forms;
using Task___.Models.Interfaces;
using Task___.Models;

namespace Task___
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(200, pictureBox1);

            PerformAnimation(circle, 20);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Square square = new Square(100, pictureBox1);

            PerformAnimation(square, 20);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rhomb circle = new Rhomb(100, 200, pictureBox1);

            PerformAnimation(circle, 20);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PerformAnimation(Figure figure, int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                figure.DrawBlack();
                figure.MoveRight(5);
                Thread.Sleep(100);
                figure.HideDrawingBackground();
            }
        }
    }
}