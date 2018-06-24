using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_VectorDistanceCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            // these are all to sample the program using all three methods
            Console.WriteLine("Please type a string that consists of uppercase letters only");
            string input = Console.ReadLine();
            Console.WriteLine(Encryption1(input));
            Console.WriteLine(Encryption2(input));
            Console.WriteLine(Encryption3(input));
            Console.ReadLine();
        }

        public static string Encryption1(string input)
        {
            input = input.ToUpper();
            StringBuilder result = new StringBuilder();
            foreach (char letter in input)
            {
                int temporary = (int)letter;
                temporary += 3;

                if (temporary > 90)
                {
                    temporary -= 26;
                }

                result.Insert(result.Length, (char)temporary);
            }
            return result.ToString();
        }

        public static string Encryption2(string input)
        {
            int index = input.Length;

            
            string cipher = "RAT";
            input = input.ToUpper();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                int temporary = (int)input[i];             
                temporary += (int)cipher[i % cipher.Length] - 60;
                if (temporary > 90)
                {
                    temporary -= 26;
                }
                result.Insert(result.Length, (char)temporary);
            }
            return result.ToString();
        }
        public static string Encryption3(string input)
        {
            int index = input.Length;
            input = input.ToUpper();

            
            string cipher = "RAT" + input;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                int temp = (int)input[i];
                temp += (int)cipher[i % cipher.Length] - 60;
                if (temp > 90)
                {
                    temp -= 26;
                }
                result.Insert(result.Length, (char)temp);
            }
            return result.ToString();
        }
    }
}
