// напишите программу, которая принимает на вход два числа и вычитает не является ли одно квадратом другого.
Console.WriteLine("Введите число №1: . . . ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №2: . . . ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB*numberB)
{
    Console.WriteLine($"правильно: число А = {numberA} является квадратом Б = {numberB}");
}
else
{
    Console.WriteLine($"ошибка: число А = {numberA} не является квадратом Б = {numberB}");
}