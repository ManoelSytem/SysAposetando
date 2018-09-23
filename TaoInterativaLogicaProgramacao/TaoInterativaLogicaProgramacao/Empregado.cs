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

        public string VerificaAposentadoria()
        {
            int AnosDeIdade = DateTime.Now.Year - Convert.ToDateTime(this.DataNascimento).Year;

            int AnosDeTrabalho = Convert.ToInt32(this.AnoAdmisao) - DateTime.Now.Year;

            return "Anos de Idade: \n"+AnosDeIdade +"Anos de Anos de Trabalho: \n"+AnosDeTrabalho;
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Atenção data de Admisão " + this.AnoAdmisao + " invalida ou não pode ser maior que o ano atual!\n\n");
                return false;
                }

            return true;
        }
    }
}
