public sealed class SingletonThreadSafe
{
    private static SingletonThreadSafe Instance = null;

    // Object to perform lock
    private static readonly object obj = new object();
    private static int Counter = 0;

    private SingletonThreadSafe()
    {
        Counter++;
        Console.WriteLine("No of Instance Created: " + Counter);
    }
    public static SingletonThreadSafe GetInstance
    {
        get
        {
            if (Instance != null)
            {
                return Instance;
            }
            else
            {
                lock (obj)
                {
                    if (Instance == null)
                    {
                        Instance = new SingletonThreadSafe();
                    }
                }

                return Instance;
            }
        }
    }


    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}

