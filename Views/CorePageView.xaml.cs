using Quantyx.Services;
using System;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Quantyx.Views {
    public partial class CorePageView : UserControl {
        private HardwareService monitor;
        private DispatcherTimer timer; //temporizador pra atualizar a interface a cada tantos segundos

        public CorePageView() {
            InitializeComponent();

            monitor = new HardwareService(); //serviço pra monitorar

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += UpdateUI;
            timer.Start(); //atualiza a cada 1 segundo
        }

        private void UpdateUI(object sender,EventArgs e) {
            monitor.UpdateSensors(); // da update né claro

            var cpuTemp = monitor.GetCpuTemp(); //guarda a info numa variavel!!
            var gpuTemp = monitor.GetGpuTemp();
            var ramUsage = monitor.GetRamUsage();

            CPUText.Text = cpuTemp.HasValue ? $"CPU TEMP: {cpuTemp.Value:F1} °C" : "N/A"; //Formata o texto pra aparecer apenas 1 casa decimal/casa pós virgula. HasValue verifica se a variavel não é nula
            GPUText.Text = gpuTemp.HasValue ? $"GPU TEMP: {gpuTemp.Value:F1} °C" : "N/A";
            RAMText.Text = ramUsage.HasValue ? $"RAM USAGE: {ramUsage.Value:F1} %" : "N/A";
        }
    }
}