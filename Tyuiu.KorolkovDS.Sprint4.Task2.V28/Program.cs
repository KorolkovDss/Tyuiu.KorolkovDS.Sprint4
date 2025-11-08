using Tyuiu.KorolkovDS.Sprint4.Task2.V28.Lib;
DataService ds  = new DataService();
Random rnd  = new Random();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Введите количество элементов массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];
for (int i = 0; i <= len - 1; i++)
{
    array[i] = rnd.Next(2,9);
}
Console.WriteLine("Массив: ");
for  (int i = 0;i <= len - 1; i++)
{
    Console.WriteLine(array[i] + "\t");
}
Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Сумма нечетных чисел массива = " + ds.Calculate(array));
Console.ReadKey();
