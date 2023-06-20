namespace Fiap1Fundamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor, dolar = 4.78;

            Console.Write("Digite o valor de dólar que quer converter para real: ");
            valor = Convert.ToDouble(Console.ReadLine());

            double calcularValor = dolar * valor;

            Console.WriteLine($"O valor digitado foi {valor} e convertido em real fica: ${calcularValor}");

        }
    }
}