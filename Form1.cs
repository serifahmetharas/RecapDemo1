using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Uygulama ilk açıldığında çalışacak kod burasıdır.

            // Button bir classtır.
            Button[,] buttons = new Button[8, 8]; // Button class ını çağır. 8x8 buton koyacağımız için çok boyutlu dizi şeklinde tanımla.
            int top = 0;
            int left = 0;
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50; // Butonun boyutlarını ayarla.
                    buttons[i, j].Left = left; // Ekranın sola uzaklığı. 
                    left = left + 50; // Sola uzaklığı 50 arttırarak yeni butonun sağda olmasını sağla.
                    buttons[i, j].Top = top;
                    this.Controls.Add(buttons[i, j]); // Ekrana butonu koy.

                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                }

                left = 0;
                top = top + 50; // Üste olan uzaklığını 50 arttırarak diğer sıranın aşağıya gelmesini sağla.
            }


        }
    }
}
