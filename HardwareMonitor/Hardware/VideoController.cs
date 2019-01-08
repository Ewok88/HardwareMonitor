using System;
using System.Collections.Generic;
using System.Management;


namespace HardwareMonitor.Hardware
{
    public class VideoCard  
    {
        public enum Architecture : ushort { Other = 1, Unknown, CGA, EGA, VGA, SVGA, MDA, HGC, MCGA, _8514A, _XGA, Linear_Frame_Buffer, PC_98 = 160 }
        public enum MemoryType : ushort { Other = 1, Unknown, VRAM, DRAM, SRAM, WRAM, EDO_RAM, Burst_Synchronous_DRAM, Pipelined_Burst_SRAM, CDRAM, _3DRAM, SDRAM, SGRAM }
        public enum Available : ushort
        {
            Other = 1, Unknown, Running_Full_Power, Warning, In_Test, Not_Applicable, Power_Off, OffLine, OffDuty, Degraded, Not_Installed, Install_Error,
            Power_Save_Unknown, Power_Save_Low_Power_Mode, Power_Save_Standby, Power_Cycle, Power_Save_Warning, Paused, Not_Ready, Not_Configured, Quiesced
        }

        public ushort[] AcceleratorCapabilities { get; set; }
        public string AdapterCompatibility { get; set; }
        public string AdapterDacType { get;  set; }
        public uint AdapterRam { get;  set; }
        public Available Availability { get;  set; }
        public string Caption { get;  set; }
        public uint ConfigManagerErrorCode { get;  set; }
        public bool ConfigManagerUserConfig { get;  set; }
        public string CreationClassName { get;  set; }
        public uint CurrentBitsPerPixel { get;  set; }
        public uint CurrentHorizontalResolution { get;  set; }
        public ulong CurrentNumberOfColors { get;  set; }
        public uint CurrentRefreshRate { get;  set; }
        public uint CurrentVerticalResolution { get;  set; }
        public string Description { get;  set; }
        public string DeviceId { get;  set; }
        public DateTime DriverDate { get;  set; }
        public string DriverVersion { get;  set; }
        public string InfFilename { get;  set; }
        public string InfSection { get;  set; }
        public DateTime InstallDate { get;  set; }
        public string InstalledDisplayDrivers { get;  set; }
        public uint MaxRefreshRate { get;  set; }
        public uint MinRefreshRate { get;  set; }
        public bool Monochrome { get;  set; }
        public string Name { get;  set; }
        public string PnpDeviceId { get;  set; }
        public string Status { get;  set; }
        public ushort StatusInfo { get;  set; }
        public string SystemCreationClassName { get;  set; }
        public string SystemName { get;  set; }
        public Architecture VideoArchitecture { get;  set; }
        public MemoryType VideoMemoryType { get;  set; }
        public string VideoModeDescription { get;  set; }
        public string VideoProcessor { get;  set; }

        public string GetManufacturer(string _manufact)
        {
            _manufact = _manufact.ToLower();
            string intel = "intel";
            string amd = "amd";
            string nvidia = "nvidia";

            if (_manufact.IndexOf(intel) > -1)
            {
                return intel;
            }
            else if (_manufact.IndexOf(amd) > -1)
            {
                return amd;
            }
            else if (_manufact.IndexOf(nvidia) > -1)
            {
                return nvidia;
            }
            else
            {
                return "videocard";
            }
        }
    }

