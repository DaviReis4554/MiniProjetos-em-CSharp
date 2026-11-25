using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("============================================");
        Console.WriteLine("||    SOMADORA DE APENAS DOIS NÚMEROS     ||");
        Console.WriteLine("============================================");
        
        // Recebe a primeira entrada
        Console.WriteLine("Digite o primeiro número:");
        //Recebe o valor como string(texto)
        string n1Ler = Console.ReadLine();
        //Converte o texto para int(numero inteiro)
        decimal n1 = Convert.ToInt32(n1Ler);
        
        // Recebe a segunda entrada
        Console.WriteLine("Digite o segundo número:");
        //Recebe o valor como string(texto)
        string n2Ler = Console.ReadLine();
        //Converte o texto para int(numero inteiro)
        decimal n2 = Convert.ToInt32(n2Ler);
        
        Console.WriteLine("Somando...");
        
        //Faz a conta
        decimal resultado = n1 + n2;
        
        //Exibe o resultado da conta
        Console.WriteLine($"{n1} + {n2} é igual a {resultado}");
        
        
    }
}
