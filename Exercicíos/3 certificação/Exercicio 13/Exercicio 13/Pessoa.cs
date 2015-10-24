using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_13
{
    class Pessoa
    {
        public int id;
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Telefone { get; set; }

        public void Inserir(string q)
        {

            MySqlConnection Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=123742vx3");
            MySqlCommand Command = new MySqlCommand();

            Command.Connection = Connection;

            Command.CommandText = q;

            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
        }

        public void Consultar(string q)
        {

            MySqlConnection Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=123742vx3");
            MySqlCommand Command = new MySqlCommand();

            Command.Connection = Connection;

            Command.CommandText = q;

            Command.Connection.Open();

            MySqlDataReader reader = Command.ExecuteReader();

            List<Pessoa> people = new List<Pessoa>();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    Pessoa p = new Pessoa();
                    p.id = reader.GetInt32(0);
                    p.Nome = reader.GetString(1);
                    p.Sobrenome = reader.GetString(2);
                    p.Peso = reader.GetDouble(3);
                    p.Altura = reader.GetDouble(4);
                    p.Telefone = reader.GetString(5);
                    people.Add(p);
                }
            }

            reader.Close();

            Command.Connection.Close();

            Console.WriteLine("Opções: ");
            Console.WriteLine("10 - Sair.");
            Console.WriteLine("9 - Consulta por id.");
            Console.WriteLine("8 - Consulta pelo primeiro nome.");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine();

            while (v != 10)
            {
                if (v != 9 && v != 8)
                {
                    Console.WriteLine("Opção Inválida.");
                    Console.WriteLine();
                }

                else if (v == 9)
                {
                    Console.Write("Informe o id: ");
                    int check_id = int.Parse(Console.ReadLine());
                    int z = 0;

                    for (int y = 0; y < people.Count; y++)
                    {
                        if (check_id == people[y].id)
                        {
                            Console.WriteLine("Nome: " + people[y].Nome);
                            Console.WriteLine("Sobrenome: " + people[y].Sobrenome);
                            Console.WriteLine("Peso: " + people[y].Peso);
                            Console.WriteLine("Altura: " + people[y].Altura);
                            Console.WriteLine("Telefone: " + people[y].Telefone);
                            z++;
                        }
                    }

                    if (z == 0)
                    {
                        Console.WriteLine("O id solicitado não está registrado no banco de dados.");
                        Console.WriteLine();
                    }

                    Console.WriteLine("Opções: ");
                    Console.WriteLine("10 - Sair.");
                    Console.WriteLine("9 - Consulta por id.");
                    Console.WriteLine("8 - Consulta pelo primeiro nome.");
                    v = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }

                else if (v == 8)
                {
                    Console.Write("Informe o nome: ");
                    string nome = Console.ReadLine();
                    int t = 0;
                    List<Pessoa> Pessoas_mesmo_nome = new List<Pessoa>();

                    for (int l = 0; l < people.Count; l++)
                    {
                        if (people[l].Nome == nome)
                        {
                            t++;
                        }
                    }

                    for (int j = 0; j < people.Count; j++)
                    {
                        if (t == 1)
                        {
                            if (people[j].Nome == nome)
                            {
                             Console.WriteLine("Id: " + people[j].id);
                             Console.WriteLine("Nome: " + people[j].Nome);
                             Console.WriteLine("Sobrenome: " + people[j].Sobrenome);
                             Console.WriteLine("Altura: " + people[j].Altura);
                             Console.WriteLine("Telefone: " + people[j].Telefone);
                             Console.WriteLine();
                            }
                        }

                        else if (t > 1)
                        {
                            if (people[j].Nome == nome)
                            {
                             Pessoas_mesmo_nome.Add(people[j]);
                            }
                        }
                      
                        else
                        {
                            Console.WriteLine("A pessoa solicitada não está registrada.");
                            Console.WriteLine();
                            break;
                        }

                    }

                    if (t > 1)
                    {
                        for (int e = 0; e < Pessoas_mesmo_nome.Count; e++)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Sobrenome: " + Pessoas_mesmo_nome[e].Sobrenome);
                            Console.WriteLine("id: " + Pessoas_mesmo_nome[e].id);
                            Console.WriteLine();
                        }

                        Console.WriteLine("Informe o id da pessoa desejada: ");
                        int id_ = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        for (int b = 0; b < Pessoas_mesmo_nome.Count; b++)
                        {     
                            if (id_ == Pessoas_mesmo_nome[b].id)
                            {
                                Console.WriteLine("Nome: " + Pessoas_mesmo_nome[b].Nome);

                                Console.WriteLine("Sobrenome: " + Pessoas_mesmo_nome[b].Sobrenome);

                                Console.WriteLine("Peso: " + Pessoas_mesmo_nome[b].Peso);

                                Console.WriteLine("Altura: " + Pessoas_mesmo_nome[b].Altura);

                                Console.WriteLine("Telefone: " + Pessoas_mesmo_nome[b].Telefone);

                                Console.WriteLine();
                            }
                        }
                    }

                    }

                            Console.WriteLine("Opções : ");

                            Console.WriteLine("10 - Sair.");

                            Console.WriteLine("9 - Consulta por id.");

                            Console.WriteLine("8 - Consulta pelo primeiro nome.");

                            v = int.Parse(Console.ReadLine());

                            Console.WriteLine();
                        }
                    }
                }

    }

