// See https://aka.ms/new-console-template for more information
using FluentColorConsole;

Menu();


static void Menu()
{

    TextoMenu();
    short res = short.Parse(Console.ReadLine());

    while (res <= 4 && res >= 1)
    {
        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());
        switch (res)
        {
            case 1:
                Soma(v1, v2);
                break;
            case 2:
                Subtracao(v1, v2);
                break;
            case 3:
                Multiplicacao(v1, v2);
                break;
            case 4:
                Divisao(v1, v2);
                break;
            default:
                break;
        }
        Console.ReadKey();
        TextoMenu();
        res = short.Parse(Console.ReadLine());
    }
}

static void TextoMenu()
{
    Console.Clear();
    var calculadoraText = ColorConsole.WithBlueText;
    calculadoraText.WriteLine("Calculadora");
    Console.WriteLine("Menu");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtracao");
    Console.WriteLine("3 - Multiplicacao");
    Console.WriteLine("4 - Divisao");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("----------");
    Console.WriteLine("Selecione uma opcao:");
}

static void Soma(float v1, float v2)
{
    Console.WriteLine("\nSoma:");
    Console.WriteLine($"{v1} + {v2} = {v1 + v2}");
}

static void Subtracao(float v1, float v2)
{
    Console.WriteLine("\nSubtracao:");
    Console.WriteLine($"{v1} - {v2} = {v1 - v2}");
}

static void Multiplicacao(float v1, float v2)
{
    Console.WriteLine("\nMultiplicacao:");
    Console.WriteLine($"{v1} * {v2} = {v1 * v2}");
}

static void Divisao(float v1, float v2)
{
    Console.WriteLine("\nDivisao:");
    if (v2 != 0)
        Console.WriteLine($"{v1} / {v2} = {v1 / v2}");
    else Console.WriteLine("Nao e possivel realizar divisao por zero!");
}