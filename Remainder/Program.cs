/*Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if (a % b == 0)
    Console.WriteLine("Число " + a + " кратно числу " + b);
else
    Console.WriteLine("Число " + a + " не кратно числу " + b + "." + " Остаток " + a % b);*/

void remainder (int a, int b)
{
    if (a % b == 0)
    {
        Console.WriteLine("Число " + a + " кратно числу " + b);
    }
    else
    {
        Console.WriteLine("Число " + a + " не кратно числу " + b + "." + " Остаток " + a % b);
    }
}

remainder (75, 16);