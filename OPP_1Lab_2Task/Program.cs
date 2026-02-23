using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Введіть НЕнульове ціле число k: ");
        int k = int.Parse(Console.ReadLine());

        Console.Write($"Введіть початковий масив: ");
        int[] sourceArray = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);

        Func<int,bool> isMultiple = n => n % k == 0;

        int[] resultLinq = sourceArray.Where(isMultiple).ToArray();
        Console.WriteLine($"Спосіб через Where: {string.Join(", ", resultLinq)}");

        int[] resultManual = Service.FilterManual(sourceArray, isMultiple);
        Console.WriteLine($"Власний спосіб:     {string.Join(", ", resultManual)}");
    }
}
