internal class Program
{
    private static void Main(string[] args)
    {
        int value = 0;

        while (value <= 0)
        {
            Console.Write("Digite um valor qualquer MAIOR do que 0: ");
            value = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (value <= 0)
            {
                Console.WriteLine("Você digitou um valor inválido. Por favor, pressione ENTER para digitar um novo valor");
                Console.ReadKey();
                Console.Clear();
            }
        }

        double anterior = 0;
        double atual = 1;
        double proximo = 1;

        for (int i = 0; i < value; i++)
        {
            Console.Write(atual + " ");
            atual = proximo + anterior;
            anterior = proximo;
            proximo = atual;
        }
        Console.WriteLine();
    }
}