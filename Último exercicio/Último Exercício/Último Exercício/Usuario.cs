﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Último_Exercício
{
    class Usuario
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Data { get; set; }

        public void AtualizarAcesso(string id)
        {

            MySqlConnection connec = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd= ");
            MySqlCommand command = new MySqlCommand();
            command.Connection = connec;
            connec.Open();
            var commandString = string.Format("UPDATE usuario SET Data='{0}'  WHERE Id='{1}' ", DateTime.Now.ToString(), id);
            command.CommandText = commandString;
            command.ExecuteNonQuery();
            connec.Close();


        }
    }
}
