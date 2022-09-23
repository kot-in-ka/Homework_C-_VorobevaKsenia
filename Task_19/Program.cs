// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число ");
string x = Console.ReadLine();
void xnumber()
{
    if (x.Length == 5)
{
    if ((x[0] == x[4]) && (x[1] == x[3]))
    {
        Console.WriteLine("Это палиндром"); 
    }
    else
    Console.WriteLine("Это не палиндром"); 
}
else
Console.WriteLine("Это не пятизначное число");
}
xnumber ();

