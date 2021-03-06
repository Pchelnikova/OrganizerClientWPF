﻿using System;
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

        //Diary CRUD
        public List<DiaryDAL> Get_All_Notes(string login)
        {        
            return ConvertDiary.WCF_to_DAL(_service.Get_All_Notes(login));
        }
        public void Add_Note(string note, string login)
        {
            _service.Add_Note(note, login);
        }
       public void Delete_Note(string note)
        {
            _service.Delete_Note(note);
        }

        //Budget Profits CRUD 
        public List<Profit_ExpenceDAL> Get_All_Profits (string login)
        {
            return Converters.ConverterProfitExpence.WCF_to_DAL_List(_service.Get_All_Profits(login));           
        }        
        public void Save_New_Profit(Profit_ExpenceDAL new_profit, string Type, string login)
        {
            _service.Save_New_Profit(ConverterProfitExpence.DAL_to_WCF(new_profit), Type, login);
        }      
        public void Delete_Profit(Profit_ExpenceDAL profit, string login)
        {
            _service.Delete_Profit(ConverterProfitExpence.DAL_to_WCF(profit), login);
        }
       
        //Budget Expence CRUD
        public List<Profit_ExpenceDAL> Get_All_Expance(string login)
        {
            return ConverterProfitExpence.WCF_to_DAL_List(_service.Get_All_Expance(login));
        }
        public void Save_New_Expence(Profit_ExpenceDAL new_expance, string Type, string login)
        {
            _service.Save_New_Expance(Converters.ConverterProfitExpence.DAL_to_WCF(new_expance), Type, login);
        }
        public void Delete_Expence(Profit_ExpenceDAL expence, string login)
        {
            _service.Delete_Expence(ConverterProfitExpence.DAL_to_WCF(expence), login);
        }

        //Budget Plans CRUD
        public List<Profit_ExpenceDAL> Get_All_Plans(string login)
        {
            return ConverterProfitExpence.WCF_to_DAL_List(_service.Get_All_Plans(login));
        }
        public void Save_New_Plan(Profit_ExpenceDAL new_plan, string Type, string login)
        {
            _service.Save_New_Plan(Converters.ConverterProfitExpence.DAL_to_WCF(new_plan), Type, login);
        }
        public void Delete_Plan(Profit_ExpenceDAL expence, string login)
        {
            _service.Delete_Plan(ConverterProfitExpence.DAL_to_WCF(expence), login);
        }

        #region
        //Get Total Sum and Budget
        public decimal Get_Total_Profits()
        {
            return _service.Get_Total_Profits();
        }
        public decimal Get_Total_Expences()
        {
            return _service.Get_Total_Expences();
        }
        public decimal Get_Total_Plans()
        {
            return _service.Get_Total_Plans();
        }
        public decimal Get_Balance()
        {
            return _service.Get_Balance();
        }
        #endregion

        //authorization
        public bool Authorization (string login, string parol)
        {
            return _service.Authorization(login, parol);
        }

        public bool Create_New_User (string login, string password)
        {
            return _service.Create_New_User(login, password);
        }
        //Get Types of Budget
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
