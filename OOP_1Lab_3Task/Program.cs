class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        double eps = 0.0001;

        double result1 = Service.CalculateSum(n => 1.0 / Math.Pow(2, n), eps);
        Console.WriteLine($"Сума ряду 1 / 2^n: {result1}");

        double result2 = Service.CalculateSum(n => 1 / Service.Factorial(n + 1), eps);
        Console.WriteLine($"Сума ряду 1 / (n + 1)!: {result2}");

        double result3 = Service.CalculateSum(n => Math.Pow(-1, n + 1) / Math.Pow(2, n), eps);
        Console.WriteLine($"Сума ряду -1^(n + 1) / 2^n: {result3}");
    }
}
