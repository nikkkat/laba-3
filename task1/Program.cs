// вариант 3

using System;

namespace task1
{
    class Program1
    {
        public static void Main()
        {
            bool t = true;
            while (t)
            {
                Console.WriteLine("введите число a для вычисление значения по формуле f(x)=x-sinx : ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("введите число b: ");
                double b = Convert.ToDouble(Console.ReadLine());

                double aa1 = Class1.foo(a);
                double bb1 = Class1.foo(b);

                if (aa1 == bb1) { Console.WriteLine("\nзначения равны"); }
                else if (aa1 > bb1) { Console.WriteLine("\nзначение функции в точке a больше"); }
                else { Console.WriteLine("\nзначение функции в точке b больше"); }

                Console.WriteLine("\nвведите 1, если хотите проверить другие числа\nлюбое другое число - выход :");
                int d = Convert.ToInt32(Console.ReadLine());

                if (d == 1) { t = true; }
                else { t = false; }
            }
        }
    }

}
