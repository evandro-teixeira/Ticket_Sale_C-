using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TicketSale
{
    class Ingresso
    {
        private UInt16 numeroPoltrona;
        private TipoIngresso tipoIngresso;
        private TipoCliente tipoCliente;

        public void setNumeroDaPoltrona(UInt16 numero)
        {
            this.numeroPoltrona = numero;
        }




        public UInt16 getNumeroDaPoltrona()
        {
            return numeroPoltrona;
        }

        public void setTipoIngresso(TipoIngresso ingresso)
        {
            this.tipoIngresso = ingresso;
        }

        public TipoIngresso getTipoIngresso()
        {
            return tipoIngresso;
        }

        public void setTipoCliente(TipoCliente cliente)
        {
            this.tipoCliente = cliente;
        }

        public TipoCliente getTipoCliente()
        {
            return tipoCliente;
        }
    }
}
