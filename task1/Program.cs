Console.Write("Введите коэффициенты k и b первой функции, через пробел: ");
var firstFunctionСoefficient = (Console.ReadLine() ?? "").Split().Select(int.Parse).ToArray();
Console.Write("Введите коэффициенты k и b второй функции, через пробел: ");
var secondFunctionСoefficient = (Console.ReadLine() ?? "").Split().Select(int.Parse).ToArray();
var x = (secondFunctionСoefficient[1] - firstFunctionСoefficient[1]) / (firstFunctionСoefficient[0] - secondFunctionСoefficient[0]);
var y = (firstFunctionСoefficient[0] *  x) + firstFunctionСoefficient[1];
Console.WriteLine($"Точка пересечения фунций ({x}, {y}) ");