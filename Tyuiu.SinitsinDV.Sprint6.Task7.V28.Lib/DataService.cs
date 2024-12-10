using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SinitsinDV.Sprint6.Task7.V28.Lib
{
    public class DataService : ISprint6Task7V28
    {
        public int[,] GetMatrix(string path)
        {
            
            var lines = File.ReadAllLines(path);

            
            var rowCount = lines.Length;
            var colCount = lines[0].Split(';').Length;

            
            int[,] matrix = new int[rowCount, colCount];

            
            for (int i = 0; i < rowCount; i++)
            {
                var values = lines[i].Split(';');
                for (int j = 0; j < colCount; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            
            if (rowCount >= 7)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (matrix[6, j] != 13)  
                    {
                        matrix[6, j] = 0;
                    }
                }
            }

            return matrix;
        }
    }
}
