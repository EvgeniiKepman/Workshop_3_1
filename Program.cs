// Задача 19.
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);

int n1 = number / 10000;
int n2 = number / 1000 % 10;
int n4 = number / 10 % 10;
int n5 = number % 10;

if (n1 == n5 && n2 == n4)
    Console.WriteLine("Да, введенное число является полиндромом.");
else
    Console.WriteLine("Нет, введенное число не является полиндромом.");
