using System;

class Program
{
    static void Main()
    {
        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            if (letter == 'e' || letter == 'q')
            {
                Console.Write("");
            }

            else
            {
                Console.Write(letter + "");
            }
        }
    }
}
