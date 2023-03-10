// Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N
Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);
// Метод вывода строк
string PrintNumbers(int M, int N)
{
    if (M == N)
    {
        Console.WriteLine(N);
        return M.ToString();
    }
    else
    {
        string s = PrintNumbers(M, N - 1) + " " + N.ToString();
        Console.WriteLine(s);
        return s;
    }
}
Console.WriteLine(PrintNumbers(M, N));