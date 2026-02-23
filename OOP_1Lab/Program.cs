using System.Text;

class Program
{
    static void MyMethod() => Console.WriteLine($"Таймер №{Thread.CurrentThread.ManagedThreadId} [{DateTime.Now:HH:mm:ss}]");
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; 
        Timer timer = new Timer(MyMethod, 2); 

        //timer.StartSimple(); 

        timer.StartThreaded();
        timer.StartThreaded();
        timer.StartThreaded();

        Console.WriteLine("Головний потік вільний. Натисніть Enter для виходу...");
        Console.ReadLine();
    }
}