using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_2
{
    partial class Form2 : Form
    {
        public delegate void CreateUpdateEventHandler(Hitung htg);
        public event CreateUpdateEventHandler OnCreate;
        private Hitung htg;
        public Form2()
        {
            InitializeComponent();
        }

       
        public void teshitung(Hitung obj)
        {
            htg = obj;
            htg.a = NilaiA.Text;
            htg.b = NilaiB.Text;
            float A = float.Parse(htg.a);
            float B = float.Parse(htg.b);
            if (comboBox1.SelectedIndex == 0)
            {
                htg.operasi = "+";
                htg.Hasil = (A + B).ToString();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                htg.operasi = "-";
                htg.Hasil = (A - B).ToString();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                htg.operasi = "x";
                htg.Hasil = (A * B).ToString();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                htg.operasi = "/";
                htg.Hasil = (A / B).ToString();
            }
            OnCreate(htg);
            this.Close();
        }

        

        private void buttonHitung_Click_1(object sender, EventArgs e)
        {
            Hitung obj = new Hitung();
            teshitung(obj);
        }

        private void buttonKeluar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
