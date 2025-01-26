using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPZ.src
{
    internal class Utils
    {
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static int AddNumbers(int a, int b) => a + b;
        public static int MultiplyNumbers(int a, int b) => a * b;

        public static int SubNumbers(int a, int b) => a - b;
        public static int SubNumbersX2(int a, int b) => a*2 - b*2;

    }
}
