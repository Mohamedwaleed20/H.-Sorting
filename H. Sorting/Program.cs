// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());
int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
Array.Sort(arr);
for (int i = 0 ; i < n; i++)
{
    Console.Write(arr[i] + " ");
}
Console.ReadLine();