// Задача 3. Задайте произвольную строку. Выясните, является ли она палиндромом.


Console.WriteLine("Введите строку");
    string str = Console.ReadLine();
    string str1 = "";
    for (int i = 0 ; i < str.Length ; i++)
    {
        str1 += str[str.Length-1-i];
    }
    int kol = 0;
    for (int i = 0 ; i < str.Length ; i++)
    {
        if (str[i] == str1[i])
        {
            kol++;
        }
    }
    if (kol == str.Length)
    {
        Console.WriteLine("строка является палиндромом");
    }
    else
    {
        Console.WriteLine("строка не является палиндромом");
    }