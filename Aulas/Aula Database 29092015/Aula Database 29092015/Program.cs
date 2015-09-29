using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Aula_Database_29092015
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int n = 1;
            while (n != 5)
            {
                Console.WriteLine("Bem-vindos a central de atendimento , escreva uma das opções abaixos:");
                Console.WriteLine("1 - Consultar");
                Console.WriteLine("2 - Inserir novo");
                Console.WriteLine("3 - Remover");
                Console.WriteLine("4 - Atualizar");
                Console.WriteLine("5 - Sair");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {

                    case 1:
                        Consultar();
                        break;
                    case 2:

                        Inserir();
                        break;
                    case 3:

                        Remover();
                        break;
                    case 4:

                        Atualizar();
                        break;
                    case 5:
                        Console.WriteLine("Obrigado por nos consultar.");
                        break;
                    default:
                        Console.WriteLine("Digite apenas um dos números pedidos");
                        break;

                }
            }
        }
        public static void Consultar()
        {

            Console.WriteLine("Método de consulta ");

            
        }
        public static void Inserir()
        {
             
            
            string query = String.Format("INSERT INTO CARRO (Modelo, Marca) VALUES ('{0}', '{1}')", asdasd, dasdasd);
            //String.Format("Olá, {0}", "Francisco");

            Console.WriteLine("Método de cadastro ");
        }
        public static void Remover()
        {
            Console.WriteLine("Método de remoção ");
        }
        public static void Atualizar()
        {
            Console.WriteLine("Método de atualização ");
        }
        public void ConsultaBD()
        {
            
            string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(strConn);
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = "" ;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            
        }
    }
}
