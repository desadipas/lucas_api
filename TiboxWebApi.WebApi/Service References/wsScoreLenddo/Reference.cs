﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TiboxWebApi.WebApi.wsScoreLenddo {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ELScoreLenddoDatos", Namespace="http://schemas.datacontract.org/2004/07/SoftBox.Scoring.EntityLayer")]
    [System.SerializableAttribute()]
    public partial class ELScoreLenddoDatos : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TiboxWebApi.WebApi.wsScoreLenddo.ELDocumento oDocumentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TiboxWebApi.WebApi.wsScoreLenddo.ELProducto oProductoField;
        
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
        public TiboxWebApi.WebApi.wsScoreLenddo.ELDocumento oDocumento {
            get {
                return this.oDocumentoField;
            }
            set {
                if ((object.ReferenceEquals(this.oDocumentoField, value) != true)) {
                    this.oDocumentoField = value;
                    this.RaisePropertyChanged("oDocumento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TiboxWebApi.WebApi.wsScoreLenddo.ELProducto oProducto {
            get {
                return this.oProductoField;
            }
            set {
                if ((object.ReferenceEquals(this.oProductoField, value) != true)) {
                    this.oProductoField = value;
                    this.RaisePropertyChanged("oProducto");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ELDocumento", Namespace="http://schemas.datacontract.org/2004/07/SoftBox.Scoring.EntityLayer")]
    [System.SerializableAttribute()]
    public partial class ELDocumento : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nTipoDocField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string sNroDocField;
        
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
        public string nTipoDoc {
            get {
                return this.nTipoDocField;
            }
            set {
                if ((object.ReferenceEquals(this.nTipoDocField, value) != true)) {
                    this.nTipoDocField = value;
                    this.RaisePropertyChanged("nTipoDoc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string sNroDoc {
            get {
                return this.sNroDocField;
            }
            set {
                if ((object.ReferenceEquals(this.sNroDocField, value) != true)) {
                    this.sNroDocField = value;
                    this.RaisePropertyChanged("sNroDoc");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ELProducto", Namespace="http://schemas.datacontract.org/2004/07/SoftBox.Scoring.EntityLayer")]
    [System.SerializableAttribute()]
    public partial class ELProducto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nModalidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nProductoField;
        
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
        public string nModalidad {
            get {
                return this.nModalidadField;
            }
            set {
                if ((object.ReferenceEquals(this.nModalidadField, value) != true)) {
                    this.nModalidadField = value;
                    this.RaisePropertyChanged("nModalidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nProducto {
            get {
                return this.nProductoField;
            }
            set {
                if ((object.ReferenceEquals(this.nProductoField, value) != true)) {
                    this.nProductoField = value;
                    this.RaisePropertyChanged("nProducto");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ELScoreLenddoResultado", Namespace="http://schemas.datacontract.org/2004/07/SoftBox.Scoring.EntityLayer")]
    [System.SerializableAttribute()]
    public partial class ELScoreLenddoResultado : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool bErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool bPasoPorLenddoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool bVerificacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double nScoreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TiboxWebApi.WebApi.wsScoreLenddo.DatosVerificacion oListaVerificacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string sCodigoLenddoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string sMensajeErrorField;
        
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
        public bool bError {
            get {
                return this.bErrorField;
            }
            set {
                if ((this.bErrorField.Equals(value) != true)) {
                    this.bErrorField = value;
                    this.RaisePropertyChanged("bError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool bPasoPorLenddo {
            get {
                return this.bPasoPorLenddoField;
            }
            set {
                if ((this.bPasoPorLenddoField.Equals(value) != true)) {
                    this.bPasoPorLenddoField = value;
                    this.RaisePropertyChanged("bPasoPorLenddo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool bVerificacion {
            get {
                return this.bVerificacionField;
            }
            set {
                if ((this.bVerificacionField.Equals(value) != true)) {
                    this.bVerificacionField = value;
                    this.RaisePropertyChanged("bVerificacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double nScore {
            get {
                return this.nScoreField;
            }
            set {
                if ((this.nScoreField.Equals(value) != true)) {
                    this.nScoreField = value;
                    this.RaisePropertyChanged("nScore");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TiboxWebApi.WebApi.wsScoreLenddo.DatosVerificacion oListaVerificacion {
            get {
                return this.oListaVerificacionField;
            }
            set {
                if ((object.ReferenceEquals(this.oListaVerificacionField, value) != true)) {
                    this.oListaVerificacionField = value;
                    this.RaisePropertyChanged("oListaVerificacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string sCodigoLenddo {
            get {
                return this.sCodigoLenddoField;
            }
            set {
                if ((object.ReferenceEquals(this.sCodigoLenddoField, value) != true)) {
                    this.sCodigoLenddoField = value;
                    this.RaisePropertyChanged("sCodigoLenddo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string sMensajeError {
            get {
                return this.sMensajeErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.sMensajeErrorField, value) != true)) {
                    this.sMensajeErrorField = value;
                    this.RaisePropertyChanged("sMensajeError");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DatosVerificacion", Namespace="http://schemas.datacontract.org/2004/07/SoftBox.Scoring.EntityLayer")]
    [System.SerializableAttribute()]
    public partial class DatosVerificacion : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> BirthdayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> EmployerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> TopEmployerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> UniversityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> VerifiedByFacebookField;
        
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
        public System.Nullable<bool> Birthday {
            get {
                return this.BirthdayField;
            }
            set {
                if ((this.BirthdayField.Equals(value) != true)) {
                    this.BirthdayField = value;
                    this.RaisePropertyChanged("Birthday");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> Email {
            get {
                return this.EmailField;
            }
            set {
                if ((this.EmailField.Equals(value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> Employer {
            get {
                return this.EmployerField;
            }
            set {
                if ((this.EmployerField.Equals(value) != true)) {
                    this.EmployerField = value;
                    this.RaisePropertyChanged("Employer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> Name {
            get {
                return this.NameField;
            }
            set {
                if ((this.NameField.Equals(value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((this.PhoneField.Equals(value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> TopEmployer {
            get {
                return this.TopEmployerField;
            }
            set {
                if ((this.TopEmployerField.Equals(value) != true)) {
                    this.TopEmployerField = value;
                    this.RaisePropertyChanged("TopEmployer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> University {
            get {
                return this.UniversityField;
            }
            set {
                if ((this.UniversityField.Equals(value) != true)) {
                    this.UniversityField = value;
                    this.RaisePropertyChanged("University");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> VerifiedByFacebook {
            get {
                return this.VerifiedByFacebookField;
            }
            set {
                if ((this.VerifiedByFacebookField.Equals(value) != true)) {
                    this.VerifiedByFacebookField = value;
                    this.RaisePropertyChanged("VerifiedByFacebook");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsScoreLenddo.IwsScoreLenddo")]
    public interface IwsScoreLenddo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwsScoreLenddo/DevuelveScoreLenddo", ReplyAction="http://tempuri.org/IwsScoreLenddo/DevuelveScoreLenddoResponse")]
        TiboxWebApi.WebApi.wsScoreLenddo.ELScoreLenddoResultado DevuelveScoreLenddo(TiboxWebApi.WebApi.wsScoreLenddo.ELScoreLenddoDatos poDatos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwsScoreLenddo/DevuelveScoreLenddo", ReplyAction="http://tempuri.org/IwsScoreLenddo/DevuelveScoreLenddoResponse")]
        System.Threading.Tasks.Task<TiboxWebApi.WebApi.wsScoreLenddo.ELScoreLenddoResultado> DevuelveScoreLenddoAsync(TiboxWebApi.WebApi.wsScoreLenddo.ELScoreLenddoDatos poDatos);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IwsScoreLenddoChannel : TiboxWebApi.WebApi.wsScoreLenddo.IwsScoreLenddo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IwsScoreLenddoClient : System.ServiceModel.ClientBase<TiboxWebApi.WebApi.wsScoreLenddo.IwsScoreLenddo>, TiboxWebApi.WebApi.wsScoreLenddo.IwsScoreLenddo {
        
        public IwsScoreLenddoClient() {
        }
        
        public IwsScoreLenddoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IwsScoreLenddoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IwsScoreLenddoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IwsScoreLenddoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TiboxWebApi.WebApi.wsScoreLenddo.ELScoreLenddoResultado DevuelveScoreLenddo(TiboxWebApi.WebApi.wsScoreLenddo.ELScoreLenddoDatos poDatos) {
            return base.Channel.DevuelveScoreLenddo(poDatos);
        }
        
        public System.Threading.Tasks.Task<TiboxWebApi.WebApi.wsScoreLenddo.ELScoreLenddoResultado> DevuelveScoreLenddoAsync(TiboxWebApi.WebApi.wsScoreLenddo.ELScoreLenddoDatos poDatos) {
            return base.Channel.DevuelveScoreLenddoAsync(poDatos);
        }
    }
}