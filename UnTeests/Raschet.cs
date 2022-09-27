using System;
using System.Collections.Generic;
using System.Text;

namespace UnTeests
{
    public class Raschet
    {
            public double first;
            public double second;
            public string Variant;
            public string radius;
            public double pi = 3.14;
        public void Compute()
        { 
            Console.WriteLine("Для расчета периметра прямоугольника нажмите <1>...");
            Console.WriteLine("Для расчета радиуса круга нажмите <2>...");
            Variant = Console.ReadLine();
            switch (Variant)
            {
                case "1":
                    Console.WriteLine("Введите длину");
                    first = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите ширину");
                    second = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Периметр равен:" + (first + second) * 2);

                    break;

                case "2":
                    Console.WriteLine("Если известен диаметр окружности нажмите <1>...");
                    Console.WriteLine("Если известна длина окружности нажмите <2>...");
                    radius = Console.ReadLine();

                    switch (radius)
                    {
                        case "1":
                            Console.WriteLine("Введите диаметр");
                            first = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Радиус равен: " + first / 2);
                            break;

                        case "2":
                            Console.WriteLine("Введите длину");
                            first = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Радиус равен: " + first / (2 * pi));
                            break;

                        default:
                            Console.WriteLine("Выбран неизвестный вариант");
                            break;
                    }

                    break;

                default:
                    Console.WriteLine("Неизвестный вариант");
                    break;
            }
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
