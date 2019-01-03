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
            const int bytesInMegabyte = 1 << 20;
            Hardware.VideoController vd = new Hardware.VideoController();
            vd.Retrieve();
            Hardware.VideoCard card0 = vd.VideoCards[0];
            for (int i = 0; i < vd.VideoCards.Count(); i++)
            {
                string title = "GPU " + i.ToString();
                TabPage myTabPage = new TabPage(title)
                {
                    Size = new Size(740, 620)
                };
                tab_gpu.TabPages.Add(myTabPage);


                Hardware.VideoCard currentCard = vd.VideoCards[i];

                Panel pnl_info = new Panel()
                {
                    Location = new Point(5, 55),
                    Size = new Size(450, 154),
                    BorderStyle = BorderStyle.FixedSingle

                };
                Panel pnl_spec = new Panel()
                {
                    Location = new Point(5, 215),
                    Size = new Size(331, 216),
                    BorderStyle = BorderStyle.FixedSingle

                };
                Panel pnl_driver = new Panel()
                {
                    Location = new Point(347, 215),
                    Size = new Size(331, 123),
                    BorderStyle = BorderStyle.FixedSingle
                };
                Panel pnl_memory = new Panel()
                {
                    Location = new Point(347, 342),
                    Size = new Size(243, 89),
                    BorderStyle = BorderStyle.FixedSingle
                };
                ////pnl info/////
                Label lb_name = new Label
                {
                    AutoSize = true,
                    Text = "Name:",
                    Location = new Point(15, 15),
                };
                Label lb_nameValue = new Label
                {
                    AutoSize = true,
                    Text = currentCard.Name,
                    Location = new Point(90, 15),
                    
                };
                Label lb_manufact = new Label
                {
                    AutoSize = true,
                    Text = "Manufacturer:",
                    Location = new Point(0, 0)
                };
                Label lb_manufactValue = new Label
                {
                    AutoSize = true,
                    Text = currentCard.AdapterCompatibility,
                    Location = new Point(145, 0)
                };
                Label lb_caption = new Label
                {
                    AutoSize = true,
                    Text = "Caption:",
                    Location = new Point(0, 30)
                };
                Label lb_captionValue = new Label
                {
                    AutoSize = true,
                    Text = currentCard.Caption,
                    Location = new Point(116, 30)
                };
                Label lb_deviceID = new Label
                {
                    AutoSize = true,
                    Text = "Device ID:",
                    Location = new Point(0, 60)
                };
                Label lb_deviceIDValue = new Label
                {
                    AutoSize = true,
                    Text = currentCard.DeviceId,
                    Location = new Point(116, 60)
                };
                Label lb_descript = new Label
                {
                    AutoSize = true,
                    Text = "Description:",
                    Location = new Point(0, 90)
                };
                Label lb_descriptValue = new Label
                {
                    AutoSize = true,
                    Text = currentCard.VideoModeDescription,
                    Location = new Point(116, 90)
                };
                Label lb_avaliable = new Label
                {
                    AutoSize = true,
                    Text = "Availability:",
                    Location = new Point(0, 120)
                };
                Label lb_avaliableValue = new Label
                {
                    AutoSize = true,
                    Text = currentCard.Availability.ToString(),
                    Location = new Point(117, 120)
                };
                /////pnl spec///
                Label lb_spec = new Label
                {
                    AutoSize = true,
                    Text = "Specifications",
                    Location = new Point(0, 0),
                    BorderStyle = BorderStyle.FixedSingle
                };
                Label lb_resol = new Label
                {
                    AutoSize = true,
                    Text = "Resolution:",
                    Location = new Point(0, 30)
                };
                Label lb_resolValue = new Label
                {
                    AutoSize = true,

                    Text = currentCard.CurrentHorizontalResolution.ToString() + "x" + currentCard.CurrentVerticalResolution.ToString(),
                    Location = new Point(200, 30)
                };
                Label lb_arch = new Label
                {
                    AutoSize = true,
                    Text = "Video Architecture:",
                    Location = new Point(0, 60)
                };
                Label lb_archValue = new Label
                {
                    AutoSize = true,
                    Text = currentCard.VideoArchitecture.ToString(),
                    Location = new Point(200, 60)
                };
                Label lb_colors = new Label
                {
                    AutoSize = true,
                    Text = "Number of colors:",
                    Location = new Point(0, 90)
                };
                Label lb_colorsValue = new Label
                {
                    AutoSize = true,
                    Text = currentCard.CurrentNumberOfColors.ToString(),
                    Location = new Point(200, 90)
                };
                Label lb_max_rate = new Label
                {
                    AutoSize = true,
                    Text = "Max Refresh Rate:",
                    Location = new Point(0, 120)
                };
                Label lb_max_rateValue = new Label
                {
                    AutoSize = true,
                    Text = currentCard.MaxRefreshRate.ToString(),
                    Location = new Point(200, 120)
                };
                Label lb_rate = new Label
                {
                    AutoSize = true,
                    Text = "Refresh Rate:",
                    Location = new Point(0, 150)
                };
                Label lb_rateValue = new Label
                {
                    AutoSize = true,
                    Text = currentCard.CurrentRefreshRate.ToString(),
                    Location = new Point(200, 150)
                };
                Label lb_mono = new Label
                {
                    AutoSize = true,
                    Text = "Monochrome:",
                    Location = new Point(0, 180)
                };
                Label lb_monoValue = new Label
                {
                    AutoSize = true,
                    Text = currentCard.Monochrome.ToString(),
                    Location = new Point(200, 180)
                };
                //// pnl drivers////
                Label lb_driver_caption = new Label
                {
                    AutoSize = true,
                    Text = "Drivers",
                    Location = new Point(0, 0),
                    BorderStyle = BorderStyle.FixedSingle
                };
                Label lb_driv_vers = new Label
                {
                    AutoSize = true,
                    Text = "Driver Version:",
                    Location = new Point(0, 30)
                };
                Label lb_driv_versValue = new Label
                {
                    AutoSize = true,
                    Text = currentCard.DriverVersion,
                    Location = new Point(170, 30)
                };
                Label lb_driv_date = new Label
                {
                    AutoSize = true,
                    Text = "Driver Date:",
                    Location = new Point(0, 60)
                };
                Label lb_driv_dateValue = new Label
                {
                    AutoSize = true,
                    Text = currentCard.DriverDate.ToShortDateString(),
                    Location = new Point(170, 60)
                };
                Label lb_instdrive = new Label
                {
                    AutoSize = true,
                    Text = "Installed Drivers:",
                    Location = new Point(0, 90)
                };
                TextBox tb_instdrive = new TextBox
                {
                    Size = new Size(152, 25),
                    Text = currentCard.InstalledDisplayDrivers.ToString(),
                    Location = new Point(174, 90),
                    BackColor = Color.FromKnownColor(KnownColor.Control),
                    BorderStyle = BorderStyle.None
                };
                /////pnl mem///
                Label lb_memory = new Label
                {
                    AutoSize = true,
                    Text = "Memory",
                    Location = new Point(0, 0),
                    BorderStyle = BorderStyle.FixedSingle
                };
                Label lb_adaptRAM = new Label
                {
                    AutoSize = true,
                    Text = "RAM:",
                    Location = new Point(0, 30)
                };
                Label lb_adaptRAMValue = new Label
                {
                    AutoSize = true,
                    Text = (currentCard.AdapterRam / bytesInMegabyte).ToString() + "MB",
                Location = new Point(60, 30)
                };
                Label lb_mem_type = new Label
                {
                    AutoSize = true,
                    Text = "Memory Type:",
                    Location = new Point(0, 60)
                };
                Label lb_mem_typeValue = new Label
                {
                    AutoSize = true,
                    Text = currentCard.VideoMemoryType.ToString(),
                    Location = new Point(140, 60)
                };
                PictureBox pbox_manufact = new PictureBox
                {
                    Location = new Point(500, 53),
                    Size = new Size(100, 100),
                    Image = Properties.Resources.videocard,
                    SizeMode = PictureBoxSizeMode.AutoSize
                };

                switch (currentCard.GetManufacturer(currentCard.AdapterCompatibility))
                {
                    case "amd":
                        pbox_manufact.Image = Properties.Resources.amd;
                        break;
                    case "intel":
                        pbox_manufact.Image = Properties.Resources.intel;

                        break;
                    case "nvidia":
                        pbox_manufact.Image = Properties.Resources.nvidia;
                        break;
                    default:
                        pbox_manufact.Image = Properties.Resources.videocard;
                        break;
                        
                }

                myTabPage.Controls.Add(lb_name);
                myTabPage.Controls.Add(lb_nameValue);
                myTabPage.Controls.Add(pnl_info);
                myTabPage.Controls.Add(pnl_driver);
                myTabPage.Controls.Add(pnl_spec);
                myTabPage.Controls.Add(pnl_memory);
                pnl_info.Controls.Add(lb_manufact);
                pnl_info.Controls.Add(lb_manufactValue);
                pnl_info.Controls.Add(lb_caption);
                pnl_info.Controls.Add(lb_captionValue);
                pnl_info.Controls.Add(lb_deviceID);
                pnl_info.Controls.Add(lb_deviceIDValue);
                pnl_info.Controls.Add(lb_descript);
                pnl_info.Controls.Add(lb_descriptValue);
                pnl_info.Controls.Add(lb_avaliable);
                pnl_info.Controls.Add(lb_avaliableValue);
                pnl_spec.Controls.Add(lb_spec);
                pnl_spec.Controls.Add(lb_resol);
                pnl_spec.Controls.Add(lb_resolValue);
                pnl_spec.Controls.Add(lb_arch);
                pnl_spec.Controls.Add(lb_archValue);
                pnl_spec.Controls.Add(lb_colors);
                pnl_spec.Controls.Add(lb_colorsValue);
                pnl_spec.Controls.Add(lb_max_rate);
                pnl_spec.Controls.Add(lb_max_rateValue);
                pnl_spec.Controls.Add(lb_rate);
                pnl_spec.Controls.Add(lb_rateValue);
                pnl_spec.Controls.Add(lb_mono);
                pnl_spec.Controls.Add(lb_monoValue);
                pnl_driver.Controls.Add(lb_driver_caption);
                pnl_driver.Controls.Add(lb_driv_vers);
                pnl_driver.Controls.Add(lb_driv_versValue);
                pnl_driver.Controls.Add(lb_driv_date);
                pnl_driver.Controls.Add(lb_driv_dateValue);
                pnl_driver.Controls.Add(lb_instdrive);
                pnl_driver.Controls.Add(tb_instdrive);
                pnl_memory.Controls.Add(lb_memory);
                pnl_memory.Controls.Add(lb_adaptRAM);
                pnl_memory.Controls.Add(lb_adaptRAMValue);
                pnl_memory.Controls.Add(lb_mem_type);
                pnl_memory.Controls.Add(lb_mem_typeValue);
                myTabPage.Controls.Add(pbox_manufact);
            }
        }
    }
}
