using System.Diagnostics;
// using DesignPrinciples.EncapsulateWhatVaries;

// using DesignPrinciples.EncapsulateWhatVaries;
using DesignPrinciples.FavorCompositionOverInheritance;


#region Encapsulate What Varies:


// Pizza pizza = Pizza.Order("chicken");

// Console.WriteLine(pizza.ToString());
    
#endregion



#region Favor Composition Over Inheritance:
var choice = 0;
var pizza  = new Pizza();

do 
{
    Console.Clear();
    choice = Orders.ReadChoice(choice);
     
    if(choice >= 1 && choice <= 6)
    {
        ITopping topping = null;

        switch(choice)
        {
            case 1:
                topping = new Tomato();
                break;
            case 2:
                topping = new Chicken();   
                break;
            case 3:
                topping = new Cheese();
                break;
            case 4:
                topping = new BlackOlives();
                break;
            case 5:
                topping = new GreenPaper();
                break;
            case 6:
                topping = new Solami();
                break;
            default:
                break;
        }

        pizza.AddTopping(topping);
        Console.WriteLine("Press any key to continue (or 0 to end)");
    }

    Console.ReadKey();
} while(choice != 0);

Console.WriteLine(pizza.ToString());
Console.ReadKey();
    
#endregion


