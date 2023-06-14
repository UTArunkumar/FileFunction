using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFunction
{
    public class DriveinfoClass
    {
        public void Driveinfomethod()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive != null)
                {
                    Console.WriteLine("Drive Name : " + drive.Name);
                    Console.WriteLine("Drive Volume name : " + drive.VolumeLabel);
                    Console.WriteLine("Drive Format : " + drive.DriveFormat);
                    Console.WriteLine("Drive Type : " + drive.DriveType);
                    Console.WriteLine("Drive root directory name : " + drive.RootDirectory);
                    Console.WriteLine("Drive free space: " + drive.AvailableFreeSpace);
                    Console.WriteLine("Total Free space on the drive : " + drive.TotalFreeSpace);
                    Console.WriteLine("Total disk size : " + drive.TotalSize);
                    Console.WriteLine();
                }
            }
        }
    }
}
