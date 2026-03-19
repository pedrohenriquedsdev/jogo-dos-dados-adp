using System.Security.Cryptography;

namespace JogoDosDados.ConsoleApp;

/*



*/


class Program
{
    static void Main(string[] args)
    {
        while (true)
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

            //Controle de Saída do User
            Console.Write("Deseeja Continuar? (s/N): ");
            string? opcaoContinuar = Console.ReadLine()?.ToUpper();

            if (opcaoContinuar != "S")
                break;


        }
    }
}
