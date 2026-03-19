using System.Windows.Controls;
using OpenHardwareMonitor.Hardware;

namespace Quantyx.Views
{
    public partial class CorePageView : UserControl
    {
        private Computer computer;
        public CorePageView()
        {
            InitializeComponent();
        }
        public void Monitor()
        {
            computer = new Computer() { CPUEnabled = true, GPUEnabled = true, RAMEnabled = true };
            computer.Open();
        }
    }
}
