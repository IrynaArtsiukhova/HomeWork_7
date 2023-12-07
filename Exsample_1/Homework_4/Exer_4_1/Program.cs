// // Задача 1: 
// Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.


while (true)
{
    
    Console.WriteLine("Введите любое число от 10 до 999. Для завершения введите 'q' или число, сумма цифр которой четная:");
    string input = Console.ReadLine()!;

     if (input.ToLower() == "q")
    {
        Console.WriteLine("Вы ввели 'q', программа завершена");
        break;
    }

        if (int.TryParse(input, out int number))
    {
        
            int digitSum = CDS(number);

                if (digitSum % 2 == 0)
        {
            Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
            break;
        }
        else
        {
            Console.WriteLine("Продолжайте ввод.");
        }
    }
    else
    {
        
        Console.WriteLine("Некорректный ввод.");
    }
}


// Метод для вычисления суммы цифр числа.
int CDS(int num) // CDS = CalculateDigitSum
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}