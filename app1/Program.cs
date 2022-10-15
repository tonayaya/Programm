// напишите программу, которая на вход принимает целое число и выдает его квадрат

// запрос числа от пользователя
Console.Write("Ввести число: ");
int number = Convert.ToInt32(Console.ReadLine());

// вычисление квадрата исходного числа
int sqrNumber = number * number;

// вывод результата на экран
Console.WriteLine($"Квадрат вашего числа = {sqrNumber}");