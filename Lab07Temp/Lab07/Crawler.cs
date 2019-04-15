using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab07
{
    class Crawler
    {
        private string html;
        private string url;

        public Crawler(string url)
        {
            
        }

        public ArrayList FindInWebSite(String regex)
        {
            ArrayList list = new ArrayList();
         
            //Hiçbir eşleşme bulamazsa RegexNotFoundException firlatilacak.

            return list;
        }

        public void ReplaceInWebsite(String regex,String regexrep)
        {
          // Buldu eşleşmeyi başka bir regex ile değiştecek.
        }

        public void SaveHtml()
        {
            //html'in o anki halini kaydedecek.
        }
        

      
       
    }
}
