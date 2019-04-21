using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSale
{
    partial class Poltrona
    {
        private UInt16 numeroTotal;
        private UInt16 numeroVendidas;

        public void setNumeroTotal(UInt16 numero)
        {
            this.numeroTotal = numero;
        }

        public UInt16 getNumeroTotal()
        {
            return numeroTotal;
        }

        public void setNumeroVendidas(UInt16 numero)
        {
            this.numeroVendidas = numero;
        }

        public UInt16 setNumeroVendidas()
        {
            return numeroVendidas;
        }

        public UInt16 getNumeroDisponiveis()
        {
            UInt16 valor = Convert.ToUInt16(this.numeroTotal - this.numeroVendidas);
            return valor;
        }
    }
}
