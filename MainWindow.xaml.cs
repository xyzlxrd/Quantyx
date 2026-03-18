using System.Windows;

namespace Quantyx {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void BtnClose_Button(object sender,RoutedEventArgs e) {
            this.Close();
        }
    }
}