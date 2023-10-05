using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task2.CountSum1;

namespace Task2
{
    internal class Program
    {
        static ILoger Loger { get; set; }

        static void Main(string[] args)
        {
            Loger loger = new Loger();

            try
            {
                Console.WriteLine("Веедите первое число: ");
                var a = double.Parse(Console.ReadLine());

                Console.WriteLine("Веедите второе число: ");
                var b = double.Parse(Console.ReadLine());


                Count count = new Count(loger);

                double c = count.Sum(a, b);
                Console.WriteLine("Сумма равна: {0}", c);
            }

            catch (Exception ex)
            {
                loger.Error("Ошибка:");
                

                Console.WriteLine(ex);

            }

            Console.ReadKey();
        }
    }
    public interface ILoger
    {
        void Event(string message);
        void Error(string message);
    }

    public class Loger : ILoger
    {
        public void Event(string message)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
        public void Error(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }
    }

    public interface ISum
    {
        double Sum(double numberOne, double numberTwo);
    }
}
