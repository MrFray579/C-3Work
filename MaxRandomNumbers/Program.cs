void compareNumbers (int firstA, int secondA)
{
    if (secondA > firstA)
    {
        Console.WriteLine(secondA + " больше " + firstA);
    }
    else
    {
        Console.WriteLine(firstA + " больше " + secondA);
    }
}



void randomNumbersCompare (int start, int finish)
{
    int A = new Random().Next(start, finish);
    Console.WriteLine(A);
    int secondA = A % 10;
    int firstA = A / 10;
    compareNumbers(firstA, secondA);
}

randomNumbersCompare (10, 99);

