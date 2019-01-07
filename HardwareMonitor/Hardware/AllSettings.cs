using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HardwareMonitor.UI;
using static System.Environment;

namespace HardwareMonitor.Hardware
{
    static class AllSettings
    {
        public static int criticalTemperature = 85;
        public static int criticalSpace = 10;
        static public int criticalRam = 10;
        public static bool spaceUnit = false;
        public static bool ramUnit = false;
        static readonly string regKeyName = "Software\\Raccoon\\HardwareMonitor";
        public static string folder = Environment.GetFolderPath(SpecialFolder.MyDocuments);
        public static uc_accelerator  Accelerator {get; set;}
        
        
        public static void WriteSettings()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null)
                    return;
                rk.SetValue("CriticalTemperature", criticalTemperature);
                rk.SetValue("CriticalSpace", criticalSpace);
                rk.SetValue("CriticalRAM", criticalRam);
                rk.SetValue("SpaceUnit", spaceUnit);
                rk.SetValue("RAMUnit", ramUnit);
                rk.SetValue("SaveFolder", folder);

            }
            finally
            {
                if (rk != null)
                    rk.Close();
            }
        }

        public static void ReadSettings()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                if (rk != null)
                {
                    criticalTemperature = (int)rk.GetValue("CriticalTemperature");
                    criticalSpace = (int)rk.GetValue("CriticalSpace");
                    criticalRam = (int)rk.GetValue("CriticalRAM");
                    spaceUnit = Convert.ToBoolean(rk.GetValue("SpaceUnit"));
                    ramUnit = Convert.ToBoolean(rk.GetValue("RAMUnit"));
                    folder = rk.GetValue("SaveFolder").ToString();
                }

            }
            finally
            {
                if (rk != null)
                    rk.Close();
            }
        }

    }
}
