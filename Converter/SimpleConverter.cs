
namespace CalculatorAPI.Converter
{
    public class SimpleConverter : NumberSystemConverter
    {
        public readonly Dictionary<int, string> SupportedNumberSystems = new Dictionary<int, string>();

        public SimpleConverter()
        {
            SupportedNumberSystems = new Dictionary<int, string>()
            {
                { 2, "Двоичная" },
                { 8, "Восьмеричная" },
                { 10, "Десятичная" },
                { 16, "Шестнадцатиричная" }
            };
        }

        public string[] SupportedNumberSystem()
        {
            return SupportedNumberSystems.Values.ToArray();
        }

        public string ConvertNS(int from, int to, string value)
        {
            if (!SupportedNumberSystems.ContainsKey(from))
            {
                return "!from";
            }
            if (!SupportedNumberSystems.ContainsKey(to))
            {
                return "!to";
            }
            int num = Convert.ToInt32(value, from);

            return Convert.ToString(num, to);
            //return Convert.ToDecimal(value.ToString());
        }
    }
}
