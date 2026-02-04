namespace LearnDotNet;

class Branches
{
    public static void Run()
    {
        Console.WriteLine("\n--------------If Else----------------");
        const string c = "Culprit";

        if(string.Equals(c, "culprit", StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("C is Culprit");
        else if (string.Equals(c, "not-culprit", StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("C isn't Culprit");
        else 
            Console.WriteLine("C might or might not be culprit");
        
        Console.WriteLine("\n--------------Switch Case----------------");
        byte num = 28;
        switch (num)
        {
            case 18:
                Console.WriteLine("User is 18");
                break;
            case > 18:
                Console.WriteLine("User is Above 18");
                break;
            case < 18:
                Console.WriteLine("User is below 18");
                break;
        }


        Console.WriteLine("\n--------------Loops----------------");
        Console.WriteLine("While Loop");
        // while loop
        byte count = 0;
        while (count < 5)
        {
            Console.WriteLine(count++);
        }

        Console.WriteLine("Do While Loop");
        // do while loop
        do
        {
            Console.WriteLine(count++);
        }while (count < 10);

        Console.WriteLine("For Loop");
        // for loop
        for (byte i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
        
        Console.WriteLine("Foreach Loop");
        List<string> names = ["Manish", "Nitesh", "Sumit", "Sandeep"];
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}