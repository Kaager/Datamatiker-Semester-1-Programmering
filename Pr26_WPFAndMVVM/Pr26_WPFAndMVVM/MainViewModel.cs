using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Pr26_WPFAndMVVM
{
    public class MainViewModel : INotifyPropertyChanged
    {
        //public string MyLabelText { get; set; } = "Text not set yet";
        private string _myLabelText = "Text not set yet";
        public string MyLabelText
        {
            get => _myLabelText;
            set
            {
                _myLabelText = value;
                OnPropertyChanged("MyLabelText");
            }
        }

        //public string MyTextBoxText { get; set; } = "Text not set yet";
        private string _myTextBoxText = "Text not set yet";

        public string MyTextBoxText
        {
            get { return _myTextBoxText; }
            set 
            {
                _myTextBoxText = value;
                OnPropertyChanged("MyTextBoxText");
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged is not null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
