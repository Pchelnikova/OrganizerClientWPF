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
        public ICollection<ProfitDAL> Show_All_Profits (string login)
        {
            var profit_list = _service.Show_All_Profits(login);
            List<ProfitDAL> profits = new List<ProfitDAL>();
            foreach (Profit_WCF item in profit_list)
                profits.Add(new ProfitDAL() { Date_ = item.Date_, Sum = item.Sum, Description = item.Description });
            return profits;            
        }

        public List<string> GetProfitsTypes ()
        {
            return _service.GetProfitsTypes().ToList();
          
        }
    }
}
