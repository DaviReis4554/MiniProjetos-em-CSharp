using System;
using System.Collections.Generic;
using System.IO;

class Teste {
  static void Main() {
    // Registrando uma nova entrada
    string registroEntrada = "registro.txt";
    
    //DateTime.Now pega a data e hora atual e o .ToString() formata para hora, minuto e segundo, como string
    string registroHora = DateTime.Now.ToString("HH:mm:ss");
    
    //File.AppendAllText adiciona no final .txt o novo registro (cria o arquivo se não existir)
    File.AppendAllText(registroEntrada, $"[{registroHora}] Aplicativo foi inicializado.\n");
    
    Console.WriteLine("Aplicativo inicializado.\n");
    
    Console.WriteLine("Registro de Inicialização:");
    
    // Cria um leitor para ler o arquivo linha por linha
    using StreamReader reader = new StreamReader(registroEntrada);
    string linha;
    
    //Enquanto ReadLine() retornar uma linha válida, ele lê e exibe na tela/console
    while ((linha = reader.ReadLine()) != null)
    {
        Console.WriteLine(linha);
    }
    
    //Conta quantas vezes o programa foi inicializado lendo todas as linhas do .txt
    string[] todasLinhas = File.ReadAllLines(registroEntrada);
    Console.WriteLine($"\nPrograma foi inicializado: {todasLinhas.Length} vezes");
  }
}