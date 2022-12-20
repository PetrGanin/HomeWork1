// Напишите программу, котороя выводит случайное трехзначное число и удаляет среднюю цифру.
int namber = new Random().Next(100,1000);
Console.WriteLine("трехзначное число: " + namber);
int namber1 = namber/100;
int namber2 = namber%10;
Console.Write(namber1);
Console.Write(namber2);