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
                Console.Write("1-Consultar Aposentadoria por Idade \n");
                Console.Write("2-Sobre \n");
                Console.Write("0-Sair \n");
                Console.Write("Digite a opção e Tecle ENTER:  ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        ConsultarAposentadoriaPorIdade();
                        Console.WriteLine("\n \n Tecle Enter para Volta ao Menu Principal");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Sobre();
                        Console.ReadKey();
                        break;
                    case "0":
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Seleção Invalida. Por favor opção 1, 2, ou 0.");
                        break;

                }

            } while (opcao != "0");

            
        }


        public static void ConsultarAposentadoriaPorIdade()
        {
            string dataNascimento, dataAdmisao;
            Empregado emp = new Empregado();
            do
            {
               
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Consultar Aposentadoria por Idade \n");
                Console.Write("Informe a data de nascimento, exemplo dd/mm/yyyy :  ");
                dataNascimento = Console.ReadLine();
                emp.DataNascimento = dataNascimento;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Informe o ano de adimisão na empresa, exemplo yyyy: ");
                dataAdmisao = Console.ReadLine();
                emp.AnoAdmisao = dataAdmisao;
                

            } while (!(emp.ValidarDataNascimento() && emp.ValidarAnoEmpresa()));

            Console.Write(emp.InfoEmpregado());

        }

        public static void Sobre()
        {
            Console.WriteLine("\n Analista de Sistemas: Manoel Neto \n " +
                "Projetos e Desenvolvimento de Sistemas. www.SoftwMicro.com.br");
        }
    }
}