    public sealed class VideoController : IHardware
    {
        public List<VideoCard> VideoCards { get; private set; }

        
        public void Retrieve()
        {
                ManagementObjectSearcher searcher =
                       new ManagementObjectSearcher("root\\CIMV2",
                      "SELECT * FROM Win32_VideoController");

                VideoCards = new List<VideoCard>();


            foreach (ManagementObject managementObject in searcher.Get())
            {

                VideoCard card = new VideoCard();
                try
                {
                    card.AcceleratorCapabilities = (ushort[])(managementObject.Properties["AcceleratorCapabilities"]?.Value);
                    card.AdapterCompatibility = (string)(managementObject.Properties["AdapterCompatibility"]?.Value);
                    card.AdapterDacType = ((string)(managementObject.Properties["AdapterDACType"]?.Value));
                    card.AdapterRam = ((uint)managementObject.Properties["AdapterRAM"]?.Value);
                    card.Availability = ((VideoCard.Available)managementObject.Properties["Availability"]?.Value);
                    card.Caption = ((string)(managementObject.Properties["Caption"]?.Value));
                    card.ConfigManagerErrorCode = ((uint)managementObject.Properties["ConfigManagerErrorCode"]?.Value);
                    card.ConfigManagerUserConfig = ((bool)(managementObject.Properties["ConfigManagerUserConfig"]?.Value ?? default(bool)));
                    card.CreationClassName = ((string)(managementObject.Properties["CreationClassName"]?.Value));
                    card.CurrentBitsPerPixel = ((uint)(managementObject.Properties["CurrentBitsPerPixel"]?.Value ?? default(uint)));
                    card.CurrentHorizontalResolution = ((uint)(managementObject.Properties["CurrentHorizontalResolution"]?.Value ?? default(uint)));
                    card.CurrentNumberOfColors = ((ulong)(managementObject.Properties["CurrentNumberOfColors"]?.Value ?? default(ulong)));
                    card.CurrentRefreshRate = ((uint)(managementObject.Properties["CurrentRefreshRate"]?.Value ?? default(uint)));
                    card.CurrentVerticalResolution = ((uint)(managementObject.Properties["CurrentVerticalResolution"]?.Value ?? default(uint)));
                    card.Description = ((string)(managementObject.Properties["Description"]?.Value));
                    card.DeviceId = ((string)(managementObject.Properties["DeviceID"]?.Value));
                    card.DriverDate = (ManagementDateTimeConverter.ToDateTime(managementObject.Properties["DriverDate"]?.Value as string ?? "00010102000000.000000+060"));
                    card.DriverVersion = ((string)(managementObject.Properties["DriverVersion"]?.Value));
                    card.InfFilename = ((string)(managementObject.Properties["InfFilename"]?.Value));
                    card.InfSection = ((string)(managementObject.Properties["InfSection"]?.Value));
                    card.InstallDate = (ManagementDateTimeConverter.ToDateTime(managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"));
                    card.InstalledDisplayDrivers = ((string)(managementObject.Properties["InstalledDisplayDrivers"]?.Value));
                    card.MaxRefreshRate = ((uint)(managementObject.Properties["MaxRefreshRate"]?.Value ?? default(uint)));
                    card.MinRefreshRate = ((uint)(managementObject.Properties["MinRefreshRate"]?.Value ?? default(uint)));
                    card.Monochrome = ((bool)(managementObject.Properties["Monochrome"]?.Value ?? default(bool)));
                    card.Name = ((string)(managementObject.Properties["Name"]?.Value));
                    card.PnpDeviceId = ((string)(managementObject.Properties["PNPDeviceID"]?.Value));
                    card.Status = ((string)(managementObject.Properties["Status"]?.Value));
                    card.StatusInfo = ((ushort)(managementObject.Properties["StatusInfo"]?.Value ?? default(ushort)));
                    card.SystemCreationClassName = ((string)(managementObject.Properties["SystemCreationClassName"]?.Value));
                    card.SystemName = ((string)(managementObject.Properties["SystemName"]?.Value));
                    card.VideoArchitecture = ((VideoCard.Architecture)(managementObject.Properties["VideoArchitecture"]?.Value ?? default(ushort)));
                    card.VideoMemoryType = (VideoCard.MemoryType)(managementObject.Properties["VideoMemoryType"]?.Value ?? default(ushort));
                    card.VideoModeDescription = ((string)(managementObject.Properties["VideoModeDescription"]?.Value));
                    card.VideoProcessor = ((string)(managementObject.Properties["VideoProcessor"]?.Value));

                    

                }
                catch(Exception ex) { }
                finally { VideoCards.Add(card); }
                
                }
            
        }
    }
}
