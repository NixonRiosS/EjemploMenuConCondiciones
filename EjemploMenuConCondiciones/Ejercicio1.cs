using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploMenuConCondiciones
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btn_evaluar_Click(object sender, EventArgs e)
        {
            double num1, num2;
            num1 = double.Parse(txt_num1.Text);
            num2 = double.Parse(txt_num2.Text);

            if (num1 > num2) {
                lbl_resultado.Text = "El primer numero es el mayor";
            }
            else if (num2 > num1) {
                    lbl_resultado.Text = "El segundo numero es el mayor";
                }
            else {
                lbl_resultado.Text = "Los numeros son iguales";
            }
            lbl_resultado.Visible = true;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
