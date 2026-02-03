// See https://aka.ms/new-console-template for more information

// Another way to do the same 
// ns name should be same as filename
namespace LearnDotNet;

public class PrimitiveDatatypes 
{
    public static void Run()
    {

        Console.WriteLine("\n--------------Char----------------");
        char c = 'A';
        Console.WriteLine("Char: {0}", c);

        Console.WriteLine("\n--------------Strings----------------");
        string name = "Manish";
        Console.WriteLine($"Hello World, {name}");

        Console.WriteLine(4+5);
        Console.WriteLine("{0} {1}", "Hola", "Amigo");

        Console.WriteLine($"To Upper: {name.ToUpper()}, To Lower: {name.ToLower()}");
        string trimString = "[     Hello      ]";
        Console.WriteLine($"TrimStart: {trimString.TrimStart()}, TrimEnd: {trimString.TrimEnd()}, Trim: {trimString.Trim()}");

        string sentance = "My Name is m4dd0c";
        Console.WriteLine($"StartsWith: {sentance.StartsWith("My")}, EndsWith: {sentance.EndsWith("m4dd0c")}, Replace: {sentance.Replace("m4dd0c", "Manish")}, Contains: {sentance.Contains("m4dd0c")}");


        Console.WriteLine("\n--------------Numbers----------------");
        byte b = 255; // max value of byte
        short n = 39;
        int number = 10;
        const float PI = 3.14f;
        double ph = 2.5;
        decimal amount = 100.5m;

        // operations
        // decimal * double isn't possible so converted double into decimal
        decimal calc = (decimal)((b + n) / (PI - ph)) * amount % number;
        Console.WriteLine("Calculation: {0}", calc);

        Console.WriteLine($"Max: {byte.MaxValue}, Min: {byte.MinValue}");

        /* If I add something to the max value of a datatype then the value loop back to min value
         * e.g., byte max = 255; byte res = max + 1; then the res will be 0
         * This is called overflow;
         * To be on the safe side we can use checked, It'll throw exception
        */ 
        /*
        checked
        {
            byte max = 255;
            byte sum = max + 1; // becomes 0
            Console.WriteLine("Overflow sum: {0}", sum);
        }
        */
    

        Console.WriteLine("\n--------------Boolean----------------");
        bool isTrue = true;
        bool isFalse = false;
        Console.WriteLine("Is True: {0}, Is False: {1}", isTrue, isFalse);
    }
}