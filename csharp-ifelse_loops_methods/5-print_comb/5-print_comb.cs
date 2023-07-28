using System;
using System.Collections.Generic;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i<99; i++)
                {
                    Console.Write(i.ToString("D2") + ", ");
                }
            Console.Write(i.ToString("D2") + "\n");
        }

    }
}
