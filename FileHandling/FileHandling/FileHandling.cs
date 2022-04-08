using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    internal class FileHandling
    {

        public void WriteFile()
        {
            FileStream fileStream = new FileStream(@"C:\users\khush\source\repos\training.txt", FileMode.Create, FileAccess.Write);

            StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteLine("Heyya Welcome");
            writer.WriteLine("C# training");
            writer.Close();
            fileStream.Close();
        }
        public void ReadFile()
        {
            FileStream fileStream = new FileStream(@"C:\users\khush\source\repos\training.txt", FileMode.Open, FileAccess.Read);

            StreamReader reader = new StreamReader(fileStream);
            while (reader.Peek() > 0)
            {
                Console.WriteLine(reader.ReadLine());
            }
            public void ReadFile()
            {
                FileStream fileStream = new FileStream(@"C:\users\khush\source\repos\networklog.txt", FileMode.Open, FileAccess.Read);

                StreamReader reader = new StreamReader(fileStream);
                Console.WriteLine("Id\t Source\t  Destination\t Date \t   Status \t  Network");
                while (reader.Peek() > 0)
                {

                    var id = reader.ReadLine();
                    string[] idstr = id.Split(':');
                    string nid = idstr[1];

                    var source = reader.ReadLine();
                    string[] SourceStr = source.Split(':');
                    string Source = SourceStr[1];

                    var dest = reader.ReadLine();
                    string[] destStr = dest.Split(':');
                    string Dest = destStr[1];

                    string Date = reader.ReadLine();

                    string time = "";



                    var status = reader.ReadLine();
                    string[] StatusStr = status.Split(':');
                    string Status = StatusStr[1];

                    var network = reader.ReadLine();
                    string[] ntwkStr = network.Split(':');
                    string ntwk = ntwkStr[1];
                    Console.WriteLine(nid + "\t" + Source + "\t" + Dest + "\t" + Date + "\t" + time + "\t" + Status + "\t " + ntwk);

                    reader.ReadLine();

                }

            }
        } } }

