using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("============================================");
        Console.WriteLine("||  CONVERSOR DE FAHRENHEIT PARA CELSIUS  ||");
        Console.WriteLine("============================================");
        Console.WriteLine("Qual a temperatura?");
        string valorTemperaturaF = Console.ReadLine();
        decimal temperaturaF = Convert.ToInt32(valorTemperaturaF);
        
        decimal temperaturaC = (temperaturaF - 32) * 5 / 9;
        
        Console.WriteLine($"{temperaturaF}ºF = {temperaturaC}ºC");
        
    }
}
