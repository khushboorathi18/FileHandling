using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingDocTypeHansdsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHandlingDocTypeClass f = new FileHandlingDocTypeClass();
            f.ReadFile();
            Console.Read();
        }
    }
}