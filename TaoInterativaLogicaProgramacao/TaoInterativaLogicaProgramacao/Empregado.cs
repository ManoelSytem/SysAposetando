using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoInterativaLogicaProgramacao
{
    public class Empregado
    {
        public String DataNascimento { get; set; }

        public String AnoAdmisao { get; set; }


        public Empregado()
        {
        }

        public string InfoEmpregado()
        {
            int AnosDeIdade = DateTime.Now.Year - Convert.ToDateTime(this.DataNascimento).Year;

            
            int AnosDeTrabalho = DateTime.Now.Year - Convert.ToInt32(this.AnoAdmisao);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" \n Veja aqui o tempo de trabalho, dias, e meses do Empregado ");

            Console.ForegroundColor = ConsoleColor.White;
            return " \n Tempo de Trabalho: "+AnosDeTrabalho+" anos. \n Número de Dias: \n "+AnosDeIdade;
        }


        public bool ValidarDataNascimento()
        {
            if (!Servico.ValidarDataNascimento(this.DataNascimento))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("    Atenção data de Nascimento " + this.DataNascimento + " Invalida!\n\n");
                return false;
            }

            return true;
        }

        public bool ValidarAnoEmpresa()
        {
                if (!(Servico.ValidarAnoEmpresa(this.AnoAdmisao) && Servico.ValidarEntreAno(this.AnoAdmisao)))
                {
                     Console.Clear();
                     Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Atenção data de Admisão " + this.AnoAdmisao + " invalida ou não pode ser maior que o ano atual!\n\n");
                return false;
                }

            return true;
        }
    }
}
