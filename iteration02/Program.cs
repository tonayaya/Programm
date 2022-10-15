// напишите программу, которая будет выдавать название дня недели по заданному номеру
// 3 -> среда
// 5 -> пятница

Console.WriteLine("Введите число дня");
int numberWeek = Convert.ToInt32(Console.ReadLine());
if (numberWeek > 7 || numberWeek < 1)
{
    Console.WriteLine("Дней недели всего 7");
}
else
{
    if (numberWeek == 1)
    {
        Console.WriteLine("сегодня понедельник");
    }
}   if (numberWeek == 2)
    {
        Console.WriteLine("сегодня вторник");
    }
{if (numberWeek == 3)
    {
        Console.WriteLine("сегодня среда");
    }
}   if (numberWeek == 4)
    {
        Console.WriteLine("сегодня четверг");
    }
if (numberWeek == 5)
    {
        Console.WriteLine("сегодня пятница");
    }
if (numberWeek == 6)
    {
        Console.WriteLine("сегодня суббота");
    }
if (numberWeek == 7)
    {
        Console.WriteLine("сегодня воскресенье");
}