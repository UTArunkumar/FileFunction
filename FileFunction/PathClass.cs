using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFunction
{
    public class PathClass
    {
        public void Pathmethod()
        {
            //GetFileName
            Console.WriteLine("GetFileName: ");
            string pathname = @"E:\task\FileFunction\FileFunction\DirctoryinfoClass.cs";
            string fileName = Path.GetFileName(pathname);
            Console.WriteLine(fileName);

            //GetDirectoryName
            Console.WriteLine("GetDirectoryName: ");
            string pathdirectory = pathname;
            string dirname = Path.GetDirectoryName(pathdirectory);
            Console.WriteLine(dirname);

            //GetFullPath
            Console.WriteLine("GetFullPath: ");
            string fullpath = pathname;
            string fullPath1 = Path.GetFullPath(fullpath);
            Console.WriteLine(fullPath1);


            //Combiningpath
            Console.WriteLine("Combiningpath: ");
            string Combiningpath1 = @"E:\task\FileFunction";
            string Combiningpath2 = @"E:\task\FileFunction\FileFunction";
            string Combiningpath = Path.Combine(Combiningpath1, Combiningpath2);
            Console.WriteLine(Combiningpath);

            //GetExtension
            Console.WriteLine("GetExtension: ");
            string path = pathname;
            string  extansion = Path.GetExtension(path);
            Console.WriteLine(extansion);

            //GetTempFileName
            Console.WriteLine("GetTempFileName: ");
            string tempFileName = Path.GetTempFileName();
            Console.WriteLine(tempFileName);

            //GetTempPath
            Console.WriteLine("GetTempPath: ");
            string tempDir = Path.GetTempPath();
            Console.WriteLine(tempDir);

            //ChangeExtension
            Console.WriteLine("ChangeExtension: ");
            string change = Path.ChangeExtension(@"C:\temp\readme.txt", ".csv");
            Console.WriteLine(change);

        }
    }
}
