using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSale
{
    class InfoEspetaculo
    {
        const float ValorMaximoIngresso = 200;
        const UInt16 NumeroMaximoIngresso = 200;
        private String NomeTeatro;
        private String NomeEspetaculo;
        private DateTime DataEspetaculo = new DateTime().Date;
        private float ValorIngresso;
        private UInt16 NumeroIngressoDiponivel;

        public Boolean setNomeTreatro(String texto)
        {
            if(texto.Length > 0)
            {
                this.NomeTeatro = texto;
                return true;
            }
            else
            {
                return false;
            }
        }

        public String getNomeTeatro()
        {
            return NomeTeatro;
        }

        public Boolean setNomeEspetaculo(String texto)
        {
            if(texto.Length > 0)
            {
                this.NomeEspetaculo = texto;
                return true;
            }
            else
            {
                return false;
            }
        }

        public String getNomeEspetaculo()
        {
            return NomeEspetaculo;
        }

        public Boolean setDataEspetaculo(DateTime data)
        {
            try
            {
                if (data.Date >= DateTime.Now)
                {
                    this.DataEspetaculo = data.Date;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public DateTime getDataEspetaculo()
        {
            return DataEspetaculo;
        }

        public Boolean setValorIngresso(float valor)
        {
            try
            {
                if((valor > 0) && (valor < ValorMaximoIngresso))
                {
                    this.ValorIngresso = valor;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public float getValorIngresso()
        {
            return ValorIngresso;
        }

        public Boolean setNumeroIngressoDiponivel(UInt16 numero)
        {
            try
            {
                if((numero > 0) && (numero < NumeroMaximoIngresso))
                {
                    this.NumeroIngressoDiponivel = numero;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public UInt16 getNumeroIngressoDiponivel()
        {
            return NumeroIngressoDiponivel;
        }
    }
}
