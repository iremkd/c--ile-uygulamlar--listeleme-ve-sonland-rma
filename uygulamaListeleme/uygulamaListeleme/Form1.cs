using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace uygulamaListeleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IslemlerListele();
        }

        private void IslemlerListele()
        {
            Process[] bellek = Process.GetProcesses(); //çalışan uygulamları bellek dizisine attık.
            foreach (Process islem in bellek)
            {
                islemler.Items.Add(islem.ProcessName); //ProcessName=işlemin adı
            }
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            islemler.Items.Clear();
            IslemlerListele();
        }

        private void sonlandir_Click(object sender, EventArgs e)
        {
            if (islemler.SelectedIndex>=0)
            {
                string islem_adi = islemler.SelectedItem.ToString();//işlemin adını çektik
                Process[] p = Process.GetProcessesByName(islem_adi);
                if (p.Length>0)
                {
                    foreach (Process iss in p)
                    {
                        iss.Kill();
                    }
                }

            }
            else
            {
                MessageBox.Show("Uygulama seçin", "HATA");
            }
        }
    }
}
