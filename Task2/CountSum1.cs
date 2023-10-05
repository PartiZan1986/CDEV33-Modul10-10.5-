using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class CountSum1
    {
        public class Count : ISum
        {
            ILoger Loger { get; }

            public Count(ILoger loger)
            {
                Loger = loger;
            }

            public double Sum(double num1, double num2)
            {
                Loger.Event("Ответ: ");
                return num1 + num2;
            }
        }
    }
}
