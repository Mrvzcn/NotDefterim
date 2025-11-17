using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotDefterim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menCikis_Click(object sender, EventArgs e)
         
        {
            Application.Exit();

        }

        private void menYeni_Click(object sender, EventArgs e)
        {
            txtIcerik.Text = string.Empty;
        }

        
            private void menKaydet_Click(object sender, EventArgs e)
        {
            // SaveFileDialog'un başlangıç ayarları
            saveFileDialog1.Filter = "Metin Dosyası (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            saveFileDialog1.Title = "Metin Belgesini Kaydet";

            // Kullanıcı Kaydet butonuna bastıysa
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Dosyaya içeriği yazar
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, txtIcerik.Text);
                    MessageBox.Show("Dosya başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kaydetme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void menAc_Click(object sender, EventArgs e)
        {
            // OpenFileDialog'un başlangıç ayarları
            openFileDialog1.Filter = "Metin Dosyası (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            openFileDialog1.Title = "Metin Belgesi Aç";

            // Kullanıcı Aç butonuna bastıysa
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Dosyanın içeriğini okur ve metin kutusuna atar
                    txtIcerik.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Açma hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    }

