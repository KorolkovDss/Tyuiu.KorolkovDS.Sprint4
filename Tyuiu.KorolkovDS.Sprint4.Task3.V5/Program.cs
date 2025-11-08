using Tyuiu.KorolkovDS.Sprint4.Task3.V5.Lib;
DataService ds = new DataService();
int[,] array = new int[5, 5] { { 3, 4, 8, 6, 3 },
                               { 9, 9, 3, 6, 9 }, 
                               { 5, 6, 7, 2, 3 }, 
                               { 3, 6, 2, 3, 8 }, 
                               { 5, 7, 2, 6, 4 } };

int rows = array.GetUpperBound(0) + 1;
int columns = array.Length / rows;

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Массив: ");

for  (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.WriteLine($"{array[i, j]} \t");
    }
}

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Сумма элементов первого столбца " + ds.Calculate(array));
Console.ReadKey();