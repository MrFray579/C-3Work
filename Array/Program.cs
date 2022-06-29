Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int [] array = new int[a];

for ( int i = 0; i < a; i++)
{
    array[i] = i;
    Console.WriteLine(array[i]);
}



