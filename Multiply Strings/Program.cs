using System;
using System.Text;

namespace Multiply_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = "389";
            var num2 = "97";
            Console.WriteLine(Multiply(num1,num2));
        }

        static string Multiply(string num1, string num2)
        {
            int m = num1.Length, n = num2.Length;
            int[] res = new int[m + n];
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = m - 1; j >= 0; j--)
                {
                    int multiply = (num1[j] - '0') * (num2[i] - '0');
                    int sum = multiply + res[i + j + 1];
                    res[i + j] += sum / 10;
                    res[i + j + 1] = sum % 10;
                }
            }

            StringBuilder sb = new StringBuilder();
            foreach(int i in res)
            {
                if (sb.Length > 0 || i != 0) sb.Append(i);
            }
            return sb.ToString();
        }
    }
}