﻿namespace Tyuiu.GubanovaSO.Sprint7.Project.V12.Lib
{
    public class DataService
    {
        public string CollectTextFromFile(string path, string row, int column)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            string[,] matrix = new string[rows, columns];
            string[] models = new string[rows];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    matrix[r, c] = Convert.ToString(line_r[c]);
                    if (c == 0)
                    {
                        models[r] = Convert.ToString(line_r[c]);
                    }
                }
            }

            string res = "";
            for (int i = 0; i < rows; i++)
            {
                if (i == Array.IndexOf(models, row))
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j == column)
                        {
                            res = matrix[i, j];
                        }
                    }
                }
            }
            return res;
        }

        public string CollectTextFromFileInt(string path, int row, int column)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            string[,] matrix = new string[rows, columns];
            string[] models = new string[rows];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    matrix[r, c] = Convert.ToString(line_r[c]);
                    if (c == 0)
                    {
                        models[r] = Convert.ToString(line_r[c]);
                    }
                }
            }

            string res = "";
            for (int i = 0; i < rows; i++)
            {
                if (i == row)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j == column)
                        {
                            res = matrix[i, j];
                        }
                    }
                }
            }
            return res;
        }
    }
}