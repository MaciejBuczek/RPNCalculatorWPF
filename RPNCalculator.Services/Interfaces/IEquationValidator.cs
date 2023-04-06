namespace RPNCalculator.Services.Interfaces
{
    public interface IEquationValidator
    {
        bool CanInsertSymbol(char symbol, string equation);
    }
}
