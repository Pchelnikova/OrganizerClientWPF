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
    [System.Runtime.Serialization.DataContractAttribute(Name="Profit_WCF", Namespace="http://schemas.datacontract.org/2004/07/WcfService.DataContracts")]
    [System.SerializableAttribute()]
    public partial class Profit_WCF : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Date_Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfOrganizer")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
        DALOrganizerClientWPF.ServiceReference1.Profit_WCF[] Show_All_Profits(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Show_All_Profits", ReplyAction="http://tempuri.org/IService1/Show_All_ProfitsResponse")]
        System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.Profit_WCF[]> Show_All_ProfitsAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProfitsTypes", ReplyAction="http://tempuri.org/IService1/GetProfitsTypesResponse")]
        string[] GetProfitsTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProfitsTypes", ReplyAction="http://tempuri.org/IService1/GetProfitsTypesResponse")]
        System.Threading.Tasks.Task<string[]> GetProfitsTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        DALOrganizerClientWPF.ServiceReference1.CompositeType GetDataUsingDataContract(DALOrganizerClientWPF.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(DALOrganizerClientWPF.ServiceReference1.CompositeType composite);
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
        
        public DALOrganizerClientWPF.ServiceReference1.Profit_WCF[] Show_All_Profits(string login) {
            return base.Channel.Show_All_Profits(login);
        }
        
        public System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.Profit_WCF[]> Show_All_ProfitsAsync(string login) {
            return base.Channel.Show_All_ProfitsAsync(login);
        }
        
        public string[] GetProfitsTypes() {
            return base.Channel.GetProfitsTypes();
        }
        
        public System.Threading.Tasks.Task<string[]> GetProfitsTypesAsync() {
            return base.Channel.GetProfitsTypesAsync();
        }
        
        public DALOrganizerClientWPF.ServiceReference1.CompositeType GetDataUsingDataContract(DALOrganizerClientWPF.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<DALOrganizerClientWPF.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(DALOrganizerClientWPF.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}