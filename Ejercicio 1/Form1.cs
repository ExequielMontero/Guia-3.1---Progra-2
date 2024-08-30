using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        Evaluador mievaluador;
        Moto vehiculo;
        Resultados result = new Resultados();
        public Form1()
        {
            InitializeComponent();
        }

        private void rbLineal_CheckedChanged(object sender, EventArgs e)
        {
            tbDepreciacion.Enabled = false;
        }

        private void rbAnual_CheckedChanged(object sender, EventArgs e)
        {
            tbDepreciacion.Enabled = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string marca = tbMarca.Text;
            int modelomoto = Convert.ToInt32(nuModelo.Value);
            int añoacalcular = Convert.ToInt32(nuAño.Value);
            double valorfabricacion = Convert.ToDouble(tbFabricacion.Text);
            int vidautil = Convert.ToInt32(tbVida.Text);
            vehiculo = new Moto(marca, modelomoto, valorfabricacion);
            if (rbLineal.Checked)
            {
                mievaluador = new EvaluadorLineal(añoacalcular, vehiculo ,vidautil);
            }
            else if (rbAnual.Checked)
            {
                double tasadepreciacion = Convert.ToDouble(tbDepreciacion.Text);
                mievaluador = new EvaluadorAnual(añoacalcular, vehiculo, tasadepreciacion);
            }

            result.tbResultados.Text = mievaluador.VerDescripcion();
            result.ShowDialog();
            tbMarca.Clear();
            tbFabricacion.Clear();
            tbDepreciacion.Clear();
            tbVida.Clear();
            rbAnual.Checked = false;
            rbLineal.Checked = false;

        }
    }
}
