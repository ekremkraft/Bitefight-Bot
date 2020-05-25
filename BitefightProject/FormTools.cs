using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitefightProject
{
    class FormTools
    {
        public static dynamic Settings = new IniFile("Settings.ini");
        public static int GetUniqueID()
        {
            int counter = 0;
            while (true)
            {
                if (!Settings.KeyExists("Server", "Account" + counter))
                {
                    return counter;
                }
                else
                {
                    counter++;
                }
            }
        }

        public static int GetAccountCount()
        {
            int counter = 0;
            while (true)
            {
                if (Settings.KeyExists("Server", "Account" + counter))
                {
                    counter++;
                }
                else
                {
                    return counter;
                }
            }
        }

        public static int GetAccountID(string Server)
        {
            int counter = 0;
            while (true)
            {
                if (Settings.Read("Server", "Account" + counter).ToString() == Server)
                {
                    return counter;
                }
                else
                {
                    counter++;
                }
            }
        }

        public static string GetStoryCurrentCount(HtmlDocument doc)
        {
            var Current = doc.GetElementsByTagName("h2");
            Current[0].InnerHtml = Current[0].InnerHtml.Replace("(this).next().next('button').trigger('mouseover')", String.Empty);
            Current[0].InnerHtml = Current[0].InnerHtml.Replace("(this).next().next('button').trigger('click')", String.Empty);
            int start = Current[0].InnerHtml.IndexOf("(");
            int lenght = Current[0].InnerHtml.Length - start;
            return Current[0].InnerHtml.Substring(start, lenght);
        }

   

        public static string GetButtonText(string ButtonID)
        {
            switch (ButtonID)
            {
                case "1":
                    return "İncele";
                case "2":
                    return "Yürümeye devam et";
                case "3":
                    return "Herşeyi parçala";
                case "4":
                    return "Daha iyi bir yol bul";
                case "5":
                    return "Üzerinden atla";
                case "6":
                    return "Yolunu şaşırt";
                case "7":
                    return "Ye";
                case "8":
                    return "Konuş";
                case "9":
                    return "Eziyet Et";
                case "10":
                    return "Şehre gir";
                case "11":
                    return "Şehri yağmala";
                case "12":
                    return "Yağmala";
                case "20":
                    return "Diren";
                case "21":
                    return "Kabullen";
                case "22":
                    return "Fırsatı değerlendir";
                case "23":
                    return "Daha fazla kopar";
                case "24":
                    return "Gizlen";
                case "25":
                    return "Hücum et";
                case "26":
                    return "Herşeyi yak";
                case "27":
                    return "Eşlik et";
                case "28":
                    return "Cezbet";
                case "29":
                    return "İspiyonla";
                case "30":
                    return "İçine bozuk para at";
                case "31":
                    return "Bozuk para ara";
                case "32":
                    return "Çılgınca eğlen";
                case "33":
                    return "Ganimeti ele geçir";
                case "34":
                    return "Ormana gir";
                case "35":
                    return "Devam et (3 FP)";
                case "36":
                    return "Hikayeyi bitir";
                case "37":
                    return "Düşmanı yakala";
                case "38":
                    return "Katlet";
                case "39":
                    return "Keşfet";
                case "40":
                    return "Vampir bakışı";
                case "42":
                    return "Her şerde bir hayır vardı";
                case "43":
                    return "Tehlikelere karşı uyar";
                case "44":
                    return "Dağa git";
                case "45":
                    return "Mağaraya gir";
                case "46":
                    return "Yeraltına gir";
                case "47":
                    return "Gölgeli adım";
                case "52":
                    return "Ruh yamyamı";
                case "53":
                    return "İzle";
                case "55":
                    return "Burda kal";
                default:
                    return "Unknown";
            }
        }

        public static int LicenseControl(string Username)
        {
            string source = "";
            WebRequest req = HttpWebRequest.Create("http://license.nowingame.com/default.aspx?act=search&username=" + Username );
            using (StreamReader reader = new StreamReader(req.GetResponse().GetResponseStream()))
            {
                source = reader.ReadToEnd();
            }
            return Convert.ToInt32(source);
        }
    }
}
