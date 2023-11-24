//* Написать программу, которая принимает на вход число и проверяет
// кратно ли оно одновременно 7 и 23.

Console.Write("Введите число: ");

int x = int.Parse(Console.ReadLine ()!);

if (x % 7 == 0 && x % 23 == 0)
    Console.Write($"Число {x} кратно одновременно 7 и 23.");
else
{
     Console.Write($"Число {x} НЕ кратно одновременно 7 и 23.");
}
Console.WriteLine((int.Parse(Console.ReadLine()!) % 161 == 0));
