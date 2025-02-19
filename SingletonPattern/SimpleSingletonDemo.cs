public static class SimpleSingletonDemo
{
    public static void SingleThread()
    {
        PrintEmp();
        PrintStudent();
    }

    public static void NoThreadSafety(){
        Parallel.Invoke(
            ()=>PrintEmp(),
            ()=>PrintStudent()
        );
    }

    public static void PrintEmp()
    {
        SimpleSingleton emp = SimpleSingleton.GetInstance;
        emp.PrintMessage("This is Employee");
    }

    public static void PrintStudent()
    {
        SimpleSingleton student = SimpleSingleton.GetInstance;
        student.PrintMessage("This is Student");
    }
}