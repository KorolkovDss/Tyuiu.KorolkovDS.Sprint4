using Tyuiu.KorolkovDS.Sprint4.Task7.V15.Lib;
DataService ds =  new DataService();
int n = 4;
int m = 2;
int[,] matrix = new int[n, m];
string value = "10293847";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
int index = 0;
Console.WriteLine("\nМассив: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.WriteLine($"{value[i]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int res = ds.Calculate(n, m, value);
Console.WriteLine("Количество нечетных элементов массива = " + res);
Console.ReadKey();
