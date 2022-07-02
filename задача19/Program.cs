// Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int n1 = Convert.ToInt32(Console.ReadLine());
string palindrome(int n)
{
    if (n < 10000 ^ n > 99999)
    {
        return "число не пятизначное";
    }
    else if (n / 10000 == n % 10 && (n / 1000) % 10 == (n / 10) % 10)
    {
        return "палиндром";
    }
    else
    {
        return "не палиндром";
    }
}
Console.WriteLine(palindrome(n1));