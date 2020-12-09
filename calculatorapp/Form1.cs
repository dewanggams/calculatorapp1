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
    public partial class Form1 : Form
    {
        private IList<Hitung> LisOfHitung = new List<Hitung>();
        public Form1()
        {
            InitializeComponent();
            InisialisasiListView();
        }
        private void InisialisasiListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("No.", 30, HorizontalAlignment.Center);
            listView1.Columns.Add("Nilai A", 60, HorizontalAlignment.Center);
            listView1.Columns.Add("Operasi", 60, HorizontalAlignment.Center);
            listView1.Columns.Add("Nilai B", 60, HorizontalAlignment.Center);
            listView1.Columns.Add("Hasil", 60, HorizontalAlignment.Center);
        }
        private void Form2_OnCreate(Hitung htg)
        {
            LisOfHitung.Add(htg);
            int noUrut = listView1.Items.Count + 1;
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(htg.a);
            item.SubItems.Add(htg.operasi);
            item.SubItems.Add(htg.b.ToString());
            item.SubItems.Add(htg.Hasil.ToString());
            listView1.Items.Add(item);
        }
        

        private void Hitung_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.OnCreate += Form2_OnCreate;
            frm2.ShowDialog();
        }

        private void Hapus_Click_1(object sender, EventArgs e)
        {
            listView1.Clear();
            InisialisasiListView();
        }

        private void Keluar_Click_1(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Close();
            this.Close();
        }
    }
}
