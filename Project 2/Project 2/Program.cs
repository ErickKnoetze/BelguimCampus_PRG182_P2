using System;
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
                                    Items.Add("Sunday Specials");
                                    break;
                                case Breakfast.Back:
                                    break;
                                default:
                                    break;
                            }
                        }

                        break;

                    case MainMenu.Combos:

                        DisplayCombos();
                        Console.WriteLine("Please select an option:");
                        input = Console.ReadLine();
                        if (Enum.TryParse(input, out Combos ComboOption))
                        {
                            switch (ComboOption)
                            {
                                case Combos.BurgerMeals:
                                    break;
                                case Combos.BreakfastCombos:
                                    break;
                                case Combos.Back:
                                    break;
                                default:
                                    break;
                            }

                        }
                        break;

                    case MainMenu.Chips:

                        DisplayChips();
                        Console.WriteLine("Please select an option:");
                        input = Console.ReadLine();
                        if (Enum.TryParse(input, out Chips ChipsOption))
                        {
                            switch (ChipsOption)
                            {
                                case Chips.PotatoChips:
                                    break;
                                case Chips.CheesyChips:
                                    break;
                                case Chips.SweetPotatoChips:
                                    break;
                                case Chips.Back:
                                    break;
                                default:
                                    break;
                            }

                        }
                        break;

                    case MainMenu.Burgers:

                        DisplayBurgers();
                        Console.WriteLine("Please select an option:");
                        input = Console.ReadLine();
                        if (Enum.TryParse(input, out Burgers BurgersOption))
                        {
                            switch (BurgersOption)
                            {
                                case Burgers.BasicBurgers:
                                    DisplayBasicBurgers();
                                    break;
                                case Burgers.GourmetBurgers:
                                    DisplayGormetBurgers();
                                    break;
                                case Burgers.Back:
                                    break;
                                default:
                                    break;
                            }

                        }
                        break;

                    case MainMenu.Drinks:

                        DisplayDrinks();
                        Console.WriteLine("Please select an option:");
                        input = Console.ReadLine();
                        if (Enum.TryParse(input, out Drinks drinksOption))
                        {
                            switch (drinksOption)
                            {
                                case Drinks.SoftDrink:
                                    DisplaySoftDrinks();
                                    Console.WriteLine("Please select an option:");
                                    input = Console.ReadLine();
                                    if (Enum.TryParse(input, out SoftDrink SoftDrinkOption))
                                    {
                                        switch (SoftDrinkOption)
                                        {
                                            case SoftDrink.cup:
                                                DisplaySoftDrinksCup();
                                                break;
                                            case SoftDrink.Bottle:
                                                DisplaySoftDrinksBottle();
                                                break;
                                            case SoftDrink.Back:
                                                break;
                                            default:
                                                break;
                                        }

                                    }
                                    break;
                                case Drinks.Milkshake:
                                    DisplayMilkshake();
                                    break;
                                case Drinks.Juice:
                                    DisplayJuice();
                                    break;
                                case Drinks.HotDrink:
                                    DisplayHotDrinks();
                                    break;
                                case Drinks.Back:
                                    break;
                                default:
                                    break;
                            }

                        }
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
        Console.Clear();
        Console.WriteLine("1. Burger Combo");
        Console.WriteLine("2. Breakfast Combos");
        Console.WriteLine("3. Back");

    }
    static void DisplaySize()
    {
        Console.Clear();
        Console.WriteLine("1. Small");
        Console.WriteLine("2. Medium");
        Console.WriteLine("3. Large");
        Console.WriteLine("4. Back");

    }
    static void DisplayChips()
    {
        Console.Clear();
        Console.WriteLine("1. Potato Chips");
        Console.WriteLine("2. Cheesy Chips");
        Console.WriteLine("3. Sweet Potato Chips");
        Console.WriteLine("4. Back");

    }
    static void DisplayBurgers()
    {
        Console.Clear();
        Console.WriteLine("1. Basic Burgers");
        Console.WriteLine("2. Gourmet Burgers");
        Console.WriteLine("3. Back");

    }
    static void DisplayBasicBurgers()
    {
        Console.Clear();
        Console.WriteLine("1. Chicken Burger");
        Console.WriteLine("2. Beef Burger");
        Console.WriteLine("3. Cheese Bruger");
        Console.WriteLine("4. Vegan Burger");
        Console.WriteLine("5. Back");

    }
    static void DisplayGormetBurgers()
    {
        Console.Clear();
        Console.WriteLine("1. Bacon Burger");
        Console.WriteLine("2. Rib Burger");
        Console.WriteLine("3. Double Decker");
        Console.WriteLine("4. Blue Cheese Burger");
        Console.WriteLine("5. Back");
    }
    static void DisplayDrinks()
    {
        Console.Clear();
        Console.WriteLine("1. Soft Drinks");
        Console.WriteLine("2. Milkshakes");
        Console.WriteLine("3. Juices");
        Console.WriteLine("4. Hot Drinks");
        Console.WriteLine("5. Back");
    }
    static void DisplaySoftDrinks()
    {
        Console.Clear();
        Console.WriteLine("1. Cup");
        Console.WriteLine("2. Bottle");
        Console.WriteLine("3. Back");
    }
    static void DisplaySoftDrinksCup()
    {
        Console.Clear();
        Console.WriteLine("1. Coke");
        Console.WriteLine("2. Pepsi");
        Console.WriteLine("3. Fanta orange");
        Console.WriteLine("4. Sprite");
        Console.WriteLine("5. Creamsoda");
        Console.WriteLine("6. Back");

    }
    static void DisplaySoftDrinksBottle()
    {
        Console.Clear();
        Console.WriteLine("1. Coke");
        Console.WriteLine("2. Pepsi");
        Console.WriteLine("3. Fanta orange");
        Console.WriteLine("4. Fanta Grape");
        Console.WriteLine("5. Sprite");
        Console.WriteLine("6. Creamsoda");
        Console.WriteLine("7. Back");

    }
    static void DisplayMilkshake()
    {
        Console.Clear();
        Console.WriteLine("1. Vanilla");
        Console.WriteLine("2. Strawberry");
        Console.WriteLine("3. Chocolate");
        Console.WriteLine("4. Lime");
        Console.WriteLine("5. Bubblegum");
        Console.WriteLine("6. Banana");
        Console.WriteLine("7. Back");
    }
    static void DisplayJuice()
    {
        Console.Clear();
        Console.WriteLine("1. Orange Juice");
        Console.WriteLine("2. Apple Juice");
        Console.WriteLine("3. Mango Juice");
        Console.WriteLine("4. Guava Juice");
        Console.WriteLine("5. Tropical Juice");
        Console.WriteLine("6. MixedBerries Juice");
        Console.WriteLine("7. Back");

    }
    static void DisplayHotDrinks()
    {
        Console.Clear();
        Console.WriteLine("1. Cappachino");
        Console.WriteLine("2. Filter coffee");
        Console.WriteLine("3. Milo");
        Console.WriteLine("4. Hot Chocolate");
        Console.WriteLine("5. Back");
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
        PotatoChips = 1,
        CheesyChips,
        SweetPotatoChips,
        Back
    }
    enum Burgers
    {
        BasicBurgers = 1,
        GourmetBurgers,
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
    enum GourmetBurgers
    {
        BaconBurger = 1,
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
        Orange = 1,
        Apple,
        Mango,
        Guava,
        Tropical,
        MixedBerries,
        Back
    }
    enum HotDrinks
    {
        Cappachino = 1,
        FilterCoffee,
        Milo,
        HotChocolate,
        Back
    }

}