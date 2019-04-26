using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TicketSale
{
    class Application
    {
        public bool CheckProgramFlow(char ch)
        {
            try
            {
                if ((ch == 'S') || (ch == 's'))
                {
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
    }
}
