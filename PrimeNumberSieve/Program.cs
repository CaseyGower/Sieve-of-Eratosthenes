using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberSieve
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get input from User
            int min;
            int max;
            string response;
            //Get Min

            do
            {
                Console.Write("Min: ");
                 response = Console.ReadLine();
            }
            while (!int.TryParse(response, out min));
            // int min = int.Parse(Console.ReadLine());



            //Get Max
            do
            {
                Console.Write("Max: ");
                 response = Console.ReadLine();
            }
            while (!int.TryParse(response, out max));
            Console.WriteLine();

            if (min > max)
            {
                Console.WriteLine("Min must be smaller then Max");
                return;
            }

            //Enter Prime Number Seive
            bool[] boolArray = new bool[max];
          //  int[] primeNumberArray = new int[];
            List<int> primes = new List<int>();
            for( int i=0; i < max; i++)
            {
                boolArray[i] = true;

            }

            boolArray[0] = false;
            boolArray[1] = false;

            for(int i=2; i<max; i++)
            {
                if (boolArray[i] == true ) 
                {
                    int a = 0;
                    primes.Add(a);
                   // primeNumberArray[a] = i;
                    a++;

                    for (int j = i ^ 2; j<max; j = i^2 + i)
                    {
                        boolArray[j] = false;
                    }
                }
            }

           foreach(var listItem in primes)
            {
                Console.WriteLine(listItem);
            }

            Console.ReadKey();


        }
       
    }
}
