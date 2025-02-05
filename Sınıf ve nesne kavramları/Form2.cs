using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınıf_ve_nesne_kavramları
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba car2 = new Araba();
            car2.renk = "Pembe";
            car2.hiz = 150;
            car2.motor = 1240.65;
            car2.durum = '2';
            car2.fiyat = 40000;

            label1.Text = car2.renk;
            label2.Text = car2.hiz.ToString();
            label3.Text = car2.motor.ToString();
            label4.Text = car2.durum.ToString();
            label5.Text = car2.fiyat.ToString();
        }
    }
}
