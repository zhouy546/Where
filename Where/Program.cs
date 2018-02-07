using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Where
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 1, 4, 7, 10, 12, 1, 3 };
            var lowNum = from num in numbers
                         where num < 5
                         select num;
            Console.WriteLine("the number smaller than 5");
            foreach (var num in lowNum)
            {
                Console.WriteLine(num);
            }

            var lowOddNum = from num in numbers
                            where num < 7 && num % 2 == 1
                            select num;
            Console.WriteLine("the odd number smaller than 5");
            foreach (var num in lowOddNum)
            {
                Console.WriteLine(num);
            }

            var booleanGroupQuery =
                from num in numbers
                group num by numbers.Average() >= 1;

            foreach (var item in booleanGroupQuery)
            {
                Console.WriteLine(item.Key == true ? "High averages" : "Low averages");
            }
        }
    }
}
