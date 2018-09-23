using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoInterativaLogicaProgramacao
{
    public class Servico
    {
        public static bool ValidarDataNascimento(string date)
        {

            return IsDate(date, "dd/MM/yyyy");
        }

        public static bool IsDate(string date, string format)
        {
            DateTime parsedDate;

            bool isValidDate;

            isValidDate = DateTime.TryParseExact(date, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate);

            return isValidDate;
        }

        public static bool ValidarAnoEmpresa(string date)
        {
            return IsDate(date, "yyyy");
        }

        public static bool ValidarEntreAno(string date)
        {
            Boolean valor;
            try
            {
                if (Convert.ToInt32(date) <= Convert.ToInt32(DateTime.Now.Year))
                    valor = true;
                else
                    valor = false;
            }
            catch (Exception e)
            {
                valor = false;
            }
           
            return valor;
        }


    }

}
