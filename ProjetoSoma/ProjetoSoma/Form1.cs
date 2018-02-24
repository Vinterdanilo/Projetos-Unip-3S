using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSoma
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        //criação de variaveis
        double n1 = 0.0, n2 = 0.0, resultado = 0.0;

        private void btnSomar_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txbPrimeiroNumero.Text);
            n2 = Convert.ToDouble(txbSegundoNumero.Text);
            resultado = n1 + n2;
            /*componete*/
            lblResultado./*propriedade*/Text = resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txbPrimeiroNumero.Text);
            n2 = Convert.ToDouble(txbSegundoNumero.Text);
            resultado = n1 - n2;
            lblResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txbPrimeiroNumero.Text);
            n2 = Convert.ToDouble(txbSegundoNumero.Text);
            resultado = n1 * n2;
            lblResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txbPrimeiroNumero.Text);
            n2 = Convert.ToDouble(txbSegundoNumero.Text);
            resultado = n1 / n2;
            lblResultado.Text = resultado.ToString();
            if (n2 == 0)
            {
                MessageBox.Show("Digite o segundo numero diferente de zero para realizar a divisão!");
            }

        }
    }
}
