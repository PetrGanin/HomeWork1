// ввод 2-х значное число и вывод является ли оно кратным или нет.
Console.WriteLine("введите чиcло");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе чиcло");
int b = Convert.ToInt32(Console.ReadLine());
int c = a%b;
int c1 = a/b;
if (c == 0)
{ 

    Console.WriteLine("является кратным" + c1);
}
else
{
    Console.WriteLine($"не является кратным {c} остаток");
}