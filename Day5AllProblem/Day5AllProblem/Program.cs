// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Swapping of two numbers


Console.WriteLine("enter First Number:");
int num1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("enter Second Number:");
int num2 = Convert.ToInt16(Console.ReadLine());

int temp = Convert.ToInt16(Console.ReadLine());

temp = num1;
num1 = num2;
num2 = temp;

Console.WriteLine("After Swapping number");
Console.WriteLine("First Number:"+ num1 );
Console.WriteLine("Second Number:" + num2);



