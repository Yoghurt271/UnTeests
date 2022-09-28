using System;
using System.Collections.Generic;
using System.Text;

namespace UnTeests
{
    public class Raschet
    {
            public double first;
            public double second;
            public double result;
            public double pi = 3.14;
        public void Perim()
        { 
            Console.WriteLine("Для расчет периметра прямоугольника");
            Console.WriteLine("Введите длину");
            first = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину");
            second = Double.Parse(Console.ReadLine());
            result = (first + second) * 2;
            Console.WriteLine("Периметр равен:" + result);

        }
        public void Diam()
        {
            Console.WriteLine("\nДля расчета радиуса круга по длине окружности");
            Console.WriteLine("Введите длину");
            first = Double.Parse(Console.ReadLine());
            result = first / (2 * pi);
            Console.WriteLine("Радиус равен: " + result);
            Console.ReadKey();
        }

    }
}
