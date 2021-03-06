﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BMI.BMIServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double heightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double weightField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double height {
            get {
                return this.heightField;
            }
            set {
                if ((this.heightField.Equals(value) != true)) {
                    this.heightField = value;
                    this.RaisePropertyChanged("height");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double weight {
            get {
                return this.weightField;
            }
            set {
                if ((this.weightField.Equals(value) != true)) {
                    this.weightField = value;
                    this.RaisePropertyChanged("weight");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BMIServiceReference.IBMIcalculatorService")]
    public interface IBMIcalculatorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBMIcalculatorService/Calculatebmi", ReplyAction="http://tempuri.org/IBMIcalculatorService/CalculatebmiResponse")]
        double Calculatebmi(BMI.BMIServiceReference.Person p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBMIcalculatorService/Calculatebmi", ReplyAction="http://tempuri.org/IBMIcalculatorService/CalculatebmiResponse")]
        System.Threading.Tasks.Task<double> CalculatebmiAsync(BMI.BMIServiceReference.Person p);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBMIcalculatorServiceChannel : BMI.BMIServiceReference.IBMIcalculatorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BMIcalculatorServiceClient : System.ServiceModel.ClientBase<BMI.BMIServiceReference.IBMIcalculatorService>, BMI.BMIServiceReference.IBMIcalculatorService {
        
        public BMIcalculatorServiceClient() {
        }
        
        public BMIcalculatorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BMIcalculatorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BMIcalculatorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BMIcalculatorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Calculatebmi(BMI.BMIServiceReference.Person p) {
            return base.Channel.Calculatebmi(p);
        }
        
        public System.Threading.Tasks.Task<double> CalculatebmiAsync(BMI.BMIServiceReference.Person p) {
            return base.Channel.CalculatebmiAsync(p);
        }
    }
}
