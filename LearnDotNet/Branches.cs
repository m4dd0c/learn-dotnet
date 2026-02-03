namespace LearnDotNet;

class Branches
{
    public static void Run()
    {
        Console.WriteLine("\n--------------Branches----------------");
        const string c = "Culprit";

        if(string.Equals(c, "culprit", StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("C is Culprit");
        else if (string.Equals(c, "not-culprit", StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("C isn't Culprit");
        else 
            Console.WriteLine("C might or might not be culprit");
        
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
        Console.WriteLine($"Length of the List {names.Count}");
        Console.WriteLine($"First element of the list: {names[0]}, IndexOf: {names.IndexOf("Mohit")}");
        names.Add("M4dd0c");
        names.Remove("Manish");
        names.Insert(1, "Vinit");
        names.Sort();
        names.Reverse();
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

    }
}