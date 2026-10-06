using System.Windows;
using System.Windows.Controls;

namespace WpfShowDialog
{
    /// <summary>
    /// Логика взаимодействия для TakeInputText.xaml
    /// </summary>
    public partial class TakeInputText : Window
    {
        
        public string InputValue { get; set; }
        public bool _isOkClose = false;
        public TakeInputText() {
            InitializeComponent();
        }

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            if (OkButton == null || InputTextBox == null) return;
            OkButton.IsEnabled = !string.IsNullOrEmpty(InputTextBox.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            InputValue = InputTextBox.Text;
            _isOkClose = true;
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            if (!_isOkClose) {
                e.Cancel = true; 
            }
        }
    }
}
