using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


public enum TipoIngresso
{
    Inteira = 0x00,
    Meia,
    Inseto,
}

public enum TipoCliente
{
    Adulto = 0x00,
    ProfessorRedePublica,
    Estudante,
    Idoso,
    Crianca,
    CriancaRedePublica,
    Bebe,
}

namespace TicketSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Sreen telas = new Sreen();

            telas.ScreenHome();

            Thread.Sleep(2000);

            telas.ScreenConfigInit();

            telas.ScreenCheckStartSale();

            Thread.Sleep(2000);

            telas.SreenPrintShowInformation();

            Console.ReadLine();
        }
    }
}
