using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuenta_de_Ahorro_y_corriente.Logica
{
    public class csAhorro
    {
        private int saldoAhorros;

        // constructor
        public csAhorro(int ahorro)
        {
            saldoAhorros = ahorro;
        }
        public csAhorro()
        {
        }
        public int sal(int saldo)
        {
            this.saldoAhorros = saldo;
            return this.saldoAhorros;

        }

        public int difeA(int saldo)
        {
            this.saldoAhorros = saldo;
            return this.saldoAhorros;
        }
        public int realizarRetiroA(int retiro)
        {
            if (this.saldoAhorros > retiro)
            {
                this.saldoAhorros = this.saldoAhorros - retiro;
            }
            else
            {
                MessageBox.Show("Su cuenta es baja");
            }

            return this.saldoAhorros;
        }

        public int realizarDepositoA(int deposito)
        {
            this.saldoAhorros = this.saldoAhorros + deposito;
            return this.saldoAhorros;
        }
    }
}

