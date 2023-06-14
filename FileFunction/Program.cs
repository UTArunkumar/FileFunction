using FileFunction;
using System;
namespace filefunction
{
    class exception
    {
        public void method()
        {
            try
            {
                string[] clours = { "Red", "Green", "White", "Black" };
                foreach (string clour in clours)
                {
                    Console.Write(clour[4]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally exception excute");
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            //Exception handling
            Console.WriteLine("Exception handling: ");
            exception obj = new exception();
            obj.method();

            Console.WriteLine();
            FileClass fileclass = new FileClass();
            fileclass.filemethod();
            FileInfoClass fileinfoclass = new FileInfoClass();
            fileinfoclass.FileInfomethod();
            DirctoryinfoClass DirctoryinfoClass = new DirctoryinfoClass();
            DirctoryinfoClass.Dirctoryinfomethod();
            PathClass Pathclassmethod = new PathClass();
            Pathclassmethod.Pathmethod();
            DriveinfoClass driveinfo = new DriveinfoClass();
            driveinfo.Driveinfomethod();
        }
    }
}