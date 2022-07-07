// See https://aka.ms/new-console-template for more information
using AntraSEPCSharpAssignment2_3;

Console.WriteLine("Hello, World!");

int[] ints = FindingPrimes.FindPrimesInRange(1, 10000);
foreach(int i in ints)
    Console.WriteLine(i);
