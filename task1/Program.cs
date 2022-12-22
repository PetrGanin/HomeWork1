// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7: ");
int namber = Convert.ToInt32(Console.ReadLine());
switch ((namber))
{
    case 1:
        Console.WriteLine("Понедельник - рабочий");
        break;
    case 2:
        Console.WriteLine("Вторник - рабочий");
        break;
    case 3:
        Console.WriteLine("Среда - рабочий");
        break;
    case 4:
        Console.WriteLine("Четверг - рабочий");
        break;
    case 5:
        Console.WriteLine("Пятница - рабочий");
        break;
    case 6:
        Console.WriteLine("Суббота - выходной");
        break;
    case 7:
        Console.WriteLine("Воскресение - выходной");
        break;
}
if (namber > 7)
{
    Console.WriteLine("такого дня недели нет");
}