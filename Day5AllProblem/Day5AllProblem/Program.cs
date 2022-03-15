// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//check alphabet is vowel or constant

char ch;
Console.WriteLine("Check whether alphabet vowel or constant");

Console.WriteLine("Enter the Alphabet");
ch = Convert.ToChar(Console.ReadLine());

switch (ch)
{
    case 'a':
        Console.WriteLine("the alphabet is vowel");
        break;
    case 'e':
        Console.WriteLine("the alphabet is vowel");
        break;
    case 'i':
        Console.WriteLine("the alphabet is vowel");
        break;
    case 'o':
        Console.WriteLine("the alphabet is vowel");
        break;
    case 'u':
        Console.WriteLine("the alphabet is vowel");
        break;
    default:
        Console.WriteLine("the alphabet is constant");
        break;
}