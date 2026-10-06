using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfShowDialog.ViewModels
{
    internal class SomeViewModel : ViewModelBase
    {
        private string _data;
        public string Data {
            get => _data;
            set { _data = value; OnPropertyChanged(); }
        }

        public ICommand GetDataCommand {
            get {
                return new RelayCommand(() => {
                    var ds = new SomeSource();
                    Data = ds.GetData(); 
                });
            }
        }

    }
}
