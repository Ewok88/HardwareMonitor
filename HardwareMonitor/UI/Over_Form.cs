using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareMonitor
{
    public partial class Over_Form : Form
    {
        PerformanceCounter perfCPU_over = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter perfRAM_over = new PerformanceCounter("Memory", "Available MBytes");
        public Over_Form()
        {

            
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            //Верхний левый угол экрана
            Point pt = Screen.PrimaryScreen.WorkingArea.Location;
            //Перенос в нижний правый угол экрана без панели задач
            pt.Offset(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            //Перенос в местоположение верхнего левого угла формы, чтобы её правый нижний угол попал в правый нижний угол экрана
            pt.Offset(-this.Width, -this.Height);
            //Новое положение формы
            this.Location = pt;
            this.ShowInTaskbar = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prbar_CPU.Value = (int)perfCPU_over.NextValue();
            prbar_CPU.Text = prbar_CPU.Value.ToString();

            prbar_RAM.Value = (int)perfRAM_over.NextValue();
            prbar_RAM.Text = perfRAM_over.NextValue().ToString();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
