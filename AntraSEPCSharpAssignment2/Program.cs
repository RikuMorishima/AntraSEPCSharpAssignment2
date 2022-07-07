// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] arr = new int[10];
for (int i = 0; i < 10; i++)
    arr[i] = new Random().Next(10) + 1;

int[] arr2 = new int[arr.Length];

for (int i = 0; i < arr2.Length; i++)
{
    arr2[i] = arr[i];
}
for (int i = 0; i < arr2.Length; i++)
{
    Console.WriteLine(arr[i]);
    Console.WriteLine(arr2[i]);
}
