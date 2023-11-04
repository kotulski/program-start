using System;
using System.IO;

internal class Program
{
    static int a = 0, b = 0;
    static string pobrana;
    /// <summary>
    /// Procedura główna aplikacji
    /// </summary>
    /// <param name="args"> Parametry wejściowe w postaci tablicy tekstowej </param>
    private static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę a: ");
        
        a = int.Parse(Console.ReadLine()!);

        Console.WriteLine(pobrana);

        Console.ReadLine();
    }

}