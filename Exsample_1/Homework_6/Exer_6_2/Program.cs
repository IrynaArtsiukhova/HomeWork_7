// Задача 2. Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

Console.WriteLine("Введите строку");
    string str = Console.ReadLine();
    string []str1 = new string [str.Length];
    for (int i = 0 ; i < str.Length ; i ++)
    {
        str1[i] = Convert.ToString(str[i]);
    }
    for (int i = 0 ; i < str.Length ; i ++)
    {
        if (str[i] == str.ToUpper()[i])
        {
            str1[i] = Convert.ToString(str.ToLower()[i]);
        }
    }
    str = "";
    for (int i = 0 ; i < str1.Length ; i ++)
    {
        str += str1[i];
    }
    Console.WriteLine("Измененная строка : " + str);