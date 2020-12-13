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
        public Bitmap HandlerTexture = Resource1.Handler;
        public Bitmap TargetTexture = Resource1.Target;
        private Point _targetPosition = new Point(300, 300);
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
            var handleRect = new Rectangle(localPosition.X - 50, localPosition.Y - 50, 100, 100); // змінна позиції фіолетової плями відносно курсору
            var targetRect = new Rectangle(_targetPosition.X - 50, _targetPosition.Y - 50, 100, 100);

            // направлення сяйва та підвищення швидкості зміни координат
            _targetPosition.X += _direction.X * 5;
            _targetPosition.Y += _direction.Y * 5;

            // Перевірка щоб сяйво не виходило за області видимості
            if (_targetPosition.X < 0 || _targetPosition.X > 500 )
            {
                //_targetPosition.X *= -1;
                //_targetPosition.X = 200;
                _direction.X *= -1;

            }
            if (_targetPosition.Y < 0 || _targetPosition.Y > 500)
            {
                //_targetPosition.Y *= -1;
                //_targetPosition.Y = 200;
                _direction.Y *= -1;
            }

            Point between = new Point(localPosition.X - _targetPosition.X, localPosition.Y - _targetPosition.Y); // проміжне значення
            float distance = (float)Math.Sqrt((between.X * between.X)+(between.Y * between.Y)); // теорема Піфагора для визначення гіпотенузи
            
            // перевірка на попадання
           if(distance < 10)
            {
                AddScore(1);
            }

            graphics.DrawImage(HandlerTexture, handleRect); // фіолетова пляма
            graphics.DrawImage(TargetTexture, targetRect); // сине сяйво
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh(); // Перерисовка форми по таймеру
        }

        private void timer2_Tick(object sender, EventArgs e) // таймер для руху сяйва
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
    }
}
