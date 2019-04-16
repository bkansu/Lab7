using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class RegexNotFoundException : Exception
    {
        public RegexNotFoundException()
        {
            throw new Exception("Bulamadık..");
        }
        public RegexNotFoundException(string message)
        {
            throw new Exception(message);
        }
        public RegexNotFoundException(string Mesaj, Exception ex)
        {
            throw new Exception(Mesaj, ex);
        }
        //Hiç argüman almayan, Sadece mesajı alan , Mesaj ve iç exception'i alan 3 farklı consturoctor tanımlanacak.
    }
}
