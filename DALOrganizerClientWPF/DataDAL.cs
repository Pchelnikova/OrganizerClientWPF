using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALOrganizerClientWPF.Converters;
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
        public ICollection<Profit_ExpenceDAL> Show_All_Profits (string login)
        {
            var profit_list = _service.Show_All_Profits(login);
            List<Profit_ExpenceDAL> profits = new List<Profit_ExpenceDAL>();
            foreach (Profit_ExpanceWCF item in profit_list)
                profits.Add(new Profit_ExpenceDAL() { Date_ = item.Date_, Sum = item.Sum, Description = item.Description });
            return profits;            
        }
        
      
        public void Save_New_Profit(Profit_ExpenceDAL new_profit, string login)
        {
            var profit = Converter.DAL_to_WCF(new_profit);
            _service.Save_New_Profit(profit, login);
        }

        public void Save_New_Expance(Profit_ExpenceDAL new_expance, string login)
        {
            var expance = Converter.DAL_to_WCF(new_expance);
            _service.Save_New_Expance(expance, login);
        }
        public void Delete_Profit(Profit_ExpenceDAL profit, string login)
        {
            var profit_WCF = Converter.DAL_to_WCF(profit);
            _service.Delete_Profit(profit_WCF, login);
        }
        //Budget Expence CRUD
        public ICollection<Profit_ExpenceDAL> Show_All_Expance(string login)
        {
            var expance_list = _service.Show_All_Expance(login);
            List<Profit_ExpenceDAL> expance = Converter.WCF_to_DAL_List(expance_list);
            return expance;
        }
        public void Delete_Expence (Profit_ExpenceDAL expence, string login)
        {
            var expence_WCF = Converter.DAL_to_WCF(expence);
            _service.Delete_Expence(expence_WCF, login);
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
