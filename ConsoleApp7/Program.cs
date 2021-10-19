using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете брой елементи за масива: ");
            int a = int.Parse(Console.ReadLine());

            int br = 0; 
            int [] A = new int[a];
            int [] B = new int[a];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
                if (A[i] < 0)
                {
                    B[br] = A[i];
                    br++;
                }
            }
            for (int j = br - 1; j >= 0; j--)
            {
                Console.WriteLine(B[j]);
            }

        }
    }
}
