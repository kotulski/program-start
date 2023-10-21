internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Patryk!");
        int wynik = Dodawanie();
        Console.WriteLine(wynik);
    }

    private static Int16 Dodawanie()
    {
        return 2 + 3;
    }
}