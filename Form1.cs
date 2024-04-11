using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoThink
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.White;
            string nombre = txtNombre.Text.ToUpper().Trim();
            if (nombre.Length == 0)
            {
                txtNombre.BackColor = Color.Red;
                return;
            }

            txtSueldo.BackColor = Color.White;
            string sueldo = txtSueldo.Text;
            int sueldo_int = 0;
            try
            {
                sueldo_int = Convert.ToInt32(sueldo);
            }catch (Exception ex)
            {
                txtSueldo.BackColor = Color.Red;
                MessageBox.Show("Debe ser un valor numerico");
                return;
            }

            string monto = txtMonto.Text;
            int monto_int = Convert.ToInt32(monto);


            int cuota_int = Convert.ToInt32(txtCuotas.Text);
            
            Credito c1 = new Credito();

            c1.Sueldo = sueldo_int;
            c1.MontoCredito = monto_int;
            c1.CantidadCuotas = cuota_int;

            lblResultadoMes.Text = "Monto Final del Credito : "+c1.calcularCredito().ToString();
            lblResultado.Text = "Monto Mensual del Credito : "+(monto_int + (c1.calcularCredito() * cuota_int)).ToString();

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
