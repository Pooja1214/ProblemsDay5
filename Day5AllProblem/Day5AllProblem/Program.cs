// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Check Year is Leap or not

int year;
Console.WriteLine("Check weather year is leap or not");
Console.WriteLine("enter year");
year = Convert.ToInt32(Console.ReadLine());

if (year % 4 == 0 && year % 400 == 0)
{
    Console.WriteLine("year is leap year");
}
else
{
    Console.WriteLine("year is not leap year");
}