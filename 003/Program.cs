// Напишите программу, которая на вход принимает целое число и выдает его квадрат (число умножить на число)

// Запрос числа от пользователя
Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

//квадрат исходного числа
int sqrNumber = number * number;

// вывод результат на экран
Console.WriteLine($"Квадрат вашего числа = {sqrNumber}");
