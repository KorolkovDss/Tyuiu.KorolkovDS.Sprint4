using System.Runtime.CompilerServices;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KorolkovDS.Sprint4.Task4.V30.Lib
{
    public class DataService : ISprint4Task4V30
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] newmat = new int[matrix.GetLength(0), matrix.GetLength(1)];   
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] %2 != 0)
                    {
                        newmat[i, j] = 0;
                    }
                    else
                    {
                        newmat[i, j] = matrix[i, j];
                    }
                }
            }
            return newmat;
        }
    }
}
