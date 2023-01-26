using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogrusayisi = 0, yanlissayisi = 0; int prgrsbr = 4;



        private void BtnNext_Click(object sender, EventArgs e)
        {
            
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnNext.Enabled = false;
            soruno++;
            LblSoruno.Text = soruno.ToString();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            progressBar1.Value = prgrsbr;
            

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                LblCevap.Text = "1923";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi ilimiz Ege Bölgesi'nde bulunmaz?";
                BtnA.Text = "İzmir";
                BtnB.Text = "Manisa";
                BtnC.Text = "Aydın";
                BtnD.Text = "Samsun";
                LblCevap.Text = "Samsun";
            }
            if (soruno == 3)

            {
                richTextBox1.Text = "Yaprak Dökümü adlı eser hangi yazarımıza aittir?";
                BtnA.Text = "Fakir Baykurt";
                BtnB.Text = "Reşat Nuri Gültekin";
                BtnC.Text = "Sait Faik Abasıyanık";
                BtnD.Text = "Cemal Süreya";
                LblCevap.Text = "Reşat Nuri Gültekin";
            }
            if (soruno==4)
            {
                richTextBox1.Text = "Telefonu kim icat etmiştir ?";
                BtnA.Text = "Nikola Tesla";
                BtnB.Text = "Thomas Edison";
                BtnC.Text = "Graham Bell";
                BtnD.Text = "Albert Einstein";
                LblCevap.Text = "Graham Bell";
            }
            if (soruno==5)
            {
                richTextBox1.Text = "Türkiye'de kurulan ilk yerli araba fabrikası hangisidir?";
                BtnA.Text = "Devrim";
                BtnB.Text = "Anadol";
                BtnC.Text = "Tofaş";
                BtnD.Text = "Murat";
                LblCevap.Text = "Devrim";
            }
            if (soruno==6)
            {
                richTextBox1.Text = "Aşağıdaki ülkelerden hangisi Türkiye'nin sınır komşusu değildir?";
                BtnA.Text = "Ukrayna";
                BtnB.Text = "Suriye";
                BtnC.Text = "Bulgaristan";
                BtnD.Text = "Azerbaycan";
                LblCevap.Text = "Ukrayna";
            }
            if (soruno==7)
            {
                richTextBox1.Text = "Yazılan ilk Türkçe sözlük aşağıdakilerden hangisidir?";
                BtnA.Text = "Mukaddimetü’l Edeb";
                BtnB.Text = "Divanü Lügati’t Türk";
                BtnC.Text = "Kitab-ı Lugat-ı Vankulu";
                BtnD.Text = "Lehçe-i Osmanî";
                LblCevap.Text = "Divanü Lügati’t Türk";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Osmanlı Devleti'nde ilk nüfus sayımı hangi padişah zamanında yapılmıştır?";
                BtnA.Text = "2.Mahmut";
                BtnB.Text = "Kanuni Sultan Süleyman";
                BtnC.Text = "Fatih Sultan Mehmet";
                BtnD.Text = "Yavuz Sultan Selim";
                LblCevap.Text = "2.Mahmut";
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Au hangi elementin sembolüdür?";
                BtnA.Text = "Gümüş";
                BtnB.Text = "Bakır";
                BtnC.Text = "Elmas";
                BtnD.Text = "Altın";
                LblCevap.Text = "Altın";
            }
            if (soruno==10)
            {
                richTextBox1.Text = "Pusulada ( N ) harfi hangi yönü ifade eder ?";
                BtnA.Text = "Kuzey";
                BtnB.Text = "Güney";
                BtnC.Text = "Doğu";
                BtnD.Text = "Batı";
                LblCevap.Text = "Kuzey";
            }
            if (soruno==11)
            {
                richTextBox1.Text = "Avrupa Birliğinin başkenti neresidir?";
                BtnA.Text = "Londra";
                BtnB.Text = "Brüksel";
                BtnC.Text = "Paris";
                BtnD.Text = "Dortmund";
                LblCevap.Text = "Brüksel";
            }
            if (soruno==12)
            {
                richTextBox1.Text = "Maddenin ölçülemeyen özelliği hangisidir?";
                BtnA.Text = "Kütlesi";
                BtnB.Text = "Hacmi";
                BtnC.Text = "Ağırlığı";
                BtnD.Text = "Kokusu";
                LblCevap.Text = "Kokusu";
                BtnNext.Text = "Sonuçlar";
            }
            if (soruno == 13)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnNext.Enabled = false;
                MessageBox.Show("Doğru Sayınız: " + dogrusayisi + "\n" + " Yanlış Sayınız: " + yanlissayisi);
            }
        }



        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnNext.Enabled = true;

            label5.Text = BtnA.Text;
            if (LblCevap.Text == label5.Text)
            {
                dogrusayisi++;
                Lbldogru.Text = dogrusayisi.ToString();
                pictureBox1.Visible = true;
                prgrsbr += 8;
            }
            else
            {
                yanlissayisi++;
                lblyanlis.Text = yanlissayisi.ToString();
                pictureBox2.Visible = true;
                prgrsbr += 8;
            }
        }



        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnNext.Enabled = true;

            label5.Text = BtnB.Text;
            if (LblCevap.Text == label5.Text)
            {
                dogrusayisi++;
                Lbldogru.Text = dogrusayisi.ToString();
                pictureBox1.Visible = true;
                prgrsbr += 8;
            }
            else
            {
                yanlissayisi++;
                lblyanlis.Text = yanlissayisi.ToString();
                pictureBox2.Visible = true;
                prgrsbr += 8;

            }
        }
        private void BtnC_Click(object sender, EventArgs e)
        {

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnNext.Enabled = true;

            label5.Text = BtnC.Text;
            if (LblCevap.Text == label5.Text)
            {
                dogrusayisi++;
                Lbldogru.Text = dogrusayisi.ToString();
                pictureBox1.Visible = true;
                prgrsbr += 8;
            }
            else
            {
                yanlissayisi++;
                lblyanlis.Text = yanlissayisi.ToString();
                pictureBox2.Visible = true;
                prgrsbr += 8;
            }

        }
        private void BtnD_Click(object sender, EventArgs e)
        {

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnNext.Enabled = true;

            label5.Text = BtnD.Text;
            if (LblCevap.Text == label5.Text)
            {
                dogrusayisi++;
                Lbldogru.Text = dogrusayisi.ToString();
                pictureBox1.Visible = true;
                prgrsbr += 8;
            }
            else
            {
                yanlissayisi++;
                lblyanlis.Text = yanlissayisi.ToString();
                pictureBox2.Visible = true;
                prgrsbr += 8; 
            } 
           
        }   
    } 
}
