// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Find Harmonic Number


Console.Write("Enter the value of N: ");
//VARIABLES
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
float nthHarmonicValue = 0;

while (i <= N)
{
    Console.Write($"1/{i} + ");
    nthHarmonicValue += 1 / (float)i;
    i++;
}
Console.WriteLine($"\n{nthHarmonicValue}");