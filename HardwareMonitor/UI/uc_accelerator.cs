using System;
using System.Windows.Forms;
using System.Diagnostics;
using HardwareMonitor.Hardware;
using System.IO;

namespace HardwareMonitor.UI
{
    public partial class uc_accelerator : UserControl
    {
        PerformanceCounter perfCPUCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter perfRAMCounter = new PerformanceCounter("Memory", "Available Bytes");
        PerformanceCounter perfSpaceCounterMem = new PerformanceCounter("LogicalDisk", "Free Megabytes", "_Total");
        PerformanceCounter perfSpaceCounterPers = new PerformanceCounter("LogicalDisk", "% Free Space", "_Total");
        const int bytesInMegabyte = 1 << 20;
        const int MegabytesInGigabyte = 1 << 10;

        public uc_accelerator()
        {
            InitializeComponent();
            
            PhysicalMemory mem = new PhysicalMemory();
            mem.Retrieve();
            prbar_ram_used.Maximum = (int)(mem.TotalMemory / bytesInMegabyte);
           

        }

        
        private void timer_uc_acc_Tick(object sender, EventArgs e)
        {

            prbar_freeSpace.Value = (int)perfSpaceCounterPers.NextValue();
            lb_freeSpace.Text = ((int)perfSpaceCounterMem.NextValue()/ MegabytesInGigabyte).ToString()+"GB";
            prbar_cpu_load.Value = (int)perfCPUCounter.NextValue();
            prbar_cpu_load.Text = prbar_cpu_load.Value.ToString();
            
            prbar_ram_used.Value = (int)(prbar_ram_used.Maximum - perfRAMCounter.NextValue() / bytesInMegabyte);
            prbar_ram_used.Text = ((int)(prbar_ram_used.Maximum - perfRAMCounter.NextValue() / bytesInMegabyte)).ToString();
        }

     
    }
}
