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

    }
    class LogicaController : IHardware
    {
        public List<LogicalDisk> LogicalDisks { get; private set; }
        DriveInfo[] allDrives = DriveInfo.GetDrives();

        public void Retrieve()
        {
            
            LogicalDisks = new List<LogicalDisk>();
            foreach (DriveInfo d in allDrives)
            {
                LogicalDisk disk = new LogicalDisk();
                disk.DriveFormat = d.DriveFormat;
                disk.DriveType = d.DriveType;
                disk.Name = d.Name;
                disk.DriveFormat = d.DriveFormat;
                disk.RootDirectory = d.RootDirectory;
                disk.TotalSize = d.TotalSize;
                disk.VolumeLabel = d.VolumeLabel;
                LogicalDisks.Add(disk);
            }

        }
        public void Update()
        {
            foreach (DriveInfo d in allDrives)
            {
                int count = 0;
                LogicalDisks[count].TotalFreeSpace = d.TotalFreeSpace;
                count++;
            }

        }

    }
}
