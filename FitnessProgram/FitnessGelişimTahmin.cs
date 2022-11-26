using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessProgram
{
    public partial class FitnessGelişimTahmin : Form
    {
        public FitnessGelişimTahmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim;
            int yaş, kilo, protein , ay;
            ay = 0;
            isim = Convert.ToString(textBox1.Text);
            yaş = Convert.ToInt32(textBox2.Text);
            kilo = Convert.ToInt32(textBox3.Text);
            protein = Convert.ToInt32(textBox4.Text);

            if (protein > kilo)
            {
                ay += 6;
            }

            else
            {
                ay += 18;
            }

            if (isim=="")
            {
                MessageBox.Show("İsim bölümü boş geçilemez");
                Application.Exit();
            }

            if (yaş <18)
            {
                MessageBox.Show("18 yaş altı hesaplama yapılamıyor.");
                Application.Exit();
            }

            listBox1.Items.Add("Ortalama  " + ay + "  Ay süre veriyoruz");


        }
    }
}
