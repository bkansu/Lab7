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
        WebClient client = new WebClient();

        public Crawler(string url)
        {
            this.url = url;
            html = client.DownloadString(url);
        }

       

        public ArrayList FindInWebSite(String regex)
        {
            ArrayList list = new ArrayList();
            Regex rx = new Regex(regex);

            for (int i = 0; i < html.Length; i++)
            {
                if (rx.IsMatch(html))
                {
                    list[i] = rx.IsMatch(html);
                }
            }

            if (list == null)
            {
                RegexMatchTimeoutException a = new RegexMatchTimeoutException();
                
            }

            //Hiçbir eşleşme bulamazsa RegexNotFoundException firlatilacak.


            
                return list;
            
            
        }

        public void ReplaceInWebsite(String regex,String regexrep)
        {
            Regex rx = new Regex(regex);
            if (rx.IsMatch(html))
            {
                rx.Replace(html, regexrep);
            }
          // Buldu eşleşmeyi başka bir regex ile değiştecek.
        }

        public void SaveHtml()
        {
            client.DownloadFile(url, "yeni");
            //html'in o anki halini kaydedecek.
        }
        

      
       
    }
}
