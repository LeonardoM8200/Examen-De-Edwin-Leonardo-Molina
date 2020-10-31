using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_EdwinLeonardoMolinaFlores.Clases
{
    class Pagos_y_Cobros
    {
        public double pagosdoble(double horas, double pagos1)
        {
            double pago;
            pago = (horas * pagos1);
            return pago;
        }
        public double cooperativa(double salariobase, double valor)
        {
            double cooperativa1;
            cooperativa1 = (salariobase * valor) / 100;
            return cooperativa1;
        }
    public double RAP (double salariobase,double valor)
        {
            double Rap1;
            Rap1= (salariobase * valor) / 100;
            return Rap1;
        }
        
    }
}
