
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite a palavra : ");
        string entrada1 = Console.ReadLine();
           
            for (int i = 0; i < entrada1.Length; i++)
            {
            	Console.WriteLine(entrada1[i]);
            }
        

        // Wait for user to press a key before exiting
        Console.Write("Press any key to continue . . . ");
        Console.ReadKey(true);
    }
}
