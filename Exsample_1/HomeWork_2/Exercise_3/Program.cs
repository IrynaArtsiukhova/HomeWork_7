// Напишите программу, которая принимает на вход целое число
// из отрезка от 10 до 99 и показывает наибольшую цифру числа


Console.Write("Введите число от 10 до 99: ");
int number = int.Parse(Console.ReadLine()!);
while (number < 10 || number > 99)
{
    Console.Write("Вы ввели неверное число!\nВведите число от 10 до 99: ");
    number = int.Parse(Console.ReadLine()!);
}
int firstNumber = number / 10;
int secondNumber = number % 10;
if (firstNumber > secondNumber)
{
    Console.WriteLine("Наибольшая цифра этого числа: " + firstNumber);
}
else
{
    Console.WriteLine("Наибольшая цифра этого числа: " + secondNumber);
}
