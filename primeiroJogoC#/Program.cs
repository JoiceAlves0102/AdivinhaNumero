Console.WriteLine("Bem vindo ao Jogo de adivinhação de números, sua tarefa é escolher um número entre 1 e 10");


Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 10);

do
{
    Console.WriteLine("Digite o número escolhido");
    int numeroEscolhido = int.Parse(Console.ReadLine()!);

    if (numeroEscolhido == numeroSecreto)
    {
        Console.WriteLine("Parabéns você acertou o número secreto");
        break;
    }
    else if (numeroEscolhido < numeroSecreto)
    {
        Console.WriteLine("O número que você escolheu é menor que o número secreto");
    }
    else
    {
        Console.WriteLine("O número que você escolheu é maior que o número secreto");
    }
} while (true);

Console.WriteLine("\nO jogo acabou. Você acertou o número secreto :) ");