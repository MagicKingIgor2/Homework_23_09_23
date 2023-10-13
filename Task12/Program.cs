//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int Prompt(string message) {
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int[] generateArray (int Length, int minValue, int maxValue) {
    int[] array = new int [Length];
    Random random = new Random();
    for (int i = 0; i < Length; i ++) {
        array[i] = random.Next(minValue, maxValue +1);
       }
    return array;
}
void printArray (int[] array) {
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i ++) {
        Console.Write($"{array[i]} ");
        }
    Console.Write($"{array[array.Length-1]}");
    Console.WriteLine("]");
}
int Length = Prompt("Длина массива: ");
int min = Prompt("Введите минимальное значение для диапазона массива: ");
int max = Prompt("Введите максимальное значение для диапазона массива: ");
int[] array = generateArray(Length, min, max);
int sumOdd(int[] array) {
    int sum = 0;
    int i = 1;
    while (i < Length) {
        sum = sum + array[i];
        i = i + 2;
    }
    return sum;
}
printArray(array);
Console.Write($"Сумма элементов, находящихся на нечетных позициях равна {sumOdd(array)}");