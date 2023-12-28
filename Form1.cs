using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            // Создаем объект Graphics для рисования на форме
            Graphics g = this.CreateGraphics();

            // Задаем цвет заливки для кисти
            SolidBrush brush = new SolidBrush(Color.White);

            // Рисуем большой круг (тело снеговика)
            g.FillEllipse(brush, 150, 100, 100, 100);

            // Рисуем средний круг (голова снеговика)
            g.FillEllipse(brush, 165, 60, 70, 70);

            // Рисуем  (нос снеговика)
            brush.Color = Color.Orange;

            // задаем координаты вершин треугольника
            Point[] points = { new Point(160, 80), new Point(200, 90), new Point(210, 80) };
  

            // закрашиваем треугольник с помощью метода FillPolygon
            g.FillPolygon(brush, points);

            // Рисуем два маленьких круга (глаза снеговика)
            brush.Color = Color.Black;
            g.FillEllipse(brush, 180, 70, 10, 10);
            g.FillEllipse(brush, 200, 70, 10, 10);

            // Рисуем шляпу снеговика
            brush.Color = Color.Purple;
            g.FillRectangle(brush, 180, 30, 40, 40);
            // Рисуем шляпу снеговика
            brush.Color = Color.Purple;
            g.FillRectangle(brush, 160, 60, 70, 10);
            // создаем объект Pen с красным цветом и толщиной линии 2 пикселя
            Pen pen = new Pen(Color.White, 2);

            // рисуем прямоугольник с помощью метода DrawRectangle
            g.DrawRectangle(pen, 160, 60, 70, 10);


            // Рисуем руки снеговика
            g.DrawLine(new Pen(Color.Brown, 5), 160, 120, 120, 150);
            g.DrawLine(new Pen(Color.Brown, 5), 220, 120, 260, 150);
        
            // задаем координаты и размеры овала, в котором будет находиться полукруг
            Rectangle rect = new Rectangle(180, 80, 40, 30);
            // создаем объект Pen с нужным цветом и толщиной линии
            Pen pen1 = new Pen(Color.Red, 2);
            pen1.DashStyle = DashStyle.Dash;
            // рисуем полукруг с помощью метода DrawArc
            g.DrawArc(pen1, rect, 0, 180);



        }
      


    }
}
