using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALOrganizerClientWPF.DTO;
using OrganizerClientWPF.DTO;

namespace OrganizerClientWPF.Converters
{
    public static class ConverterDiary
    {
        public static List<DiaryWPF_DTO> DAL_to_WPF_List (List<DiaryDAL> diaryDAL)
        {
            var diary_list_wpf = new List<DiaryWPF_DTO>();
            foreach (DiaryDAL item in diaryDAL)
            {
                DiaryWPF_DTO diaryWPF_DTO = new DiaryWPF_DTO
                {
                    Date_ = item.Date_,
                    Text = item.Text
                };
                diary_list_wpf.Add(diaryWPF_DTO);
            }
            return diary_list_wpf;
        }
    }
}
