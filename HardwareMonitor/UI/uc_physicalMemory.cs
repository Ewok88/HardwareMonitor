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
    public partial class uc_physicalMemory : UserControl
    {
        public uc_physicalMemory()
        {
            InitializeComponent();

			const int bytesInMegabyte = 1 << 20;

            Hardware.PhysicalMemory mem = new Hardware.PhysicalMemory();
            mem.Retrieve();
            Hardware.MemoryBank memory0 = mem.MemoryBanks[0];

            for (int i = 0; i < mem.MemoryBanks.Count(); i++)
            {
                string title = "RAM " + i.ToString();
                TabPage myTabPage = new TabPage(title)
                {
                    Size = new Size(740, 620)
                };
                tab_memory.TabPages.Add(myTabPage);

				Hardware.MemoryBank currentBank = mem.MemoryBanks[i];

				Label lb_bank = new Label
                {
                    AutoSize = true,
                    Text = "Bank:",
                    Location = new Point(15, 15)
                };
				Label lb_bankValue = new Label
				{
					AutoSize = true,
					Text = currentBank.BankLabel,
					Location = new Point( 165, 15 )
				};
				Label lb_capacity = new Label
                {
                    AutoSize = true,
                    Text = "Capacity:",
                    Location = new Point(15, 45)
                };
				Label lb_capacityValue = new Label
				{
					AutoSize = true,
					Text = ( currentBank.Capacity / bytesInMegabyte ).ToString() + " MB",
					Location = new Point( 165, 45 )
				};
                Label lb_clspeed = new Label
                {
                    AutoSize = true,
                    Text = "Clock Speed:",
                    Location = new Point(15, 75)
                };
                Label lb_clspeedValue = new Label
                {
                    AutoSize = true,
                    Text = currentBank.ConfiguredClockSpeed.ToString() + " MHz",
                    Location = new Point(165, 75)
                };
                Label lb_form = new Label
                {
                    AutoSize = true,
                    Text = "Form Factor:",
                    Location = new Point(15, 105)
                };
                Label lb_formValue = new Label
                {
                    AutoSize = true,
                    Text = currentBank.FormFactor.ToString(),
                    Location = new Point(165, 105)
                };
                Label lb_loc = new Label
                {
                    AutoSize = true,
                    Text = "Location:",
                    Location = new Point(15, 135)
                };
                Label lb_locValue = new Label
                {
                    AutoSize = true,
                    Text = currentBank.DeviceLocator,
                    Location = new Point(165, 135)
                };
                Label lb_manufact = new Label
                {
                    AutoSize = true,
                    Text = "Manufacturer:",
                    Location = new Point(15, 165)
                };
                Label lb_manufactValue = new Label
                {
                    AutoSize = true,
                    Text = currentBank.Manufacturer,
                    Location = new Point(165, 165)
                };
                Label lb_model = new Label
                {
                    AutoSize = true,
                    Text = "Model:",
                    Location = new Point(15, 195)
                };
                Label lb_modelValue = new Label
                {
                    AutoSize = true,
                    Text = currentBank.Model,
                    Location = new Point(165, 195)
                };
                Label lb_name = new Label
                {
                    AutoSize = true,
                    Text = "Name:",
                    Location = new Point(15, 225)
                };
                Label lb_nameValue = new Label
                {
                    AutoSize = true,
                    Text = currentBank.Name,
                    Location = new Point(165, 225)
                };
                Label lb_part_n = new Label
                {
                    AutoSize = true,
                    Text = "Part Number:",
                    Location = new Point(15, 255)
                };
                Label lb_part_nValue = new Label
                {
                    AutoSize = true,
                    Text = currentBank.PartNumber,
                    Location = new Point(165, 255)
                };
                Label lb_ser_n = new Label
                {
                    AutoSize = true,
                    Text = "Serial Number:",
                    Location = new Point(15, 285)
                };
                Label lb_ser_nValue = new Label
                {
                    AutoSize = true,
                    Text = currentBank.SerialNumber,
                    Location = new Point(165, 285)
                };
                Label lb_type = new Label
                {
                    AutoSize = true,
                    Text = "Type:",
                    Location = new Point(15, 315)
                };
                Label lb_typeValue = new Label
                {
                    AutoSize = true,
                    Text = currentBank.MemoryType.ToString(),
                    Location = new Point(165, 315)
                };
                Label lb_type_det = new Label
                {
                    AutoSize = true,
                    Text = "Type Detail:",
                    Location = new Point(15, 345)
                };
                Label lb_type_detValue = new Label
                {
                    AutoSize = true,
                    Text = currentBank.TypeDetail.ToString(),
                    Location = new Point(165, 345)
                };
                Label lb_voltage = new Label
                {
                    AutoSize = true,
                    Text = "Voltage:",
                    Location = new Point(15, 375)
                };
                Label lb_voltageValue = new Label
                {
                    AutoSize = true,
                    Text = currentBank.ConfiguredVoltage.ToString(),
                    Location = new Point(165, 375)
                };
                Label lb_width = new Label
                {
                    AutoSize = true,
                    Text = "Data Width:",
                    Location = new Point(15, 405)
                };
                Label lb_widthValue = new Label
                {
                    AutoSize = true,
                    Text = currentBank.DataWidth.ToString(),
                    Location = new Point(165, 405)
                };

                myTabPage.Controls.Add(lb_bank);
				myTabPage.Controls.Add(lb_bankValue);
				myTabPage.Controls.Add(lb_capacity);
				myTabPage.Controls.Add(lb_capacityValue);
				myTabPage.Controls.Add(lb_clspeed);
                myTabPage.Controls.Add(lb_clspeedValue);
                myTabPage.Controls.Add(lb_form);
                myTabPage.Controls.Add(lb_formValue);
                myTabPage.Controls.Add(lb_loc);
                myTabPage.Controls.Add(lb_locValue);
                myTabPage.Controls.Add(lb_manufact);
				myTabPage.Controls.Add(lb_manufactValue);
                myTabPage.Controls.Add(lb_model);
                myTabPage.Controls.Add(lb_modelValue);

                myTabPage.Controls.Add(lb_name);
                myTabPage.Controls.Add(lb_nameValue);
                myTabPage.Controls.Add(lb_part_n);
                myTabPage.Controls.Add(lb_part_nValue);
                myTabPage.Controls.Add(lb_ser_n);
                myTabPage.Controls.Add(lb_ser_nValue);
                myTabPage.Controls.Add(lb_type);
                myTabPage.Controls.Add(lb_typeValue);
                myTabPage.Controls.Add(lb_type_det);
                myTabPage.Controls.Add(lb_type_detValue);
                myTabPage.Controls.Add(lb_voltage);
                myTabPage.Controls.Add(lb_voltageValue);
                myTabPage.Controls.Add(lb_width);
                myTabPage.Controls.Add(lb_widthValue);

            }

	    }

    }
}
