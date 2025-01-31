public sealed class SingletonThreadSafe
{
    private static SingletonThreadSafe Instance = null;
    private static int Counter = 0;

    private SingletonThreadSafe()
    {
        Counter++;
        Console.WriteLine("Counter: " + Counter);
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
                Instance = new SingletonThreadSafe();
                return Instance;
            }
        }
    }


    public void PrintDetails(string message)
    {
        Console.WriteLine(message);
    }
}

