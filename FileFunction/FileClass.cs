namespace FileFunction
{
    public class FileClass
    {
        public void filemethod()
        {
            string PathName = @"E:\task\FileFunction\files\Demo.txt";
            File.WriteAllText(PathName, "The File class provides us built-in methods that allow us to perform input / output operations on files.");
            Console.WriteLine("File create successfully....");

            string fileread = File.ReadAllText(PathName);
            Console.WriteLine(fileread);

            File.AppendAllText(PathName, "\nArunKumar");
            Console.WriteLine("Add Extra Text");

            string PathName1 = @"E:\task\FileFunction\files\copypath\copyFile.txt";
            if (!File.Exists(PathName1))
            {
                File.Copy(PathName, PathName1);
            }
            Console.WriteLine("Copied Successfully...");

            string PathName2 = @"E:\task\FileFunction\files\movefile\Demo.txt";
            if (!File.Exists(PathName2))
            {
                File.Move(PathName, PathName2);
            }
            Console.WriteLine("Moved Successfully...");


            File.Delete(PathName2);
            Console.WriteLine("Delete Successfully..."); 


        }



    }
}
