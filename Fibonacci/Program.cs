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

        double[] vet = new double[value];

        if (value == 1)
        {
            vet[0] = 1;
            Console.WriteLine(vet[value - 1] + ".");
        }
        else if(value == 2)
        {
            vet[0] = 1;
            vet[1] = 1;
            for (int i = 0; i < (value - 1); i++)
            {
                Console.Write(vet[i] + ", ");
            }
            Console.WriteLine(vet[value - 1] + ".");
        }
        else
        {
            vet[0] = 1;
            vet[1] = 1;
            for (int i = 0; i < (value - 2); i++)
            {
                vet[i + 2] = vet[i] + vet[i + 1];
            }

            for (int i = 0; i < (value - 1); i++)
            {
                Console.Write(vet[i] + ", ");
            }
            Console.Write(vet[value - 1] + ".");
            Console.WriteLine();
        }
    }
}