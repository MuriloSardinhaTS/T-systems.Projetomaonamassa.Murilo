using System;
class Verificacao
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite sua idade para a verificacao: ");
        int idade = int.Parse(Console.ReadLine());
        if (idade < 18)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Você não tem permissão de idade!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OK, você tem a permissão de idade");
        }
        Console.ResetColor();
        Console.ReadKey();


    }
}
