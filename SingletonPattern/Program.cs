internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Simple Singleton Example");
        PrintEmp();
        PrintStudent();
    
    }
    public static void PrintEmp()
    {
        SimpleSingleton emp = SimpleSingleton.GetInstance;
        emp.PrintDetails("This is Employee");
    }

    public static void PrintStudent()
    {
        SimpleSingleton student = SimpleSingleton.GetInstance;
        student.PrintDetails("This is Student");
    }
}