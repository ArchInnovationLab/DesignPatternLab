public static class ThreadSafeDemo
{
    public static void SingleThread()
    {
        PrintEmp();
        PrintStudent();
    }

    public static void ThreadSafe(){
        Parallel.Invoke(
            ()=>PrintEmp(),
            ()=>PrintStudent()
        );
    }

    public static void PrintEmp()
    {
        SingletonThreadSafe emp = SingletonThreadSafe.GetInstance;
        emp.PrintMessage("This is Employee");
    }

    public static void PrintStudent()
    {
        SingletonThreadSafe student = SingletonThreadSafe.GetInstance;
        student.PrintMessage("This is Student");
    }
}