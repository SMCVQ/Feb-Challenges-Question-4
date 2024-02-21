using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Feb_Challenges_Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive whole number: ");
            string input = Console.ReadLine();
            int NumberIn = 0;
            int PartValue = 0;
            int NumberOut = 0;
            int Count = 0;

            while (NumberIn > 0)
            {
                Count = Count++;
                PartValue = NumberIn % 2;
                NumberIn = NumberIn / 2;
                for (int i = 1; i < Count; i++)
                {
                    PartValue = PartValue * 10;
                }

                NumberOut = NumberOut + PartValue;
            }
            Console.WriteLine("The result is: ", NumberOut);
            Console.ReadLine();
        }
    }
}
