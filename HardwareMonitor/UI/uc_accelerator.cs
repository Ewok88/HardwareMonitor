using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using HardwareMonitor.Hardware;

namespace HardwareMonitor.UI
{
    public partial class uc_accelerator : UserControl
    {
        PerformanceCounter perfCPUCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter perfRAMCounter = new PerformanceCounter("Memory", "Available MBytes");
        const int bytesInMegabyte = 1 << 20;

        public uc_accelerator()
        {
            InitializeComponent();
            PhysicalMemory mem = new PhysicalMemory();
            mem.Retrieve();
            prbar_ram_used.Maximum =(int)(mem.TotalMemory/ bytesInMegabyte);

        }
        
        private void timer_uc_acc_Tick(object sender, EventArgs e)
        {
            prbar_cpu_load.Value = (int)perfCPUCounter.NextValue();
            prbar_cpu_load.Text = prbar_cpu_load.Value.ToString();
            var a = prbar_ram_used.Maximum;
            prbar_ram_used.Value = (int)perfRAMCounter.NextValue();
            prbar_ram_used.Text = perfRAMCounter.NextValue().ToString();
        }

        




    }
}
