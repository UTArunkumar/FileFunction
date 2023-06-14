using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFunction
{
    public class DirctoryinfoClass
    {
        public void Dirctoryinfomethod()
        {
            // Get  DirectoryInfo 
            string path = @"E:\task\FileFunction\directoryinfo";
            DirectoryInfo fl = new DirectoryInfo(path);
            fl.Create();
            {
                Console.WriteLine("Directory has been created");
            }

            //Grt SubDirectoryInfo
            string path1 = @"E:\task\FileFunction\directoryinfo\direct";
            DirectoryInfo fls = new DirectoryInfo(path1);
            DirectoryInfo dis = fls.CreateSubdirectory("hellotest");
            {
                Console.WriteLine("SubDirectory has been created");
            }

            //Moveto another DirectoryInfo
            try
            {
                string path2 = @"E:\task\FileFunction\directoryinfo\directoryinfo2";
                DirectoryInfo dir = new DirectoryInfo(path);
                dir.MoveTo(path2);
                {
                    Console.WriteLine("Directory has been Moved");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Directory has been deleted
            Directory.Delete(path1, true);
            Console.WriteLine("Directory has been deleted");

            //File created time
            string filename = (path);
            Directory.SetCreationTime(filename, DateTime.Now);
            DateTime dt = Directory.GetCreationTime(filename);
            Console.WriteLine("File created time: {0}", dt.ToString());

            //GetAll Directories
            string root = @"C:\Users\VISUAL~1";
            string[] subdirectory = Directory.GetDirectories(root);
            foreach (string subdir in subdirectory)
            {
                Console.WriteLine(subdir);
            }

            //GetDirectories on file 
            string fileroot = @"C:\Users\VISUAL~1";
            string[] subfiles = Directory.GetFiles(fileroot);
            foreach (string subdir in subfiles)
            {
                Console.WriteLine(subdir);
            }

            bool have = Directory.Exists(@"E:\task\FileFunction");
            Console.WriteLine(have);
        }
    }
}
