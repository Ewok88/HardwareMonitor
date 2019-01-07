using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HardwareMonitor.Hardware;
using HardwareMonitor.UI;

namespace HardwareMonitor.UI
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

       

        private void btn_OK_Click(object sender, EventArgs e)
        {
            AllSettings.criticalTemperature = (int)num_temp.Value;
            AllSettings.criticalSpace = (int)num_space.Value;
            AllSettings.criticalRam = (int)num_RAM.Value;
            AllSettings.spaceUnit = switch_space.Value;
            AllSettings.ramUnit = switch_RAM.Value;
            AllSettings.folder = tb_direction.Text;
            AllSettings.WriteSettings();
           
            Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Set();
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Set();
            Close();
        }

        void Set()
        {
            switch_space.Value = AllSettings.spaceUnit;
            switch_RAM.Value = AllSettings.ramUnit;
            if (switch_RAM.Value == true)
            {
                num_RAM.Maximum = AllSettings.Accelerator.GetTotalRamInGiga();
                slide_RAM.MaximumValue = (int)AllSettings.Accelerator.GetTotalRamInGiga();
            }
            else
            {
                num_RAM.Maximum = 100;
                slide_RAM.MaximumValue = 100;
            }
            if (switch_space.Value == true)
            {
                num_space.Maximum = AllSettings.Accelerator.GetTotalMemoryInGiga();
                slide_space.MaximumValue = (int)AllSettings.Accelerator.GetTotalMemoryInGiga();
            }
            else
            {
                num_space.Maximum = 100;
                slide_space.MaximumValue = 100;
            }
            num_temp.Value = AllSettings.criticalTemperature;
            num_space.Value = (decimal)AllSettings.criticalSpace;
            num_RAM.Value = (decimal)AllSettings.criticalRam;
            tb_direction.Text = AllSettings.folder;
           

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Set();

        }

        private void slide_temp_ValueChanged(object sender, EventArgs e)
        {
            num_temp.Value = slide_temp.Value;
        }

        private void num_temp_ValueChanged(object sender, EventArgs e)
        {
            slide_temp.Value = (int)num_temp.Value;
        }

        private void slide_space_ValueChanged(object sender, EventArgs e)
        {
            num_space.Value = slide_space.Value;
        }

        private void num_space_ValueChanged(object sender, EventArgs e)
        {
            slide_space.Value = (int)num_space.Value;
        }

        private void slide_RAM_ValueChanged(object sender, EventArgs e)
        {
            num_RAM.Value = slide_RAM.Value;
        }

        private void num_RAM_ValueChanged(object sender, EventArgs e)
        {
            slide_RAM.Value = (int)num_RAM.Value;
        }

        private void switch_space_OnValueChange(object sender, EventArgs e)
        {
          
            if (switch_space.Value == true)
            {
                num_space.Maximum = AllSettings.Accelerator.GetTotalMemoryInGiga();
                slide_space.MaximumValue = (int)AllSettings.Accelerator.GetTotalMemoryInGiga();
            }
            else { 
                num_space.Maximum = 100;
                slide_space.MaximumValue = 100;
            }
        }

        private void switch_RAM_OnValueChange(object sender, EventArgs e)
        {
            if(switch_RAM.Value==true)
            {
                num_RAM.Maximum = AllSettings.Accelerator.GetTotalRamInGiga();
                slide_RAM.MaximumValue = (int)AllSettings.Accelerator.GetTotalRamInGiga();
            }
            else
            {
                num_RAM.Maximum = 100;
                slide_RAM.MaximumValue = 100;
            }
        }

        private void btn_folder_Click(object sender, EventArgs e)
        {
            fbd_save.RootFolder = Environment.SpecialFolder.Desktop;
            fbd_save.Description = "Select Folder";
            fbd_save.ShowNewFolderButton = false;
            if(fbd_save.ShowDialog()== DialogResult.OK)
            {
                tb_direction.Text = fbd_save.SelectedPath;
            }
        }
    }
}
