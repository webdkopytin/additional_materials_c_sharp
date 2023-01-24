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

            #region FileInfo

            ////using System.IO;
            //// Предоставляет свойства и методы экземпляра для создания, копирования, удаления,
            //// перемещения и открытия файлов, а также позволяет создавать объекты System.IO.FileStream.
            //// Этот класс не наследуется. Просмотреть исходный код .NET Framework для этого
            //// типа Reference Source.

            //FileInfo fileInfo = new FileInfo(@"E:\data.txt");

            //Console.WriteLine(fileInfo.Attributes);     // Archive
            //Console.WriteLine(fileInfo.Exists);         // True
            //Console.WriteLine(fileInfo.Extension);      // .txt
            //Console.WriteLine(fileInfo.IsReadOnly);     // False
            //Console.WriteLine(fileInfo.LastAccessTime); // 22.08.2025 18:52:14
            //Console.WriteLine(fileInfo.LastWriteTime);  // 22.08.2025 18:52:14
            //Console.WriteLine(fileInfo.FullName);       // E:\data.txt
            //Console.WriteLine(fileInfo.Name);           // data.txt
            //Console.WriteLine(fileInfo.DirectoryName);  // E:\

            #endregion

            #region Directory, DirectoryInfo

            //// using System.IO;
            //// Предоставляет статические методы для создания, перемещения и перечисления в каталогах и вложенных каталогах. 

            ////Directory.CreateDirectory
            ////Directory.Delete
            ////Directory.Exists
            ////Directory.Move

            //DirectoryInfo directoryInfo = new DirectoryInfo(@"c:\");

            ////directoryInfo.Attributes
            ////directoryInfo.Create
            ////directoryInfo.Delete
            ////directoryInfo.Exists
            ////directoryInfo.FullName
            ////directoryInfo.Name
            ////directoryInfo.Root
            ////directoryInfo.GetDirectories
            ////directoryInfo.GetFiles

            //GetDir(@"D:\ Work\Skill");
            ////GetDir(@"C:\Program Files\Windows Defender");

            #endregion
        }

        /// <summary>
        /// Получение всех файлов и папок выбранного каталога
        /// </summary>
        /// <param name = "path" > Путь к каталогу</param>
        /// <param name = "trim" > Количество отступов</param>
        static void GetDir(string path, string trim = "")
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);  // Получаем информацию о текущем каталоге

            foreach (var item in directoryInfo.GetDirectories())    // Перебираем все подкаталоги текущего каталога
            {
                Console.WriteLine($"{trim}{item.Name}");            // Выводим информацию о нём
                GetDir(item.FullName, trim + "    ");               // Запускаем "просмотре" вложенного каталога
            }

            foreach (var item in directoryInfo.GetFiles())          // Перебираем все файлы текущего каталога
            {
                Console.WriteLine($"{trim}{item.Name}");            // Выводим информацию о них
            }
        }
    }
}
