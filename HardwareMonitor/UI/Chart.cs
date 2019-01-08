using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HardwareMonitor.UI
{
    public partial class Chart : Form
    {
        public static uc_accelerator Accelerator {get; set;}
        private Thread cpuThread;
        private Thread ramThread;
        public static PerformanceCounter CPU_counter { get; set; }
        private double[] cpuArray = new double[60];
        private double[] ramArray = new double[60];


        public Chart()
        {
            InitializeComponent();
        }

        private void GetCPUCounter()
        {
            CPU_counter = Accelerator.perfCPUCounter;
            
            while (true)
            {
                cpuArray[cpuArray.Length - 1] = Math.Round(CPU_counter.NextValue(), 0);

                Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1);

                if (chrt_cpu.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateCPUChart(); });
                }
                
                Thread.Sleep(1000);
            }
        }

        private void UpdateCPUChart()
        {
            chrt_cpu.Series["CPU"].Points.Clear();

            for (int i = 0; i < cpuArray.Length - 1; ++i)
            {
                chrt_cpu.Series["CPU"].Points.AddY(cpuArray[i]);
            }
        }


        private void GetRAMCounter()
        {
            
            while (true)
            {
                ramArray[ramArray.Length - 1] = Math.Round(Accelerator.GetUsedRamInPerc(), 0);

                Array.Copy(ramArray, 1, ramArray, 0, ramArray.Length - 1);

                if (chrt_cpu.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateRAMChart(); });
                }

                Thread.Sleep(1000);
            }
        }

        private void UpdateRAMChart()
        {
            chrt_cpu.Series["RAM"].Points.Clear();

            for (int i = 0; i < ramArray.Length - 1; ++i)
            {
                chrt_cpu.Series["RAM"].Points.AddY(ramArray[i]);
            }
        }
        
        private void Chart_Load(object sender, EventArgs e)
        {
            cpuThread = new Thread(new ThreadStart(this.GetCPUCounter));
            ramThread = new Thread(new ThreadStart(this.GetRAMCounter));
            ramThread.IsBackground = true;
            cpuThread.IsBackground = true;
            ramThread.Start();
            cpuThread.Start();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
