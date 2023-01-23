// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
string num = Console.ReadLine()??" ";
int leng = num.Length;

if (leng == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"Число {num} - Палиндром");
    }
    else
    {
        Console.WriteLine($"Число {num} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: Число {num} - не является пятизначным");
}
