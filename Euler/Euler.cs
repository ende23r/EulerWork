using System;
using System.Collections.Generic;
using System.Text;

namespace Euler
{
    /* Class for integers of arbitrary size */
    class ArbInt
    {
        private List<int> pieces;
        private static int digits_per_int = 9;

        public ArbInt()
        {
            pieces = new List<int>();
            pieces.Add(0);
        }

        public ArbInt(int i)
        {
            pieces = new List<int>();
            pieces.Add(i);
        }

        public ArbInt(String s)
        {
            pieces = new List<int>();
            int i, temp;
            for(i=s.Length-digits_per_int; i > 0; i -= digits_per_int)
            {
                if (Int32.TryParse(s.Substring(i, digits_per_int), out temp))
                {
                    pieces.Add(temp);
                }
                else
                {
                    Console.WriteLine("Error parsing string to int!");
                    return;
                }
            }

            if (Int32.TryParse(s.Substring(0, digits_per_int + i), out temp))
            {
                pieces.Add(temp);
            }
            else
            {
                Console.WriteLine("Error parsing string to int!");
                return;
            }
        }

        public void add(int i)
        {

        }

        public void add(ArbInt ai)
        {

        }
    }

    class Euler
    {
        /* SOLVED! Add up all multiples of 3 and 5 less than 1000 */
        static int problem1()
        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        /* SOLVED! Add all even fibbonacci numbers less than or equal to 4 million. */
        static int problem2()
        {
            int prev = 1;
            int curr = 2;
            int sum = 0;

            while(curr < 4000000)
            {
                //Console.WriteLine(curr);
                if (curr%2 == 0)
                {
                    sum += curr;
                    
                }
                int temp = prev + curr;
                prev = curr;
                curr = temp;
            }
            return sum;
        }

        /* Finds the largest prime factor of 600,851,475,143 */
        // Square root is about 775147.
        static int problem3()
        {
            ArbInt prod = new ArbInt("600851475143");
            return 0;
        }

        static bool isPalindrome(string s)
        {
            int mid = s.Length / 2;
            for (int i=0; i < mid; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        /* SOLVED! Return the largest palindromic number that is a multiple of two three-digit numbers. */
        static int problem4()
        {
            int largest = 0;
            for (int i=800; i < 1000; i++)
            {
                for (int j=i; j < 1000; j++)
                {
                    int prod = i * j;
                    if( isPalindrome(string.Format("{0}", prod)) && (prod > largest) )
                    {
                        largest = prod;
                    }
                }
            }
            return largest;
        }

        /* Finds the smallest number that is evenly divisible by all the numbers 1 to 20 */
        static int problem5()
        {
            int tester = 20;

            bool found = false;
            while (!found)
            {
                tester++;
                found = true;
                for(int i=2; i<20; i++)
                {
                    if((tester % i) != 0)
                    {
                        found = false;
                        break;
                    }
                }
            }

            return tester;
        }

        static void Main(string[] args)
        {
            int result = problem5();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
 