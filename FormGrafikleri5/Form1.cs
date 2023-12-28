using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGrafikleri5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Örnek: Formun üzerini baklava dilimi deseni ile kaplayacak
            //kodu yazınız.( Temel çizim fonksiyonları kullanılacak drawline,drawrectangle,
            //drawellipse vs.)
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Blue, 2);
            for (int i = 1; i <= 95; i++)
            {
                g.DrawLine(p,i*10,0,0,i*10);
            }
            for (int i = 0; i <120; i++)
            {
                g.DrawLine(p, i * 10-500,0, i*10,500);
            }
        }
    }
}
