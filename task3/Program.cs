int[,] MakeArray(int size)
{
    var rnd = new Random();
    int[,] expArray = new int[size,size];
    for (int i = 0; i < size; i++)
        for (int j = 0; j < size; j++)
            expArray[i,j] = rnd.Next(1, 100);
    return expArray;
}

int[,] CopyArray(int[,] origin)
{
    int[,] newArray = new int[origin.GetLength(0), origin.GetLength(1)];
    for (int i = 0; i < origin.GetLength(0); i++)
        for (int j = 0; j < origin.GetLength(1); j++)
            newArray[i,j] = origin[i,j];
    return newArray;
}

Console.Write("Введите размерность массива: ");
var n  = int.Parse(Console.ReadLine() ?? "");
var expArray = MakeArray(n);
var copyArray = CopyArray(expArray);
Console.WriteLine("Готово!");
