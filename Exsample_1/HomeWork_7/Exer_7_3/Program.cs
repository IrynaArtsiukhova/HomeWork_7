// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.


int SIZE = 5;
    int[] arr = new int [SIZE];
    Console.Write("Введите 1 элемент массива = ");
    arr[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите 2 элемент массива = ");
    arr[1] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите 3 элемент массива = ");
    arr[2] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите 4 элемент массива = ");
    arr[3] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите 5 элемент массива = ");
    arr[4] = Convert.ToInt32(Console.ReadLine());
    fun (arr , SIZE);
  static int fun(int[] arr , int SIZE)
  {
    Console.Write(arr[SIZE-1]+" ");
    SIZE--;
    if (SIZE == 0)
    {
        return 0;
    }
    return fun(arr , SIZE);    
  }