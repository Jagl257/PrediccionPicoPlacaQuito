using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoPlacaQuito
{
    public class Auto
    {
        //Atributos
        private int idAuto;
        private string placa;

        //Getters y Setters
        public int IdAuto { get => idAuto; set => idAuto = value; }
        public string Placa { get => placa; set => placa = value; }

        //Constructor
        public Auto(int idAuto, string placa)
        {
            this.idAuto = idAuto;
            this.placa = placa;
        }

        //Metodo

        public bool PuedeSalir(string fechaString, string placa, string hora )
        {
            DateTime fecha;
            try
            {
                fecha = DateTime.Parse(fechaString + " " + hora);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en el ingreso de la fecha y hora: " + e);
                Console.WriteLine("Se utilizara la fecha y hora actual");
            }
            finally
            {
                fecha = DateTime.Now;
            }


            string diaRestriccion;

            switch (placa.Last())
            {
                case '1':
                    diaRestriccion = "Monday";
                    break;
                case '2':
                    diaRestriccion = "Monday";
                    break;
                case '3':
                    diaRestriccion = "Tuesday";
                    break;
                case '4':
                    diaRestriccion = "Tuesday";
                    break;
                case '5':
                    diaRestriccion = "Wednesday";
                    break;
                case '6':
                    diaRestriccion = "Wednesday";
                    break;
                case '7':
                    diaRestriccion = "Thursday";
                    break;
                case '8':
                    diaRestriccion = "Thursday";
                    break;
                case '9':
                    diaRestriccion = "Friday";
                    break;
                case '0':
                    diaRestriccion = "Friday";
                    break;
                default:
                    diaRestriccion = "Fallo";
                    break;
            }

            Console.WriteLine(Convert.ToString(fecha.DayOfWeek));

            if (Convert.ToString(fecha.DayOfWeek) == "Saturday" || Convert.ToString(fecha.DayOfWeek) == "Sunday")
            {
                return true;
            }
            else if (Convert.ToString(fecha.DayOfWeek) == diaRestriccion)
            {
                if ((fecha.Hour > 7) && (fecha.Hour <= 9 && fecha.Minute < 30))
                {
                    return false;
                }
                else if ((fecha.Hour > 16) && (fecha.Hour <= 19 && fecha.Minute < 30))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }
    }
}
