using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace HardwareMonitor.Hardware
{
    class TemperatureSensor : IHardware
    {
        public TemperatureSensor()
        {
            keyInstanceName = "NonAvailable";
        }

        public bool Active { get; set; }
        public int ActiveTripPoint { get; set; }
        public int ActiveTripPointCount { get; set; }
        public int CriticalTripPoint { get; set; }
        public int CurrentTemperature { get; set; }
        public string keyInstanceName { get; set; }
        public int PassiveTripPoint { get; set; }
        public int Reserved { get; set; }
        public int SamplingPeriod { get; set; }
        public int ThermalConstant1 { get; set; }
        public int ThermalConstant2 { get; set; }
        public int ThermalStamp { get; set; }

        ManagementObjectSearcher searcher =
                     new ManagementObjectSearcher("root\\WMI",
                    "SELECT * FROM MSAcpi_ThermalZoneTemperature");
        public void Retrieve()
        {
            try
            {
                foreach (ManagementObject managementObject in searcher.Get())
                {
                    Active = (bool)(managementObject.Properties["Active"]?.Value);
                    ActiveTripPoint = (int)(managementObject.Properties["ActiveTripPoint"]?.Value);
                    ActiveTripPointCount = (int)(managementObject.Properties["ActiveTripPointCount"]?.Value);
                    CriticalTripPoint = (int)(managementObject.Properties["CriticalTripPoint"]?.Value);
                    CurrentTemperature = (int)(managementObject.Properties["CurrentTemperature"]?.Value);
                    keyInstanceName = (string)(managementObject.Properties["keyInstanceName"]?.Value);
                    PassiveTripPoint = (int)(managementObject.Properties["PassiveTripPoint"]?.Value);
                    Reserved = (int)(managementObject.Properties["Reserved"]?.Value);
                    SamplingPeriod = (int)(managementObject.Properties["SamplingPeriod"]?.Value);
                    SamplingPeriod = (int)(managementObject.Properties["SamplingPeriod"]?.Value);
                    ThermalConstant1 = (int)(managementObject.Properties["ThermalConstant1"]?.Value);
                    ThermalConstant2 = (int)(managementObject.Properties["ThermalConstant2"]?.Value);
                    ThermalStamp = (int)(managementObject.Properties["ThermalStamp"]?.Value);
                }
            }
            catch (Exception ex) { }
        }

        public void Update()
        {
            try
            {
               ManagementObjectSearcher searcher =
                      new ManagementObjectSearcher("root\\WMI",
                      "SELECT * FROM MSAcpi_ThermalZoneTemperature");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    int temp = int.Parse(queryObj["CurrentTemperature"].ToString());
                    CurrentTemperature = (temp - 2732) / 10;
                }
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
        
