using System;

namespace Taks2
{
    internal class Program
    {
        static void Add(ref int[] arr, int num)
        {
            int[] arr2 = new int[arr.Length + 1];
            arr2[arr.Length] = num;
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }
            arr = arr2;
        }

        static void DeleteSpaces(ref string str)
        {
            string str2 = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    str2 += str[i];
                }
            }
            str = str2;
        }

        static void CloseSQRT(ref int num)
        {
            for (int i = 0; i < num; i++)
            {
                if (i * i > num)
                {
                    num = i - 1;
                    break;
                }
            }
        }

        static void ChangePos(ref int num)
        {
            int count = 1;
            int num2 = num;
            while (num2 != 0)
            {
                num2 /= 10;
                count *= 10;
            }
            int a = num % 10;
            num = a * count / 10 + num / 10;

        }

        static void Main(string[] args)
        {
            
        }
    }
}
