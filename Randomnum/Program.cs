

int something (int start, int finish)
{
    int A = new Random().Next(start, finish);
    Console.WriteLine(A);

    int thirdnum = A % 10;
    int firstnum = A / 100;
    int result = firstnum * 10 + thirdnum;
    return result;
}

int a = something (100, 999);
Console.WriteLine(a);

