﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrganizerClientWPF.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Show_All_Notes", ReplyAction="http://tempuri.org/IService1/Show_All_NotesResponse")]
        DALOrganizerClientWPF.ServiceReference1.Diary_WCF[] Show_All_Notes(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Show_All_Notes", ReplyAction="http://tempuri.org/IService1/Show_All_NotesResponse")]
        System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.Diary_WCF[]> Show_All_NotesAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Add_Note", ReplyAction="http://tempuri.org/IService1/Add_NoteResponse")]
        void Add_Note(string note, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Add_Note", ReplyAction="http://tempuri.org/IService1/Add_NoteResponse")]
        System.Threading.Tasks.Task Add_NoteAsync(string note, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_Note", ReplyAction="http://tempuri.org/IService1/Delete_NoteResponse")]
        void Delete_Note(string note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_Note", ReplyAction="http://tempuri.org/IService1/Delete_NoteResponse")]
        System.Threading.Tasks.Task Delete_NoteAsync(string note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Show_All_Profits", ReplyAction="http://tempuri.org/IService1/Show_All_ProfitsResponse")]
        DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceDAL[] Show_All_Profits(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Show_All_Profits", ReplyAction="http://tempuri.org/IService1/Show_All_ProfitsResponse")]
        System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceDAL[]> Show_All_ProfitsAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Show_All_Expance", ReplyAction="http://tempuri.org/IService1/Show_All_ExpanceResponse")]
        DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceDAL[] Show_All_Expance(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Show_All_Expance", ReplyAction="http://tempuri.org/IService1/Show_All_ExpanceResponse")]
        System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceDAL[]> Show_All_ExpanceAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProfitsTypes", ReplyAction="http://tempuri.org/IService1/GetProfitsTypesResponse")]
        string[] GetProfitsTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProfitsTypes", ReplyAction="http://tempuri.org/IService1/GetProfitsTypesResponse")]
        System.Threading.Tasks.Task<string[]> GetProfitsTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetExpanceTypes", ReplyAction="http://tempuri.org/IService1/GetExpanceTypesResponse")]
        string[] GetExpanceTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetExpanceTypes", ReplyAction="http://tempuri.org/IService1/GetExpanceTypesResponse")]
        System.Threading.Tasks.Task<string[]> GetExpanceTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Save_New_Expance", ReplyAction="http://tempuri.org/IService1/Save_New_ExpanceResponse")]
        void Save_New_Expance(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceDAL new_expance, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Save_New_Expance", ReplyAction="http://tempuri.org/IService1/Save_New_ExpanceResponse")]
        System.Threading.Tasks.Task Save_New_ExpanceAsync(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceDAL new_expance, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Save_New_Profit", ReplyAction="http://tempuri.org/IService1/Save_New_ProfitResponse")]
        void Save_New_Profit(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceDAL new_profit, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Save_New_Profit", ReplyAction="http://tempuri.org/IService1/Save_New_ProfitResponse")]
        System.Threading.Tasks.Task Save_New_ProfitAsync(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceDAL new_profit, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        DALOrganizerClientWPF.ServiceReference1.CompositeType GetDataUsingDataContract(DALOrganizerClientWPF.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(DALOrganizerClientWPF.ServiceReference1.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : OrganizerClientWPF.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<OrganizerClientWPF.ServiceReference1.IService1>, OrganizerClientWPF.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DALOrganizerClientWPF.ServiceReference1.Diary_WCF[] Show_All_Notes(string login) {
            return base.Channel.Show_All_Notes(login);
        }
        
        public System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.Diary_WCF[]> Show_All_NotesAsync(string login) {
            return base.Channel.Show_All_NotesAsync(login);
        }
        
        public void Add_Note(string note, string login) {
            base.Channel.Add_Note(note, login);
        }
        
        public System.Threading.Tasks.Task Add_NoteAsync(string note, string login) {
            return base.Channel.Add_NoteAsync(note, login);
        }
        
        public void Delete_Note(string note) {
            base.Channel.Delete_Note(note);
        }
        
        public System.Threading.Tasks.Task Delete_NoteAsync(string note) {
            return base.Channel.Delete_NoteAsync(note);
        }
        
        public DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceDAL[] Show_All_Profits(string login) {
            return base.Channel.Show_All_Profits(login);
        }
        
        public System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceDAL[]> Show_All_ProfitsAsync(string login) {
            return base.Channel.Show_All_ProfitsAsync(login);
        }
        
        public DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceDAL[] Show_All_Expance(string login) {
            return base.Channel.Show_All_Expance(login);
        }
        
        public System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceDAL[]> Show_All_ExpanceAsync(string login) {
            return base.Channel.Show_All_ExpanceAsync(login);
        }
        
        public string[] GetProfitsTypes() {
            return base.Channel.GetProfitsTypes();
        }
        
        public System.Threading.Tasks.Task<string[]> GetProfitsTypesAsync() {
            return base.Channel.GetProfitsTypesAsync();
        }
        
        public string[] GetExpanceTypes() {
            return base.Channel.GetExpanceTypes();
        }
        
        public System.Threading.Tasks.Task<string[]> GetExpanceTypesAsync() {
            return base.Channel.GetExpanceTypesAsync();
        }
        
        public void Save_New_Expance(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceDAL new_expance, string login) {
            base.Channel.Save_New_Expance(new_expance, login);
        }
        
        public System.Threading.Tasks.Task Save_New_ExpanceAsync(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceDAL new_expance, string login) {
            return base.Channel.Save_New_ExpanceAsync(new_expance, login);
        }
        
        public void Save_New_Profit(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceDAL new_profit, string login) {
            base.Channel.Save_New_Profit(new_profit, login);
        }
        
        public System.Threading.Tasks.Task Save_New_ProfitAsync(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceDAL new_profit, string login) {
            return base.Channel.Save_New_ProfitAsync(new_profit, login);
        }
        
        public DALOrganizerClientWPF.ServiceReference1.CompositeType GetDataUsingDataContract(DALOrganizerClientWPF.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(DALOrganizerClientWPF.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
