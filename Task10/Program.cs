// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
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
    Console.Write("]");
}
int Length = Prompt("Длина массива: ");
int min = Prompt("Введите минимальное значение для диапазона массива: ");
int max = Prompt("Введите максимальное значение для диапазона массива: ");
int[] array = generateArray(Length, min, max);
printArray(array);