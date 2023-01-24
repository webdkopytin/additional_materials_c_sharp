using System;
using System.IO;
using System.Text;

namespace _008_StringReaderWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // using System.IO;
            // Реализует объект System.IO.TextWriter для записи сведений в строку. 
            // Сведения хранятся в базовом System.Text.StringBuilder.

            StringBuilder sb = new StringBuilder(100);
            string s = "Расширенная работа со строками: StringReader и StringWriter, изменяемые строки: StringBuilder";
            sb.Append(s);
            Console.WriteLine(sb);

            using (StringWriter sw = new StringWriter(sb))
            {
                sw.Write("!!!");
            };
            Console.WriteLine(sb);

            // Реализует System.IO.TextReader считывает данные из строки.
            using (StringReader sr = new StringReader(s))
            {
                char[] buf = new char[5];
                sr.ReadBlock(buf, 0, buf.Length);
            };
        }
    }
}
