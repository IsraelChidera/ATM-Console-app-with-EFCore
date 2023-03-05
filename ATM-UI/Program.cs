using ATM.UI;

namespace ATM_UI
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Application application = new();
            await application.Run();
        }
    }
}