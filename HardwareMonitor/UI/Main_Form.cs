
using HardwareMonitor.Hardware;
using HardwareMonitor.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HardwareMonitor
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            pnl_right.Height = btn_accelerator.Height;
            uc_accelerator1.BringToFront();
            AllSettings.Accelerator = uc_accelerator1;
            Chart.Accelerator = uc_accelerator1;
            
            Checker.icon = icn_tray;
        }
        private void Main_Form_Load(object sender, EventArgs e)
        {
            AllSettings.ReadSettings();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            icn_tray.BalloonTipTitle = "Hardware Monitor";
            icn_tray.BalloonTipText = "Application has been minimized";
            icn_tray.Text = "Hardware Monitor";
            icn_tray.BalloonTipIcon = ToolTipIcon.Info;
            icn_tray.ShowBalloonTip(2);
        }

        private void icn_tray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            icn_tray.Visible = false;
            this.WindowState = FormWindowState.Normal; 
        }

        private void Main_Form_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                icn_tray.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                icn_tray.Visible = false;
            }
        }
        
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_accelerator_Click(object sender, EventArgs e)
        {
      
            pnl_right.Height = btn_accelerator.Height;
            pnl_right.Top = btn_accelerator.Top;
            uc_accelerator1.BringToFront();
        }

        private void btn_system_Click(object sender, EventArgs e)
        {
            pnl_right.Height = btn_system.Height;
            pnl_right.Top = btn_system.Top;
            uc_system1.BringToFront();
        }

        private void btn_motherboard_Click(object sender, EventArgs e)
        {
            pnl_right.Height = btn_motherboard.Height;
            pnl_right.Top = btn_motherboard.Top;
            uc_motherboard1.BringToFront();
        }

        private void btn_processor_Click(object sender, EventArgs e)
        {
            pnl_right.Height = btn_processor.Height;
            pnl_right.Top = btn_processor.Top;
            uc_processor2.BringToFront();
            
        }

        private void btn_gpu_Click(object sender, EventArgs e)
        {
            pnl_right.Height = btn_gpu.Height;
            pnl_right.Top = btn_gpu.Top;
            uc_video_controller1.BringToFront();
            
        }

        private void bt_overlay_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Over_Form")
                {
                    f.Close();
                    return;
                }
            }
            Over_Form form_over = new Over_Form();

            form_over.Show();
        
        }

        private void btn_ph_mem_Click(object sender, EventArgs e)
        {
            pnl_right.Height = btn_ph_mem.Height;
            pnl_right.Top = btn_ph_mem.Top;
            uc_physicalMemory1.BringToFront();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            Settings form_settings = new Settings();
            form_settings.ShowDialog();
        }
    }
}   
