﻿using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SinitsinDV.Sprint6.Task6.V9.Lib
{
    public class DataService : ISprint6Task6V9
    {
        public string CollectTextFromFile(string str, string path)
        {
            string lastWord = null;  

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    
                    if (line.Contains(str))
                    {
                        
                        var words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        if (words.Length > 0)
                        {
                            lastWord = words[words.Length - 1]; 
                        }
                    }
                }
            }

            return lastWord;  
        }
    }
}