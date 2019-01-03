using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace HardwareMonitor.Hardware
{
    public class MemoryBank {

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
        
        #region "comment"
        //public enum Form : ushort {Unknown, Other, SIP, DIP, ZIP, SOJ, Proprietary, SIMM, DIMM, TSOP, PGA, RIMM, SODIMM, SRIMM, SMD, SSMP, QFP, TQFP, SOIC, LCC, PLCC, BGA, FPBGA, LGA }
        //public enum MemType : ushort { Unknown, Other, DRAM , Synchronous_DRAM, Cache_DRAM, EDO, EDRAM, VRAM , SRAM, RAM, ROM , Flash , EEPROM , FEPROM , EPROM , CDRAM, _3DRAM , SDRAM , SGRAM , RDRAM , DDR , DDR2 , DDR2_FB_DIMM, DDR3=24, FBD2 }
        //public enum DetailType : ushort { Reserved =1, Other , Unknown =4, Fast_paged=8, Static_column =16,Pseudo_static=32, RAMBUS=64, Synchronous=128, CMOS =256, EDO=512, Window_DRAM=1024, Cache_DRAM=2048, Non_volatile=4096}
        //public List<uint> Attributes { get; private set; }
        //public List<string> BankLabel { get; private set; }
        //public List<ulong> Capacity { get; private set; }
        //public List<string> Caption { get; private set; }
        //public List<uint> ConfiguredClockSpeed { get; private set; }
        //public List<uint> ConfiguredVoltage { get; private set; }
        //public List<string> CreationClassName { get; private set; }
        //public List<ushort> DataWidth { get; private set; }
        //public List<string> Description { get; private set; }
        //public List<string> DeviceLocator { get; private set; }
        //public List<Form> FormFactor { get; private set; }
        //public List<bool> HotSwappable { get; private set; }
        //public List<DateTime> InstallDate { get; private set; }
        //public List<ushort> InterleaveDataDepth { get; private set; }
        //public List<uint> InterleavePosition { get; private set; }
        //public List<string> Manufacturer { get; private set; }
        //public List<uint> MaxVoltage { get; private set; }
        //public List<MemType> MemoryType { get; private set; }
        //public List<uint> MinVoltage { get; private set; }
        //public List<string> Model { get; private set; }
        //public List<string> Name { get; private set; }
        //public List<string> OtherIdentifyingInfo { get; private set; }
        //public List<string> PartNumber { get; private set; }
        //public List<uint> PositionInRow { get; private set; }
        //public List<bool> PoweredOn { get; private set; }
        //public List<bool> Removable { get; private set; }
        //public List<bool> Replaceable { get; private set; }
        //public List<string> SerialNumber { get; private set; }
        //public List<string> Sku { get; private set; }
        //public List<uint> SmbiosMemoryType { get; private set; }
        //public List<uint> Speed { get; private set; }
        //public List<string> Status { get; private set; }
        //public List<string> Tag { get; private set; }
        //public List<ushort> TotalWidth { get; private set; }
        //public List<DetailType> TypeDetail { get; private set; }
        //public List<string> Version { get; private set; }
        #endregion
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
                MemoryBank MemBank = new MemoryBank();

                MemBank.Attributes = ((uint)(managementObject.Properties["Attributes"]?.Value ?? default(uint)));
                MemBank.BankLabel = ((string)(managementObject.Properties["BankLabel"]?.Value));
                MemBank.Capacity = ((ulong)(managementObject.Properties["Capacity"]?.Value ?? default(ulong)));
                MemBank.Caption = ((string)(managementObject.Properties["Caption"]?.Value));
                MemBank.ConfiguredClockSpeed = ((uint)(managementObject.Properties["ConfiguredClockSpeed"]?.Value ?? default(uint)));
                MemBank.ConfiguredVoltage = ((uint)(managementObject.Properties["ConfiguredVoltage"]?.Value ?? default(uint)));
                MemBank.CreationClassName = ((string)(managementObject.Properties["CreationClassName"]?.Value));
                MemBank.DataWidth = ((ushort)(managementObject.Properties["DataWidth"]?.Value ?? default(ushort)));
                MemBank.Description = ((string)(managementObject.Properties["Description"]?.Value));
                MemBank.DeviceLocator = ((string)(managementObject.Properties["DeviceLocator"]?.Value));
                MemBank.FormFactor = ((MemoryBank.Form)(managementObject.Properties["FormFactor"]?.Value ?? default(ushort)));
                MemBank.HotSwappable = ((bool)(managementObject.Properties["HotSwappable"]?.Value ?? default(bool)));
                MemBank.InstallDate = (ManagementDateTimeConverter.ToDateTime(managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"));
                MemBank.InterleaveDataDepth = ((ushort)(managementObject.Properties["InterleaveDataDepth"]?.Value ?? default(ushort)));
                MemBank.InterleavePosition = ((uint)(managementObject.Properties["InterleavePosition"]?.Value ?? default(uint)));
                MemBank.Manufacturer = ((string)(managementObject.Properties["Manufacturer"]?.Value));
                MemBank.MaxVoltage = ((uint)(managementObject.Properties["MaxVoltage"]?.Value ?? default(uint)));
                MemBank.MemoryType = ((MemoryBank.MemType)(managementObject.Properties["MemoryType"]?.Value ?? default(ushort)));
                MemBank.MinVoltage = ((uint)(managementObject.Properties["MinVoltage"]?.Value ?? default(uint)));
                MemBank.Model = ((string)(managementObject.Properties["Model"]?.Value));
                MemBank.Name = ((string)(managementObject.Properties["Name"]?.Value));
                MemBank.OtherIdentifyingInfo = ((string)(managementObject.Properties["OtherIdentifyingInfo"]?.Value));
                MemBank.PartNumber = ((string)(managementObject.Properties["PartNumber"]?.Value));
                MemBank.PositionInRow = ((uint)(managementObject.Properties["PositionInRow"]?.Value ?? default(uint)));
                MemBank.PoweredOn = ((bool)(managementObject.Properties["PoweredOn"]?.Value ?? default(bool)));
                MemBank.Removable = ((bool)(managementObject.Properties["Removable"]?.Value ?? default(bool)));
                MemBank.Replaceable = ((bool)(managementObject.Properties["Replaceable"]?.Value ?? default(bool)));
                MemBank.SerialNumber = ((string)(managementObject.Properties["SerialNumber"]?.Value));
                MemBank.Sku = ((string)(managementObject.Properties["SKU"]?.Value));
                MemBank.SmbiosMemoryType = ((uint)(managementObject.Properties["SMBIOSMemoryType"]?.Value ?? default(uint)));
                MemBank.Speed = ((uint)(managementObject.Properties["Speed"]?.Value ?? default(uint)));
                MemBank.Status = ((string)(managementObject.Properties["Status"]?.Value));
                MemBank.Tag = ((string)(managementObject.Properties["Tag"]?.Value));
                MemBank.TotalWidth = ((ushort)(managementObject.Properties["TotalWidth"]?.Value ?? default(ushort)));
                MemBank.TypeDetail = ((MemoryBank.DetailType)(managementObject.Properties["TypeDetail"]?.Value ?? default(ushort)));
                MemBank.Version = ((string)(managementObject.Properties["Version"]?.Value));
                MemoryBanks.Add(MemBank);
                TotalMemory += MemBank.Capacity;
            }
            
            
                
              
            
        }
         
    }
}
