using System.Text;

class Program
{
    static void MyMethod() => Console.WriteLine($"Таймер №{Thread.CurrentThread.ManagedThreadId} [{DateTime.Now:HH:mm:ss}]");
    static void NewMethod() => Console.Clear();
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; 
        Timer timer1 = new Timer(MyMethod, 2); 
        Timer timer2 = new Timer(NewMethod, 7);
        //timer1.StartSimple(); 

        timer1.StartThreaded();
        timer2.StartThreaded();

        Console.WriteLine("Головний потік вільний. Натисніть Enter для виходу...");
        Console.ReadLine();
    }
}