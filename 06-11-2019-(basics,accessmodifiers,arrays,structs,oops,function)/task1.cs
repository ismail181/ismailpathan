using System;

public class Programm
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 5 ; i++ )
        {
            for (int j = 1; j <= 5 ; j++ )
            {
                if (((i == 1 || i == 5) && (j>= 1) && (j <= 5)) || (i == j) )
                {
                    Console.Write("*"+" ");
                }
                else
                    Console.Write("  ");
            }
            Console.WriteLine();
        }
    }
}