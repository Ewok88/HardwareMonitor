using System.Windows.Forms;

namespace HardwareMonitor.UI
{
    public partial class uc_motherboard : UserControl
    {
        public uc_motherboard()
        {
            InitializeComponent();

            Hardware.Motherboard bd = new Hardware.Motherboard();
            bd.Retrieve();
            lb_board_caption.Text = bd.Caption;
            lb_board_manufact.Text = bd.Manufacturer;
            lb_board_product.Text = bd.Product;
            lb_board_serial.Text = bd.SerialNumber;
            lb_board_version.Text = bd.Version;
        }
    }
}
