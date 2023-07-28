namespace DesignPrinciples.EncapsulateWhatVaries.InitialCase;

public class Pizza
{
    public virtual string Title => $"{nameof(Pizza)}";
    public virtual decimal Price => 10M;

    public static Pizza Order(string type)      // Like 'Factory Design Pattern'
    {
        Pizza pizza;

        if(type.Equals("cheese"))
        {
            pizza = new Cheese();
        }
        else if(type.Equals("chicken"))
        {
            pizza = new Chicken();
        }
        else 
        {
            pizza = new Pizza();
        }

        Prepare();
        Cook();
        Cut();
        Console.WriteLine(pizza);

        return pizza;
    }

    private static void Prepare()
    {
        Console.Write("Prepating... ");
        Thread.Sleep(1500);
        Console.WriteLine("Completed.");
    }

    private static void Cook()
    {
        Console.Write("Cooking... ");
        Thread.Sleep(1500);
        Console.WriteLine("Completed.");
    }

    private static void Cut()
    {
        Console.Write("Cutting and Boxing... ");
        Thread.Sleep(1500);
        Console.WriteLine("Completed.");
    }

    public override string ToString()
    {
        return $"\n{Title}\n\tPrice: {Price.ToString("C")}\n";
    }
}

public class Cheese : Pizza
{
    public override string Title => $"{base.Title} {nameof(Cheese)}";       // Pizza Cheese
    public override decimal Price => base.Price + 3M;    
}

public class Chicken : Pizza
{
    public override string Title => $"{base.Title} {nameof(Chicken)}";
    public override decimal Price => base.Price + 5M;
}
