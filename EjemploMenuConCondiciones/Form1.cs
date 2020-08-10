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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pb_1_Click(object sender, EventArgs e)
        {
            Ejercicio1 ejercicio1 = new Ejercicio1();
            ejercicio1.Show();
            this.Hide();
        }

        private void btn_salirprograma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        
private void pb_2_Click(object sender, EventArgs e)
        {
            Ejercicio2 ejercicio2 = new Ejercicio2();
            ejercicio2.Show();
            this.Hide();

        }
    }
    }

