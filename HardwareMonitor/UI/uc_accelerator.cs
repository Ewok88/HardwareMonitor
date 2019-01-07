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
        public PerformanceCounter perfCPUCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        public PerformanceCounter perfRAMCounter = new PerformanceCounter("Memory", "Available Bytes");
        public PerformanceCounter perfSpaceCounterMem = new PerformanceCounter("LogicalDisk", "Free Megabytes", "_Total");
        public PerformanceCounter perfSpaceCounterPers = new PerformanceCounter("LogicalDisk", "% Free Space", "_Total");
        Checker m_checker = new Checker();
        const int bytesInMegabyte = 1 << 20;
        const int bytesInGigabyte = 1 << 30;
        const int MegabytesInGigabyte = 1 << 10;

        public long GetTotalMemoryInGiga()
        {
            return controller.TotalMemory / bytesInGigabyte;
        }

        public ulong GetTotalRamInGiga()
        {
            return mem.TotalMemory / bytesInGigabyte;
        }

        public float GetFreeRamInPerc()
        {
            return (perfRAMCounter.NextValue()/ bytesInMegabyte * 100) / (mem.TotalMemory / bytesInMegabyte);
        }
        public float GetUsedRamInPerc()
        {
            return 100 - GetFreeRamInPerc();
        }

        public void SetStorageTabs()
        {
            var progBarUse = tab_storage.SelectedTab.Controls[0] as CircularProgressBar.CircularProgressBar;
            var progBarFree = tab_storage.SelectedTab.Controls[1] as CircularProgressBar.CircularProgressBar;
            var lb_Use = tab_storage.SelectedTab.Controls[2] as Label;
            var lb_Free = tab_storage.SelectedTab.Controls[3] as Label;
            if (tab_storage.SelectedIndex == 0)
            {
                progBarUse.Value = prbar_usedSpace_total.Maximum - (int)perfSpaceCounterPers.NextValue();
                progBarFree.Value = (int)perfSpaceCounterPers.NextValue();
                lb_Use.Text = Math.Round((((controller.TotalMemory / bytesInMegabyte) - perfSpaceCounterMem.NextValue()) / MegabytesInGigabyte), 1) + " GB";
                lb_Free.Text = Math.Round((perfSpaceCounterMem.NextValue() / MegabytesInGigabyte), 1) + " GB";
            }
            else
            {
                var logicalDisk = controller.LogicalDisks[tab_storage.SelectedIndex - 1];
                progBarUse.Value = logicalDisk.GetUsedSpaceInPerc();
                progBarFree.Value = logicalDisk.GetFreeSpaceInPerc();
                lb_Use.Text = Math.Round((logicalDisk.GetUsedSpaceInMegaBytes() / MegabytesInGigabyte), 1) + " GB";
                lb_Free.Text = Math.Round((logicalDisk.GetFreeSpaceInMegaBytes() / MegabytesInGigabyte), 1) + " GB";
            }
        }

        public void SetTemperatureProgressBar()
        {
            prbar_temperature.Value = sensor.CurrentTemperature;
            prbar_temperature.Text = sensor.CurrentTemperature.ToString();
            m_checker.CheckTemperature(sensor.CurrentTemperature, AllSettings.criticalTemperature);
        }
        public void SetCpuLoadProgressBar()
        {
            prbar_cpu_load.Value = (int)perfCPUCounter.NextValue();
            prbar_cpu_load.Text = prbar_cpu_load.Value.ToString();
        }
        public void SetRAMProgressBar()
        {
            prbar_ram_used.Value = (int)(prbar_ram_used.Maximum - perfRAMCounter.NextValue() / bytesInMegabyte);
            prbar_ram_used.Text = ((int)(prbar_ram_used.Maximum - perfRAMCounter.NextValue() / bytesInMegabyte)).ToString();
        }

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
                    Location = new Point(5, 25),
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
                    Location = new Point(5, 155),
                    Font = new Font("Century Gothic", 22, FontStyle.Regular),
                    ForeColor = Color.Gray
                };
                Label lb_space_freeValue = new Label
                {
                    AutoSize = true,
                    Text = "",
                    Location = new Point(220, 155),
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
            SetStorageTabs();
            SetTemperatureProgressBar();
            SetCpuLoadProgressBar();
            SetRAMProgressBar();

            if (AllSettings.spaceUnit==false)
            {
                m_checker.CheckFreeSpace((int)perfSpaceCounterPers.NextValue(), AllSettings.criticalSpace);
            }
            else
            {
                m_checker.CheckFreeSpace((int)perfSpaceCounterMem.NextValue()/ MegabytesInGigabyte, AllSettings.criticalSpace);
            }

            if (AllSettings.ramUnit == false)
            {
                var a = GetFreeRamInPerc();
                m_checker.CheckFreeRAM((int)GetFreeRamInPerc(), AllSettings.criticalRam);
            }
            else
            {
                m_checker.CheckFreeRAM((int)perfRAMCounter.NextValue() / bytesInGigabyte, AllSettings.criticalRam);
            }

        }

        private void uc_accelerator_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_chart_Click(object sender, EventArgs e)
        {
            Chart chart_form = new Chart();
            chart_form.Show();
        }
    }
}
