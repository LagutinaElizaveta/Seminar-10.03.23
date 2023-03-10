// Напишите программу, которая на вход принимает два числа A и B
// и возводит число А в целую степень В с помощью рекурсии
Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
// Метод возведения в степень
int ExponentiationNumbers(int A, int B)
{
    if (B == 0)
    {
        return 1;
    }
    else
    {
        return (A * ExponentiationNumbers(A, B - 1));
    }
}
Console.WriteLine($"Результат возведения числа {A} в степень {B} равен {ExponentiationNumbers(A, B)}");