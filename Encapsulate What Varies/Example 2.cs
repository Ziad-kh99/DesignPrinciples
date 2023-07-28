namespace DesignPrinciples.EncapsulateWhatVaries;

public class Pizza
{
    public virtual string Title => $"{nameof(Pizza)}";
    public virtual decimal Price => 10M;

    private static Pizza Create(string type)    // this method has code change repeatedly and don't has static code.
    {
        Pizza pizza;

        if(type.Equals(PizzaTypes.CheesePizza))
        {
            pizza = new Cheese();
        }
        else if(type.Equals(PizzaTypes.ChickenPizza))
        {
            pizza = new Chicken();
        }
        else if(type.Equals(PizzaTypes.VegeterianPizza))
        {
            pizza = new Vegeterian();
        }
        else 
        {
            pizza = new Pizza();
        }

        return pizza;
    }

    public static Pizza Order(string type)      // In this case this method is static, and don't contains any code that can change
    {
        Pizza pizza = Create(type);

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

public class Vegeterian : Pizza
{
    public override string Title => $"{base.Title} {nameof(Vegeterian)}";
    public override decimal Price => base.Price + 4M;   
}