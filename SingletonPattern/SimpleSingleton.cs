public sealed class SimpleSingleton
{
    private static int Counter = 0;

    private SimpleSingleton()
    {
        Counter++;
        Console.WriteLine("No of Instance Created: " + Counter);
    }
    private static SimpleSingleton Instance = null;
    
    
    public static SimpleSingleton GetInstance
    {
        get
        {
            if (Instance != null)
            {
                return Instance;
            }
            else
            {
                Instance = new SimpleSingleton();
                return Instance;
            }
        }
    }


    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    // class Derived : Singleton
    // {

    //     public void PrintDerivedDetails(string message)
    //     {
    //         Console.WriteLine(message);
    //     }
    // }
}

