﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_Profit", ReplyAction="http://tempuri.org/IService1/Delete_ProfitResponse")]
        void Delete_Profit(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF profit_ExpanceWCF, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_Profit", ReplyAction="http://tempuri.org/IService1/Delete_ProfitResponse")]
        System.Threading.Tasks.Task Delete_ProfitAsync(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF profit_ExpanceWCF, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_Expence", ReplyAction="http://tempuri.org/IService1/Delete_ExpenceResponse")]
        void Delete_Expence(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF profit_ExpanceWCF, string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_Expence", ReplyAction="http://tempuri.org/IService1/Delete_ExpenceResponse")]
        System.Threading.Tasks.Task Delete_ExpenceAsync(DALOrganizerClientWPF.ServiceReference1.Profit_ExpanceWCF profit_ExpanceWCF, string login);
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
    }
}
