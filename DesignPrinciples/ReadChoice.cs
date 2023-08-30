public class Orders
{
    internal static int ReadChoice(int choice)   
    {
        Console.WriteLine("Available Toppings");
        Console.WriteLine("------------");
        Console.WriteLine("1. Tomato");
        Console.WriteLine("2. Chicken");
        Console.WriteLine("3. Cheese");
        Console.WriteLine("5. Black Olives");
        Console.WriteLine("5. Green Paper");
        Console.WriteLine("6. Solami");
        Console.WriteLine("Select Toppings: ");

        if(int.TryParse(Console.ReadLine(), out int ch))
        {
            choice = ch;
        }

        return choice;
    }
}