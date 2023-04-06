using RPNCalculator.Presentation.ViewModels;
using System.Windows;

namespace RPNCalculator
{
    /// <summary>
    /// Interaction logic for CalculatorWindow.xaml
    /// </summary>
    public partial class CalculatorWindow : Window
    {
        public CalculatorWindow()
        {
            InitializeComponent();
            DataContext = new CalculatorViewModel();
        }
    }
}
