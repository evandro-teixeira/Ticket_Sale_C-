using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public enum TipoIngresso
{
    Inteira = 0x01,
    Meia = 0x02,
    Inseto = 0x04,
}

public enum TipoCliente
{
    Adulto                  = 0x01,
    ProfessorRedePublica    = 0x02,
    Estudante               = 0x04,
    Idoso                   = 0x08,
    Crianca                 = 0x10,
    CriancaRedePublica      = 0x20,
    Bebe                    = 0x40,
}

namespace TicketSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingresso ticket = new Ingresso();
            Poltrona cadeira = new Poltrona();
            Console.WriteLine("Digite o numero de poltronas disponivel no teatro");

            cadeira.setNumeroTotal(Convert.ToUInt16(Console.ReadLine()));

            Console.WriteLine("numero digitado {0}", cadeira.getNumeroTotal()); 
        }
    }
}
