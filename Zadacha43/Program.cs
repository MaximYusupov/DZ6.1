// Задача 43 (ДОП, по желанию, на 5 нужно сделать 2 задачки): Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int num;
        Console.Write("Введите целое число: ");
        num = Convert.ToInt32(Console.ReadLine()!);
        int decimalnum;
        string rem = "";
        while (num >= 1)
        {
            decimalnum = num / 2;
            rem += (num % 2).ToString();
            num = decimalnum;
        }
        string bin = "";
        for (int i = rem.Length - 1; i >= 0; i--)
        {
            bin = bin + rem[i];
        }
        Console.WriteLine($"Двоичное число : {bin}");