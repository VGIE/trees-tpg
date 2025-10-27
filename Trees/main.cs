
using System;
using Trees;

class MainClass
{
    public static void Main(string[] args)
    {
        bool success = Tests.TestGenericTree(Console.WriteLine, Console.WriteLine);

        if (success)
            Console.WriteLine("All tests passed");
    }
}