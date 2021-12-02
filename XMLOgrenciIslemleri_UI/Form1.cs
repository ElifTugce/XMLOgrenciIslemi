using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Ornek1
{
    public partial class Form1 : Form
    {
        // Global Alan
        // Listelerimizi oluşturalım
        List<string> SiniflarListesi = new List<string>() { "A Sınıfı", "B Sınıfı" };
        List<Ogrenci> ASinifiOgrenciler = new List<Ogrenci>();
        List<Ogrenci> BSinifiOgrenciler = new List<Ogrenci>();
        List<string> SecilenSecmeliDersler = new List<string>();
        public Form1()
        {
            // YÖNTEM1
            // Adrange diziye bir array ister. Bu nedenle listeyi toArray ile diziye çevirmeliyiz.

            InitializeComponent();
            //comboBoxSinif.Items.AddRange(SiniflarListesi.ToArray());

            // YÖNTEM2
            // Döngü kurma yöntemi ile ekleyebiliriz.
            foreach (var item in SiniflarListesi)
            {
                comboBoxSinif.Items.Add(item);
            }

            //Tab a basınca nereye gideceğimizi bununla belirleriz.
            txtAd.TabIndex = 0;
            txtSoyad.TabIndex = 1;
            dateTimePicker1.TabIndex = 2;
            comboBoxSinif.TabIndex = 3;
            btnOgrenciEkle.TabIndex = 4;
            listBoxASinifi.TabIndex = 5;
            listBoxBSinifi.TabIndex = 6;

            groupBoxSecmeliDers.Enabled = false;

            //CheckOnClick tıkladığım an listedeki checkbox ı tiklesin.
            checkedListBoxSecmeliDers.CheckOnClick = true;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //B sınıfındaki herkesi A ya gönderecek
            foreach (var item in BSinifiOgrenciler)
            {
                item.Sinifi = "A sınıfı";

            }
            ASinifiOgrenciler.AddRange(BSinifiOgrenciler.ToArray());
            BSinifiOgrenciler.Clear();
            ListeleriDoldur();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            // Öğrencilerimiz Ekleyelim

            // string.IsNullOrEmpty --> Hazır bir string metot
            // içine verilen valuenun null ya da boş olup olmadığına bakar
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text))
            {
                MessageBox.Show("Lütfen ad soyad giriniz.");
            }
            else
            {
                Ogrenci ogr1 = new Ogrenci()
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    DTarihi = dateTimePicker1.Value
                };
                //comboboxta seçtiği değer

                //if (comboBoxSinif.SelectedIndex == -1)
                //{
                //    MessageBox.Show("Lütfen sınıf seçiniz.");
                //}
                //else
                //{
                //    //işlemler
                //}
                if (AsinifindanAyniOgrencidenVarMi(ogr1))
                {
                    MessageBox.Show("Bu öğrenci zaten A sınıfına kayıt olmuştur.");
                }
                else if (BsinifindanAyniOgrencidenVarMi(ogr1))
                {
                    MessageBox.Show("Bu öğrenci zaten B sınıfına kayıt olmuştur.");
                }


                else if (comboBoxSinif.SelectedIndex >= 0) // indeksler sıfırdan başladığı için >=0 olmalıdır.
                {
                    //Öğrencinin sınıfı comboboxtan gelen seçili değer olacak.
                    ogr1.Sinifi = comboBoxSinif.SelectedItem.ToString();

                    // Artık öğrenciyi listeye eklemeliyiz.
                    switch (comboBoxSinif.SelectedIndex)
                    {
                        case 0: // A sınıfıdır
                            if (AsinifindanAyniOgrencidenVarMi(ogr1)==false)
                            {
                                ASinifiOgrenciler.Add(ogr1);
                            }
                            else
                            {
                                MessageBox.Show("Öğrenci sistemde zaten bulunuyor.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                            break;

                        case 1: // B sınıfıdır
                            if (BsinifindanAyniOgrencidenVarMi(ogr1) == false)
                            {
                                BSinifiOgrenciler.Add(ogr1);
                            }
                            else
                            {
                                MessageBox.Show("Öğrenci sistemde zaten bulunuyor.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;
                        default:
                            break;
                    }

                    //Öğrenci seçmeli ders alıyorsa listesine dersleri bu satırda ekleyelim.
                    ogr1.SecmeliDersAliyorMu = checkBoxSecmeliDers.Checked;

                    //alıyorsa -se -sa eki koşul bildirir.
                    //C#'ta ise koşul dendiğinde aklımıza if gelmelidir. Aşağıya bir if ekleyelim. Acaba seçmeli ders alıyor mu?
                    if (ogr1.SecmeliDersAliyorMu)
                    {
                        ogr1.AldigiSecmeliDersler.AddRange(SecilenSecmeliDersler);
                    }

                    KontrolleriTemizle();
                    ListeleriDoldur();
                }
                else
                {
                    MessageBox.Show("Lütfen sınıf seçiniz");
                }
            }
        }

        private bool AsinifindanAyniOgrencidenVarMi(Ogrenci ogrenci)
        {
            bool sonuc = false;
            foreach (var item in ASinifiOgrenciler)
            {
                if (item.Ad==ogrenci.Ad && item.Soyad==ogrenci.Soyad && item.DTarihi.ToShortDateString()==ogrenci.DTarihi.ToShortDateString())
                {
                    sonuc = true;
                    break;
                }
            }
            return sonuc;
        }
        private bool BsinifindanAyniOgrencidenVarMi(Ogrenci ogrenci)
        {
            bool sonuc = false;
            foreach (var item in BSinifiOgrenciler)
            {
                if (item.Ad == ogrenci.Ad && item.Soyad == ogrenci.Soyad && item.DTarihi.ToShortDateString() == ogrenci.DTarihi.ToShortDateString())
                {
                    sonuc = true;
                    break;
                }
            }
            return sonuc;
        }
        private void KontrolleriTemizle()
        {
            //1. yöntem
            txtAd.Text = "";
            //2. yöntem
            txtSoyad.Text = string.Empty;
            comboBoxSinif.SelectedIndex = -1;
            comboBoxSinif.Text = "Sınıfınızı Seçiniz...";
            dateTimePicker1.Value = DateTime.Now;

            // CheckedList içinde checklenmiş (yani tik atılmış) olan dersleri unchecked yapmalıyız.
            foreach (int indexi in checkedListBoxSecmeliDers.CheckedIndices)
            {
                checkedListBoxSecmeliDers.SetItemCheckState(indexi, CheckState.Unchecked); // bizden int istiyor.

            }

            // Checked olan dersleri tuttuğumuz listeyi temizleyelim.
            SecilenSecmeliDersler.Clear(); // seçilen dersler listesini temizledik.

            //CheckBoxSecmeliDers unchecked olsun. Tiki kaldıralım.
            checkBoxSecmeliDers.Checked = false;

            

        }
        private void ListeleriDoldur()
        {
            listBoxASinifi.Items.Clear();
            listBoxASinifi.BackColor = Color.White;
            listBoxASinifi.Items.AddRange(ASinifiOgrenciler.ToArray());


            listBoxBSinifi.Items.Clear();
            listBoxBSinifi.BackColor = Color.White;
            listBoxBSinifi.Items.AddRange(BSinifiOgrenciler.ToArray());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHepsiniSagaGönder_Click(object sender, EventArgs e)
        {
            //A sınıfındaki herkesi B ye gönderecek
            foreach (var item in ASinifiOgrenciler)
            {
                item.Sinifi = "B sınıfı";

            }
            BSinifiOgrenciler.AddRange(ASinifiOgrenciler.ToArray());
            ASinifiOgrenciler.Clear();
            ListeleriDoldur();
        }

        private void btnSagaGönder_Click(object sender, EventArgs e)
        {
            //seçili olanı sağa gönderme işlemi
            //Yani A dan B ye gönderiyoruz
            // Kimin seçili olduğunu ListBox'ın SelectedItem özelliği ile alıyoruz.
            // SelectedItem bize object tipinde değer gönderiyor.
            // Bu nedenle gelen object tipi kullanacağımız classa cast ediyoruz.

            //Cast etme yöntem1
            // Orenci transferEdilecekOgr = listBoxSinifi.SelectedItem as Ogrenci;
            //kim seçili onu bulalım
            Ogrenci transferEdilecekOgr = (Ogrenci)listBoxASinifi.SelectedItem;
            if (transferEdilecekOgr != null)
            {
                ASinifiOgrenciler.Remove(transferEdilecekOgr);
                transferEdilecekOgr.Sinifi = "B sınıfı";
                BSinifiOgrenciler.Add(transferEdilecekOgr);
                ListeleriDoldur();

            }
        }

        private void btnSolaGönder_Click(object sender, EventArgs e)
        {
            Ogrenci transferEdilecekOgr = (Ogrenci)listBoxBSinifi.SelectedItem;
            if (transferEdilecekOgr != null)
            {
                BSinifiOgrenciler.Remove(transferEdilecekOgr);
                transferEdilecekOgr.Sinifi = "A sınıfı";
                ASinifiOgrenciler.Add(transferEdilecekOgr);
                ListeleriDoldur();

            }
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSecmeliDers.Checked)
            {
                groupBoxSecmeliDers.Enabled = true;
            }
            else
            {
                groupBoxSecmeliDers.Enabled = false;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SecilenSecmeliDersler.Clear();
            // checkListBox'ın CheckedItems propertysi bize bir koleksiyon verir.
            foreach (var item in checkedListBoxSecmeliDers.CheckedItems)
            {

                //Eğer SecilenSecmeliDersler listesinde bu ders varsa bir daha eklemesi için koşul yazacağız.
                //CheckedItems'ın foreach döngüsündeki var item ile bize sunduğu değişken object tipte geliyor.
                //SecilenSecmeliDersler listemiz string tipte bir listedir.
                //Bu nedenle item.ToString() yaptık.
                if (SecilenSecmeliDersler.Count(x=> x==item.ToString()) ==0) // Bu satırın anlamı "Bu ders listede kaç tane var? Eğer hiç yoksa listeye ekle..." 
                    //Böylece her dersi yalnızca bir kere alabiliriz. Ders tekrarı olması saçma olurdu.
                {
                    SecilenSecmeliDersler.Add(item.ToString());
                }
                
            }
        }

        private void SecmeliDers_Enter(object sender, EventArgs e)
        {

        }

        private void xMLileDisariAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Ogrenci> DisariAktarilacaklar = new List<Ogrenci>();

            // A sınıfında öğrenci varsa
            if (ASinifiOgrenciler.Count>0) // A sınıfında öğrenci varsa
            {
                DisariAktarilacaklar.AddRange(ASinifiOgrenciler); // Dışarı aktarılacaklar listesine ekleyelim.
            }
            // B sınıfında öğrenci varsa
            if (BSinifiOgrenciler.Count > 0) // B sınıfında öğrenci varsa
            {
                DisariAktarilacaklar.AddRange(BSinifiOgrenciler); // Dışarı aktarılacaklar listesine ekleyelim.
            }
            // oluşacak xml dosyasını nereye kaydedeceği ile ilgili
            // Diyalog nesnesine ihtiyacımız var.
            // Xml'i seriliaze edecek işlemler...

            saveFileDialog1.Title = "Öğrenci XML Dosyası Kaydet";
            saveFileDialog1.Filter = "XML Formatı | *xml ";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                //Açılan diyalog penceresinde tamam / ok tuşuna basarsak XML doyasını oluşturabiliriz.
                // Xml'i seriliaze edecek işlemler...

                XmlSerializer myXMLSerilizaer = new XmlSerializer(typeof(List<Ogrenci>));

                // C#'ta using bloğundan bahseceğiz. IDisposable interfaceinden türemiş nesneler using(){}
                // bloğu içinde oluşurulursa,using bloğundan çıkılır çıkılmaz GC(Garbage Collector) a devredilir ve hemen silinirler.
                // Çünkü IDisposable dan türemiş classlarda %100 Dispose metodu vardır.
                // Using bloğunda aslınfa blok sonunda bu metodu çalışturmaktadır. 
                // Bu sayede manuel olarak nesneyi Dispose etmemize gerek kalmaz.
                using (StreamWriter yazar = new StreamWriter(saveFileDialog1.FileName))
                {
                    myXMLSerilizaer.Serialize(yazar, DisariAktarilacaklar);
                }
                MessageBox.Show($"{DisariAktarilacaklar.Count} adet öğrenci xml dosyası olarak aktarıldı.");

            }

        }

        private void xMLileiceriVeriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Bilgisayarda olan xml dosyasını açmamıza yardımcı olacak diyalog nesnesine ihtiyacımız var.
            // 2 adet diyalog nesnesine ihtiyac var. Open diyalog ve save file diyalog...


            //İçeri almadan önce temizleyelim.
            KontrolleriTemizle();
            openFileDialog1.Title = "XMl Dosyanızı Seçiniz";
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
            XmlSerializer myXMLSerilizaer = new XmlSerializer(typeof(List<Ogrenci>));


                //Var olan br dosyayı okumak için okuyucuya ihtiyaç duyarız.

                using (TextReader okuyucu = new StreamReader(openFileDialog1.FileName))
                {
                    // 1.YÖNTEM

                    ASinifiOgrenciler = myXMLSerilizaer.Deserialize(okuyucu) as List<Ogrenci>; //Deserilize şifrelemeyi çözüyo...

                    // 2. YÖNTEM

                    // ASinifiOgrenciler = (List<Ogrenci>)myXMLSerilizaer.Deserialize(okuyucu);
                MessageBox.Show($"{ASinifiOgrenciler.Count} adet öğrenci içeri aktarıldı.");
                ListeleriDoldur();
                }
                
            }
            }
        }
    }

