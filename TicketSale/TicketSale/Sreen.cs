using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TicketSale
{
    class Sreen
    {
        private CultureInfo idioma = new CultureInfo("pt-BR");
        const UInt16 NUMBER_CHAR  =  78;
        private DateTime data = new DateTime();
        private string[] texto =
        {
           	/* 00 */"Projeto PIM IV",
	        /* 01 */"Tema:",
	        /* 02 */"Objetivo Geral:",
	        /* 03 */"Desenvolvimento de um sistema em linguagem C.",
	        /* 04 */"Desenvolver um sistema em linguagem C para venda de ingressos de teatro.",
	        /* 05 */"Ticket Sale",
	        /* 06 */"Digite o nome do Teatro:",
	        /* 07 */"Digite o nome do Espetaculo:",
	        /* 08 */"Digite a data do Espetaculo (dd/mm/aa):",
	        /* 09 */"Digite o valor do ingresso (R$ rr.ss):",
	        /* 10 */"Digite o numero de ingresso disponivel:",
	        /* 11 */"Data Invalida",
	        /* 12 */"Valor do Ingresso Fora dos Limites",
	        /* 13 */"Numero de Ingresso Fora dos Limites",
	        /* 14 */"Deseja Iniciar a Venda dos Ingresso?",
	        /* 15 */"Digite; S (para Sim) ou N (para Nao):",
	        /* 16 */"Espetaculo:",
	        /* 17 */"Teatro:",
	        /* 18 */"Data Espetaculo:",
	        /* 19 */"Informe a Idade do Cliente:",
	        /* 20 */"Idade Isenta de Pagamento",
	        /* 21 */"Cliente contemplado com Meia-Entrada",
	        /* 22 */"Aluno da Rede Publica de Ensino?",
	        /* 23 */"Letra Invalida",
	        /* 24 */"Criança contemplada com gratuidade",
	        /* 25 */"Estudante?",
	        /* 26 */"Professor da Rede Publica de Ensino?",
	        /* 27 */"Ingresso sem Desconto",
	        /* 28 */"Informações sobre o Cliente",
	        /* 29 */"Idade Invalida",
	        /* 30 */"Ingresso Esgotados",
	        /* 31 */"Detalhe do Ingresso Vendido",
	        /* 32 */"Valor do Ingresso R$:",
	        /* 33 */"Numero da Poltrona:",
	        /* 34 */"Informação do Espetaculo",
	        /* 35 */"Deseja Encerrar a Venda de Ingresso",
	        /* 36 */"Poltronas em Verde estão Disponiveis",
	        /* 37 */"Digite o numero da poltrona Disponivel",
	        /* 38 */"Numero Invalido",
	        /* 39 */"Poltrona Indisponivel",
	        /* 40 */"Selecione a Poltrona",
	        /* 41 */"Ingresso tipo Cortesia",
	        /* 42 */"Ingresso tipo Meia-Entrada",
	        /* 43 */"Ingresso tipo Interira",
	        /* 44 */"Data da Venda:",
	        /* 45 */"Fechamento do Caixa",
	        /* 46 */"Ingressos Vendidos:",
	        /* 47 */"Ingressos Disponivel:",
	        /* 48 */"Saldo em Caixa R$:",
	        /* 49 */"Obrigado por utilizar o Software",
        };  
        
        public void screen_home()
        {
            screen_header();

            Console.WriteLine("{0}", texto[0]);

            Console.WriteLine("{0} {1}", texto[1], texto[2]);

            Console.WriteLine("{0} {1}", texto[2], texto[4]);

            screen_line();
        }

        public void screen_header()
        {
            String[] txt = new String[1];
            data = DateTime.Now;
            Console.Clear();
            screen_line();
            Console.ForegroundColor = ConsoleColor.Blue;
            screen_centralized_text(texto[5]);
            Console.WriteLine(" ");
            txt[0] = string.Format("{0} {1}", data.ToString("dddd", idioma),Convert.ToString( DateTime.Now) );
            screen_centralized_text(txt[0]);
            Console.Write("\n\r");
            Console.ResetColor();
            screen_line();
        }

        public void screen_line()
        {
            UInt16 i = 0;
            for(i=0;i<NUMBER_CHAR;i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(" ");
        }

        private void screen_putchar(char ch, UInt16 number_ch)
        {
            UInt16 i = 0;

            for(i=0;i<number_ch;i++)
            {
                Console.Write(ch);
            }
        }

        private UInt16 screen_calc_number_char(String txt)
        {
            //UInt16 number = 0;
            return (UInt16)((NUMBER_CHAR - txt.Length) / 2);
        }

        private void screen_centralized_text(String txt)
        {
            screen_putchar(' ', screen_calc_number_char(txt));
            Console.Write("{0}", txt);
            screen_putchar(' ', screen_calc_number_char(txt));
        }
    }
}
