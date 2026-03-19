using System.Security.Cryptography;

namespace JogoDosDados.ConsoleApp;

/*



*/


class Program
{
    static void Main(string[] args)
    {
        const int limiteLinhaChegada = 30;

        while (true)
        {
            int posicaoDoJogador = 0;
            bool jogoEstaEmAndamento = true;

            while (jogoEstaEmAndamento)
            {
                Console.Clear();
                Console.WriteLine("=========================");
                Console.WriteLine("Jogo dos Dados");
                Console.WriteLine("=========================");

                //Lógica do Jogo 
                Console.Write("Pressione enter para lançar um dado...");
                Console.ReadLine();

                int resultado = RandomNumberGenerator.GetInt32(1, 7);

                Console.WriteLine("=========================");
                Console.WriteLine($"O número sorteado foi: {resultado}");
                Console.WriteLine("=========================");

                posicaoDoJogador += resultado;

                if (posicaoDoJogador < limiteLinhaChegada)
                    Console.WriteLine($"Você está na posicão: {posicaoDoJogador} de {limiteLinhaChegada}");
                else
                    {
                        Console.WriteLine("Parábens você alcançou a linha de chegada");
                        jogoEstaEmAndamento = false;
                    }

                    Console.Write("Pressione enter para continuar...");
                    Console.ReadLine();
                
            }

            //Controle de Saída do User
            Console.Write("Deseeja Continuar? (s/N): ");
            string? opcaoContinuar = Console.ReadLine()?.ToUpper();

            if (opcaoContinuar != "S")
                break;


        }
    }
}
