// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int summ(int m, int n) {
    if (m == n)
    return n;
    else return m + summ(m + 1, n);
    }
Console.Write($"Сумма натуральных элементов в промежутке от {m} до {n} равно {summ(m,n)}");
