// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Program for compute Quotient and Remainder

int divident, divisor;
//int quotient, remainder; Declare variables here also

Console.WriteLine("Enter Divident");
divident = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Divisor");
divisor = Convert.ToInt32(Console.ReadLine());

int quotient = divident / divisor;
int remainder = divident % divisor;

Console.WriteLine("quotient = " + quotient);
Console.WriteLine("remainder = " + remainder);
