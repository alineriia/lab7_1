using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lab7
{
    class lab7_1
    {
        public static void Main()
        {
            List <Char> symbols = new List <Char> ();
            string line, file = "text.txt";
            using (StreamReader MyFile = new StreamReader(file))
            {
                while ((line = MyFile.ReadLine()) != null)
                {
                    foreach (Char c in line)
                        symbols.Add(c);
                    symbols.Add('\n');
                }
            }

            int l = 0, r = 0;
            for (int i = 0; i != symbols.Count; i++)
            {
                Console.Write(symbols[i]);
                if (symbols[i] == '(')
                {
                    l++;
                }
                else
                {
                    if (symbols[i] == ')')
                    {
                        r++;
                    }
                }
            }

            Console.Write("Result: ");
            if (l == r)
            {
                Console.WriteLine("Balance");
            }
            else if (l > r)
            {
                Console.WriteLine("Correct mistakes");
            }
            else
            {
                Console.WriteLine("Correct mistakes");
            }
            Console.ReadKey();

        }
    }
}
