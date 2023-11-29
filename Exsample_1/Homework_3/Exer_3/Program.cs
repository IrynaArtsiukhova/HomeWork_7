// Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементом массива.

static double[] AFAWNZD(int length) 

 {
     double[] array = new double[length];
     Random random = new Random();

     for (int i = 0; i < length; i++)
     {
         double randomNumber = Math.Round(random.NextDouble() * 10, 2);
         array[i] = randomNumber;
     }
     return array;
 }

 void PrintArray(double[] InMass)
 {
     Console.Write("Массив с элементами: ");
     for (int i = 0; i < InMass.Length; i++)
     {
         Console.Write(InMass[i] + " ");
     }
 }

 void DON(double[] InMass) 
 {
     double max = InMass[0];
     double min = InMass[0];

     foreach (double num in InMass)
     {
         if (num > max)
             max = num;

         if (num < min)
             min = num;
     }

     double difference = max - min;

     Console.WriteLine();
     Console.WriteLine($"Максимальный элемент: {max}");
     Console.WriteLine($"Минимальный элемент: {min}");
     Console.WriteLine($"Разница: {difference}");
 }

 int arrayLength = 25;
 double[] myArray = AFAWNZD(arrayLength);
 PrintArray(myArray);
 DON(myArray);