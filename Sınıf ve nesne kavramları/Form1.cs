namespace Sınıf_ve_nesne_kavramları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba car= new Araba();
            car.renk = "Mavi";
            car.hiz = 200;
            car.motor = 1245.65;
            car.durum = '0';
            car.fiyat = 50000;

            label1.Text= car.renk;
            label2.Text = car.hiz.ToString();
            label3.Text = car.motor.ToString();
            label4.Text = car.durum.ToString();
            label5.Text = car.fiyat.ToString();

        }
    }
}
