// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
double Prompt(string message) {
    Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}
double[] generateArray (double Length, double minValue, double maxValue) {
    double[] array = new double [Length];
    Random random = new Random();
    for (int i = 0; i < Length; i ++) {
        array[i] = random.Next(minValue, maxValue +1);
       }
    return array;
}
void printArray (double[] array) {
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i ++) {
        Console.Write($"{array[i]} ");
        }
    Console.Write($"{array[array.Length-1]}");
    Console.WriteLine("]");
}
double Length = Prompt("Длина массива: ");
double min = Prompt("Введите минимальное значение для диапазона массива: ");
double max = Prompt("Введите максимальное значение для диапазона массива: ");
double[] array = generateArray(Length, min, max);
printArray(array);
