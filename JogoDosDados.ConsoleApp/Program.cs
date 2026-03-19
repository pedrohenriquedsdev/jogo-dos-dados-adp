using System.Security.Cryptography;

namespace JogoDosDados.ConsoleApp;

/*



*/


class Program
{
    static void Main(string[] args)
    {
        const int limiteLinhaChegada = 30;
        const int bonusAvancoExtra = 3;
        const int penalidadeDoRecuo = 2;

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

                Console.WriteLine($"Você está na posicão: {posicaoDoJogador} de {limiteLinhaChegada}");

                //VALIDAMOS ALGUMAS BONIFICAÇÕES E PENALIDADAES   
                if (posicaoDoJogador == 5 || posicaoDoJogador == 10 || posicaoDoJogador == 15 || posicaoDoJogador == 25)
                {
                    Console.WriteLine($"EVENTO: Avanço de casas extra: {bonusAvancoExtra} casas");
                    posicaoDoJogador += bonusAvancoExtra;
                    Console.WriteLine($"Nova Posicão: {posicaoDoJogador} de {limiteLinhaChegada}");
                }
                else if (posicaoDoJogador == 7 || posicaoDoJogador == 13 || posicaoDoJogador == 20)
                {
                    Console.WriteLine($"PENALIDADE: Avanço de casas extra: {penalidadeDoRecuo} casas");
                    posicaoDoJogador -= penalidadeDoRecuo;
                    Console.WriteLine($"Nova Posicão: {posicaoDoJogador} de {limiteLinhaChegada}");
                }

                //CONFERIMOS A POSIÇÃO DO JOGADOR
                if (posicaoDoJogador >= limiteLinhaChegada)
                {
                    Console.WriteLine("Parábens você alcançou a linha de chegada");
                    jogoEstaEmAndamento = false;
                }

                Console.WriteLine();
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
