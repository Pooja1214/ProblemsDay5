// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//program for head tail percentage calculation

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

