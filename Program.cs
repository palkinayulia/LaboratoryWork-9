namespace Лабораторная_работа__9
{
    public class Program
    {
        public static double AverageCircle(RectangleArray array) //функция для выполнения задания 3 части
        {
            double areaCircle;
            double sumAreas = 0;
            double averageCircle;
            for (int i = 0; i < array.Length; i++)
            {
                areaCircle = Math.PI * Math.Pow(Math.Sqrt(array[i].Width * array[i].Width * array[i].Length * array[i].Length) / 2, 2);
                sumAreas += areaCircle;
            }
            averageCircle = sumAreas / array.Length;
            return averageCircle;
        }
        static void Main(string[] args)
        {
            //часть 1
            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle(10, 20);
            Rectangle r3 = new Rectangle(r2);

            r1.ShowRec();
            r2.ShowRec();
            r3.ShowRec();

            //int n;
            //bool isConvert;
            //do
            //{
            //    Console.Write("Введите величину, на которую хотите увеличить стороны прямоугольника: ");
            //    string input = Console.ReadLine();
            //    isConvert = int.TryParse(input, out n);
            //    if (!isConvert || n < 0) Console.WriteLine("Неправильно введено число \nПопробуйте еще раз.");
            //} while (!isConvert || n < 0);
            ////r2.AddSize(10, 15, n);

            //bool isConvert;
            //int n;
            //do
            //{
            //    Console.Write("Введите величину, на которую хотите увеличить стороны прямоугольника: ");
            //    string input = Console.ReadLine();
            //    isConvert = int.TryParse(input, out n);
            //    if (!isConvert || n < 0) Console.WriteLine("Неправильно введено число \nПопробуйте еще раз.");
            //} while (!isConvert || n < 0);
            // Rectangle.AddSize(r3, n);

            Console.WriteLine($"Количество созданных объектов: {Rectangle.count} ");


            //часть 2
            double area = (double)r1;
            Console.WriteLine(area);
            bool check = r1;
            Console.WriteLine(check);

            r1 = r1 + 3.5;
            r1.ShowRec();

            r1++;
            r1.ShowRec();

            r1 = r1 - 2.5;
            r1.ShowRec();

            r1--;
            r1.ShowRec();

            //try
            //{
            //    r1.Length = -100;
            //} catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //часть 3
            RectangleArray arr = new RectangleArray(5);
            arr.Show();


            double average = AverageCircle(arr);
            Console.WriteLine($"среднее арифметическое площадей описанных около прямоугольников окружностей: {average:f4}");

            RectangleArray arr2 = new RectangleArray(arr);
            arr2.Show();

            arr[0] = new Rectangle(10, 234);
            arr.Show();

            RectangleArray arr3 = new RectangleArray();
            arr3.Show();

            //try
            //{
            //    arr2[100] = new Rectangle(10, 14);
            //    arr2.Show();
            //} catch (Exception ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}

        }
    }
}
