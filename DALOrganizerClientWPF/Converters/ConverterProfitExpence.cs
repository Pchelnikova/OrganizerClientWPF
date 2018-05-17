using DALOrganizerClientWPF.DTO;
using DALOrganizerClientWPF.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALOrganizerClientWPF.Converters
{
    public static class ConverterProfitExpence
    {
        public static Profit_ExpanceWCF DAL_to_WCF (Profit_ExpenceDAL profit_ExpenceDAL)
        {
            Profit_ExpanceWCF profit_ExpenceWCF = new Profit_ExpanceWCF()
            {
                Date_ = profit_ExpenceDAL.Date_,
                Sum = profit_ExpenceDAL.Sum,
                Description = profit_ExpenceDAL.Description,
                Profit_Expance_Type = profit_ExpenceDAL.Profit_Expance_Type
            };
            return profit_ExpenceWCF;
        }

        public static List<Profit_ExpenceDAL> WCF_to_DAL_List(Profit_ExpanceWCF[] profit_ExpenceDAL)
        {
            List<Profit_ExpenceDAL> profit_expance = new List<Profit_ExpenceDAL>();
            foreach (Profit_ExpanceWCF item in profit_ExpenceDAL)
            {
                profit_expance.Add(new Profit_ExpenceDAL() { Date_ = item.Date_, Sum = item.Sum, Description = item.Description, Profit_Expance_Type = item.Profit_Expance_Type });
            }
            return profit_expance;
        }
    }
}
