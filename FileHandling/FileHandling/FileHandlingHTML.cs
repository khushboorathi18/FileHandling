using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class FileHandlingDocTypeClass
    {
        public void ReadFile()
        {
            FileStream fileStream = new FileStream(@"C:\Users\khush\source\repos\HTML.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            Console.WriteLine("Input tags are:");
            int count = 0;
            string Word = "<input";
            while (reader.Peek() > 0)
            {
                string line = reader.ReadLine();
                if (line.Contains(Word))
                {
                    Console.WriteLine(line);
                    count++;
                }
            }
            Console.WriteLine("Number of <input = " + count);
            reader.Close();
            fileStream.Close();
        }
    }
}