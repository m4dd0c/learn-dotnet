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



    }
}