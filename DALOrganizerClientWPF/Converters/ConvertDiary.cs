using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALOrganizerClientWPF.DTO;
using DALOrganizerClientWPF.ServiceReference1;

namespace DALOrganizerClientWPF.Converters
{
    public static class ConvertDiary
    {
        public static List<DiaryDAL> WCF_to_DAL (Diary_WCF[] diaryWCF)
        {
            List<DiaryDAL> diaries = new List<DiaryDAL>();
            foreach (Diary_WCF item in diaryWCF)
            {
                diaries.Add(new DiaryDAL() { Date_ = item.Date_, Text = item.Text });
            }
            return diaries;
        }
    }
}
