using System;
using System.Collections.Generic;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SinitsinDV.Sprint6.Task6.V9.Lib
{
    public class DataService : ISprint6Task6V9
    {
        public string CollectTextFromFile(string str, string path)
        {
            List<string> lastWords = new List<string>();  // Список для хранения последних слов

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Проверяем, содержит ли строка подстроку
                    if (line.Contains(str))
                    {
                        // Разделяем строку на слова и берем последнее
                        var words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        if (words.Length > 0)
                        {
                            lastWords.Add(words[words.Length - 1]);  // Добавляем последнее слово в список
                        }
                    }
                }
            }

            // Возвращаем все последние слова как одну строку, разделенную пробелами
            return string.Join(" ", lastWords);
        }
    }
}
