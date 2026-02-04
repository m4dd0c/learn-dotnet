using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace LearnDotNet;
class NonPrimitiveDatatypes
{
    public static void Run()
    {
        Console.WriteLine("\n--------------NonPrimitiveDataTypes----------------");
        // tuple
        var user = (Name: "Manish", Age: 22);
        Console.WriteLine($"Name: {user.Name}, his age: {user.Age}");
        // 5 years later
        user.Age += 5;
        Console.WriteLine("user age after 5 years {0}", user.Age);

        // deconstruction in tuple
        var (name, age) = user;
        Console.WriteLine($"Name: {name}, his age: {age}");

        // with keyword to create new tuple with same keys but different values
        var user2 = user with {Name = "John", Age = 56};
        Console.WriteLine(user2);

        // struct, class
        // struct is value type and class is reference type

        // Lists
        List<string> names = ["Manish", "Nitesh", "Sumit", "Sandeep"];
        Console.WriteLine($"Length of the List {names.Count}");
        Console.WriteLine($"First element of the list: {names[0]}, IndexOf: {names.IndexOf("Mohit")}");
        names.Add("M4dd0c");
        names.Remove("Manish");
        names.Insert(1, "Vinit");
        names.Sort();
        names.Reverse();
        foreach (var n in names){
            Console.WriteLine(n);
        }

        // Array
        int[] numbers = [1, 2, 3, 4, 5];
        int[] moreNumbers = [..numbers, 6,7];
        foreach (var n in moreNumbers)
            Console.WriteLine(n);

        Console.WriteLine();

        List<int> li = [1,2,3];
        List<int> moreLi = [..li, 4, 5];
        foreach(var l in moreLi)
            Console.WriteLine(l);
    }
}