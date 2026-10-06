using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace WpfShowDialog
{
    internal class SomeSource
    {
        public string GetData() {
            var inputWindow = new TakeInputText();
            var frame = new DispatcherFrame();
            inputWindow.Closed += (s, e) => frame.Continue = false;
            inputWindow.Show();
            Dispatcher.PushFrame(frame);
            return inputWindow.InputValue;
        }
    }
}
