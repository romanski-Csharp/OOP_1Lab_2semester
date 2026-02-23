class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Func<double, double>[] functions = new Func<double, double>[]
        {
                x => Math.Sqrt(Math.Abs(x)),
                x => Math.Pow(x, 3),
                x => x + 3.5
        };

        Console.WriteLine("Вводьте рядки послідовно один за одним.");
        Console.WriteLine("Формат: <індекс_функції> <число> (наприклад, '1 5')");
        Console.WriteLine("Доступні функції: \n0 - sqrt(|x|), \n1 - x^3, \n2 - x + 3,5");
        Console.WriteLine("Будь-яке інше введення завершить програму. \n");

        try
        {
            while (true)
            {
                string[] parts = Console.ReadLine().Trim().Split();

                int index = int.Parse(parts[0]);
                double x = double.Parse(parts[1]);


                Console.WriteLine(functions[index](x));
            }
        }
        catch (Exception)
        {
            Console.WriteLine("\nРоботу завершено (виникло виключення)");
            Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}