﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DALOrganizerClientWPF.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Diary_WCF", Namespace="http://schemas.datacontract.org/2004/07/WcfService.DataContracts")]
    [System.SerializableAttribute()]
    public partial class Diary_WCF : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Date_Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date_ {
            get {
                return this.Date_Field;
            }
            set {
                if ((this.Date_Field.Equals(value) != true)) {
                    this.Date_Field = value;
                    this.RaisePropertyChanged("Date_");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Profit_ExpanceWCF", Namespace="http://schemas.datacontract.org/2004/07/WcfService.DataContracts")]
    [System.SerializableAttribute()]
    public partial class Profit_ExpanceWCF : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Date_Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Profit_Expance_TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal SumField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date_ {
            get {
                return this.Date_Field;
            }
            set {
                if ((this.Date_Field.Equals(value) != true)) {
                    this.Date_Field = value;
                    this.RaisePropertyChanged("Date_");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Profit_Expance_Type {
            get {
                return this.Profit_Expance_TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.Profit_Expance_TypeField, value) != true)) {
                    this.Profit_Expance_TypeField = value;
                    this.RaisePropertyChanged("Profit_Expance_Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Sum {
            get {
                return this.SumField;
            }
            set {
                if ((this.SumField.Equals(value) != true)) {
                    this.SumField = value;
                    this.RaisePropertyChanged("Sum");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_All_Notes", ReplyAction="http://tempuri.org/IService1/Get_All_NotesResponse")]
        DALOrganizerClientWPF.ServiceReference1.Diary_WCF[] Get_All_Notes(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_All_Notes", ReplyAction="http://tempuri.org/IService1/Get_All_NotesResponse")]
        System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.Diary_WCF[]> Get_All_NotesAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Add_Note", ReplyAction="http://tempuri.org/IService1/Add_NoteResponse")]
        void Add_Note(string note, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Add_Note", ReplyAction="http://tempuri.org/IService1/Add_NoteResponse")]
        System.Threading.Tasks.Task Add_NoteAsync(string note, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_Note", ReplyAction="http://tempuri.org/IService1/Delete_NoteResponse")]
        void Delete_Note(string note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_Note", ReplyAction="http://tempuri.org/IService1/Delete_NoteResponse")]
        System.Threading.Tasks.Task Delete_NoteAsync(string note);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_All_Profits", ReplyAction="http://tempuri.org/IService1/Get_All_ProfitsResponse")]
        DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF[] Get_All_Profits(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_All_Profits", ReplyAction="http://tempuri.org/IService1/Get_All_ProfitsResponse")]
        System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF[]> Get_All_ProfitsAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_All_Expance", ReplyAction="http://tempuri.org/IService1/Get_All_ExpanceResponse")]
        DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF[] Get_All_Expance(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_All_Expance", ReplyAction="http://tempuri.org/IService1/Get_All_ExpanceResponse")]
        System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF[]> Get_All_ExpanceAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_All_Plans", ReplyAction="http://tempuri.org/IService1/Get_All_PlansResponse")]
        DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF[] Get_All_Plans(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_All_Plans", ReplyAction="http://tempuri.org/IService1/Get_All_PlansResponse")]
        System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF[]> Get_All_PlansAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProfitsTypes", ReplyAction="http://tempuri.org/IService1/GetProfitsTypesResponse")]
        string[] GetProfitsTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProfitsTypes", ReplyAction="http://tempuri.org/IService1/GetProfitsTypesResponse")]
        System.Threading.Tasks.Task<string[]> GetProfitsTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetExpanceTypes", ReplyAction="http://tempuri.org/IService1/GetExpanceTypesResponse")]
        string[] GetExpanceTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetExpanceTypes", ReplyAction="http://tempuri.org/IService1/GetExpanceTypesResponse")]
        System.Threading.Tasks.Task<string[]> GetExpanceTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Save_New_Expance", ReplyAction="http://tempuri.org/IService1/Save_New_ExpanceResponse")]
        void Save_New_Expance(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF new_expance, string Type, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Save_New_Expance", ReplyAction="http://tempuri.org/IService1/Save_New_ExpanceResponse")]
        System.Threading.Tasks.Task Save_New_ExpanceAsync(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF new_expance, string Type, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Save_New_Profit", ReplyAction="http://tempuri.org/IService1/Save_New_ProfitResponse")]
        void Save_New_Profit(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF new_profit, string Type, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Save_New_Profit", ReplyAction="http://tempuri.org/IService1/Save_New_ProfitResponse")]
        System.Threading.Tasks.Task Save_New_ProfitAsync(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF new_profit, string Type, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Save_New_Plan", ReplyAction="http://tempuri.org/IService1/Save_New_PlanResponse")]
        void Save_New_Plan(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF new_expance, string Type, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Save_New_Plan", ReplyAction="http://tempuri.org/IService1/Save_New_PlanResponse")]
        System.Threading.Tasks.Task Save_New_PlanAsync(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF new_expance, string Type, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_Profit", ReplyAction="http://tempuri.org/IService1/Delete_ProfitResponse")]
        void Delete_Profit(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF profit_ExpanceWCF, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_Profit", ReplyAction="http://tempuri.org/IService1/Delete_ProfitResponse")]
        System.Threading.Tasks.Task Delete_ProfitAsync(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF profit_ExpanceWCF, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_Expence", ReplyAction="http://tempuri.org/IService1/Delete_ExpenceResponse")]
        void Delete_Expence(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF profit_ExpanceWCF, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_Expence", ReplyAction="http://tempuri.org/IService1/Delete_ExpenceResponse")]
        System.Threading.Tasks.Task Delete_ExpenceAsync(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF profit_ExpanceWCF, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_Plan", ReplyAction="http://tempuri.org/IService1/Delete_PlanResponse")]
        void Delete_Plan(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF profit_ExpanceWCF, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_Plan", ReplyAction="http://tempuri.org/IService1/Delete_PlanResponse")]
        System.Threading.Tasks.Task Delete_PlanAsync(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF profit_ExpanceWCF, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_Total_Profits", ReplyAction="http://tempuri.org/IService1/Get_Total_ProfitsResponse")]
        decimal Get_Total_Profits();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_Total_Profits", ReplyAction="http://tempuri.org/IService1/Get_Total_ProfitsResponse")]
        System.Threading.Tasks.Task<decimal> Get_Total_ProfitsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_Total_Expences", ReplyAction="http://tempuri.org/IService1/Get_Total_ExpencesResponse")]
        decimal Get_Total_Expences();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_Total_Expences", ReplyAction="http://tempuri.org/IService1/Get_Total_ExpencesResponse")]
        System.Threading.Tasks.Task<decimal> Get_Total_ExpencesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_Total_Plans", ReplyAction="http://tempuri.org/IService1/Get_Total_PlansResponse")]
        decimal Get_Total_Plans();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_Total_Plans", ReplyAction="http://tempuri.org/IService1/Get_Total_PlansResponse")]
        System.Threading.Tasks.Task<decimal> Get_Total_PlansAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_Balance", ReplyAction="http://tempuri.org/IService1/Get_BalanceResponse")]
        decimal Get_Balance();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_Balance", ReplyAction="http://tempuri.org/IService1/Get_BalanceResponse")]
        System.Threading.Tasks.Task<decimal> Get_BalanceAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Authorization", ReplyAction="http://tempuri.org/IService1/AuthorizationResponse")]
        bool Authorization(string login, string parol);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Authorization", ReplyAction="http://tempuri.org/IService1/AuthorizationResponse")]
        System.Threading.Tasks.Task<bool> AuthorizationAsync(string login, string parol);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Create_New_User", ReplyAction="http://tempuri.org/IService1/Create_New_UserResponse")]
        bool Create_New_User(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Create_New_User", ReplyAction="http://tempuri.org/IService1/Create_New_UserResponse")]
        System.Threading.Tasks.Task<bool> Create_New_UserAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteUser", ReplyAction="http://tempuri.org/IService1/DeleteUserResponse")]
        void DeleteUser(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteUser", ReplyAction="http://tempuri.org/IService1/DeleteUserResponse")]
        System.Threading.Tasks.Task DeleteUserAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ChangeUser_Login", ReplyAction="http://tempuri.org/IService1/ChangeUser_LoginResponse")]
        void ChangeUser_Login(string login, string newLogin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ChangeUser_Login", ReplyAction="http://tempuri.org/IService1/ChangeUser_LoginResponse")]
        System.Threading.Tasks.Task ChangeUser_LoginAsync(string login, string newLogin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ChangeUser_Password", ReplyAction="http://tempuri.org/IService1/ChangeUser_PasswordResponse")]
        void ChangeUser_Password(string login, string newPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ChangeUser_Password", ReplyAction="http://tempuri.org/IService1/ChangeUser_PasswordResponse")]
        System.Threading.Tasks.Task ChangeUser_PasswordAsync(string login, string newPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ChangeUser_Status", ReplyAction="http://tempuri.org/IService1/ChangeUser_StatusResponse")]
        void ChangeUser_Status(string login, string newStatus);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ChangeUser_Status", ReplyAction="http://tempuri.org/IService1/ChangeUser_StatusResponse")]
        System.Threading.Tasks.Task ChangeUser_StatusAsync(string login, string newStatus);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Diary_ByDate", ReplyAction="http://tempuri.org/IService1/Diary_ByDateResponse")]
        DALOrganizerClientWPF.ServiceReference1.Diary_WCF[] Diary_ByDate(string login, System.DateTime date1, System.DateTime date2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Diary_ByDate", ReplyAction="http://tempuri.org/IService1/Diary_ByDateResponse")]
        System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.Diary_WCF[]> Diary_ByDateAsync(string login, System.DateTime date1, System.DateTime date2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_Sum_byType_forChart_Profits", ReplyAction="http://tempuri.org/IService1/Get_Sum_byType_forChart_ProfitsResponse")]
        System.Collections.Generic.Dictionary<string, decimal> Get_Sum_byType_forChart_Profits();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_Sum_byType_forChart_Profits", ReplyAction="http://tempuri.org/IService1/Get_Sum_byType_forChart_ProfitsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, decimal>> Get_Sum_byType_forChart_ProfitsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_All_Wishes", ReplyAction="http://tempuri.org/IService1/Get_All_WishesResponse")]
        DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF[] Get_All_Wishes(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_All_Wishes", ReplyAction="http://tempuri.org/IService1/Get_All_WishesResponse")]
        System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF[]> Get_All_WishesAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Save_New_Wish", ReplyAction="http://tempuri.org/IService1/Save_New_WishResponse")]
        void Save_New_Wish(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF new_wish, string Type, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Save_New_Wish", ReplyAction="http://tempuri.org/IService1/Save_New_WishResponse")]
        System.Threading.Tasks.Task Save_New_WishAsync(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF new_wish, string Type, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetWishTypes", ReplyAction="http://tempuri.org/IService1/GetWishTypesResponse")]
        string[] GetWishTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetWishTypes", ReplyAction="http://tempuri.org/IService1/GetWishTypesResponse")]
        System.Threading.Tasks.Task<string[]> GetWishTypesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : DALOrganizerClientWPF.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<DALOrganizerClientWPF.ServiceReference1.IService1>, DALOrganizerClientWPF.ServiceReference1.IService1 {
        
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
        
        public DALOrganizerClientWPF.ServiceReference1.Diary_WCF[] Get_All_Notes(string login) {
            return base.Channel.Get_All_Notes(login);
        }
        
        public System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.Diary_WCF[]> Get_All_NotesAsync(string login) {
            return base.Channel.Get_All_NotesAsync(login);
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
        
        public DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF[] Get_All_Profits(string login) {
            return base.Channel.Get_All_Profits(login);
        }
        
        public System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF[]> Get_All_ProfitsAsync(string login) {
            return base.Channel.Get_All_ProfitsAsync(login);
        }
        
        public DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF[] Get_All_Expance(string login) {
            return base.Channel.Get_All_Expance(login);
        }
        
        public System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF[]> Get_All_ExpanceAsync(string login) {
            return base.Channel.Get_All_ExpanceAsync(login);
        }
        
        public DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF[] Get_All_Plans(string login) {
            return base.Channel.Get_All_Plans(login);
        }
        
        public System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF[]> Get_All_PlansAsync(string login) {
            return base.Channel.Get_All_PlansAsync(login);
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
        
        public void Save_New_Expance(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF new_expance, string Type, string login) {
            base.Channel.Save_New_Expance(new_expance, Type, login);
        }
        
        public System.Threading.Tasks.Task Save_New_ExpanceAsync(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF new_expance, string Type, string login) {
            return base.Channel.Save_New_ExpanceAsync(new_expance, Type, login);
        }
        
        public void Save_New_Profit(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF new_profit, string Type, string login) {
            base.Channel.Save_New_Profit(new_profit, Type, login);
        }
        
        public System.Threading.Tasks.Task Save_New_ProfitAsync(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF new_profit, string Type, string login) {
            return base.Channel.Save_New_ProfitAsync(new_profit, Type, login);
        }
        
        public void Save_New_Plan(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF new_expance, string Type, string login) {
            base.Channel.Save_New_Plan(new_expance, Type, login);
        }
        
        public System.Threading.Tasks.Task Save_New_PlanAsync(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF new_expance, string Type, string login) {
            return base.Channel.Save_New_PlanAsync(new_expance, Type, login);
        }
        
        public void Delete_Profit(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF profit_ExpanceWCF, string login) {
            base.Channel.Delete_Profit(profit_ExpanceWCF, login);
        }
        
        public System.Threading.Tasks.Task Delete_ProfitAsync(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF profit_ExpanceWCF, string login) {
            return base.Channel.Delete_ProfitAsync(profit_ExpanceWCF, login);
        }
        
        public void Delete_Expence(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF profit_ExpanceWCF, string login) {
            base.Channel.Delete_Expence(profit_ExpanceWCF, login);
        }
        
        public System.Threading.Tasks.Task Delete_ExpenceAsync(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF profit_ExpanceWCF, string login) {
            return base.Channel.Delete_ExpenceAsync(profit_ExpanceWCF, login);
        }
        
        public void Delete_Plan(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF profit_ExpanceWCF, string login) {
            base.Channel.Delete_Plan(profit_ExpanceWCF, login);
        }
        
        public System.Threading.Tasks.Task Delete_PlanAsync(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF profit_ExpanceWCF, string login) {
            return base.Channel.Delete_PlanAsync(profit_ExpanceWCF, login);
        }
        
        public decimal Get_Total_Profits() {
            return base.Channel.Get_Total_Profits();
        }
        
        public System.Threading.Tasks.Task<decimal> Get_Total_ProfitsAsync() {
            return base.Channel.Get_Total_ProfitsAsync();
        }
        
        public decimal Get_Total_Expences() {
            return base.Channel.Get_Total_Expences();
        }
        
        public System.Threading.Tasks.Task<decimal> Get_Total_ExpencesAsync() {
            return base.Channel.Get_Total_ExpencesAsync();
        }
        
        public decimal Get_Total_Plans() {
            return base.Channel.Get_Total_Plans();
        }
        
        public System.Threading.Tasks.Task<decimal> Get_Total_PlansAsync() {
            return base.Channel.Get_Total_PlansAsync();
        }
        
        public decimal Get_Balance() {
            return base.Channel.Get_Balance();
        }
        
        public System.Threading.Tasks.Task<decimal> Get_BalanceAsync() {
            return base.Channel.Get_BalanceAsync();
        }
        
        public bool Authorization(string login, string parol) {
            return base.Channel.Authorization(login, parol);
        }
        
        public System.Threading.Tasks.Task<bool> AuthorizationAsync(string login, string parol) {
            return base.Channel.AuthorizationAsync(login, parol);
        }
        
        public bool Create_New_User(string login, string password) {
            return base.Channel.Create_New_User(login, password);
        }
        
        public System.Threading.Tasks.Task<bool> Create_New_UserAsync(string login, string password) {
            return base.Channel.Create_New_UserAsync(login, password);
        }
        
        public void DeleteUser(string login) {
            base.Channel.DeleteUser(login);
        }
        
        public System.Threading.Tasks.Task DeleteUserAsync(string login) {
            return base.Channel.DeleteUserAsync(login);
        }
        
        public void ChangeUser_Login(string login, string newLogin) {
            base.Channel.ChangeUser_Login(login, newLogin);
        }
        
        public System.Threading.Tasks.Task ChangeUser_LoginAsync(string login, string newLogin) {
            return base.Channel.ChangeUser_LoginAsync(login, newLogin);
        }
        
        public void ChangeUser_Password(string login, string newPassword) {
            base.Channel.ChangeUser_Password(login, newPassword);
        }
        
        public System.Threading.Tasks.Task ChangeUser_PasswordAsync(string login, string newPassword) {
            return base.Channel.ChangeUser_PasswordAsync(login, newPassword);
        }
        
        public void ChangeUser_Status(string login, string newStatus) {
            base.Channel.ChangeUser_Status(login, newStatus);
        }
        
        public System.Threading.Tasks.Task ChangeUser_StatusAsync(string login, string newStatus) {
            return base.Channel.ChangeUser_StatusAsync(login, newStatus);
        }
        
        public DALOrganizerClientWPF.ServiceReference1.Diary_WCF[] Diary_ByDate(string login, System.DateTime date1, System.DateTime date2) {
            return base.Channel.Diary_ByDate(login, date1, date2);
        }
        
        public System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.Diary_WCF[]> Diary_ByDateAsync(string login, System.DateTime date1, System.DateTime date2) {
            return base.Channel.Diary_ByDateAsync(login, date1, date2);
        }
        
        public System.Collections.Generic.Dictionary<string, decimal> Get_Sum_byType_forChart_Profits() {
            return base.Channel.Get_Sum_byType_forChart_Profits();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, decimal>> Get_Sum_byType_forChart_ProfitsAsync() {
            return base.Channel.Get_Sum_byType_forChart_ProfitsAsync();
        }
        
        public DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF[] Get_All_Wishes(string login) {
            return base.Channel.Get_All_Wishes(login);
        }
        
        public System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF[]> Get_All_WishesAsync(string login) {
            return base.Channel.Get_All_WishesAsync(login);
        }
        
        public void Save_New_Wish(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF new_wish, string Type, string login) {
            base.Channel.Save_New_Wish(new_wish, Type, login);
        }
        
        public System.Threading.Tasks.Task Save_New_WishAsync(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF new_wish, string Type, string login) {
            return base.Channel.Save_New_WishAsync(new_wish, Type, login);
        }
        
        public string[] GetWishTypes() {
            return base.Channel.GetWishTypes();
        }
        
        public System.Threading.Tasks.Task<string[]> GetWishTypesAsync() {
            return base.Channel.GetWishTypesAsync();
        }
    }
}
