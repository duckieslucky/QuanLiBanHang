using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Resources.CustomComponent
{
    public class BoolBinding : INotifyPropertyChanged
    {
        private bool state;
        // Declare the event
        public event PropertyChangedEventHandler PropertyChanged;

        public BoolBinding()
        {
        }

        public BoolBinding(bool value)
        {
            this.state = value;
        }

        public bool State
        {
            get { return state; }
            set
            {
                state = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged();
            }
        }

        public bool OppState
        {
            get { return !state; }
        }

        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
