using System;
using System.Windows.Forms;
using System.Diagnostics;
using HardwareMonitor.Hardware;
using System.Linq;
using System.Drawing;


namespace HardwareMonitor.UI
{
    public partial class uc_accelerator : UserControl
    {
        PhysicalMemory mem = new PhysicalMemory();
        LogicaController controller = new LogicaController();
        TemperatureSensor sensor = new TemperatureSensor();
        PerformanceCounter perfCPUCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter perfRAMCounter = new PerformanceCounter("Memory", "Available Bytes");
        PerformanceCounter perfSpaceCounterMem = new PerformanceCounter("LogicalDisk", "Free Megabytes", "_Total");
        PerformanceCounter perfSpaceCounterPers = new PerformanceCounter("LogicalDisk", "% Free Space", "_Total");
      
        
        const int bytesInMegabyte = 1 << 20;
        const int MegabytesInGigabyte = 1 << 10;

        public uc_accelerator()
        {
            InitializeComponent();
            mem.Retrieve();
            controller.Retrieve();
            sensor.Update();
            prbar_ram_used.Maximum = (int)(mem.TotalMemory / bytesInMegabyte);

            for (int i = 0; i < controller.LogicalDisks.Count(); i++)
            {
                Hardware.LogicalDisk currentDisk = controller.LogicalDisks[i];
                TabPage myTabPage = new TabPage(currentDisk.Name)
                {
                    Size = new Size(380, 200),
                    
                };

                tab_storage.TabPages.Add(myTabPage);

                CircularProgressBar.CircularProgressBar prbar_usedSpace = new CircularProgressBar.CircularProgressBar
                {
                    Location = new Point(8, 25),
                    Size = new Size(125, 125),
                    OuterColor = Color.Gainsboro,
                    ProgressColor = Color.SteelBlue,
                    OuterMargin = -30,
                    OuterWidth = 30,
                    ProgressWidth = 30,
                    Maximum = 100,
                    Value = 0,
                    InnerColor = SystemColors.Control
                    
                    
                };

                CircularProgressBar.CircularProgressBar prbar_freeSpace = new CircularProgressBar.CircularProgressBar
                {
                    Location = new Point(220, 25),
                    Size = new Size(125, 125),
                    OuterColor = Color.Gainsboro,
                    ProgressColor = Color.SteelBlue,
                    OuterMargin = -30,
                    OuterWidth = 30,
                    ProgressWidth = 30,
                    Maximum = 100,
                    Value = 0,
                    InnerColor = SystemColors.Control
                };

                Label lb_space_used = new Label
                {
                    AutoSize = true,
                    Text = "Used:",
                    Location = new Point(5, 5)
                };
                Label lb_space_free= new Label
                {
                    AutoSize = true,
                    Text = "Free:",
                    Location = new Point(215, 5)
                };
                Label lb_space_usedValue = new Label
                {
                    AutoSize = true,
                    Text = "",
                    Location = new Point(45, 155),
                    Font = new Font("Century Gothic", 22, FontStyle.Regular),
                    ForeColor = Color.Gray
                };
                Label lb_space_freeValue = new Label
                {
                    AutoSize = true,
                    Text = "",
                    Location = new Point(260, 155),
                    Font = new Font("Century Gothic", 22, FontStyle.Regular),
                     ForeColor = Color.Gray
                };

               
                myTabPage.Controls.Add(prbar_usedSpace);
                myTabPage.Controls.Add(prbar_freeSpace);
                myTabPage.Controls.Add(lb_space_usedValue);
                myTabPage.Controls.Add(lb_space_freeValue);
                myTabPage.Controls.Add(lb_space_used);
                myTabPage.Controls.Add(lb_space_free);
               
            }
           
        }

        
        private void timer_uc_acc_Tick(object sender, EventArgs e)
        {
            controller.Update();

            var progBarUse = tab_storage.SelectedTab.Controls[0] as CircularProgressBar.CircularProgressBar;
            var progBarFree = tab_storage.SelectedTab.Controls[1] as CircularProgressBar.CircularProgressBar;
            var lb_Use = tab_storage.SelectedTab.Controls[2] as Label;
            var lb_Free = tab_storage.SelectedTab.Controls[3] as Label;
            if (tab_storage.SelectedIndex==0)
            {
                progBarUse.Value = prbar_usedSpace_total.Maximum - (int)perfSpaceCounterPers.NextValue();
                progBarFree.Value = (int)perfSpaceCounterPers.NextValue();
                lb_Use.Text = Math.Round((((controller.TotalMemory / bytesInMegabyte) - perfSpaceCounterMem.NextValue()) / MegabytesInGigabyte),1) + " GB";
                lb_Free.Text = Math.Round((perfSpaceCounterMem.NextValue() / MegabytesInGigabyte),1) + " GB";
            }
            else
            {
                var logicalDisk = controller.LogicalDisks[tab_storage.SelectedIndex - 1];
                progBarUse.Value = logicalDisk.GetUsedSpaceInPerc();
                progBarFree.Value = logicalDisk.GetFreeSpaceInPerc();
                lb_Use.Text = Math.Round((logicalDisk.GetUsedSpaceInMegaBytes() / MegabytesInGigabyte),1) + " GB";
                lb_Free.Text = Math.Round((logicalDisk.GetFreeSpaceInMegaBytes() / MegabytesInGigabyte),1) + " GB";
            }
            

            prbar_temperature.Value = sensor.CurrentTemperature;
            prbar_temperature.Text = sensor.CurrentTemperature.ToString();
            //prbar_freeSpace_total.Value = (int)perfSpaceCounterPers.NextValue();
            //prbar_usedSpace_total.Value= prbar_usedSpace_total.Maximum-(int)perfSpaceCounterPers.NextValue();
            //lb_space_freeValue.Text = ((int)perfSpaceCounterMem.NextValue()/ MegabytesInGigabyte).ToString()+" GB";
            //lb_space_usedValue.Text = ((int)((controller.TotalMemory/ bytesInMegabyte) - perfSpaceCounterMem.NextValue())/ MegabytesInGigabyte).ToString()+" GB";
            prbar_cpu_load.Value = (int)perfCPUCounter.NextValue();
            prbar_cpu_load.Text = prbar_cpu_load.Value.ToString();
            
            prbar_ram_used.Value = (int)(prbar_ram_used.Maximum - perfRAMCounter.NextValue() / bytesInMegabyte);
            prbar_ram_used.Text = ((int)(prbar_ram_used.Maximum - perfRAMCounter.NextValue() / bytesInMegabyte)).ToString();
        }

       
    }
}
