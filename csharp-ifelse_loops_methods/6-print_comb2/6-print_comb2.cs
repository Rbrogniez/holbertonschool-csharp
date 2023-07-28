using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            for (i = 0; i<=7 ; i++)
            {
                for (j = i ; j<=9 ; j++)
                {
                    string number = i.ToString() + j.ToString();
                    if (i != j)
                        Console.Write(number + ", ");
                }
            }
            Console.Write((i).ToString() + (j-1).ToString() + "\n");
        }
    }
}
