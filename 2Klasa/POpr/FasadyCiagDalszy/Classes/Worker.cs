namespace FasadyCiagDalszy.Classes;

public abstract class Worker
{
    protected string Fname;
    protected string Sname;
    protected int Age;
    protected int Salary;

    protected Worker(string fname, string sname, int age, int salary)
    {
        Fname = fname;
        Sname = sname;
        Age = age;
        Salary = salary;
    }

    protected string GetFname()
    {
        return Fname;
    }

    protected string GetSname()
    {
        return Sname;
    }

    protected int GetAge()
    {
        return Age;
    }

    protected int GetSalary()
    {
        return Salary;
    }

    public abstract void Work();
}

public class Makeuper : Worker
{
    public Makeuper(string fname, string sname, int age, int salary) : base(fname, sname, age, salary)
    {
    }

    public override void Work()
    {
        Console.WriteLine($"Makeuper {GetFname()} {GetSname()} kremuje twarz!");
    }
}

public class Barber : Worker
{
    public Barber(string fname, string sname, int age, int salary) : base(fname, sname, age, salary)
    {
    }

    public override void Work()
    {
        Console.WriteLine($"Barber {GetFname()} {GetSname()} tnie włosy!");
    }
}

public class Manicurist : Worker
{
    public Manicurist(string fname, string sname, int age, int salary) : base(fname, sname, age, salary)
    {
    }

    public override void Work()
    {
        Console.WriteLine($"Manikiurzysta {GetFname()} {GetSname()} gładzi paznokcie!");
    }
}