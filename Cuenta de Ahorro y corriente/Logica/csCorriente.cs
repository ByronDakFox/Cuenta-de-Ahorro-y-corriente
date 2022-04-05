using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuenta_de_Ahorro_y_corriente.Logica
{
    public class csCorriente
    {
        private int saldoCorriente;

        // constructor
        public csCorriente(int corriente)
        {
            saldoCorriente = corriente;
        }
        public csCorriente()
        {
        }

        public int difeCo(int saldo)
        {      
                this.saldoCorriente = saldo;

            return this.saldoCorriente;
        }
        public int realizarRetiroC(int retiro)
        {
            if (saldoCorriente > retiro)
            {
                saldoCorriente = saldoCorriente - retiro;
            }
            else
            {
                MessageBox.Show("Su cuenta es baja");
            }

            return saldoCorriente;
        }

        public int realizarDepositoC(int deposito)
        {
            this.saldoCorriente = this.saldoCorriente + deposito;
            return this.saldoCorriente;
        }
    }
}
