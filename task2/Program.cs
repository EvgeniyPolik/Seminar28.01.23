int[] GetIntCoordinats(string origin)
{
    origin = origin.Remove(0, 1);
    origin = origin.Remove(origin.Length-1, 1);
    int[] result = origin.Split(',').Select(int.Parse).ToArray();
    return result;
}

int[][] MakeNewFigures(int[][] origin, int k)
{
    int [][] result = new int[origin.Length][];
    for (int i = 0; i < origin.Length; i++)
    {
        result[i] = new int[origin[i].Length];
        for (int j = 0; j < origin[i].Length; j ++)
            result[i][j] = origin[i][j] * k;
    }
    return result;
}

void PrintFigures(int[][] figure)
{
    for (int i = 0; i < figure.Length; i++)
    {
        Console.Write($"({figure[i][0]}, {figure[i][1]})");
        Console.Write(" ");
    }
    Console.WriteLine();

}

Console.Write("Введите координаты вершин через пробел, в формате: (0,0) (2,0) (2,2) (0,2): ");
string[] strArray = (Console.ReadLine() ?? "").Split();
int[][] coordinatsArray = new int[strArray.Length][];
var index = 0;
foreach (var str in strArray)
{
    coordinatsArray[index] = GetIntCoordinats(str);
    index++;
}

Console.Write("Введите коэффициент маштабирования: ");
var multiplier = int.Parse(Console.ReadLine() ?? "");
var newCoordinatArray = MakeNewFigures(coordinatsArray, multiplier);
Console.WriteLine("Исходная фигура: ");
PrintFigures(coordinatsArray);
Console.WriteLine("Маштабированая фигура: ");
PrintFigures(newCoordinatArray);



