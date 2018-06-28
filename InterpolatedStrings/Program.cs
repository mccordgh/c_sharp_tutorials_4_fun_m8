using System;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {
        var titles = new Dictionary<string, string>()
        {
            ["Doyle, Sir Arthur Conan"] = "Hound of the Baskerville, The",
            ["London, Jack"] = "Call of the Wild, The",
            ["Shakespeare, William"] = "Tempest, The"
        };

        Console.WriteLine("Author and Title List");
        Console.WriteLine();
        Console.WriteLine($"|{"Author", -25}|{"Title", 30}|");

        foreach (var title in titles)
        {
            Console.WriteLine($"|{title.Key, -25}|{title.Value, 30}|");
        }
    }
}