void remainder (int a)
{
    if (a % 7 == 0 & a % 23 == 0)
    {
        Console.WriteLine("Число кратно");
    }
    else
    {
        Console.WriteLine("Число не кратно " + a);
    }
}

remainder (161);