// напишите программу, которая будет выдавать название дня недели по заданному номеру.
Console.WriteLine("Введите любое число");
// просим ввести любое число 
int numberWeek = Convert.ToInt32(Console.ReadLine());
// задаем условие если число меньше 1 и больше 7 то вывод на экран :"дней недели всего 7"
if (numberWeek > 7 || numberWeek < 1)
{
    Console.WriteLine("введите число от 1 до 7 так как дней недели всего 7 ");
}
// иначе сравниваем числа от 1 до 7 
else
{
    if (numberWeek == 1)
    // приравниваем число к значению дня недели
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