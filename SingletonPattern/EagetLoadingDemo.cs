public static class EagetLoadingDemo
{
    public static void SingleThread()
    {
        PrintEmp();
        PrintStudent();
    }

    public static void ThreadSafety(){
        Parallel.Invoke(
            ()=>PrintEmp(),
            ()=>PrintStudent()
        );
    }

    public static void PrintEmp()
    {
        EagerLoading emp = EagerLoading.GetInstance();
        emp.PrintMessage("This is Employee");
    }

    public static void PrintStudent()
    {
        EagerLoading student = EagerLoading.GetInstance();
        student.PrintMessage("This is Student");
    }
}