using System.Security.Cryptography;
using Tyuiu.KorolkovDS.Sprint4.Task4.V30.Lib;
DataService ds  = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
Console.WriteLine("***************************************************************************");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.WriteLine($"Введите {i},{j} элемент массива: ");
        matrix[i,j]= Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("\nМассив: ");
for (int i = 0;i < rows; i++)
{
    for (int j = 0;j < columns; j++)
    {
        Console.WriteLine($"{matrix[i, j]} \t");

    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int[,] res = ds.Calculate(matrix);
Console.WriteLine("Массив без нечетных элементов:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(res[i, j] + "\t");
    }
}
    Console.ReadKey();