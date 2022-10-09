// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int firstnum, endnum;
string str;

 Console.Write("Введите пятизначное число: ");
    str = Console.ReadLine();
        firstnum = 0;
        endnum = str.Length - 1;

        if (endnum == 4)
            {
            while (firstnum < endnum && Char.IsDigit(str[firstnum]) && Char.IsDigit(str[endnum]))
                {
                    if (str[firstnum] == str[endnum])
                    {
                        firstnum++;
                        endnum = endnum - 1;
                    }
                    else
                    {
                        Console.WriteLine($" число {str} не является палиндромом");
                        firstnum = 5;
                    }
                }
                if (firstnum == 2) Console.WriteLine($"число {str} - палиндром");
                if (firstnum != 2 && firstnum != 5) Console.WriteLine($"{str} - ошибка ввода");
            }
            else Console.WriteLine("Ошибка ввода");