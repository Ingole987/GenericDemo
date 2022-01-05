// See https://aka.ms/new-console-template for more information
using GenericsDemo;
//Console.WriteLine("Hello, World!");
namespace GenericsDemo
{
internal class Program
{
static int[] intArray = { 2, 4, 5, 6, 8, 7 };
static char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
static double[] doubleArray = { 1.1, 3.3, 2.2, 4.4 };
static void Main(string[] args)

{
DisplayInt(intArray);
DisplayChar(charArray);
DisplayDouble(doubleArray);
Console.ReadKey();

}
public static void DisplayInt(int[] test)
{
    for (int i = 0;i<test.Length; i++)
    {
        Console.WriteLine(test[i] + " ");
    }
Console.WriteLine();
}
public static void DisplayChar(char[] test)
{
    for (int i = 0; i < test.Length; i++)
{
    Console.Write(test[i] + " ");
}
Console.WriteLine();
}
public static void DisplayDouble(double[] test)
{
    for (int i = 0; i < test.Length; i++)
    {
        Console.WriteLine(test[i] + " ");
    }
Console.WriteLine();
}
}
}
    
    



