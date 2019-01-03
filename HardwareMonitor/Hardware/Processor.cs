using System;
using System.Management;

namespace HardwareMonitor.Hardware
{
    class Processor : IHardware
    {
        public enum Architecture : ushort { x86, MIPS, Alpha, PowerPC, ia64 = 6, x64 = 9}
        public enum ProcType : ushort { Other=1, Unknown, Central_Processor, Math_Processor, DSP_Processor, Video_Processor}
        public ushort AddressWidth { get;  set; }
        public Architecture Architect { get; set; }
        public ushort Availability { get;  set; }
        public string Caption { get;  set; }
        public uint ConfigManagerErrorCode { get;  set; }
        public bool ConfigManagerUserConfig { get;  set; }
        public string CreationClassName { get;  set; }
        public uint CurrentClockSpeed { get;  set; }
        public ushort DataWidth { get;  set; }
        public string Description { get;  set; }
        public string DeviceId { get;  set; }
        public bool ErrorCleared { get;  set; }
        public string ErrorDescription { get;  set; }
        public uint ExtClock { get; set; }
        public ushort Family { get;  set; }
        public DateTime InstallDate { get;  set; }
        public uint L2CacheSize { get; set; }
        public uint L3CacheSize { get; set; }
        public uint LastErrorCode { get;  set; }
        public ushort LoadPercentage { get;  set; }
        public uint MaxClockSpeed { get;  set; }
        public string Name { get;  set; }
        public uint NumberOfCores { get; set; }
        public string OtherFamilyDescription { get;  set; }
        public string PnpDeviceId { get;  set; }
        public ushort[] PowerManagementCapabilities { get;  set; }
        public bool PowerManagementSupported { get;  set; }
        public ProcType ProcessorType { get; set; }
        public string Role { get;  set; }
        public uint Revision { get; set; }
        public string Status { get;  set; }
        public ushort StatusInfo { get;  set; }
        public string Stepping { get;  set; }
        public string SystemCreationClassName { get;  set; }
        public string SystemName { get;  set; }
        public uint ThreadCount { get; set; }
        public string UniqueId { get;  set; }
        public ushort UpgradeMethod { get;  set; }

		public void Retrieve()
		{
			ManagementObjectSearcher searcher =
				   new ManagementObjectSearcher( "root\\CIMV2",
				  "SELECT * FROM Win32_Processor" );
			foreach ( ManagementObject managementObject in searcher.Get() )
			{
                AddressWidth = (ushort)(managementObject.Properties["AddressWidth"]?.Value ?? default(ushort));
                Architect = (Architecture)(managementObject.Properties["Architecture"]?.Value);
                Availability = (ushort)(managementObject.Properties["Availability"]?.Value ?? default(ushort));
                Caption = (string)(managementObject.Properties["Caption"]?.Value);
                ConfigManagerErrorCode = (uint)(managementObject.Properties["ConfigManagerErrorCode"]?.Value ?? default(uint));
                ConfigManagerUserConfig = (bool)(managementObject.Properties["ConfigManagerUserConfig"]?.Value ?? default(bool));
                CreationClassName = (string)(managementObject.Properties["CreationClassName"]?.Value);
                CurrentClockSpeed = (uint)(managementObject.Properties["CurrentClockSpeed"]?.Value ?? default(uint));
                DataWidth = (ushort)(managementObject.Properties["DataWidth"]?.Value ?? default(ushort));
                Description = (string)(managementObject.Properties["Description"]?.Value);
                DeviceId = (string)(managementObject.Properties["DeviceID"]?.Value);
                ErrorCleared = (bool)(managementObject.Properties["ErrorCleared"]?.Value ?? default(bool));
                ErrorDescription = (string)(managementObject.Properties["ErrorDescription"]?.Value);
                ExtClock = (uint)(managementObject.Properties["ExtClock"]?.Value);
                Family = (ushort)(managementObject.Properties["Family"]?.Value ?? default(ushort));
                InstallDate = ManagementDateTimeConverter.ToDateTime(managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060");
                L2CacheSize= (uint)(managementObject.Properties["L2CacheSize"]?.Value ?? default(uint));
                L3CacheSize = (uint)(managementObject.Properties["L3CacheSize"]?.Value ?? default(uint));
                LastErrorCode = (uint)(managementObject.Properties["LastErrorCode"]?.Value ?? default(uint));
                LoadPercentage = (ushort)(managementObject.Properties["LoadPercentage"]?.Value ?? default(ushort));
                MaxClockSpeed = (uint)(managementObject.Properties["MaxClockSpeed"]?.Value ?? default(uint));
                Name = (string)(managementObject.Properties["Name"]?.Value);
                NumberOfCores = (uint)(managementObject.Properties["NumberOfCores"]?.Value ?? default(uint));
                OtherFamilyDescription = (string)(managementObject.Properties["OtherFamilyDescription"]?.Value);
                PnpDeviceId = (string)(managementObject.Properties["PNPDeviceID"]?.Value);
                PowerManagementCapabilities = (ushort[])(managementObject.Properties["PowerManagementCapabilities"]?.Value ?? new ushort[0]);
                PowerManagementSupported = (bool)(managementObject.Properties["PowerManagementSupported"]?.Value ?? default(bool));
                ProcessorType = (ProcType)(managementObject.Properties["ProcessorType"]?.Value);
                Role = (string)(managementObject.Properties["Role"]?.Value);
                //Revision = (uint)(managementObject.Properties["Revision"]?.Value);
                Status = (string)(managementObject.Properties["Status"]?.Value);
                StatusInfo = (ushort)(managementObject.Properties["StatusInfo"]?.Value ?? default(ushort));
                Stepping = (string)(managementObject.Properties["Stepping"]?.Value);
                SystemCreationClassName = (string)(managementObject.Properties["SystemCreationClassName"]?.Value);
                SystemName = (string)(managementObject.Properties["SystemName"]?.Value);
                ThreadCount = (uint)(managementObject.Properties["ThreadCount"]?.Value ?? default(uint));
                UniqueId = (string)(managementObject.Properties["UniqueId"]?.Value);
                UpgradeMethod = (ushort)(managementObject.Properties["UpgradeMethod"]?.Value ?? default(ushort));

            }
		}
	}
}
