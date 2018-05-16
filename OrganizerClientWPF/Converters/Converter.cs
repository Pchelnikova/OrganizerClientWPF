using DALOrganizerClientWPF.DTO;
using OrganizerClientWPF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerClientWPF.Converters
{
    public static class Converter
    {
        public static Profit_ExpenceDAL WPF_to_DAL(Profit_ExpanceWPF_DTO profit_ExpanceWPF)
        {
            Profit_ExpenceDAL profit_ExpanceDAL = new Profit_ExpenceDAL()
            {
                Date_ = profit_ExpanceWPF.Date_,
                Sum = profit_ExpanceWPF.Sum,
                Description = profit_ExpanceWPF.Description,
                Profit_Expance_Type = profit_ExpanceWPF.Profit_Expance_Type
            };
            return profit_ExpanceDAL;
        }
    }
}
