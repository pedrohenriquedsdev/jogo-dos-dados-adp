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
            int posicaoDoComputador = 0;
            bool jogoEstaEmAndamento = true;

            while (jogoEstaEmAndamento)
            {

                //Lógica do Jogagor
                // Console.Clear();
                Console.WriteLine("=========================");
                Console.WriteLine("Jogo dos Dados");
                Console.WriteLine("=========================");
                Console.WriteLine("Rodada Do Jogador");
                Console.WriteLine("=========================");

                Console.Write("Pressione enter para lançar um dado...");
                Console.ReadLine();

                int resultadoDoJogador = RandomNumberGenerator.GetInt32(1, 7);

                Console.WriteLine("=========================");
                Console.WriteLine($"O número sorteado foi: {resultadoDoJogador}");
                Console.WriteLine("=========================");

                posicaoDoJogador += resultadoDoJogador;

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
                    Console.WriteLine($"PENALIDADE: Recuo de casas: {penalidadeDoRecuo} casas");
                    posicaoDoJogador -= penalidadeDoRecuo;
                    Console.WriteLine($"Nova Posicão: {posicaoDoJogador} de {limiteLinhaChegada}");
                }

                //CONFERIMOS A POSIÇÃO DO JOGADOR
                if (posicaoDoJogador >= limiteLinhaChegada)
                {
                    Console.WriteLine("Parábens você alcançou a linha de chegada");
                    jogoEstaEmAndamento = false;
                    Console.ReadLine();
                    continue;

                }

                Console.WriteLine();
                Console.Write("Pressione enter para continuar...");
                Console.ReadLine();


                //Implementação do Turno do Computador
                Console.WriteLine("=========================");
                Console.WriteLine("Rodada Do Computador");
                Console.WriteLine("=========================");

                int resultadoDoComputador = RandomNumberGenerator.GetInt32(1, 7);

                Console.WriteLine("=========================");
                Console.WriteLine($"O número sorteado foi: {resultadoDoComputador}");
                Console.WriteLine("=========================");

                posicaoDoComputador += resultadoDoComputador;

                Console.WriteLine($"Computador está na posicão: {posicaoDoComputador} de {limiteLinhaChegada}");

                if (posicaoDoComputador == 5 || posicaoDoComputador == 10 || posicaoDoComputador == 15 || posicaoDoComputador == 25)
                {
                    Console.WriteLine($"EVENTO: Avanço de casas extra: {bonusAvancoExtra} casas");
                    posicaoDoComputador += bonusAvancoExtra;
                    Console.WriteLine($"Nova Posicão: {posicaoDoComputador} de {limiteLinhaChegada}");
                }
                else if (posicaoDoComputador == 7 || posicaoDoComputador == 13 || posicaoDoComputador == 20)
                {
                    Console.WriteLine($"PENALIDADE: Recuo de casas: {penalidadeDoRecuo} casas");
                    posicaoDoComputador -= penalidadeDoRecuo;
                    Console.WriteLine($"Nova Posicão: {posicaoDoComputador} de {limiteLinhaChegada}");
                }

                //CONFERIMOS A POSIÇÃO DO JOGADOR
                if (posicaoDoComputador >= limiteLinhaChegada)
                {
                    Console.WriteLine("Que pena o computador alcançou a linha de chegada.");
                    jogoEstaEmAndamento = false;
                }

            }

            //Controle de Saída do User
            Console.Write("Deseeja Continuar? (s/N): ");
            string? opcaoContinuar = Console.ReadLine()?.ToUpper();

            if (opcaoContinuar != "S")
                break;


        }
    }
}
