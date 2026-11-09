using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomaticoModulado
{
    public class GestorDinero
    {
        private double saldo;

        public GestorDinero(double saldo)
        {
            this.saldo = saldo;
        }

        public bool retirarDinero(double monto)
        {
            if (monto > 0 && monto <= saldo)
            {
                saldo -= monto; // saldo = saldo - monto;
                return true;
            } else if (monto > 0)
            {
                throw new ArgumentException("Saldo insuficiente");
            }
            return false;
        }
        public bool depositarDinero(double monto)
        {
            if (monto > 0)
            {
                saldo += monto; // saldo = saldo + monto 
                return true;
            }
            return false;
        }

        public double obtenerSaldo()
        {
            return saldo;
        }
    }
}
