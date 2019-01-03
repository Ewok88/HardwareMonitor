using System.Windows.Forms;
using HardwareMonitor.Hardware;
using static HardwareMonitor.Hardware.Processor;

namespace HardwareMonitor.UI
{
    public partial class uc_processor : UserControl
    {
        public uc_processor()
		{
			InitializeComponent();

			Processor a = new Processor();
			a.Retrieve();
			lb_proc_name.Text = a.Name;
            lb_proc_arch.Text = a.Architect.ToString();
            lb_proc_capt.Text = a.Caption.ToString();
            lb_proc_clspeed.Text = a.CurrentClockSpeed.ToString() + " MHz";
            lb_proc_descr.Text = a.Description.ToString();
            lb_proc_extClock.Text = a.ExtClock.ToString() + " MHz";
            lb_proc_maxclspeed.Text = a.MaxClockSpeed.ToString() + " MHz";
            lb_proc_cache_lvl2.Text = a.L2CacheSize.ToString() + "KB";
            lb_proc_cache_lvl3.Text = a.L3CacheSize.ToString() + "KB";
            lb_proc_type.Text = a.ProcessorType.ToString();
            lb_proc_numcor.Text = a.NumberOfCores.ToString();
            lb_proc_numthreads.Text = a.ThreadCount.ToString();
            lb_proc_revision.Text = a.Revision.ToString();
            lb_proc_role.Text = a.Role.ToString();

        }

        
    }
}
