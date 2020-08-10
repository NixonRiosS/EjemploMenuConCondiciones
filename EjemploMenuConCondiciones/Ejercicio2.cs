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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_evaluar_Click(object sender, EventArgs e)
        {
            double num;
            num = double.Parse(txt_num3.Text);

            if (num > 0){
                lbl_respuesta.Text = "El numero es positivo";
            }
            else if (num < 0){
                lbl_respuesta.Text = "El numero es negativo";

            }
            else
            {
                lbl_respuesta.Text = "El numero es neutro";
            }
            lbl_respuesta.Visible = true;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }
    }
    }

