//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];
void array(int a) {
    for (int i = 0; i < a; i++) {
        randomArray[i] = new Random().Next(99,999+1);
        Console.WriteLine(randomArray[i] + " ");
    }
}
int Length(int[] randomArray) {
    int Length = 0;
    for (int i = 0; i < randomArray.Length; i++) {
        if (randomArray[i] % 2 == 0)
        Length ++;
    }
    return Length;
}
array(a);
Console.Write($"Количество чётных чисел в массиве: {Length(randomArray)}");