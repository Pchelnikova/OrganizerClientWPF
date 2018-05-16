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
        public static Profit_ExpenceDAL WPF_to_DAL(Profit_ExpenceWPF_DTO profit_ExpanceWPF)
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

        public static Profit_ExpenceWPF_DTO DAL_to_WPF(Profit_ExpenceDAL profit_ExpanceDAL)
        {
            Profit_ExpenceWPF_DTO profit_ExpanceWPF = new Profit_ExpenceWPF_DTO()
            {
                Date_ = profit_ExpanceDAL.Date_,
                Sum = profit_ExpanceDAL.Sum,
                Description = profit_ExpanceDAL.Description,
                Profit_Expance_Type = profit_ExpanceDAL.Profit_Expance_Type
            };
            return profit_ExpanceWPF;
        }

        public static List<Profit_ExpenceWPF_DTO> DAL_to_WPF_List(List<Profit_ExpenceDAL> profit_ExpenceDAL)
        {
            List<Profit_ExpenceWPF_DTO> profit_expance = new List<Profit_ExpenceWPF_DTO>();
            foreach (Profit_ExpenceDAL item in profit_ExpenceDAL)
            {
                profit_expance.Add(new Profit_ExpenceWPF_DTO() { Date_ = item.Date_, Sum = item.Sum, Description = item.Description });
            }
            return profit_expance;
        }


    }
}
