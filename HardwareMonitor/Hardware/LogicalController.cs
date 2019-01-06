using System.Collections.Generic;
using System.IO;


namespace HardwareMonitor.Hardware
{
    class LogicalDisk
    {
        const int bytesInMegabyte = 1 << 20;
        public string DriveFormat { get; set; }
        public System.IO.DriveType DriveType { get; set; }
        public string Name { get; set; }
        public System.IO.DirectoryInfo RootDirectory { get; set; }
        public long TotalSize { get; set; }
        public string VolumeLabel { get; set; }
        public long TotalFreeSpace { get; set; }

        public int GetFreeSpaceInPerc()
        {
            int percent = (int)(TotalFreeSpace * 100 / TotalSize);
            return percent;
        }

        public int GetUsedSpaceInPerc()
        {
            int percent = 100 - GetFreeSpaceInPerc();
            return percent;
        }

        public double GetFreeSpaceInMegaBytes()
        {
            double megaBytes = TotalFreeSpace / bytesInMegabyte;
            return megaBytes;
        }

        public double GetUsedSpaceInMegaBytes()
        {
            double megaBytes = TotalSize / bytesInMegabyte - GetFreeSpaceInMegaBytes();
            return megaBytes; 
        }



    }
    class LogicaController : IHardware
    {
        public long TotalMemory { get; set; }
        public List<LogicalDisk> LogicalDisks { get; private set; }
        DriveInfo[] allDrives = DriveInfo.GetDrives();

        public void Retrieve()
        {
            
            LogicalDisks = new List<LogicalDisk>();
            foreach (DriveInfo d in allDrives)
            {
                LogicalDisk disk = new LogicalDisk();
                if (d.IsReady == true) {
                    disk.DriveFormat = d.DriveFormat;
                    disk.DriveType = d.DriveType;
                    disk.Name = d.Name;
                    disk.DriveFormat = d.DriveFormat;
                    disk.RootDirectory = d.RootDirectory;
                    disk.TotalSize = d.TotalSize;
                    disk.VolumeLabel = d.VolumeLabel;
                    LogicalDisks.Add(disk);
                    TotalMemory += d.TotalSize;
                }
            }

        }


        public void Update()
        {
            int count = 0;
            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady == true)
                {
                    LogicalDisks[count].TotalFreeSpace = d.TotalFreeSpace;
                }
                count++;
            }
        }

        

    }
}
