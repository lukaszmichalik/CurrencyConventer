using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CurrencyConverter.ViewModel
{
    public class MathViewModel : INotifyPropertyChanged
    {
        private double _currency;
        private double _amount;
        private double _result;

        public double Currency
        {
            get { return _currency; }
            set
            {
                _currency = value;
                OnPropertyChanged();
            }
        }

        public double Amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
                OnPropertyChanged();
            }
        }

        public double Result
        {
            get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged();
            }
        }

        public ICommand ConvertAmountToAnotherCurrencyCommand
        {
            get{ 
            return new Command(() =>
        {
            Result = _amount * _currency;
        });
        }
        }

        public ICommand RateForSpecificCurrencyCommand
        {
            get
            {
                return new Command(() =>
                {
                    Result = 1.0 / _currency;
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
