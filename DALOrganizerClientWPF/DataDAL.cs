using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALOrganizerClientWPF.DTO;
using DALOrganizerClientWPF.ServiceReference1;


namespace DALOrganizerClientWPF
{
    public class DataDAL
    {
        private readonly Service1Client _service = new Service1Client();

        public ICollection<DiaryDAL> Show_All_Notes(string login)
        {

            var diary_list = _service.Show_All_Notes(login);
            List<DiaryDAL> diaries = new List<DiaryDAL>();
            foreach (Diary_WCF item in diary_list)
                diaries.Add(new DiaryDAL() { Date_ = item.Date_, Text = item.Text });
            return diaries;
        }

        public void Add_Note(string note, string login)
        {
            _service.Add_Note(note, login);
        }

       public void Delete_Note(string note)
        {
            _service.Delete_Note(note);
        }

        //Budget CRUD
        public ICollection<Profit_ExpanceDAL> Show_All_Profits (string login)
        {
            var profit_list = _service.Show_All_Profits(login);
            List<Profit_ExpanceDAL> profits = new List<Profit_ExpanceDAL>();
            foreach (Profit_ExpanceWCF item in profit_list)
                profits.Add(new Profit_ExpanceDAL() { Date_ = item.Date_, Sum = item.Sum, Description = item.Description });
            return profits;            
        }
        
        public ICollection<Profit_ExpanceDAL> Show_All_Expance(string login)
        {
            var expance_list = _service.Show_All_Expance(login);
            List<Profit_ExpanceDAL> expance = new List<Profit_ExpanceDAL>();
            foreach (Profit_ExpanceWCF item in expance_list)
                expance.Add(new Profit_ExpanceDAL() { Date_ = item.Date_, Sum = item.Sum, Description = item.Description });
            return expance;
        }

        public void Save_New_Profit(Profit_ExpanceDAL new_profit, string login)
        {
           Profit_ExpanceWCF profit = new Profit_ExpanceWCF()
            {
                Date_ = new_profit.Date_,
                Sum = new_profit.Sum,
                Description = new_profit.Description,
                Profit_Expanc_Type = new_profit.Profit_Expance_Type               
            };
            _service.Save_New_Profit(profit, login);
        }

        public void Save_New_Expance(Profit_ExpanceDAL new_expance, string login)
        {
            Profit_ExpanceWCF expance = new Profit_ExpanceWCF()
            {
                Date_ = new_expance.Date_,
                Sum = new_expance.Sum,
                Description = new_expance.Description,
                Profit_Expanc_Type = new_expance.Profit_Expance_Type
            };
            _service.Save_New_Expance(expance, login);
        }

        public void Delete_Expence (DateTime dateTime)
        {
            _service.Delete_Expence(dateTime);
        }

        public List<string> GetProfitsTypes ()
        {
            return _service.GetProfitsTypes().ToList();
          
        }
        public List<string> GetExpanceTypes()
        {
            return _service.GetExpanceTypes().ToList();
        }
    }
}
