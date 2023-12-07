// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


static void Main()
    {
        Console.Write("Введите количество строк массива: ");
        int numRows;
         while (!int.TryParse(Console.ReadLine(), out numRows) || numRows <= 0)
        {
            Console.WriteLine("Ошибка. Введите положительное число строк массива.");
         }

        Console.Write("Введите количество столбцов массива: ");
        int numCols;

        while (!int.TryParse(Console.ReadLine(), out numCols) || numCols <= 0)
        {
            Console.WriteLine("Ошибка. Введите положительное число столбцов массива.");
        }

        // Генерируем двумерный массив, заполненный случайными числами
        int[,] randomNumbersArray = GenerateRandomNumbersArray(numRows, numCols);

        Console.WriteLine("Сгенерированный массив:");
        DisplayArray(randomNumbersArray);  

        Console.Write("\nВведите номер строки: ");
        int row;

        while (!int.TryParse(Console.ReadLine(), out row) || row < 0 || row >= numRows)
        {
            Console.WriteLine($"Ошибка. Введите номер строки (0 to {numRows - 1}).");
        }

        Console.Write("Введите номер столбца: ");
        int col;

        while (!int.TryParse(Console.ReadLine(), out col) || col < 0 || col >= numCols)
        {
            Console.WriteLine($"Ошибка. Введите номер столбца (0 to {numCols - 1}).");
        }

        int elementValue = GetElementValue(randomNumbersArray, row, col);
        if (elementValue != int.MinValue)
        {
            Console.WriteLine($"\nЗначение элемента ({row}, {col}): {elementValue}");
        }
        else
        {
            Console.WriteLine($"\nТакого элемента нет ({row}, {col}).");
        }
    }

    static int[,] GenerateRandomNumbersArray(int numRows, int numCols)
    {
        Random random = new Random();
        int[,] numbersArray = new int[numRows, numCols];

         for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                numbersArray[i, j] = random.Next(1, 100); // Генерируем случайное число в диапазоне от 1 до 100
            }
        }

        return numbersArray;
    }

    static void DisplayArray(int[,] array)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int GetElementValue(int[,] array, int row, int col)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        if (row >= 0 && row < numRows && col >= 0 && col < numCols)
        {
            return array[row, col];
        }
        else
        {
            return int.MinValue; // Указывает на отсутствие такого элемента
        }
    }
