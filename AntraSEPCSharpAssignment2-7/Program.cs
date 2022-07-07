// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter Numbers:");
string intarr = Console.ReadLine();
string[] splitted = intarr.Split(' ');
int[] ints = new int[splitted.Length]; 
for (int i = 0; i < splitted.Length; ++i)
{
    ints[i] = int.Parse(splitted[i]);
}


int[,] frequency = new int[splitted.Length,2];
int filled = -1;

int maxFrequency = -1;

// Counts the numbers based on a map-like structure where the key is the actual values in the inputs, value is the frequency
for (int i = 0; i < splitted.Length; ++i) // i represents the inputlist's index number
{
    for (int j = 0; j < splitted.Length; ++j)  // j represents the frequency list's index number
    {
        // is not found
        if (filled < j)
        {
            frequency[j, 0] = ints[i];
            ++frequency[j, 1];
            ++filled;
            if (frequency[j, 1] > maxFrequency)
                maxFrequency = frequency[j, 1];
            break;
        }
        // add 1 to the frequency if the value exists
        if (frequency[j,0] == ints[i])
        {
            ++frequency[j, 1];

            if (frequency[j,1] > maxFrequency)
                maxFrequency = frequency[j,1];
            break;
        }

    }
}


// Get the most frequent value. maxFrequency holds the value for the most occurring.
int count = 0;
int leftMost = -1;
for (int i = splitted.Length; --i>=0;)
{
    if (frequency[i,1] == maxFrequency)
    {
        Console.WriteLine($"Most frequent: {frequency[i,0]}, occurred {frequency[i,1]} times");
        ++count;
        leftMost = i;
    }
}
if (count > 1)
{
    Console.WriteLine($"Left most number : {frequency[leftMost, 0]}");
}