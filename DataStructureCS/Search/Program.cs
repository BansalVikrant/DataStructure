using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    class Program
    {
        const int MAXLEN = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements");
            int intLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter sorted array");
            int[] answer = new int[MAXLEN];
            for (int i = 0; i < intLength; i++)
            {
                answer[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
