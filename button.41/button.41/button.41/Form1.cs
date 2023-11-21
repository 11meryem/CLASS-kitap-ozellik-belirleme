using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._41
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

        private void button1_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.ad = "Büşra'nın çıkmadığı mutfağı";
            kitap.yazar = " Köylü Büşra";
            kitap.yayınEvi = "Büşra'nın evi";
            kitap.sayfaSayisi = 1000;
            kitap.cikisYili = 2020;
            label1.Text = kitap.ad +"   "+kitap.yayınEvi+"   " +kitap.yazar+"   " +kitap.cikisYili+"   "+kitap.sayfaSayisi;

        }
    }
}
