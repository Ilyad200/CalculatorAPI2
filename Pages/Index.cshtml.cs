using CalculatorAPI.Converter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculatorAPI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string result = "";
        private SimpleConverter _converter = new SimpleConverter();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet(string from, string to, string value)
        {
            if (from != null && to != null && value != null)
                Converted(from, to, value);
            //return RedirectToPage("/Index");
        }

        public void OnPost(string from)
        {
            //Converted(from, to, value);
            //return RedirectToPage("/Index");
        }

        public void Converted(string from, string to, string value)
        {
            if (!CheckValue(from, value))
            {
                result = "����� ������� �� � ��������� ������� ���������";
                return;
            }

            string res = _converter.ConvertNS(Int32.Parse(from), Int32.Parse(to), value);

            if (res == "!from")
            {
                result = $"������� ���������, � ���������� {from} �� ��������������";
                return;
            }
            if (res == "!to")
            {
                result = $"������� ���������, � ���������� {to} �� ��������������";
                return;
            }
            result = $"�����: {res.ToUpper()}";
        }
        private bool CheckValue(string from, string value)
        {
            
            if (Int32.TryParse(value, out _))
            {
                if (Int32.Parse(from) == 2)
                {
                    foreach (char s in value)
                    {
                        if (Int32.Parse(s.ToString()) > 1)
                        {
                            return false;
                        }
                    }
                }
                if (Int32.Parse(from) == 8)
                {
                    foreach (char s in value)
                    {
                        if (Int32.Parse(s.ToString()) > 7)
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                if (Int32.Parse(from) != 16)
                {
                    return false;
                }
                foreach (char s in value)
                {
                    if (s >= '0' && s <= '9' || s >= 'a' && s <= 'f' || s >= 'A' && s <= 'F')
                        continue;
                    else
                        return false;
                }
            }
            return true;
        }
    }
}
