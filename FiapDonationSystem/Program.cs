namespace FiapDonationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bem vindo ao FIAP donation system! Digite as informações que serão requisitadas abaixo: ");

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu telefone: ");
            string telefone = Console.ReadLine();

            Console.WriteLine("Digite seu e-mail: ");
            string email = Console.ReadLine();

            Console.WriteLine("Digite sua senha: ");
            string senha = Console.ReadLine();

            Console.WriteLine("Digite seu apelido: ");
            string apelido = Console.ReadLine();

        }
    }
}