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
            Sreen telas = new Sreen();

            //telas.screen_header();
            telas.screen_home();
        }
    }
}
