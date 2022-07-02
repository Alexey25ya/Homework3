// Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
void cube(int n)
{
    int i = 1;
    while (i <= n)
    {
    
     Console.WriteLine(Math.Pow(i, 3));
        i++;
    }
}
cube(N);