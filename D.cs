using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int numero;

      
        if (int.TryParse(Console.ReadLine(), out numero))
        {
            int soma = 0;
            
         
            for (int i = 1; i <= numero; i++)
            {
                soma += i;
            }

            
            Console.WriteLine("A soma dos números de 1 até " + numero + " é: " + soma);
        }
        else
        {
           
            Console.WriteLine("Erro: digite um número inteiro.");
        }

    
        Console.Write("Press any key to continue . . . ");
        Console.ReadKey(true);
    }
}
