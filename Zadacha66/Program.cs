// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
// элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число число: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число число: ");
int number2 = int.Parse(Console.ReadLine());


int Val (int N, int M)
{
    if (N == M) return M;
    int temp = N + Val (N + 1 , M - 1) + M;
    return temp;
}


Console.WriteLine();
Console.WriteLine(Val (number1, number2));