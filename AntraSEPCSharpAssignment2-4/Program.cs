// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Enter Numbers:");
string intarr = Console.ReadLine();

Console.WriteLine("Enter Rotating value:");
int rot = int.Parse(Console.ReadLine());

LinkedList<int> ints = new LinkedList<int>();

string[] splitted = intarr.Split(' ');
for (int i = 0; i < splitted.Length; ++i)
{
    ints.AddLast(int.Parse(splitted[i]));
}

int[] sumRotated = new int[ints.Count];
for (;rot > 0; --rot)
{
    int val = ints.ElementAt(ints.Count - 1);
    ints.AddFirst(val);
    ints.RemoveLast();



    for(int i = 0; i < ints.Count; ++i)
    {
        sumRotated[i] +=ints.ElementAt(i);
    }
}

foreach (int g in sumRotated)
{
    Console.Write($"{g} ");
}
Console.WriteLine();