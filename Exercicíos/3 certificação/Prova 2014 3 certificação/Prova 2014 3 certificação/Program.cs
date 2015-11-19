using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_2014_3_certificação
{
    class Program
    {
        static void Main(string[] args)
        {
            /* O botão "cadastrar não oferece nenhuma resposta visivel . Ele apenas deve registrar o Deputado com os dados preenchidos 
             * para que ele possa ser posteriormente consultado pelas demais fuincionalidades do programa
             */
            /*
             * A)
            Console.WriteLine("Botão Cadastrar");
           Deputado p = new Deputado;
            p.Nome = textbox1.text;
            p.Idade = int.Parse(textbox3.text);
            p.Tempo = int.Parse(textbox4.text);
            p.Numero = textbox2.text;
            p.Legenda = p.Numero[0].Tostring() + p.numero[1].Tostring();
           string Q = (" INSERT INTO PESSOA (nome , idade , tempo , numero, legenda ) VALUES({0}, {1}, {2}, {3}, {4})",p.Nome, p.Idade, p.Tempo, p.Numero, p.Legenda);
            */
            /*
            Console.WriteLine("Limpar");

            string Q = ("DELETE * FROM PESSOA");
            */
            /*List<pessoa>CadastroNome = new List<pessoa>();
            int z = 500;
            int x;
            for (int i = 0; i < CadastroNome.Count; i++)
            {
                if(pessoa.Idade[i] < z)
                {
                    z = pessoa.Idade[i];
                        x = i;
                }
                else()
                {

                }
                
            }
            MessageBox.Show("O candidato mais novo é + {0} + com {1 } + anos", pessoa.Nome[x],z );
             * */
            int Tempo = int.Parse(Console.ReadLine());
            double tempototal = Tempo / 60;
            MessageBox.Show ("{0}"tempototal)
       }
    }
}
