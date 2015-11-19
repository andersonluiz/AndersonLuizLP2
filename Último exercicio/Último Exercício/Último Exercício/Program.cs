using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Último_Exercício;


namespace Ultimo_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            
         

            
            MySqlCommand command = new MySqlCommand();
           
            MySqlConnection connec = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd= ");
            command.Connection = connec;
            connec.Open();

            bool fazer = true;
            while (fazer)
            {
                Console.WriteLine("Digite seu login: ");
                string login = Console.ReadLine();
                Console.WriteLine("Digite sua senha: ");
                string senha = Console.ReadLine();

                string str = String.Format("SELECT * FROM Usuario WHERE Login = '{0}' AND Senha = '{1}'", login,senha);
                command.CommandText = str;

                MySqlDataReader reader = command.ExecuteReader();

                var usu = new Usuario();
                

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        usu.Id = reader.GetInt32(0);
                        usu.Nome = reader.GetString(1);
                        usu.Email = reader.GetString(2);
                        usu.Login = reader.GetString(3);
                        usu.Senha = reader.GetString(4);
                        usu.Data = reader.GetString(5);                        
                         Console.WriteLine("Última data de Acesso: {0}", usu.Data);                        
                          AtualizarAcesso(usu.Id);
                         Console.WriteLine("Data atualizada.");
                        
                        
                    }
                    reader.Close();
                    connec.Close();
                }
                 	else
                		{
                   
                    		Console.WriteLine("O usuário ou senha informados estão incorretos");
                    
                		}
                
                Console.WriteLine("Digite 0 para fazer logout");
                int logout = int.Parse(Console.ReadLine());
                

                if (logout == 0)
                {
                    Console.WriteLine("Obrigada!");
                      fazer = false;
                }
                else
                {
                    fazer = true;
                }
            }
        }

        private static void AtualizarAcesso(int p)
        {
            throw new NotImplementedException();
        }
    }
}
