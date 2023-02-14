using System;

namespace Interface14._02._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            IOutput obj = new Class();
            obj.Show();
            Console.WriteLine("\n");
            obj.Show_();

            IMath obj1 = new Class();
            obj1.Max();
            Console.WriteLine("\n");
            obj1.Min();
            Console.WriteLine("\n");
            obj1.Avg();
            Console.WriteLine("\n");

            ISort obj3 = new Class();
            obj3.SortAsc();
            Console.WriteLine("\n");
            obj3.SortDesc();




        }
    }
}
