using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int numero;
    
        if (int.TryParse(Console.ReadLine(), out numero))
        {
           
            for (int i = 0; i <= numero; i += 2)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
           
            Console.WriteLine("Erro: digite um número inteiro.");
        }

        // Wait for user to press a key before exiting
        Console.Write("Press any key to continue . . . ");
        Console.ReadKey(true);
    }
}
