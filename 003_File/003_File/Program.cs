using System;
using System.IO;

namespace _003_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region File

            // using System.IO;
            // Предоставляет статические методы для создания, копирования, удаления, перемещения и открытия 

            string text = File.ReadAllText(@"e:\data.txt"); // Открывает текстовый файл, считывает все строки файла и затем закрывает файл.

            Console.WriteLine(text);

            string[] lines = File.ReadAllLines(@"e:\data.txt"); // Открывает текстовый файл, считывает все строки файла и затем закрывает файл.

            foreach (var line in lines) Console.WriteLine($">>{line}<<");

            lines = new string[] { "один", "два", "три" };

            File.WriteAllLines(@"e:\data2.txt", lines); // Создает новый файл, записывает в него указанный массив строк и затем закрывает файл

            text = "Пример текста";
            File.WriteAllText(@"e:\data3.txt", text);   // Создает новый файл, записывает в него указанную строку и затем закрывает файл.
                                                        // Если целевой файл уже существует, он будет переопределен.

            //File.AppendAllLines
            //File.AppendAllText

            File.Copy(@"e:\data3.txt", @"e:\newdata3.txt"); // Копирует существующий файл в новый файл. Перезапись файла с тем же именем не разрешена.

            File.Exists(@"e:\newdata3.txt"); // Определяет, существует ли заданный файл.

            File.Delete(@"e:\newdata3.txt"); // Удаляет указанный файл.

            File.Exists(@"e:\newdata3.txt"); // Определяет, существует ли заданный файл.

            File.Move(@"e:\data3.txt", @"d:\newdata3.txt"); // Перемещает заданный файл в новое местоположение и разрешает переименование файла.

            #endregion
        }
    }
}
