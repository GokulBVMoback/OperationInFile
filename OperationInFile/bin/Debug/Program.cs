using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationInFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory());//, "Report.txt");
            Console.WriteLine(path);    
            //string path = $".\\Report.txt";
            //using (FileStream fs = File.Open(path, FileMode.Open)) ;
            //string readText = File.ReadAllText(path);
            //Console.WriteLine(readText);
        }
    }
}
