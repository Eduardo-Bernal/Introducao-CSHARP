namespace C__DEV2_Sem;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo(a) ao sistema.");
        // entrada de dados
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nOlá, {nome}! Voce tem {idade} anos.");

        if (idade < 18)
        {
            Console.WriteLine("Voce ainda é menor de idade.");
        }
        else
        {
            Console.WriteLine("Voce é maior de idade.");
        }

        //menu
        Console.WriteLine($"\nEscolha uma opção: ");
        Console.WriteLine("1- Ver a tabuada de um numero: ");
        Console.WriteLine("2- Contar ate um numero: ");
        Console.WriteLine("3- sequencia de fibonacci: ");
        Console.WriteLine("4- Sair");
        Console.Write("Digite a sua opção: ");

        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.Write("Escolha um número para ver a tabuada: ");
                int numeroTabuada = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nTabuada do {numeroTabuada}:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numeroTabuada} x {i} = {numeroTabuada * i}");
                }
                break;
            case 2:
                Console.WriteLine("Escolha um numero, para receber a contagem ate ele:");
                int numeroSequencia = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nSequencia do {numeroSequencia}:");
                for (int i = 1; i <= numeroSequencia; i++)
                {
                    Console.WriteLine(i);
                }
                break;
            case 3:
                Console.WriteLine("A seguir a sequência de Fibonacci:");
                int numAnterior = 0;
                int numAtual = 1;
                int numProximo = 0;

                while (numAnterior <= 2584)
                {
                    Console.WriteLine(numAnterior);
                    numProximo = numAnterior + numAtual;
                    numAnterior = numAtual;
                    numAtual = numProximo;
                }
                break;
            case 4:
                Console.WriteLine("Você saiu do menu");
                break;
            default:
                Console.WriteLine("opção invalida");
                break;
        }

    }
}
