using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KorolkovDS.Sprint4.Task3.V5.Lib
{
    public class DataService : ISprint4Task3V5
    {
        public int Calculate(int[,] array)
        {
            int res = 0;
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0;  j < columns - 1; j++)
                {
                    if (j ==1)
                        res += array[i, j];
                }

            }
            return res;
        }
    }
}
