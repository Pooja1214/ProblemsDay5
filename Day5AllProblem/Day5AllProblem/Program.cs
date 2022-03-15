// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Largest number among 3 numbers

Console.WriteLine("Enter value for num1: ");
int num1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Enter value for num2: ");
int num2 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Enter value for num3: ");
int num3 = Convert.ToInt16(Console.ReadLine());



if (num1 > num2 && num1 > num3)
{
    Console.WriteLine("num1 is greater");
}
else if (num2 > num3 && num2 > num1)
{
    Console.WriteLine("num2 is greater");
}
else
{
    Console.WriteLine("num3 is greater");
}