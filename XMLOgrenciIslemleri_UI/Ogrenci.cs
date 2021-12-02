using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1
{
   public class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DTarihi { get; set; }
        public string Sinifi { get; set; }
        private byte _yas = 0;
        public byte Yas
        {
            get
            {
                _yas = Convert.ToByte(DateTime.Now.Year - DTarihi.Year);
                return _yas;
            }
        }
        public bool SecmeliDersAliyorMu { get; set; }
        public List<string> AldigiSecmeliDersler { get; set; } = new List<string>();
        //ToString metodunu ezeceğiz.
        public override string ToString()
        {
            return this.Ad + " " + this.Soyad.ToUpper() + " - " + this.Yas + "yaşında" + this.AldigiSecmeliDersler.Count + "adet seçmeli dersi almıştır.";
        }

    }
}
