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

        private void Form1_Load(object sender, EventArgs e)
        {
            button5.Text = "BAŞLA";
        }
        int dogrusayisi=0, yanlissayisi=0;
        int soru_numarasi = 0;
        string dogru_cevap;
        string kullanici_cevabi;
        bool sorubir, soruiki, soruüç, sorudört, sorubeş;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            kullanici_cevabi = button1.Text;
            if (kullanici_cevabi == dogru_cevap)
            {
                dogrusayisi++;
               

            }
            else
            {

                soru_numarasi = 0;
                MessageBox.Show("Yanlış Cevap!!!\nKaybettiniz!!! :( ");
                label1.BackColor = Color.Green;
                label2.BackColor=Color.Green;
                label3.BackColor = Color.Green;
                label4.BackColor = Color.Green;
                label5.BackColor = Color.Green;

            }
            
            label6.Text = dogrusayisi.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            kullanici_cevabi = button2.Text;
            if (kullanici_cevabi == dogru_cevap)
            {
                dogrusayisi++;
                
            }
            else
            {

                soru_numarasi = 0;
                MessageBox.Show("Yanlış Cevap!!!\nKaybettiniz!!! :( ");
                label1.BackColor = Color.Green;
                label2.BackColor = Color.Green;
                label3.BackColor = Color.Green;
                label4.BackColor = Color.Green;
                label5.BackColor = Color.Green;

            }

            label6.Text = dogrusayisi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            kullanici_cevabi = button3.Text;
            if (kullanici_cevabi == dogru_cevap)
            {
                dogrusayisi++;
                
            }
            else
            {
                soru_numarasi = 0;
                MessageBox.Show("Yanlış Cevap!!!\nKaybettiniz!!! :( ");
                label1.BackColor = Color.Green;
                label2.BackColor = Color.Green;
                label3.BackColor = Color.Green;
                label4.BackColor = Color.Green;
                label5.BackColor = Color.Green;
            }
            label6.Text = dogrusayisi.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            kullanici_cevabi = button4.Text;
            if (kullanici_cevabi == dogru_cevap)
                dogrusayisi++;
            else
            {

                soru_numarasi = 0;
                MessageBox.Show("Yanlış Cevap!!!\nKaybettiniz!!! :( ");
                label1.BackColor = Color.Green;
                label2.BackColor = Color.Green;
                label3.BackColor = Color.Green;
                label4.BackColor = Color.Green;
                label5.BackColor = Color.Green;

            }
            label6.Text = dogrusayisi.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            soru_numarasi++;
            button5.Text = "SIRADAKİ SORU";
            if (soru_numarasi == 1)
            {
                richTextBox1.Text = "Türkiye'nin başkenti neresidir?";
                button1.Text = "Ankara";
                button2.Text = "Konya";
                button3.Text = "İstanbul";
                button4.Text = "Sivas";
                dogru_cevap = "Ankara";

            }
            if(soru_numarasi == 2)
            {
                richTextBox1.Text = "İstanbul kaç yılında fethedilmiştir?";
                button1.Text = "1441";
                button2.Text = "1453";
                button3.Text = "1461";
                button4.Text = "1465";
                dogru_cevap = "1453";
                label1.BackColor = Color.Blue;
            }
            if (soru_numarasi == 3)
            {
                richTextBox1.Text = "Hangisinin yazılışı YANLIŞTIR?";
                button1.Text = "Hamburger";
                button2.Text = "Trileçe";
                button3.Text = "Antrikot";
                button4.Text = "Çipsi";
                dogru_cevap = "Çipsi";
                label2.BackColor = Color.Blue;

            }
            if (soru_numarasi == 4)
            {
                richTextBox1.Text = "Hangi oyuncu Fenerbahçe'de hiç OYNAMAMIŞTIR?";
                button1.Text = "Okan Buruk";
                button2.Text = "Burak Yılmaz";
                button3.Text = "Mehmet Topal";
                button4.Text = "Serdar Aziz";
                dogru_cevap = "Okan Buruk";
                label3.BackColor = Color.Blue;
            }
            if (soru_numarasi == 5)
            {
                richTextBox1.Text = "*******FİNAL SORU*****\nEşeknar üçgenin bir dış açısı kaç derecedir?";
                button1.Text = "30";
                button2.Text = "60";
                button3.Text = "120";
                button4.Text = "135";
                dogru_cevap="120";
                label4.BackColor = Color.Blue;
            }
            if (soru_numarasi == 6)
            {
                MessageBox.Show("********** TEBRİKLER *********\n**********1.000.000 TL KAZANDINIZ *********");
                button5.Enabled = false;
            }


        }
    }
}
