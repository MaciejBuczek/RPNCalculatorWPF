using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculator.Presentation.ViewModels
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        private string _infixEquation = string.Empty;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string InfixEquaiton
        {
            get
            {
                return _infixEquation;
            }
            set
            {
                _infixEquation = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName]string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
