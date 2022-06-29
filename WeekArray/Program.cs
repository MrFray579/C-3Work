Console.WriteLine("Введите номер дня недели:");
int a = Convert.ToInt32(Console.ReadLine());
string [] weekDays = new string[] {"Sun", "Mon", "Tue", "Web", "Thu", "Fri", "Sat"};

if (a <= 7)
Console.WriteLine(weekDays[a - 1]);
else
Console.WriteLine("Введите другое число");