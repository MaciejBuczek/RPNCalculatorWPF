using RPNCalculator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculator.Services.Services
{
    public class EquationValidator : IEquationValidator
    {
        private readonly int _minAsciiNumber = 48;
        private readonly int _maxAsciiNumber = 57;

        public bool CanInsertSymbol(char symbol, string equation)
        {
            var asciiValue = (int)symbol;

            if(asciiValue >= _minAsciiNumber && asciiValue <= _maxAsciiNumber)
                return true;
        
            return false;
        }
    }
}
