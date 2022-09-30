using System;
using System.Collections.Generic;
using System.Diagnostics;
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
           
            //For Read txt file
            string path =@"..\..\Report.txt";
            string fileRead=File.ReadAllText(path);
            Console.WriteLine(fileRead);
            Console.WriteLine("Path:" +path);
            //Console.WriteLine("Path:" + Path.Combine(Directory.GetCurrentDirectory()));

            //For Get the Name and Extension of the file
            FileInfo fileInfo = new FileInfo(path);
            string fileName = fileInfo.Name;
            string fileExtension = fileInfo.Extension;
            Console.WriteLine("File Name: "+fileName);
            Console.WriteLine("File Extension: "+fileExtension);

            using (StreamReader sr = File.OpenText(path))
            {
                int counter=0;//To Count the word
                string character = " ";//To split word in the docutment
                string[] fields = null;
                string line = null;

                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    line.Trim();
                    fields = line.Split(character.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    counter += fields.Length;
                }
                sr.Close();
                Console.WriteLine("\nThe word count is:{0}", counter);
            }
            
            string copyFile = @"..\..\For Copied File\Copy.txt";
            File.Copy(path, copyFile, true);

            string path2 =@"..\..\For Copied File\Copy.txt";
            using (StreamWriter sw = File.AppendText(path2))
            {
                sw.WriteLine("\n\t\t"+DateTime.Now);
                sw.Close();
            }
            string fileRead2 = File.ReadAllText(path2);
            Console.WriteLine(fileRead2);
            string copyFile2 = @"..\..\For Copied File\Copy2.txt";
            File.Copy(copyFile, copyFile2, true);
            Console.WriteLine("Path:" + path2);
            File.Delete(Path.Combine(@"..\..\For Copied File\Copy.txt"));
            Console.WriteLine("Copy.txt file was deleted.");
            Console.ReadKey();
        }
    }
 }
