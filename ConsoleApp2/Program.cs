using System;
using System.IO;

internal class Program
{
    /// <summary>
    /// Procedura główna aplikacji
    /// </summary>
    /// <param name="args"> Parametry wejściowe w postaci tablicy tekstowej </param>
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Patryk!");
        Kielbasa();

        Console.ReadLine();
    }

    /// <summary>
    /// 
    /// </summary>
    private static void Kielbasa()
    {
        Console.WriteLine($"Kielbasa");
        // TextReader tr = File.OpenText("D:\\Studia\\Programowanie\\program-start\\README.md");
        // Console.WriteLine(tr.ReadToEnd());
    }

}