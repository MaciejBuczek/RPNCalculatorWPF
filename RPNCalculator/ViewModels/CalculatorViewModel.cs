using RPNCalculator.Presentation.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RPNCalculator.Presentation.ViewModels
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        private string _infixEquation = string.Empty;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ICommand InsertToEquationCommand { get; set; }

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

        public CalculatorViewModel()
        {
            InsertToEquationCommand = new RelayCommand(InsertToEquation);
        }

        private void InsertToEquation(object? obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            var parameter = (string)obj;
            InfixEquaiton += parameter;
        }
        
        private void OnPropertyChanged([CallerMemberName]string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
