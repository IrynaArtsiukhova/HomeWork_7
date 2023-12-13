// Задача 3: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


Console.WriteLine("Введите размер массива");
    Console.Write("x = ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("y = ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] arr = new int [n,m];
    Random rand = new Random();
    Console.WriteLine("Массив случайных чисел : ");
    for(int i = 0; i < n ; i++)
    {
        for(int j = 0; j < m ; j++)
        {
            arr[i,j] = rand.Next(10,100);
            Console.Write(arr[i,j]+" ");
        }
        Console.WriteLine();
    }
    int min = 0;
    for(int j = 0; j < m ; j++)
    {
        min += arr[0,j];
    }
    int num = 0;
    for(int i = 0; i < n ; i++)
    {
        int sum = 0;
        for(int j = 0; j < m ; j++)
        {
            sum += arr[i,j];
        }
        if(min>sum)
        {
            min = sum;
            num = i + 1;
        }
    }
    Console.WriteLine("Строка с наименьшими числами - " + num + ", их сумма равна = " + min);