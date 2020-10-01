using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ExchangeCalculator.Model;

namespace ExchangeCalculator.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private MainModel myModel = null;

        public MainViewModel()
        {
            myModel = new MainModel();
        }

        public MainModel MyModel
        {
            get
            {
                return myModel;
            }
            set
            {
                myModel = value;
            }
        }

        public string Dollar
        {
            get
            {
                if(string.IsNullOrEmpty(myModel.Dollar))
                {
                    Won = "0";
                }
                else
                {
                    int result = int.Parse(myModel.Dollar) * 1160;
                    Won = result.ToString();
                }
                return myModel.Dollar;
            }
            set
            {
                if (myModel.Dollar != value)
                {
                    myModel.Dollar = value;
                    OnPropertyChanged("Dollar");
                }
            }
        }

        public string Won
        {
            get
            {
                return MyModel.Won;
            }
            set
            {
                myModel.Won = value;
                OnPropertyChanged("Won");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
