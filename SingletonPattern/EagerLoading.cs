public sealed class EagerLoading
{
    private static readonly EagerLoading Instance = new EagerLoading();

    private static int Counter = 0;

    private EagerLoading()
    {
        Counter++;
        Console.WriteLine("No of Instance Created: " + Counter);
    }
    public static EagerLoading GetInstance() => Instance;

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}
