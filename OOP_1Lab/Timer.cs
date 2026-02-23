public class Timer
{
    private readonly Action action;
    private readonly int interval;

    public Timer(Action action, int seconds)
    {
        this.action = action;
        interval = seconds;
    }

    public void StartSimple()
    {
        Console.WriteLine("Запуск простого таймера (блокуючий режим)");
        while (true)
        {
            action.Invoke();
            Thread.Sleep(interval * 1000);
        }
    }

    public void StartThreaded()
    {
        Console.WriteLine("Запуск нового таймера в окремому потоці");
        Task.Run(() =>
        {
            while (true)
            {
                action.Invoke();
                Thread.Sleep(interval * 1000);
            }
        });
    }
}
