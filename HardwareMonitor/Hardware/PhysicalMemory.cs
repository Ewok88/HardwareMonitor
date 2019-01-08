using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace HardwareMonitor.Hardware
{
    public class MemoryBank {

       public MemoryBank()
        {
            BankLabel = "Unknown";            
            Caption = "Unknown";
            CreationClassName = "Unknown";
            Description = "Unknown";
            DeviceLocator = "Unknown";
            Manufacturer = "Unknown";
            Model = "Unknown";
            Name = "Unknown";
            OtherIdentifyingInfo = "Unknown";
            PartNumber = "Unknown";
            SerialNumber = "Unknown";
            Sku = "Unknown";
            Status = "Unknown";
            Tag = "Unknown";
            Version = "Unknown";
        }
        
        public enum Form : ushort { Unknown, Other, SIP, DIP, ZIP, SOJ, Proprietary, SIMM, DIMM, TSOP, PGA, RIMM, SODIMM, SRIMM, SMD, SSMP, QFP, TQFP, SOIC, LCC, PLCC, BGA, FPBGA, LGA }
        public enum MemType : ushort { Unknown, Other, DRAM, Synchronous_DRAM, Cache_DRAM, EDO, EDRAM, VRAM, SRAM, RAM, ROM, Flash, EEPROM, FEPROM, EPROM, CDRAM, _3DRAM, SDRAM, SGRAM, RDRAM, DDR, DDR2, DDR2_FB_DIMM, DDR3 = 24, FBD2 }
        public enum DetailType : ushort { Reserved = 1, Other, Unknown = 4, Fast_paged = 8, Static_column = 16, Pseudo_static = 32, RAMBUS = 64, Synchronous = 128, CMOS = 256, EDO = 512, Window_DRAM = 1024, Cache_DRAM = 2048, Non_volatile = 4096 }

        public uint Attributes { get; set; }
        public string BankLabel { get;  set; }
        public  ulong Capacity { get;  set; }
        public  string Caption { get;  set; }
        public  uint ConfiguredClockSpeed { get;  set; }
        public  uint ConfiguredVoltage { get;  set; }
        public  string CreationClassName { get;  set; }
        public  ushort DataWidth { get;  set; }
        public  string Description { get;  set; }
        public  string DeviceLocator { get;  set; }
        public  Form FormFactor { get;  set; }
        public  bool HotSwappable { get;  set; }
        public  DateTime InstallDate { get;  set; }
        public  ushort InterleaveDataDepth { get;  set; }
        public  uint InterleavePosition { get;  set; }
        public  string Manufacturer { get;  set; }
        public  uint MaxVoltage { get;  set; }
        public  MemType MemoryType { get;  set; }
        public  uint MinVoltage { get;  set; }
        public  string Model { get;  set; }
        public  string Name { get;  set; }
        public  string OtherIdentifyingInfo { get;  set; }
        public  string PartNumber { get;  set; }
        public  uint PositionInRow { get;  set; }
        public  bool PoweredOn { get;  set; }
        public  bool Removable { get;  set; }
        public  bool Replaceable { get;  set; }
        public  string SerialNumber { get;  set; }
        public  string Sku { get;  set; }
        public  uint SmbiosMemoryType { get;  set; }
        public  uint Speed { get;  set; }
        public  string Status { get;  set; }
        public  string Tag { get;  set; }
        public  ushort TotalWidth { get;  set; }
        public  DetailType TypeDetail { get;  set; }
        public  string Version { get;  set; }
    }
    
    class PhysicalMemory : IHardware
    {
        public ulong TotalMemory { get; set; }
        public List<MemoryBank> MemoryBanks { get; private set; }

        public void Retrieve()
        {
            ManagementObjectSearcher searcher =
                   new ManagementObjectSearcher("root\\CIMV2",
                  "SELECT * FROM Win32_PhysicalMemory");
            MemoryBanks = new List<MemoryBank>();
           
            foreach (ManagementObject managementObject in searcher.Get())
            {
                MemoryBank memBank = new MemoryBank();
                try
                {
                   
                    memBank.Capacity = ((ulong)(managementObject.Properties["Capacity"]?.Value ?? default(ulong)));
                    memBank.Attributes = ((uint)(managementObject.Properties["Attributes"]?.Value ?? default(uint)));
                    memBank.BankLabel = ((string)(managementObject.Properties["BankLabel"]?.Value));
                    memBank.Caption = ((string)(managementObject.Properties["Caption"]?.Value));
                    memBank.ConfiguredClockSpeed = ((uint)(managementObject.Properties["ConfiguredClockSpeed"]?.Value ?? default(uint)));
                    memBank.ConfiguredVoltage = ((uint)(managementObject.Properties["ConfiguredVoltage"]?.Value ?? default(uint)));
                    memBank.CreationClassName = ((string)(managementObject.Properties["CreationClassName"]?.Value));
                    memBank.DataWidth = ((ushort)(managementObject.Properties["DataWidth"]?.Value ?? default(ushort)));
                    memBank.Description = ((string)(managementObject.Properties["Description"]?.Value));
                    memBank.DeviceLocator = ((string)(managementObject.Properties["DeviceLocator"]?.Value));
                    memBank.FormFactor = ((MemoryBank.Form)(managementObject.Properties["FormFactor"]?.Value ?? default(ushort)));
                    memBank.HotSwappable = ((bool)(managementObject.Properties["HotSwappable"]?.Value ?? default(bool)));
                    memBank.InstallDate = (ManagementDateTimeConverter.ToDateTime(managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"));
                    memBank.InterleaveDataDepth = ((ushort)(managementObject.Properties["InterleaveDataDepth"]?.Value ?? default(ushort)));
                    memBank.InterleavePosition = ((uint)(managementObject.Properties["InterleavePosition"]?.Value ?? default(uint)));
                    memBank.Manufacturer = ((string)(managementObject.Properties["Manufacturer"]?.Value));
                    memBank.MaxVoltage = ((uint)(managementObject.Properties["MaxVoltage"]?.Value ?? default(uint)));
                    memBank.MemoryType = ((MemoryBank.MemType)(managementObject.Properties["MemoryType"]?.Value ?? default(ushort)));
                    memBank.MinVoltage = ((uint)(managementObject.Properties["MinVoltage"]?.Value ?? default(uint)));
                    memBank.Model = ((string)(managementObject.Properties["Model"]?.Value));
                    memBank.Name = ((string)(managementObject.Properties["Name"]?.Value));
                    memBank.OtherIdentifyingInfo = ((string)(managementObject.Properties["OtherIdentifyingInfo"]?.Value));
                    memBank.PartNumber = ((string)(managementObject.Properties["PartNumber"]?.Value));
                    memBank.PositionInRow = ((uint)(managementObject.Properties["PositionInRow"]?.Value ?? default(uint)));
                    memBank.PoweredOn = ((bool)(managementObject.Properties["PoweredOn"]?.Value ?? default(bool)));
                    memBank.Removable = ((bool)(managementObject.Properties["Removable"]?.Value ?? default(bool)));
                    memBank.Replaceable = ((bool)(managementObject.Properties["Replaceable"]?.Value ?? default(bool)));
                    memBank.SerialNumber = ((string)(managementObject.Properties["SerialNumber"]?.Value));
                    memBank.Sku = ((string)(managementObject.Properties["SKU"]?.Value));
                    memBank.SmbiosMemoryType = ((uint)(managementObject.Properties["SMBIOSMemoryType"]?.Value ?? default(uint)));
                    memBank.Speed = ((uint)(managementObject.Properties["Speed"]?.Value ?? default(uint)));
                    memBank.Status = ((string)(managementObject.Properties["Status"]?.Value));
                    memBank.Tag = ((string)(managementObject.Properties["Tag"]?.Value));
                    memBank.TotalWidth = ((ushort)(managementObject.Properties["TotalWidth"]?.Value ?? default(ushort)));
                    memBank.TypeDetail = ((MemoryBank.DetailType)(managementObject.Properties["TypeDetail"]?.Value ?? default(ushort)));
                    memBank.Version = ((string)(managementObject.Properties["Version"]?.Value));
                    
                }
                catch (Exception ex){}

                finally
                {
                    TotalMemory += memBank.Capacity;
                    MemoryBanks.Add(memBank);
                }
            }

        }
         
    }
}
