using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFunction
{
    public class FileInfoClass
    {
        public void FileInfomethod()
        {
            Console.WriteLine("Create file:");
            string filePath = @"E:\task\FileFunction\FileInfo\Sample.txt";
            FileInfo file = new FileInfo(filePath);

            using (FileStream fs = file.Create())
            {
                Console.WriteLine("File is created successfully.");
            }

            using (StreamWriter sw = file.CreateText())
            {
                sw.WriteLine("The FileInfo class is used to deal with file and its operations in C#. ");
            }

            using (StreamReader sr = file.OpenText())
            {
                Console.WriteLine(sr);
            }

            using (StreamWriter sw = file.AppendText())
            {
                sw.WriteLine("It uses StreamWriter class to write data to the file. It is a part of System.IO namespace.");
            }

            try {

                string filePath1 = @"E:\task\FileFunction\FileInfo\Copypath\file copy.txt";
                FileInfo fi1 = new FileInfo(filePath);
                fi1.CopyTo(filePath1);
                Console.WriteLine("{0} was copied to {1}.", filePath, filePath1);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            FileInfo fi = new FileInfo(filePath);
            Console.WriteLine($"File name is {fi.Name}");
            Console.WriteLine($"File creation time is {fi.CreationTime.ToLongTimeString()}");
            Console.WriteLine($"File last access time is {fi.LastAccessTime.ToLongDateString()}");
            Console.WriteLine($"File length is {fi.Length.ToString()} Bytes");
            Console.WriteLine($"File extension is {fi.Extension}");
            Console.WriteLine($"File exists: {fi.Exists}");
            Console.WriteLine($"File last write time is {fi.LastWriteTime}");
            Console.ReadLine();




        }
    }
}
