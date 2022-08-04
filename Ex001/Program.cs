Console.Write("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());
if(value == 1)
{
    Console.WriteLine("Сегодня ПОНЕДЕЛЬНИК");
}
else if(value == 2)
{
    Console.WriteLine("Сегодня ВТОРНИК");
}
else if(value == 3)
{
    Console.WriteLine("Сегодня СРЕДА");
}
else if(value == 4)
{
    Console.WriteLine("Сегодня ЧЕТВЕРГ");
}
else if(value == 5)
{
    Console.WriteLine("Сегодня ПЯТНИЦА");
}
else if(value == 6)
{
    Console.WriteLine("Сегодня СУББОТА");
}
else if(value == 7)
{
    Console.WriteLine("Сегодня ВОСКРЕСЕНЬЕ");
}
else
{
    Console.WriteLine("Вы вообще не то число ввели, досвиданья!");
}