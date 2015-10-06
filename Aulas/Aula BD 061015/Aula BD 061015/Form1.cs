using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_BD_061015
{
    public partial class Form1 : Form
    {
        List<Pessoa> lista;
 
        public Form1()
        {
            InitializeComponent();
            lista = new List<Pessoa>();
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int j = 0;
            for(int i = 0; i < lista.Count; i ++)
            {
                Pessoa a = new Pessoa();
                a.nome = txtNome.Text;
                a.sobrenome = txtSobrenome.Text;
                a.presente1 = txtOpção1.Text;
                a.presente2 = txtOpção2.Text;
                a.presente3 = txtOpção3.Text;
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static void ConsultaBD()
        {
            string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(strConn);
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = "";
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("{0}", lista.Count));
        }
    }
}

