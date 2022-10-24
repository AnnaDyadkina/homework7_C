// Напишите программу, которая на вход принимает позиции элемента в двумерном
//массиве, и возвращает значение этого элемента
//или же указание, что такого элемента нет.
int m = Prompt("Количество строк");
int n = Prompt("Количество столбцов");

int[,] newArray = CreateArray(m, n);
PrintArray (newArray);

// int findNumber = Prompt("Введите искомое число");
// FindValue(findNumber, newArray);

int findRow = Prompt("Введите номер строки");
int findColumn = Prompt("Введите номер стобца");
FindValue(findRow, findColumn, newArray);

int[,] CreateArray (int m, int n)
{
  int[,] array = new int[m, n];
  for (int i =0; i < m; i++)
  {
    for (int j = 0; j<n; j++)
    {
      array[i, j] = new Random().Next(-100, 101);
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

// void FindValue (int find, int[,] array)
// {
//   string findResult = String.Empty;
//   for (int i =0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j<array.GetLength(1); j++)
//     {
//       if (array[i, j] == find)
//       {
//         findResult = findResult + ", [" + i + ", " + j + "]";
//       }
//     }
//   }
//   if (findResult.Length == 0)
//   {
//     Console.WriteLine("Такого числа нет");
//   }
//   else
//   {
//     Console.WriteLine("Индекс в массиве" + findResult.Remove(0, 1));
//   }
// }

void FindValue (int row, int column, int[,] array)
{
  if (row < array.GetLength(0) && column < array.GetLength(1))
  {
    Console.WriteLine(array[row, column]);
  }
  else
  {
    Console.WriteLine("Такого числа нет");
  }
}
