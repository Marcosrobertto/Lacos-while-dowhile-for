using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
        
        string repetir = "sim";
        while(repetir == "sim"){

            Console.WriteLine("Deseja ver a tabuada de qual número?");
            int resposta = int.Parse(Console.ReadLine());

            int resultado;

            for (int contador = 0; contador <= 10; contador++)
            { 
                
                resultado = resposta * contador;
                Console.WriteLine($"{resposta} * {contador} = {resultado}");

            }

            Console.WriteLine("Deseja repetir a consulta ?");
            repetir = Console.ReadLine();


            if(repetir != "sim"){
                Console.WriteLine("Obrigado");
            }
        }



            // do
            // {
            //     // Executado pelo menos uma vezes
            //     Console.WriteLine("Bom dia");

            //     Console.WriteLine("Ainda deseja reseber bom dia? ");

            //     numeroDeVezes++;

            //     resposta = Console.ReadLine();

            // } while(resposta == "Sim");




            // while(resposta == "Sim") {
            //     // Executado quando condição é verdadeira
            //     Console.WriteLine("Bom dia!");

            //     // numeroDeVezes = numeroDeVezes + 1;
            //     numeroDeVezes++;


            //     Console.WriteLine("Ainda deseja receber um bom dia? ");
            //     resposta = Console.ReadLine();
            // }

            // Console.WriteLine($"Numero de vezes: {numeroDeVezes}");
            // Console.WriteLine("Fim do programa");
        }
    }
}
