using System;

class Program
{
    static void Main()
    {
     //Responsável por números aleatórios
     Random random = new Random();
     //Define o número aleatório entre 1 e 20
     int numeroSecreto = random.Next(1, 21);
     int maxTentativas = 5;
     int numeroTentativas = 0;
     bool venceu = false;
    
     Console.WriteLine("Eu estou pensando em um número entre 1 e 20");
     Console.WriteLine($"Você tem {maxTentativas} tentativas. BOA SORTE!");
    
     // Pergunta o "chute" do player
     while (numeroTentativas < maxTentativas)
     {
         //Adiciona 1 no numero de tentativas
         numeroTentativas++;
         Console.Write($"\nTentativa #{numeroTentativas}: ");
         //Converte o ReadLine para int
         int chute = Convert.ToInt32(Console.ReadLine());
    
         // Checa se acertou o número
         if (chute == numeroSecreto)
         {
             Console.WriteLine($"CORRETO! Você acertou em {numeroTentativas} tentativas.");
             venceu = true;
             //Se venceu, break o loop e encerra o programa
             break;
         }
         else if (chute < numeroSecreto)
         {
             Console.WriteLine("Muito baixo.");
         }
         else
         {
             Console.WriteLine("Muito alto.");
         }
     }
    
     // Caso se esgote o numero de tentativas
     if (!venceu)
     {
         Console.WriteLine($"\nQue droga! O número era {numeroSecreto}.");
     }
    }
}