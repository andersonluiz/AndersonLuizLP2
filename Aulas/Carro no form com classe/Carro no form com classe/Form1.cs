using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carro_no_form_com_classe
{
    public partial class FormCarro : Form
    {
        public FormCarro()
        {
            InitializeComponent();
            
            
        }
        List<object> cadastro = new List<object>();
       
        private void button1_Click(object sender, EventArgs e)
        {
           
                Carro c1 = new Carro();
                c1.placa = txtPlaca.Text;
                c1.modelo = txtModelo.Text;
                c1.consumoKmL = double.Parse(txtConsumo.Text);
                c1.qtdCombustivelL = double.Parse(txtQtdCombustivel.Text);
                cadastro.Add(c1);


             }            

    }
}
