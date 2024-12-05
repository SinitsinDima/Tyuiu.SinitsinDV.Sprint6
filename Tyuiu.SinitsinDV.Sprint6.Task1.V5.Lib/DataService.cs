﻿using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SinitsinDV.Sprint6.Task1.V5.Lib
{
    public class DataService : ISprint6Task1V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double [len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if(x == 0)
                {
                   y = 0;
                }
                else
                {
                    y = Math.Sin(x) + (Math.Cos(2 * x) / 2) - 1.5 * x;
                    
                }
                
                Math.Round(valueArray[count] = y);
                count++;


            }
            return valueArray;
        }
    }
}
