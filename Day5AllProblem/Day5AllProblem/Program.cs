// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Swapping of two numbers

/*
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

*/

//**************************************************************************

/*
//Largest number among 3 numbers

Console.WriteLine("Enter value for a: ");
int a = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Enter value for b: ");
int b = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Enter value for c: ");
int c = Convert.ToInt16(Console.ReadLine());



if (a > b && a>c)
{
    Console.WriteLine("a is greater");
}
else if(b>c && b>a)
{
    Console.WriteLine("b is greater");
}
else
{
    Console.WriteLine("c is greater");
}
*/

//***************************************************************************

// Even Odd Number
/*
 
Console.WriteLine("enter number:");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Number is even");
}
else 
{
    Console.WriteLine("Number is odd");
}
*/
//**************************************************************************

/*
//Check Year is Leap or not

int year;
Console.WriteLine("Check weather year is leap or not");
Console.WriteLine("enter year");
year = Convert.ToInt32(Console.ReadLine());

if (year % 4 == 0)
{
    Console.WriteLine("year is leap year");
}
else
{
    Console.WriteLine("year is not leap year");
}
*/
//***************************************************************************

/*
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
*/
//**************************************************************

/*
//Program for compute Quotient and Remainder

int divident,divisor;
//int quotient, remainder; Declare variables here also

Console.WriteLine("Enter Divident");
divident = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Divisor");
divisor = Convert.ToInt32(Console.ReadLine());

int quotient = divident / divisor;
int remainder = divident % divisor;

Console.WriteLine("quotient = " +quotient);
Console.WriteLine("remainder = " +remainder);

*/
//*********************************************************

Console.WriteLine("Let's flip a coin N times");
{
    Random Rand = new Random();
    
            int heads = 0;
            int tails = 0;
            int result = 0;
    Console.WriteLine("enter how many times coin flip");
            int N = Convert.ToInt16(Console.ReadLine());
   
           for (int i = 0; i < N; i++)
         {
               result = Rand.Next(0, 2);
                 if (result == 1)
                {
                   heads++;
                }
                else
                {
                    tails++;
                }
              }
    
            Console.WriteLine("heads was flipped {0} times", +heads);
            Console.WriteLine("tails was flipped {0} times", +tails);
            return result;
        }
    

