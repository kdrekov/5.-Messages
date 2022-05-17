using System;

namespace _5._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string message;
            string[] ArrayMessage = new string[n];
            for (int i = 0; i < n; i++)
            {
                ArrayMessage[i] = Console.ReadLine();
            }
            int[,] code = new int[3, n];

            for (int i = 0; i < n; i++)
            {
                string a = ArrayMessage[i].ToString();
                code[0, i] = int.Parse(a) % 10;
                code[1, i] = a.Length;
                if (code[0, i] == 0)
                {
                    code[2, i] = 32;
                }
                else if (code[0, i] > 1 && code[0, i] < 7)
                {
                    code[2, i] = (code[0, i] - 2) * 3 + code[1, i] + 96;
                }
                else if (code[0, i] == 7)
                {
                    code[2, i] = 111 + code[1, i];
                }
                else if (code[0, i] == 8)
                {
                    code[2, i] = 115 + code[1, i];
                }
                else if (code[0, i] == 9)
                {
                    code[2, i] = 118 + code[1, i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(Char.ConvertFromUtf32(code[2, i]));
                
            }
            Console.WriteLine();
            Math.Ceiling(5.58);

        }
    }
}
