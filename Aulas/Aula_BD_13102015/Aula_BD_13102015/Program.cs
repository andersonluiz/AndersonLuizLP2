using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_BD_13102015
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção de cadastro");
            Console.WriteLine(" 1 - Inserir novo");
            Console.WriteLine(" 2 - Consulta");
            int x = int.Parse(Console.ReadLine());
            if(x == 2)
            {
                Console.WriteLine("Consultar por  nome:");
                {
                    Console.WriteLine("Digite seu nome:");
                    string sti = Console.ReadLine();
                    string sqr = ("SELECT Nome FROM Pessoa Values ('{0}')",sti);
                }
                Console.WriteLine("Consultar por  ID:");
                {

                }
            }
            else if (x == 1 )
            {
                Console.WriteLine("Inserir novo usuário:");
                Console.WriteLine("Insira seu Nome:");
                Pessoa p = new Pessoa();
                p.Nome = Console.ReadLine();
                Console.WriteLine("Insira seu Peso:");
                p.Peso = Double.Parse(Console.ReadLine());
                Console.WriteLine("Insira seu Sobrenome:");
                p.Sobrenome = Console.ReadLine();
                Console.WriteLine("Insira sua Altura:");
                p.Altura = Double.Parse(Console.ReadLine());
                Console.WriteLine("Insira seu Telefone:");
                p.Telefone = Console.ReadLine();
                string str = string.Format("INSERT INTO Pessoa (Nome, Peso , Sobrenome, Altura, Telefone) Values ('{0}', {1}, '{2}' , {3} , '{4}')"
                    , p.Nome, p.Peso, p.Sobrenome, p.Altura, p.Telefone);
                //OS VALORES FICAM ENTRE PARENTESES
                //OS VALORES QUE SÃO STRING FICAM ENTRE ASPAS SIMPLES

                ConsultaBD(str);
            }
            else
            {
                Console.WriteLine("Digite a caceta do número certo , já ta dificil e você não ta colaborando ... ");

            }
        }
        public static void ConsultaBD(string str)
        {
            string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(strConn);
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = str;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        
    }
    }

