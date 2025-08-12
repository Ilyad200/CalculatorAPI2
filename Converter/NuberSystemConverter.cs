namespace CalculatorAPI.Converter
{
    // CurrencyConverter - конвертер валют
    public interface NumberSystemConverter
    {
        // SupportedCurrencies - метод получения поддерживаемых для конвертации валют
        // вход: -
        // выход: массив с кодами валют
        // исключения: -
        string[] SupportedNumberSystem();

        // Convert - метод конвертации значения одной валюты в другую
        // вход:
        //  - from - код исходной валюты
        //  - to - код целевой валюты
        //  - value - значение для конвертацииы
        // выход: сконвертированное значение
        // исключения: UnsupportedCurrencyException, InvalidValueException
        string ConvertNS(int from, int to, string value);
    }
}
