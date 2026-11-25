using System;
class Teste {
  static void Main() {
    //Enquanto for True
    while (true)
    {
        //Exibir na tela "Digite 'exit' para parar o loop"
        Console.Write("Digite 'exit' para parar o loop: ");
        
        //Programa recebe a entrada do usuário
        string userInput = Console.ReadLine();
        
        //Transforma a entrada do usuario em toda minuscula
        //Compara se a entrada do usuario é igual a "exit"
        if (userInput.ToLower() == "exit")
        {
            //Caso a entrada seja "exit", ele dá break e encerra o loop
            break;
        }
        
        //Entrada do usuário diferente de "exit"
        //Mostra o que o usuario digitou, e continua o loop
        Console.WriteLine($"Você digitou: {userInput}");
    }
    
    //Após o break, ele sai do while e vem para cá
    Console.WriteLine("Adeus!");
    }
}