using System.Windows.Forms;
using System.Diagnostics;



namespace HardwareMonitor.UI
{
    public partial class uc_system : UserControl
    {
        PerformanceCounter perfsyscount = new PerformanceCounter("System", "System Up Time");

        public uc_system()
        {
            InitializeComponent();
            Hardware.OperatingSystem op = new Hardware.OperatingSystem();
            op.Retrieve();
            lb_sys_caption.Text = op.Caption;
            lb_sys_arch.Text = op.OsArchitecture;
            lb_sys_boottime.Text = op.LastBootUpTime.ToShortDateString();
            lb_sys_build_num.Text = op.BuildNumber;
            lb_sys_build_type.Text = op.BuildType;
            lb_sys_manufact.Text = op.Manufacturer;
            lb_sys_serial.Text = op.SerialNumber;
            lb_sys_user.Text = op.RegisteredUser;
            lb_sys_version.Text = op.Version;
            lb_sys_csname.Text = op.CsName;
            lb_sys_usernum.Text = op.NumberOfUsers.ToString();
            lbox_languages.Items.AddRange(op.MuiLanguages);
            
        }

        private void timer_sys_Tick(object sender, System.EventArgs e)
        {
            var ts = System.TimeSpan.FromSeconds(perfsyscount.NextValue());
            lb_sys_time.Text =ts.Days +"d "+ ts.Hours + ":" + ts.Minutes+ ":" + ts.Seconds;
        }
    }
}
