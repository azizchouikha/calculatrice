using calculatrice;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entrez deux nombres séparés par une virgule:");
        string input = Console.ReadLine();

        StringCalculator calculator = new StringCalculator();
        int result = calculator.Add(input);

        Console.WriteLine($"Le résultat est: {result}");
    }
}

