using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 98; i++)

                {
                    string hex = i.ToString("x");
                    Console.Write(i + " = " + "0x"+hex + "\n");
                }

        }
    }
}
