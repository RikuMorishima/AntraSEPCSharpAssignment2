// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
Console.WriteLine("Hello, World!");
Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
List<string> strings = new List<string>();
while (true)
{
    
    string str = Console.ReadLine();
    if (str == null)
        continue;
    if (str == "end")
        break;

    if (str.StartsWith('+'))
    {
        strings.Add(str.Substring(1));
    }
    if (str.StartsWith('-'))
    {
        if (str.Substring(1).StartsWith('-'))
        {
            strings.Clear();
        }
        else
        {
            strings.Remove(str.Substring(1));
        }
    }
    Console.WriteLine("List Contents: ");
    for (int i = 0; i < strings.Count; i++)
    {
        Console.WriteLine(strings.ElementAt(i));
    }
    str = null;
}