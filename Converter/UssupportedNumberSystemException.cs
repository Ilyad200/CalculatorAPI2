namespace CalculatorAPI.Converter
{
    public class UnsupportedNumberSystemException : ApplicationException
    {
        public UnsupportedNumberSystemException(string system) :
            base($"{system} система счисления не поддерживается")
        { }
    }
}
