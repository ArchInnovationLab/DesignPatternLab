internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Simple Singleton Demo");
        SimpleSingletonDemo.SingleThread();    
        // UseSimpleSingleton.NoThreadSafety();

        System.Console.WriteLine("Singleton - Thread Safety Demo");
        ThreadSafeDemo.ThreadSafe();
        
    }

    
}