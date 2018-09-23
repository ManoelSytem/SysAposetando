using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaoInterativaLogicaProgramacao
{
    public class Program
    {


        public static void Main(string[] args)
        {
            //Carregamento da Aplicação
            var spinner = new Spinner(10, 10);
            spinner.Start();
            Thread.Sleep(3000);
            spinner.Stop();


            //Entradas Inicias 
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            string opcao;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("    Bem vindo ao SysAposentando");
                Console.WriteLine("    Entre com as Informações Abaixo\n\n\n\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Opções:");
                Console.Write("1-Consultar Aposentadoria por Idade \n\n");
                Console.Write("Digite a opção e Tecle ENTER:  ");
                opcao = Console.ReadLine();
                Console.Clear();
            } while (opcao != "1");

            ConsultarAposentadoriaPorIdade();

            Console.WriteLine("Saiu do While: ");
            Console.ReadKey();
        }


        public static void ConsultarAposentadoriaPorIdade()
        {
            string dataNascimento, dataAdmisao;
            Empregado emp = new Empregado();
            do
            {
               
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Consultar Aposentadoria por Idade \n");
                if((emp.DataNascimento!= null && emp.ValidarDataNascimento()))
                Console.WriteLine("Data de Nascimento  :  "+emp.DataNascimento);
                else
                {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Informe a data de nascimento, exemplo dd/mm/yyyy :  ");
                dataNascimento = Console.ReadLine();
                emp.DataNascimento = dataNascimento;
                }
                if ((emp.AnoAdmisao!=null) && emp.ValidarAnoEmpresa())
                    Console.Write("Data de Admisão: " + emp.AnoAdmisao);
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Informe o ano de adimisão na empresa, exemplo yyyy: ");
                    dataAdmisao = Console.ReadLine();
                    emp.AnoAdmisao = dataAdmisao;
                }


            } while (!(emp.ValidarDataNascimento() && emp.ValidarAnoEmpresa()));

            
            Console.Write("Saiu do While");
            Console.ReadKey();

        }

    }
}
