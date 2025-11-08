using Tyuiu.KorolkovDS.Sprint4.Task6.V1.Lib;
DataService ds  = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
var array = new string[] { "Яблоко", "Банан", "Вишня", "Драгонфрут", "Бузина", "Инжир", "Виноград" };
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Количество элементов длина которых > 6");
int res = ds.Calculate(array);
Console.WriteLine(res);
Console.ReadKey();