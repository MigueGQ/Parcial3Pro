using parcial3_WinForms.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial3_WinForms
{
    public partial class Form1 : Form
    {
        CN_Avion1 cn = new CN_Avion1();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Create(txtAvion.Text, txtSalida.Text, txtLlegada.Text, Convert.ToInt32(txtNum.Text));
                MessageBox.Show("Se ha Insertado el Registro ");
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar");
            };
        }
    }
}
