using System.Windows;
using WpfShowDialog.ViewModels;

namespace WpfShowDialog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new SomeViewModel();
        }

        //private void MainButton_Click(object sender, RoutedEventArgs e) {
        //    TakeInputText takeInputText = new TakeInputText();
        //    takeInputText.Show();
        //}
    }
}