using System.Text;

namespace DesignPrinciples.FavorCompositionOverInheritance;

public class Pizza
{
    public virtual decimal Price => 10M;

    public List<ITopping> Toppings { get; private set; } = new List<ITopping>();

    public void AddTopping(ITopping topping)
    {
        Toppings.Add(topping);
    }

    private decimal CalculateTotalPrice()
    {
        var totalPrice = this.Price;
        foreach (var topping in Toppings)
        {
            totalPrice += topping.Price;
        }

        return totalPrice;
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder(); 
        output.Append($"\n{nameof(Pizza)} \n\tBase Price: {Price.ToString("C")}");
        foreach(var topping in Toppings)
        {
            output.Append($"\n\t{topping.Title} ({topping.Price.ToString("C")})");
        }

        output.Append("\n========================================\n");
        output.Append($"Total Price: {CalculateTotalPrice().ToString("C")}");

        return output.ToString();
    }
}

public interface ITopping
{
    string Title { get; }
    decimal Price { get; }
}

public class Tomato : ITopping
{
    public string Title => nameof(Tomato);
    public decimal Price => 3M ;
}

public class Chicken : ITopping 
{
    public string Title => nameof(Chicken);
    public decimal Price => 6M;
}

public class Cheese : ITopping 
{
    public string Title => nameof(Cheese);
    public decimal Price => 4M;
}

public class BlackOlives : ITopping 
{
    public string Title => nameof(BlackOlives);
    public decimal Price => 2M;
}

public class GreenPaper : ITopping 
{
    public string Title => nameof(GreenPaper);
    public decimal Price => 2.5M;
}

public class Solami : ITopping
{
    public string Title => nameof(Solami);
    public decimal Price => 7.5M;
}
