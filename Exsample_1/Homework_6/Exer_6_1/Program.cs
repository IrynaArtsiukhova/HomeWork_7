//  Задача 1. Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива.

 Console.WriteLine("Введите массив");
    char[,] arr = new char[2,3];
    for (int i = 0 ; i < arr.GetLength(0) ; i++)
    {
        for (int j = 0 ; j < arr.GetLength(1) ; j++)
        {
            Console.Write("Введите элемент " +(i+1)+ " строки " + (j+1) + " столбца " + " массива : ");
            arr[i,j] = Convert.ToChar(Console.ReadLine());
        }
    }
    Console.WriteLine();
    Console.WriteLine("Массив");
    for (int i = 0 ; i < arr.GetLength(0) ; i++)
    {
        for (int j = 0 ; j < arr.GetLength(1) ; j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
    string str = "";
    for (int i = 0 ; i < arr.GetLength(0) ; i++)
    {
        for (int j = 0 ; j < arr.GetLength(1) ; j++)
        {
            str += arr[i,j];
        }
    }
    Console.WriteLine();
    Console.WriteLine("Строка");
    Console.WriteLine(str);
