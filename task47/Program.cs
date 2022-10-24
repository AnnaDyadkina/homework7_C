// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
int m = Prompt("Количество строк");
int n = Prompt("Количество столбцов");

double[,] newArray = CreateArray(m, n);
PrintArray (newArray);

double[,] CreateArray (int m, int n)
{
  double[,] array = new double[m, n];
  for (int i =0; i < m; i++)
  {
    for (int j = 0; j<n; j++)
    {
      array[i, j] = new Random().Next(-100, 101);
      array[i, j] = array[i, j]* new Random().NextDouble();
      array[i, j] = Math.Round(array[i, j], 2);
    }
  }
  return array;
}

void PrintArray (double[,] array)
{
  for (int i =0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j<array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
  }
}

int Prompt (string message)
{
  Console.WriteLine(message);
  int number = int.Parse(Console.ReadLine());
  return number;
}
