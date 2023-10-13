// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int Prompt(string message) {
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int[] Inputarray(int length) {
    int[] array = new int [length];
    for (int i = 0; i < array.Length; i++) {
        array[i] = Prompt($"Введите {i + 1}-й элемент: ");
    }
    return array;
}
void Printarray (int[] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}
int length = Prompt("Введите количество элементов: ");
int[] array;
array = Inputarray(length);
Printarray(array);
int CountPositive (int[] array) {
    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] > 0) {
            count ++;
        }
    }
    return count;
}
Console.WriteLine($"Количество чисел больше 0: {CountPositive(array)}");
