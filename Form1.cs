using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] kelimeler = richTextBox1.Text.Split(' ');
            string gecici = "";
            for(int i=0; i<kelimeler.Length; i++)
            {
                for(int j=0; j<kelimeler.Length; j++)
                {
                    if(kelimeler[i].Length>kelimeler[j].Length)
                    {
                        gecici = kelimeler[i];
                        kelimeler[i] = kelimeler[j];
                        kelimeler[j] = gecici;
                    }
                }
            }
            int satir = 0;
            int sutun = 0;
            for (int i = 0; i < kelimeler.Length; i++)
            {
                dataGridView1.Rows[satir].Cells[sutun].Value = kelimeler[i];
                if(sutun==2)
                {
                    satir++;
                    sutun = 0;
                    dataGridView1.Rows.Add();
                }
                else
                {
                    sutun++;
                }
            }
            double satiradet = kelimeler.Length / 3;
            dataGridView1.Rows.Add(Math.Floor(satiradet));
            int sayac = 0;
            for (int i = 0; i < satiradet; i++)
            {
                for (int a = 0; a < 3; a++)
                {
                    dataGridView1.Rows[i].Cells[a].Value = kelimeler[sayac];
                    sayac++;
                }
            }
        }
    }
}
