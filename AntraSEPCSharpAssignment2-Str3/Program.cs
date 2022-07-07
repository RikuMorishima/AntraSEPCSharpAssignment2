// See https://aka.ms/new-console-template for more information
using AntraSEPCSharpAssignment2_Str3;

Console.WriteLine("Hello, World!");

string input = Console.ReadLine();
string[] splitted = input.Split(".,:;=()&[]\"\'\\/!? ".ToCharArray());



int outputLength = 0;
string[] refined = new string[splitted.Length];
foreach(string s in splitted)
{
    if (IsPalindrome.IsStrPalindrome(s) && !refined.Contains(s))
    {
        refined[outputLength++] = s;
    }
}
Array.Resize(ref refined, outputLength);
Array.Sort(refined);

bool insertComma = false;
foreach(string s in refined)
{
    if (insertComma)
        Console.Write(", ");
    Console.Write($"{s}");
    insertComma = true;
}
Console.WriteLine();