public sealed class Singleton
{
    private static int Counter = 0;

    private Singleton()
    {
        Counter++;
        Console.WriteLine("No of Object Created: " + Counter);
    }
    private static Singleton? Instance = null;
    
    
    public static Singleton GetInstance
    {
        get
        {
            if (Instance != null)
            {
                return Instance;
            }
            else
            {
                Instance = new Singleton();
                return Instance;
            }
        }
    }

    public void PrintDetails(string message)
    {
        Console.WriteLine(message);
    }
}

