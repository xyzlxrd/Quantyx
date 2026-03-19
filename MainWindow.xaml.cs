using System.Windows;
using System.Windows.Input;

namespace Quantyx {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            CoreBtn.IsChecked = true;
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

    }
}