// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string input = Console.ReadLine();

// converting
char[] array = input.ToCharArray();
Array.Reverse(array);
string converted = new string(array);
Console.WriteLine(converted);

//print in back direction
for(int i = input.Length; --i >=0;)
{
    Console.Write(input[i]);
}
Console.WriteLine();