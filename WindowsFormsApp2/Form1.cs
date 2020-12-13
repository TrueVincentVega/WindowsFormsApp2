using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        // змінні 
        public Bitmap aimTexture = Resource1.aim;
        public Bitmap duck1Texture = Resource1.Duck1;
        private Point _duckPosition = new Point(300, 300);
        private Point _direction = Point.Empty; // направление
        private int _score = 0; // поле з початковим рахунком

        public Form1()
        {
            InitializeComponent();

            // Виправлення мерехтіння
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint, true); 
            UpdateStyles();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            var localPosition = this.PointToClient(Cursor.Position); // змінна поточної позиції курсору на екрані (переводимо в точку на формі)
            var aimRect = new Rectangle(localPosition.X - 50, localPosition.Y - 50, 100, 100); // змінна позиції прицілу відносно курсору
            var duckRect = new Rectangle(_duckPosition.X - 50, _duckPosition.Y - 50, 100, 100);

            // направлення качки та підвищення швидкості зміни координат
            _duckPosition.X += _direction.X * 5;
            _duckPosition.Y += _direction.Y * 5;

            // Перевірка щоб качка не вилітала за області видимості
            if (_duckPosition.X < 0 || _duckPosition.X > 500 )
            {
                //_duckPosition.X *= -1;
                //_duckPosition.X = 200;
                _direction.X *= -1;

            }
            if (_duckPosition.Y < 0 || _duckPosition.Y > 500)
            {
                //_duckPosition.Y *= -1;
                //_duckPosition.Y = 200;
                _direction.Y *= -1;
            }

            Point between = new Point(localPosition.X - _duckPosition.X, localPosition.Y - _duckPosition.Y); // проміжне значення
            float distance = (float)Math.Sqrt((between.X * between.X)+(between.Y * between.Y)); // теорема Піфагора для визначення гіпотенузи
            
            // перевірка на попадання по качці
           if(distance < 10)
            {
                AddScore(1);
            }

           // Кінець гри при досяганні 15 пострілів
           if (_score >= 15)
            {
                dog_pictureBox.Visible = true;
                gameover_label.Visible = true;
                _duckPosition = Point.Empty;
            }
            graphics.DrawImage(aimTexture, aimRect); 
            graphics.DrawImage(duck1Texture, duckRect); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh(); // Перерисовка форми по таймеру
        }

        private void timer2_Tick(object sender, EventArgs e) // таймер для руху качки
        {
            Random random = new Random();
            timer2.Interval = random.Next(25, 1000);
            _direction.X = random.Next(-1, 2);
            _direction.Y = random.Next(-1, 2);
        }

        private void AddScore(int score)
        {
            _score += score;
            score_label.Text = _score.ToString();
        }

        // NEW GAME BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            _score = 0;
            score_label.Text = _score.ToString();
            _duckPosition = new Point(300, 300);
            dog_pictureBox.Visible = false;
            gameover_label.Visible = false;
        }
    }
}
