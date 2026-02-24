using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace dz_aisd2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //наиб число из списка, вернуть строку

            string[] numbers = Console.ReadLine().Split(' ');

            for (int i = 0; i < numbers.Length - 1; i++)
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    string num1 = $"{numbers[j]}{numbers[j + 1]}";
                    string num2 = $"{numbers[j + 1]}{numbers[j]}";

                    if (string.Compare(num1, num2) < 0)
                    {
                        string m = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = m;
                    }
                }
            Console.WriteLine(string.Join("", numbers));
        }
    }
}
