using System.Diagnostics;
using System.Globalization;

class Program
{
    static List<string> Items = new();
    static List<decimal> Price = new();
    static void Main(string[] args)
    {

        while (true)
        {

            DisplayMainMenu();
            Console.WriteLine("Please select an option:");
            string input = Console.ReadLine();
            if (Enum.TryParse(input, out MainMenu option))
            {
                switch (option)
                {
                    case MainMenu.Breakfast:
                        DisplayBreakfast();
                        Console.WriteLine("Please select an option:");
                        input = Console.ReadLine();
                        if (Enum.TryParse(input, out Breakfast breakfastOption))
                        {
                            switch (breakfastOption)
                            {
                                case Breakfast.BreakfastSpecial:
                                    Items.Add("Breakfast Special");
                                    break;
                                case Breakfast.HashAndEgg:
                                    Items.Add("Hashbrown & Eggs");
                                    break;
                                case Breakfast.SundaySpecial:
                                    Items.Add("Sunday Special");
                                    break;
                                case Breakfast.Back:
                                    break;
                                default:
                                    break;
                            }
                        }

                        break;
                    case MainMenu.Combos:
                        break;
                    case MainMenu.Chips:
                        break;
                    case MainMenu.Burgers:
                        break;
                    case MainMenu.Drinks:
                        break;
                    case MainMenu.CheckOut:
                        Checkout();
                        break;
                    default:
                        break;
                }
            }

        }

    }
    static void DisplayMainMenu()
    {
        Console.Clear();
        Console.WriteLine("Main Menu :\n");
        Console.WriteLine("1. Breakfast");
        Console.WriteLine("2. Combos");
        Console.WriteLine("3. Chips");
        Console.WriteLine("4. Burgers");
        Console.WriteLine("5. Drinks");
        Console.WriteLine("6. Checkout\n");
    }
    static void DisplayBreakfast()
    {
        Console.Clear();
        Console.WriteLine("1. Breakfast Special R80");
        Console.WriteLine("(Two eggs, Boerewors, Bacon and toast)\n");
        Console.WriteLine("2. Hashbrown & Eggs R55");
        Console.WriteLine("(Two eggs on two hashbrowns)\n");
        Console.WriteLine("3. Sunday Special R45");
        Console.WriteLine("(An egg on a english muffin)\n");
        Console.WriteLine("4. Back");
    }
    static void Checkout()
    {
        int count = 1;
        foreach (string item in Items)
        {
            Console.WriteLine($"{count}. {item}");
        }
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Continue");
    }
    static void DisplayCombos()
    {

    }
    static void DisplaySize()
    {

    }
    static void DisplayChips()
    {

    }
    static void DisplayBurgers()
    {

    }
    static void DisplayBasicBurgers()
    {

    }
    static void DisplayGormetBurgers()
    {

    }
    static void DisplayDrinks()
    {

    }
    static void DisplaySoftDrinks()
    {

    }
    static void DisplaySoftDrinksCup()
    {

    }
    static void DisplaySoftDrinksBottle()
    {

    }
    static void DisplayMilkshake()
    {

    }
    static void DisplayJuice()
    {

    }
    static void DisplayHotDrinks()
    {

    }

    enum MainMenu
    {
        Breakfast = 1,
        Combos,
        Chips,
        Burgers,
        Drinks,
        CheckOut
    }
    enum Breakfast
    {
        BreakfastSpecial = 1,
        HashAndEgg,
        SundaySpecial,
        Back
    }
    enum Combos
    {
        BurgerMeals = 1,
        BreakfastCombos,
        Back
    }
    enum Size
    {
        Small = 1,
        Medium,
        Large,
        Back
    }
    enum Chips
    {
        NormalChips = 1,
        CheesyChips,
        SweetPotatoChips,
        Back
    }
    enum Burgers
    {
        BasicBurgers = 1,
        GormetBurgers,
        Back
    }
    enum BasicBurgers
    {
        ChickenBurger = 1,
        BeefBurger,
        CheeseBurger,
        VeganBurger,
        Back
    }
    enum GormetBurgers
    {
        BaconBurger,
        RibBurger,
        DoubleDecker,
        BlueCheeseBurger,
        Back
    }

    enum Drinks
    {
        SoftDrink = 1,
        Milkshake,
        Juice,
        HotDrink,
        Back
    }
    enum SoftDrink
    {
        cup = 1,
        Bottle,
        Back
    }
    enum SoftDrinkCup
    {
        Coke = 1,
        Pepsi,
        FantaOrange,
        Sprite,
        Creamsoda,
        Back
    }
    enum SoftDrinkBottle
    {
        Coke = 1,
        Pepsi,
        FantaOrange,
        FantaGrape,
        Sprite,
        Creamsoda,
        MountainDew,
        Stoney,
        Back

    }
    enum MilkShake
    {
        Vanilla = 1,
        StrawBerry,
        Chocolate,
        Lime,
        Bubblegum,
        Bannana,
        Back
    }
    enum Juice
    {
        Orange,
        Apple,
        Mango,
        Guava,
        Tropical,
        MixedBerries,
        Back
    }
    enum HotDrinks
    {
        Cappachino,
        FilterCoffee,
        Milo,
        HotChocolate,
        Back
    }

}