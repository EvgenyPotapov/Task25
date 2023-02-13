// Задача 25: Напишите цикл, который принимает на вход
//два числа (A и B) и возводит число A в натуральную
// степень B. Реализовать функцию возведения в степень
// самостоятельно!

Console.Clear();

double MathPow(int num, int st)
{
    double n = Math.Pow(num, st);
    return n; 
}

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

double math = MathPow(A, B);
Console.WriteLine($"{A}, {B} -> {math}");