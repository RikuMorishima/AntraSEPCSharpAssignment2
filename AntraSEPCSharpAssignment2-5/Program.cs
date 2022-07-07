// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Input Engine same as 2-4
Console.WriteLine("Enter Numbers:");
string intarr = Console.ReadLine();

LinkedList<int> ints = new LinkedList<int>();

string[] splitted = intarr.Split(' ');
for (int i = 0; i < splitted.Length; ++i)
{
    ints.AddLast(int.Parse(splitted[i]));
}

int longestIndex = 0;
int longestSize = 0;

for (int i = ints.Count;--i >= 0;)
{
    int valueToCheck = ints.ElementAt(i);
    int sizeToCheck = 0;
    int indexToCheck = 0;
    for (int j = i; j < ints.Count; ++j)
    {
        if (valueToCheck != ints.ElementAt(j))
        {
            break;
        }
        sizeToCheck++;
        indexToCheck = i;
    }
    if (sizeToCheck >= longestSize)
    {
        longestSize = sizeToCheck; 
        longestIndex = indexToCheck;
    }
}

for (int i = longestIndex;i < longestIndex + longestSize;++i)
{
    Console.Write($"{ints.ElementAt(i)} ");
}