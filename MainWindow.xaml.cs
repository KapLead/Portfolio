using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Portfolio
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) => Close();

        private void Button_Click_1(object sender, RoutedEventArgs e) => WindowState = WindowState.Minimized;

        private void Button_Click_2(object sender, RoutedEventArgs e) => WindowState = WindowState.Maximized;

        private void BtnLeave(object sender, MouseEventArgs e) => ((Button) sender).Background = null;
        private void BtnMove(object sender, MouseEventArgs e) => ((Button)sender).Background = new SolidColorBrush(Color.FromArgb(20,200,200,200));
    }
}
