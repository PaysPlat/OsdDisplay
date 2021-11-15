using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OsdDisplayTestApplication
{
    internal sealed class MainVM : INotifyPropertyChanged
    {

        public string Message
        {
            get => message;
            set
            {
                if (SetProperty(ref message, value))
                {
                    UpdateMessage(message);
                }
            }
        }

        private string message;

        public ICommand ClearMessageCommand { get; }


        public MainVM()
        {
            DisplayHelper.Start();

            ClearMessageCommand = new Command(o => ClearMessage(), o => true);
        }

        private static void UpdateMessage(string message)
        {
            DisplayHelper.Display(message);
        }

        private static void ClearMessage()
        {
            DisplayHelper.ClearDisplay();
        }

        private bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }
        public event PropertyChangedEventHandler PropertyChanged;

    }
}
