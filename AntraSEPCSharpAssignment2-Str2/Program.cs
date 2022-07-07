// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input: ");
string input = Console.ReadLine();

char[] separators = ".,:;=()&[]\"\'\\/!? ".ToCharArray();
string[] splitted = input.Split(separators);

int index = 0;
int jndex = 0;
string[] splitBy = new string[splitted.Length];
foreach(string s in splitted)
{
    try
    {
        jndex = jndex + s.Length;
        splitBy[index++] = input.Substring(jndex, 1);

        Console.WriteLine(input.Substring(jndex, 1));
        jndex++;
    } catch (ArgumentOutOfRangeException)
    {

    }
    //jndex++;
}

Array.Resize(ref splitted, splitted.Length - 1);
Array.Reverse(splitted);

for (int i = 0,j=0; i < splitBy.Length && j<splitted.Length;i++,j++ )
{
    Console.Write($"{splitted[j]}{splitBy[i]}");
}