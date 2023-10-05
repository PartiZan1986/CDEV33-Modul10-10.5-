using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Веедите первое число: ");
                var a = double.Parse(Console.ReadLine());

                Console.WriteLine("Веедите второе число: ");
                var b = double.Parse(Console.ReadLine());


                Count count = new Count();

                double c = count.Sum(a, b);
                Console.WriteLine("Сумма равна: {0}", c);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }
    }
    public interface ISum
    {
        double Sum(double numberOne, double numberTwo);
    }

    public class Count : ISum
    {
        public double Sum(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
