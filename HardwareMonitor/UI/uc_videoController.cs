using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareMonitor.UI
{
    public partial class uc_video_controller : UserControl
    {
        public uc_video_controller()
        {
            InitializeComponent();
            Hardware.VideoController vd = new Hardware.VideoController();
            vd.Retrieve();
            //GPU0////
            Hardware.VideoCard gpu0 = vd.VideoCards[0];
            lb_gpu_compat0.Text = gpu0.AdapterCompatibility;
            lb_gpu_arch0.Text = gpu0.VideoArchitecture.ToString();
            lb_gpu_avail0.Text = gpu0.Availability.ToString();
            lb_gpu_caption0.Text = gpu0.Caption;
            lb_gpu_colors0.Text = gpu0.CurrentNumberOfColors.ToString();
            lb_gpu_compat0.Text = gpu0.AdapterCompatibility.ToString();
            lb_gpu_descript0.Text = gpu0.VideoModeDescription;
            lb_gpu_devID0.Text = gpu0.DeviceId;
            lb_gpu_driv_date0.Text = gpu0.DriverDate.ToShortDateString();
            lb_gpu_driv_vers0.Text = gpu0.DriverVersion;
            tb_gpu_intdrive0.Text = gpu0.InstalledDisplayDrivers;
            lb_gpu_max_rate0.Text = gpu0.MaxRefreshRate.ToString();
            lb_gpu_mem_type0.Text = gpu0.VideoMemoryType.ToString();
            lb_gpu_name0.Text = gpu0.Name;
            lb_gpu_ram0.Text = (gpu0.AdapterRam/ 1048576).ToString()+"MB";
            lb_gpu_rate0.Text = gpu0.CurrentRefreshRate.ToString();
            lb_gpu_resol0.Text = gpu0.CurrentHorizontalResolution.ToString() + "x" + gpu0.CurrentVerticalResolution.ToString();
            lb_gpu_mono0.Text = gpu0.Monochrome.ToString();
			////GPU1///
			Hardware.VideoCard gpu1 = vd.VideoCards[1];
			lb_gpu_compat1.Text = gpu1.AdapterCompatibility;
			lb_gpu_arch1.Text = gpu1.VideoArchitecture.ToString();
			lb_gpu_avail1.Text = gpu1.Availability.ToString();
			lb_gpu_caption1.Text = gpu1.Caption;
			lb_gpu_colors1.Text = gpu1.CurrentNumberOfColors.ToString();
			lb_gpu_compat1.Text = gpu1.AdapterCompatibility.ToString();
			lb_gpu_descript1.Text = gpu1.VideoModeDescription;
			lb_gpu_devID1.Text = gpu1.DeviceId;
			lb_gpu_driv_date1.Text = gpu1.DriverDate.ToShortDateString();
			lb_gpu_driv_vers1.Text = gpu1.DriverVersion;
			lb_gpu_max_rate1.Text = gpu1.MaxRefreshRate.ToString();
			lb_gpu_mem_type1.Text = gpu1.VideoMemoryType.ToString();
			lb_gpu_name1.Text = gpu1.Name;
			lb_gpu_ram1.Text = ( gpu1.AdapterRam/1048576 ).ToString() + "MB";
			lb_gpu_rate1.Text = gpu1.CurrentRefreshRate.ToString();
			lb_gpu_resol1.Text = gpu1.CurrentHorizontalResolution.ToString() + "x" + gpu1.CurrentVerticalResolution.ToString();
			lb_gpu_mono1.Text = gpu1.Monochrome.ToString();
			//  tab_gpu.TabPages.Remove(tabPage_gpu1);



		}


    }
}
