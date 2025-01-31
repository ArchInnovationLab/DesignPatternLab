internal class Program
{
    public static void PrintEmp()
    {
        // Singleton emp = new Singleton();
        Singleton emp = Singleton.GetInstance;
        emp.PrintDetails("From Emp");
    }

    public static void PrintStudent()
    {
        // Singleton emp = new Singleton();
        Singleton stud = Singleton.GetInstance;
        stud.PrintDetails("From Student");
    }

    public static void Main()
    {
        Console.WriteLine("Understand Singleton Design Pattern!");

        PrintEmp();
        PrintStudent();

    }



}