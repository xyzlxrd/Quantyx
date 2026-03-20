using LibreHardwareMonitor.Hardware;
using Quantyx.Services;
using Quantyx.Views;
using System.Windows;
using System.Windows.Input;

namespace Quantyx {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            CoreBtn.IsChecked = true;
            MainContent.Content = new CorePageView();
        }

        private void BtnClose_Button(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnMinimize_Button(object sender, RoutedEventArgs e) {
            this.WindowState = WindowState.Minimized;
        }

        private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            this.DragMove();
        }

        private void OpenCorePage(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new CorePageView();
        }

        private void OpenMetricsPage(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new MetricsPageView();
        }

        private void OpenPerformancePage(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new PerformancePageView();
        }

        private void OpenProcessesPage(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new ProcessesPageView();
        }

        private void OpenOverlayPage(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new OverlayPageView();
        }

        private void OpenSettingsPage(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new SettingsPageView();
        }
    }
}