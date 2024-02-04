using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__9
{
    public class Rectangle
    {
        public static int count = 0;

        private double length;
        private double width;


        public double Length
        {
            get // вызывается при чтениии свойства Length (r.Length)
            {
                return length;
            }
            set // вызывается при записи Length (r.Length = 105)
            {
                if (value < 0.0001 || value > 46340.9499)
                {
                    //throw new ArgumentException("значение не может быть таким");
                    value = 0;
                }
                length = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 0.0001 || value > 46340.9499)
                {
                    value = 0;
                }
                width = value;
            }
        }

        public double AreaCircle //S = π × r2(площадь круга) r = (a^2+b^2)/2(радиус)
        {
            get => Math.PI * Math.Pow(Math.Sqrt(width * width * length * length)/ 2,2);
        }

        public bool IsSqrt //проверка на квадрат
        {
            get => Length == Width;
        }
        public void ShowRec()
        {
            Console.WriteLine($"Ширина: {width} Длина: {length}");
        }

        public Rectangle(Rectangle r) //конструктор копирования
        {
            this.Length = r.Length;
            this.Width = r.Width;
            count++;
        }
        public Rectangle() // конструктор без параметров
        {
            this.length = 0;
            this.width = 0;
            count++; 
        }
        public Rectangle(double length, double width) //конструктор с параметрами
        {
            this.Length = length;
            this.Width = width;
            count++;
        } 

        public Rectangle AddSize(double length, double width, int n) //вызывается для конкретного объекта
        {
            Rectangle rec = new Rectangle(length, width);
            this.Length = Length * n;
            this.Width = Width * n;
            Console.WriteLine($"Новая ширина: {Width} Новая длина: {Length} ");
            return rec;
        }

        public static Rectangle AddSize(Rectangle r, int n) //не имеет ссылки на конкретный объект
        {
            r.Length *= n;
            r.Width *= n;
            Console.WriteLine($"Новая ширина: {r.Width} Новая длина: {r.Length}");
            return r;
        }
        public static int GetCount => count; //счетчик объектов

        public static Rectangle operator +(Rectangle r, double n) //операция +
        {
            return new Rectangle(r.Length + n, r.Width + n);
        }
        public static Rectangle operator +(double n, Rectangle r) //операция +
        {
            return new Rectangle(n + r.Length, n + r.Width);
        }

        public static Rectangle operator -(Rectangle r, double n) //операция -
        {
            return new Rectangle(r.Length - n, r.Width - n);
        }
        public static Rectangle operator -(double n, Rectangle r) //операция -
        {
            return new Rectangle(n - r.Length, n - r.Width);
        }

        public static Rectangle operator ++(Rectangle r) //операция ++
        {
            return new Rectangle(r.Length + 1, r.Width + 1);
        }
        public static Rectangle operator --(Rectangle r) //операция --
        {
            return new Rectangle(r.Length - 1, r.Width - 1);
        }

        public static explicit operator double(Rectangle r) //явная операция приведения типа - площадь окружности
        {
            return r.AreaCircle;
        }

        public static implicit operator bool(Rectangle r) //неявная операция приведения типа - является ли прямоугольник квадратом?
        {
            return r.IsSqrt;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Rectangle)) return false;
            Rectangle rec = (Rectangle)obj;
            return this.Length == rec.Length && this.Width == rec.Width;
        }


    }
}
