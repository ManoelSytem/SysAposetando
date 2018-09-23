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

        public void ValidaAposentadoria(long anosTrabalho, int Idade)
        {
            if(Idade >= 65)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nParábêns você já pode se realizar sua aposentadoria.");
            }
            if((Idade == 60 && anosTrabalho == 25))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nParábêns você já pode se realizar sua aposentadoria.");
            }
            if(anosTrabalho == 30)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Parábêns você já pode realizar sua aposentadoria.");
            }
            if((Idade < 65 && anosTrabalho < 30))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n No momento você não esta apto a realizar sua aposentadoria, aguarde mais um tempo.");
            }
            
        }
        public string InfoEmpregado()
        {
            DateTime DataNascimento = new DateTime(Convert.ToDateTime(this.DataNascimento).Year, Convert.ToDateTime(this.DataNascimento).Month, Convert.ToDateTime(this.DataNascimento).Day);
            int AnosTrabalho = DateTime.Now.Year - Convert.ToInt32(this.AnoAdmisao);
            int AnosIdade = DateTime.Now.Year - Convert.ToDateTime(this.DataNascimento).Year;
            long IdadeEmDias = (int)DataNascimento.Subtract(DateTime.Today).TotalDays;// (DateTime.Parse(DataAtual).Subtract(DateTime.Parse(DataNascimento))).Days;
            DateTime DataNiveAnoAtual = new DateTime(DateTime.Now.Year, Convert.ToDateTime(this.DataNascimento).Month, Convert.ToDateTime(this.DataNascimento).Day);
            long difNiveAtualEmDiasDataAtual = (int)DataNiveAnoAtual.Subtract(DateTime.Today).TotalDays;
            long Meses = (AnosIdade * 12)+(Math.Abs(difNiveAtualEmDiasDataAtual)/31);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" \n Veja aqui abaixo o tempo de trabalho, dias, e meses do Empregado: ");

            ValidaAposentadoria(AnosTrabalho, AnosIdade);
            Console.ForegroundColor = ConsoleColor.White;
            return " \n Tempo de Trabalho: "+AnosTrabalho + " anos. \n Número de anos: "+AnosIdade
                +"\n Número de dias: "+Math.Abs(IdadeEmDias)+"\n Número em meses : "+ Meses+"\n";
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
