using Tyuiu.KorolkovDS.Sprint4.Task0.V28.Lib;
DataService ds  = new DataService();
int[] array = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Исходный массив");
for (int i = 0; i < array.Length - 1; i++)
{
    Console.WriteLine(array[i]);
}
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Произведение четных чисел массива = " + ds.GetMultEvenArrEl(array));
Console.ReadKey();