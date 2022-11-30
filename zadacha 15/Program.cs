// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите натуральное число ");
int x =  Convert.ToInt32(Console.ReadLine());
{
    if (x == 1) Console.WriteLine("Понедельник");
    else if (x == 2) Console.WriteLine("Вторник");
    else if (x == 3) Console.WriteLine("Среда");
    else if (x == 4) Console.WriteLine("Четверг");
    else if (x == 5) Console.WriteLine("Пятница");
    else if (x == 6) Console.WriteLine("Суббота");
    else if (x == 7) Console.WriteLine("Воскресенье");
}
if (x > 0 && x < 8)
{
    if (x == 6 || x == 7)
    {
        Console.Write("Выходной");
    }
    else
    {
        Console.Write("Рабочий");
    }
}
else
{
    Console.Write("Не соответствует 7 дням недели");
}