// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



Fitness intermidiate = new Fitness("RIK", 2000, "Karachi");
//Console.WriteLine(intermidiate.gymname);
intermidiate.ShowGymname();
intermidiate.ShowAddress();
intermidiate.ShowMonthlyFee();



Begginers Basics = new Begginers("FWR", 1500, "Nazimabad",true);
//Console.WriteLine(intermidiate.gymname);
Basics.ShowBasic();




public class Fitness
{
    public string? gymname;
    private int monthlyfee;
    protected string address;


    public Fitness(string gymname, int monthlyfee, string address)
    {
        this.gymname = gymname;
        this.monthlyfee = monthlyfee;
        this.address = address;
    }

    public void ShowGymname()
    {
        Console.WriteLine(this.gymname);
    }
    public void ShowMonthlyFee()
    {
        Console.WriteLine(this.monthlyfee);
    }

    public void ShowAddress()
    {
        Console.WriteLine(this.address);
    }

}

public class Begginers : Fitness
{
    public bool basic;
    public Begginers(string gymname, int monthlyfee, string address, bool basic) : base(gymname, monthlyfee, address)
    {
        this.basic = basic;
    }
    public void ShowBasic()
    {
        Console.WriteLine(this.gymname);
        this.ShowMonthlyFee() ;
        Console.WriteLine(this.address);
        Console.WriteLine(this.basic);
    }
}



