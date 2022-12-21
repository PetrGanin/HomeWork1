// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("введите трехзначное чиcло");
string namber = Console.ReadLine();
string name = "-tom";

if (namber[0] == name[0])
{
    Console.WriteLine("вторым числом является");
    Console.WriteLine(namber[2]);
}
else
{
    Console.WriteLine("вторым числом является");
    Console.WriteLine(namber[1]);
}