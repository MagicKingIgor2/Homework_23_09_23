//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
int Figure(string message) {
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool Weekend(int days) {
    if (days > 5) {
        return true;
    }
    return false;
}
bool needday(int number) {
    if (number > 0 && number <= 7) {
        return true;
    }
    Console.WriteLine("Такого дня недели нет!");
    return false;
}
int days = Figure("Введите день недели: ");
if (needday(days)) {
    if (Weekend(days)) {
        Console.WriteLine("Выходной");
    }
    else {
        Console.WriteLine("Рабочий день");
    }
}
