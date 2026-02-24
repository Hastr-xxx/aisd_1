using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace dz_aisd1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());

            int[] arr_1 = vvod();
            int[] Ans = new int[1];

            for (int i  = 0; i < k - 1; i++)
            {
                int[] arr_2 = vvod();

                Ans = metod(arr_1, arr_2);
                arr_1 = Ans;
            }

            for (int p = 0; p < Ans.Length; p++)
            {
                Console.Write($"{Ans[p]} ");
            }




            int[] metod(int[] arr1, int[] arr2)
            {
                int[] ans = new int[arr1.Length + arr2.Length];

                int ind1 = 0;
                int ind2 = 0;
                int indAns = 0;

                while (ind1 < arr1.Length && ind2 < arr2.Length)
                {
                    if (arr1[ind1] < arr2[ind2])
                    {
                        ans[indAns] = arr1[ind1];
                        ind1++;
                    }
                    else if (arr1[ind1] > arr2[ind2])
                    {
                        ans[indAns] = arr2[ind2];
                        ind2++;
                    }
                    else
                    {
                        ans[indAns] = arr1[ind1];
                        ind1++;
                        indAns++;
                        ans[indAns] = arr2[ind2];
                        ind2++;
                    }
                    indAns++;
                }

                while (ind1 < arr1.Length)
                {
                    ans[indAns] = arr1[ind1++];
                    indAns++;
                }

                while (ind2 < arr2.Length)
                {
                    ans[indAns] = arr2[ind2++];
                    indAns++;
                }

                return ans;
            }

            int[] vvod()
            {
                string[] numbers = Console.ReadLine().Split(' ');
                int[] arr = new int[numbers.Length];

                for (int j = 0; j < numbers.Length; j++)
                {
                    arr[j] = int.Parse(numbers[j]);
                }
                return arr;
            }

            
        }
    }
}
