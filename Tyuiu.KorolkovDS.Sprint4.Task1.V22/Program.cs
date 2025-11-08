using Tyuiu.KorolkovDS.Sprint4.Task1.V22.Lib;
DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Введите колличество элементов массива:");
int len;
len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];
for (int i = 0; i <= len-1; i++)
{
    Console.WriteLine("Введите значение " + i + " элемента массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Массив: ");
for (int i = 0; i <= len -1; i++)
{
    Console.WriteLine(array[i] + "\t");
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");
int res = ds.Calculate(array);
Console.WriteLine(res);
Console.ReadKey();
