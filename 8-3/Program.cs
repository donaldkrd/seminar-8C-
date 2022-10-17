// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
int m = InputNumbers("Число строк 1-й матрицы: ");
int n = InputNumbers("Число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон чисел: от 1 до ");

int[,] firstArray = new int[m, n];
CreateArray(firstArray);
Console.WriteLine($"\nПервая матрица:");
PrintArray(firstArray);

int[,] secomdArray = new int[n, p];
CreateArray(secomdArray);
Console.WriteLine($"\nВторая матрица:");
PrintArray(secomdArray);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstArray, secomdArray, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstArray, int[,] secomdArray, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstArray.GetLength(1); k++)
      {
        sum += firstArray[i,k] * secomdArray[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}
void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}