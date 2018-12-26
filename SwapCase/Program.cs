using System;

namespace SwapCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "HackerRank.com presents \"Pythonist 2\".";
            var output = "";
            foreach (char letter in input)
            {
                if (char.IsLower(letter))
                {
                    output += char.ToUpper(letter);
                }
                else
                {
                    output +=  char.ToLower(letter);
                }


            }

            Console.WriteLine(output);
        }
    }
}
