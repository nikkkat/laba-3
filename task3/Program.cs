using System;

namespace task3
{
    class Program3
    {
        public static void Main()
        {

            Console.WriteLine("введите дату: ");
            string s = Console.ReadLine();

            DateService.GetDay(s);

            Console.WriteLine("\nвведите день: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите месяц: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());

            DateService.GetDaysSpan(day, month, year);
        }
    }
}