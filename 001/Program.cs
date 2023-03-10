// Напишите программу, которая будет принимать на вход число и возвращать сумму цифр
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int SumNumbers(int N)
{

    if (N / 10 < 1)
    {
        return N;
    }
    else
    {
        return (N % 10 + SumNumbers(N / 10));
    }
}
Console.WriteLine(SumNumbers(N));