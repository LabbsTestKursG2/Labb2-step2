using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2TestKurs
{
    public class Solution
    {


        public string StrCount(string str)
        {
            return str;
        }

        public string StrType(string strType)
        {
            return strType;
        }

        public int NextPalindrome(int value)
        {

            int result = 0;
            bool found = false;

            while (!found)
            {
                value++;
                found = IsPalindrome(value);
                if (found)
                    result = value;
            }

            return result;
        }
       

        public List<int> NextPrime(int number = 11)
        {
            List<int> list = new List<int>();
            while (list.Count<3)
            { 
             
                bool isPrime = true;
             
                number = number + 1;

                int squaredNumber = (int)Math.Sqrt(number);

               
                for (int i = 2; i <= squaredNumber; i++)
                {
               
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    list.Add(number);
            }
            foreach (var item in list)
            Console.WriteLine(item);

            return (list);
        }

        public bool IsPalindrome(int number)
        {

            string numberString = number.ToString();
            int backIndex;

            bool same = true;
            for (int i = 0; i < numberString.Length; i++)
            {
                backIndex = numberString.Length - (i + 1);
                if (i == backIndex || backIndex < i)
                    break;
                else
                {
                    if (numberString[i] != numberString[backIndex])
                    {
                        same = false;
                        break;
                    }
                }
            }

            return same;
        }
    }
}
