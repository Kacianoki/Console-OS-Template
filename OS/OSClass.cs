namespace OS
{
    public class MainClass : ConsoleOS
    {
        public override ConsoleOSInfo osinfo { get; } = new("My New Console OS");
        public static void Main()
        {
            Console.WriteLine("Boot...");
            Console.Beep();
        }

    }
}