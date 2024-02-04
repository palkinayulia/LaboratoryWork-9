using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__9
{
    public class RectangleArray
    {
        Rectangle[] array;

        static Random rnd = new Random();
        public int Length
        {
            get => array.Length;
        }

        public RectangleArray(int length) //конструктор с параметром
        {
            array = new Rectangle[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = new Rectangle(rnd.Next(100), rnd.Next(100));
            }
        }

        public RectangleArray() //конструктор без параметров
        {
            array = new Rectangle[0];
        }

        public void Show()
        {
            if (array.Length ==0) Console.WriteLine("элементов нет");
            for (int i = 0; i < array.Length; i++)
            {
                array[i].ShowRec();
            }
        }

        public RectangleArray(RectangleArray other) //конструктор копирования объекта(глубокое копирование)
        {
            this.array = new Rectangle[other.Length];
            for(int i = 0;i < other.Length;i++)
                this.array[i] = new Rectangle(other.array[i]);
        }

        public Rectangle this[int index]
        {
            get
            {
                if (0 <= index && index < array.Length)
                    return array[index];
                else throw new Exception("Индекс выходит за пределы коллекции");
            }
            set
            {
                if (0 <= index && index < array.Length)
                    array[index] = value;
                else Console.WriteLine("Индекс выходит за пределы коллекции");
            }
        }
    }
}
