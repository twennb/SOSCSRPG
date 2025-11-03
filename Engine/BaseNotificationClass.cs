using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class BaseNotificationClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged; // define a public event
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); // check for when something wants to be changed
        }
    }
}
