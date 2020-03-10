using System;

namespace ConsoleApp1
{
    class Program
    {
        /*Napisati program koji ispisuje tablicu množenja do broja 12*/
        static void Main(string[] args)
        {
            int i, j, k;
            for (i = 1; i <= 12; i++)
            {
                for (k = 1; k <= 12; k++)
                {
                    j = i * k;
                    Console.Write(i + "x" + k +"=" + j +" ");
                }
                Console.WriteLine(" ");
            }
           
            
        }
    }
}
