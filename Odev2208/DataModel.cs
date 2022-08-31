using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2208
{
    public class DataModel
    {
        public string NullVeriControl(string text)
        {
            if (!String.IsNullOrEmpty(text))
            {
                return text;
            }
            else
            {
                return null;
            }
        }

        public bool CiftSayiKontrol(string text)
        {
            int number = Convert.ToInt32(text[text.Length - 1]);
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DigitControl(string text, int number)
        {
            if (text.Length == number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DigitControl(string text)
        {
            if (text.Length >= 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
