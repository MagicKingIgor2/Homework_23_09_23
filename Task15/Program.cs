// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
const int k = 0;
const int b = 1;
const int x_coord = 0;
const int y_coord = 1;
const int Line1 = 1;
const int Line2 = 2;
double[] LineData1 = InputLineData(Line1);
double[] LineData2 = InputLineData(Line2);
if (ValidateLines(LineData1, LineData2)) {
    double[] coord = Findcoord(LineData1, LineData2);
    Console.WriteLine($"Точка пересечения уравнений y={LineData1[k]}*x+{LineData1[b]} и y={LineData2[k]}*x+{LineData2[b]}");
    Console.WriteLine($"Имеет координаты [{coord[x_coord]};{coord[y_coord]}]");
}
double Prompt(string message) {
    Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}
double[] InputLineData(int numberofLine) {
    double[] LineData = new double[2];
    LineData[k] = Prompt($"Введите коэффициент k для {numberofLine} прямой: ");
    LineData[b] = Prompt($"Введите константу b для {numberofLine} прямой: ");
    return LineData;
}
double[] Findcoord(double[] LineData1, double[] LineData2) {
    double[] coord = new double[2];
    coord[x_coord] = (LineData1[b] - LineData2[b]) / (LineData1[k] - LineData2[k]);
    coord[y_coord] = LineData1[k]*coord[x_coord] + LineData1[b];
    return coord;
}
bool ValidateLines(double[] LineData1, double[] LineData2) {
    if (LineData1[k] == LineData2[k]) {
        if (LineData1[b] == LineData2[b]) {
            Console.Write("Прямые совпадают");
            return false;
        }
        else {
            Console.Write("Прямые параллельны");
            return false;
        }
    }
    return true;
}