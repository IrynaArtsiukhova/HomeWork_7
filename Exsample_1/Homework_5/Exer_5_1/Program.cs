// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


Console.Clear();
Console.Write("Введите строку: ");
int row = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int col = Convert.ToInt32(Console.ReadLine()) - 1;
int x = 10; 
int y = 10; 
Random random = new Random();
int[,] arr = new int[x, y];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
{
    arr[i, j] = random.Next(10, 100);
Console.Write("{0} ", arr[i, j]);
}
Console.WriteLine();
}
    if (row < 0 | row > arr.GetLength(0) - 1 | col < 0 | col > arr.GetLength(1) - 1)
{
Console.WriteLine("Такого элемента нет ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[row, col]);
}
Console.ReadLine();
