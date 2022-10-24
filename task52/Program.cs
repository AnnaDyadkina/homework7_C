// Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце
int m = Prompt("Количество строк");
int n = Prompt("Количество столбцов");

int[,] newArray = CreateArray(m, n);
PrintArray (newArray);
sumColumn (newArray);

int[,] CreateArray (int m, int n)
{
  int[,] array = new int[m, n];
  for (int i =0; i < m; i++)
  {
    for (int j = 0; j<n; j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
  return array;
}

void PrintArray (int[,] array)
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

void sumColumn (int[,] array)
{
  double sum = 0;
  string result = "Среднее арифметическое каждого столбца: ";
  for (int i =0; i < array.GetLength(1); i++)
  {
    sum = 0;
    for (int j = 0; j<array.GetLength(0); j++)
    {
      sum = sum + array[j, i];
    }
    double average = sum / array.GetLength(0);
    average = Math.Round(average, 2);
    result = result + average + ", ";
  }
  Console.WriteLine(result.Remove(result.Length-2));
}
