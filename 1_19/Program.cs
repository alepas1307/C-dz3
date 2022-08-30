// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
String result = Convert.ToString(number);
if(number>9999 && number<100000)
{
    if(result[0]==result[4] && result[1]==result[3])
    {
        Console.WriteLine("Является полиндромом");
    }
    else
    {
        Console.WriteLine("Не является полиндромом");
    }
}
else
{
    Console.WriteLine("Число не является пятизначным");
}