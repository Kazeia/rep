﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPCNETUnitTesting.UPCNETServiceAdministrador {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Services.upcnet.upc.com/", ConfigurationName="UPCNETServiceAdministrador.UPCNETServiceAdministrador")]
    public interface UPCNETServiceAdministrador {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceAdministrador/validarLoginAdministrad" +
            "orRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceAdministrador/validarLoginAdministrad" +
            "orResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        UPCNETUnitTesting.UPCNETServiceAdministrador.validarLoginAdministradorResponse validarLoginAdministrador(UPCNETUnitTesting.UPCNETServiceAdministrador.validarLoginAdministradorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceAdministrador/validarLoginAdministrad" +
            "orRequest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceAdministrador/validarLoginAdministrad" +
            "orResponse")]
        System.Threading.Tasks.Task<UPCNETUnitTesting.UPCNETServiceAdministrador.validarLoginAdministradorResponse> validarLoginAdministradorAsync(UPCNETUnitTesting.UPCNETServiceAdministrador.validarLoginAdministradorRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceAdministrador/getAdministradorByIdReq" +
            "uest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceAdministrador/getAdministradorByIdRes" +
            "ponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorByIdResponse getAdministradorById(UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorByIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceAdministrador/getAdministradorByIdReq" +
            "uest", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceAdministrador/getAdministradorByIdRes" +
            "ponse")]
        System.Threading.Tasks.Task<UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorByIdResponse> getAdministradorByIdAsync(UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorByIdRequest request);
        
        // CODEGEN: Parameter 'arg0' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceAdministrador/editAdministradorReques" +
            "t", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceAdministrador/editAdministradorRespon" +
            "se")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        UPCNETUnitTesting.UPCNETServiceAdministrador.editAdministradorResponse editAdministrador(UPCNETUnitTesting.UPCNETServiceAdministrador.editAdministradorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceAdministrador/editAdministradorReques" +
            "t", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceAdministrador/editAdministradorRespon" +
            "se")]
        System.Threading.Tasks.Task<UPCNETUnitTesting.UPCNETServiceAdministrador.editAdministradorResponse> editAdministradorAsync(UPCNETUnitTesting.UPCNETServiceAdministrador.editAdministradorRequest request);
        
        // CODEGEN: Parameter 'arg0' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceAdministrador/setAdministradorRequest" +
            "", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceAdministrador/setAdministradorRespons" +
            "e")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        UPCNETUnitTesting.UPCNETServiceAdministrador.setAdministradorResponse setAdministrador(UPCNETUnitTesting.UPCNETServiceAdministrador.setAdministradorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceAdministrador/setAdministradorRequest" +
            "", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceAdministrador/setAdministradorRespons" +
            "e")]
        System.Threading.Tasks.Task<UPCNETUnitTesting.UPCNETServiceAdministrador.setAdministradorResponse> setAdministradorAsync(UPCNETUnitTesting.UPCNETServiceAdministrador.setAdministradorRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceAdministrador/getAdministradorRequest" +
            "", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceAdministrador/getAdministradorRespons" +
            "e")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorResponse getAdministrador(UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Services.upcnet.upc.com/UPCNETServiceAdministrador/getAdministradorRequest" +
            "", ReplyAction="http://Services.upcnet.upc.com/UPCNETServiceAdministrador/getAdministradorRespons" +
            "e")]
        System.Threading.Tasks.Task<UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorResponse> getAdministradorAsync(UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validarLoginAdministrador", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class validarLoginAdministradorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg1;
        
        public validarLoginAdministradorRequest() {
        }
        
        public validarLoginAdministradorRequest(string arg0, string arg1) {
            this.arg0 = arg0;
            this.arg1 = arg1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validarLoginAdministradorResponse", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class validarLoginAdministradorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public validarLoginAdministradorResponse() {
        }
        
        public validarLoginAdministradorResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://Services.upcnet.upc.com/")]
    public partial class administrador : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string apellidoField;
        
        private string correoField;
        
        private string iDAdministradorField;
        
        private string nombreField;
        
        private string passField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string apellido {
            get {
                return this.apellidoField;
            }
            set {
                this.apellidoField = value;
                this.RaisePropertyChanged("apellido");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string correo {
            get {
                return this.correoField;
            }
            set {
                this.correoField = value;
                this.RaisePropertyChanged("correo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string IDAdministrador {
            get {
                return this.iDAdministradorField;
            }
            set {
                this.iDAdministradorField = value;
                this.RaisePropertyChanged("IDAdministrador");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string pass {
            get {
                return this.passField;
            }
            set {
                this.passField = value;
                this.RaisePropertyChanged("pass");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getAdministradorById", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class getAdministradorByIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        public getAdministradorByIdRequest() {
        }
        
        public getAdministradorByIdRequest(string arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getAdministradorByIdResponse", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class getAdministradorByIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UPCNETUnitTesting.UPCNETServiceAdministrador.administrador @return;
        
        public getAdministradorByIdResponse() {
        }
        
        public getAdministradorByIdResponse(UPCNETUnitTesting.UPCNETServiceAdministrador.administrador @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="editAdministrador", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class editAdministradorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg2;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg3;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg4;
        
        public editAdministradorRequest() {
        }
        
        public editAdministradorRequest(string arg0, string arg1, string arg2, string arg3, string arg4) {
            this.arg0 = arg0;
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
            this.arg4 = arg4;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="editAdministradorResponse", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class editAdministradorResponse {
        
        public editAdministradorResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="setAdministrador", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class setAdministradorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg2;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg3;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg4;
        
        public setAdministradorRequest() {
        }
        
        public setAdministradorRequest(string arg0, string arg1, string arg2, string arg3, string arg4) {
            this.arg0 = arg0;
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
            this.arg4 = arg4;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="setAdministradorResponse", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class setAdministradorResponse {
        
        public setAdministradorResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getAdministrador", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class getAdministradorRequest {
        
        public getAdministradorRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getAdministradorResponse", WrapperNamespace="http://Services.upcnet.upc.com/", IsWrapped=true)]
    public partial class getAdministradorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Services.upcnet.upc.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UPCNETUnitTesting.UPCNETServiceAdministrador.administrador[] @return;
        
        public getAdministradorResponse() {
        }
        
        public getAdministradorResponse(UPCNETUnitTesting.UPCNETServiceAdministrador.administrador[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UPCNETServiceAdministradorChannel : UPCNETUnitTesting.UPCNETServiceAdministrador.UPCNETServiceAdministrador, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UPCNETServiceAdministradorClient : System.ServiceModel.ClientBase<UPCNETUnitTesting.UPCNETServiceAdministrador.UPCNETServiceAdministrador>, UPCNETUnitTesting.UPCNETServiceAdministrador.UPCNETServiceAdministrador {
        
        public UPCNETServiceAdministradorClient() {
        }
        
        public UPCNETServiceAdministradorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UPCNETServiceAdministradorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UPCNETServiceAdministradorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UPCNETServiceAdministradorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPCNETUnitTesting.UPCNETServiceAdministrador.validarLoginAdministradorResponse UPCNETUnitTesting.UPCNETServiceAdministrador.UPCNETServiceAdministrador.validarLoginAdministrador(UPCNETUnitTesting.UPCNETServiceAdministrador.validarLoginAdministradorRequest request) {
            return base.Channel.validarLoginAdministrador(request);
        }
        
        public bool validarLoginAdministrador(string arg0, string arg1) {
            UPCNETUnitTesting.UPCNETServiceAdministrador.validarLoginAdministradorRequest inValue = new UPCNETUnitTesting.UPCNETServiceAdministrador.validarLoginAdministradorRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            UPCNETUnitTesting.UPCNETServiceAdministrador.validarLoginAdministradorResponse retVal = ((UPCNETUnitTesting.UPCNETServiceAdministrador.UPCNETServiceAdministrador)(this)).validarLoginAdministrador(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UPCNETUnitTesting.UPCNETServiceAdministrador.validarLoginAdministradorResponse> UPCNETUnitTesting.UPCNETServiceAdministrador.UPCNETServiceAdministrador.validarLoginAdministradorAsync(UPCNETUnitTesting.UPCNETServiceAdministrador.validarLoginAdministradorRequest request) {
            return base.Channel.validarLoginAdministradorAsync(request);
        }
        
        public System.Threading.Tasks.Task<UPCNETUnitTesting.UPCNETServiceAdministrador.validarLoginAdministradorResponse> validarLoginAdministradorAsync(string arg0, string arg1) {
            UPCNETUnitTesting.UPCNETServiceAdministrador.validarLoginAdministradorRequest inValue = new UPCNETUnitTesting.UPCNETServiceAdministrador.validarLoginAdministradorRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            return ((UPCNETUnitTesting.UPCNETServiceAdministrador.UPCNETServiceAdministrador)(this)).validarLoginAdministradorAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorByIdResponse UPCNETUnitTesting.UPCNETServiceAdministrador.UPCNETServiceAdministrador.getAdministradorById(UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorByIdRequest request) {
            return base.Channel.getAdministradorById(request);
        }
        
        public UPCNETUnitTesting.UPCNETServiceAdministrador.administrador getAdministradorById(string arg0) {
            UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorByIdRequest inValue = new UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorByIdRequest();
            inValue.arg0 = arg0;
            UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorByIdResponse retVal = ((UPCNETUnitTesting.UPCNETServiceAdministrador.UPCNETServiceAdministrador)(this)).getAdministradorById(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorByIdResponse> UPCNETUnitTesting.UPCNETServiceAdministrador.UPCNETServiceAdministrador.getAdministradorByIdAsync(UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorByIdRequest request) {
            return base.Channel.getAdministradorByIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorByIdResponse> getAdministradorByIdAsync(string arg0) {
            UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorByIdRequest inValue = new UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorByIdRequest();
            inValue.arg0 = arg0;
            return ((UPCNETUnitTesting.UPCNETServiceAdministrador.UPCNETServiceAdministrador)(this)).getAdministradorByIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPCNETUnitTesting.UPCNETServiceAdministrador.editAdministradorResponse UPCNETUnitTesting.UPCNETServiceAdministrador.UPCNETServiceAdministrador.editAdministrador(UPCNETUnitTesting.UPCNETServiceAdministrador.editAdministradorRequest request) {
            return base.Channel.editAdministrador(request);
        }
        
        public void editAdministrador(string arg0, string arg1, string arg2, string arg3, string arg4) {
            UPCNETUnitTesting.UPCNETServiceAdministrador.editAdministradorRequest inValue = new UPCNETUnitTesting.UPCNETServiceAdministrador.editAdministradorRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            inValue.arg2 = arg2;
            inValue.arg3 = arg3;
            inValue.arg4 = arg4;
            UPCNETUnitTesting.UPCNETServiceAdministrador.editAdministradorResponse retVal = ((UPCNETUnitTesting.UPCNETServiceAdministrador.UPCNETServiceAdministrador)(this)).editAdministrador(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UPCNETUnitTesting.UPCNETServiceAdministrador.editAdministradorResponse> UPCNETUnitTesting.UPCNETServiceAdministrador.UPCNETServiceAdministrador.editAdministradorAsync(UPCNETUnitTesting.UPCNETServiceAdministrador.editAdministradorRequest request) {
            return base.Channel.editAdministradorAsync(request);
        }
        
        public System.Threading.Tasks.Task<UPCNETUnitTesting.UPCNETServiceAdministrador.editAdministradorResponse> editAdministradorAsync(string arg0, string arg1, string arg2, string arg3, string arg4) {
            UPCNETUnitTesting.UPCNETServiceAdministrador.editAdministradorRequest inValue = new UPCNETUnitTesting.UPCNETServiceAdministrador.editAdministradorRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            inValue.arg2 = arg2;
            inValue.arg3 = arg3;
            inValue.arg4 = arg4;
            return ((UPCNETUnitTesting.UPCNETServiceAdministrador.UPCNETServiceAdministrador)(this)).editAdministradorAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPCNETUnitTesting.UPCNETServiceAdministrador.setAdministradorResponse UPCNETUnitTesting.UPCNETServiceAdministrador.UPCNETServiceAdministrador.setAdministrador(UPCNETUnitTesting.UPCNETServiceAdministrador.setAdministradorRequest request) {
            return base.Channel.setAdministrador(request);
        }
        
        public void setAdministrador(string arg0, string arg1, string arg2, string arg3, string arg4) {
            UPCNETUnitTesting.UPCNETServiceAdministrador.setAdministradorRequest inValue = new UPCNETUnitTesting.UPCNETServiceAdministrador.setAdministradorRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            inValue.arg2 = arg2;
            inValue.arg3 = arg3;
            inValue.arg4 = arg4;
            UPCNETUnitTesting.UPCNETServiceAdministrador.setAdministradorResponse retVal = ((UPCNETUnitTesting.UPCNETServiceAdministrador.UPCNETServiceAdministrador)(this)).setAdministrador(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UPCNETUnitTesting.UPCNETServiceAdministrador.setAdministradorResponse> UPCNETUnitTesting.UPCNETServiceAdministrador.UPCNETServiceAdministrador.setAdministradorAsync(UPCNETUnitTesting.UPCNETServiceAdministrador.setAdministradorRequest request) {
            return base.Channel.setAdministradorAsync(request);
        }
        
        public System.Threading.Tasks.Task<UPCNETUnitTesting.UPCNETServiceAdministrador.setAdministradorResponse> setAdministradorAsync(string arg0, string arg1, string arg2, string arg3, string arg4) {
            UPCNETUnitTesting.UPCNETServiceAdministrador.setAdministradorRequest inValue = new UPCNETUnitTesting.UPCNETServiceAdministrador.setAdministradorRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            inValue.arg2 = arg2;
            inValue.arg3 = arg3;
            inValue.arg4 = arg4;
            return ((UPCNETUnitTesting.UPCNETServiceAdministrador.UPCNETServiceAdministrador)(this)).setAdministradorAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorResponse UPCNETUnitTesting.UPCNETServiceAdministrador.UPCNETServiceAdministrador.getAdministrador(UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorRequest request) {
            return base.Channel.getAdministrador(request);
        }
        
        public UPCNETUnitTesting.UPCNETServiceAdministrador.administrador[] getAdministrador() {
            UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorRequest inValue = new UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorRequest();
            UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorResponse retVal = ((UPCNETUnitTesting.UPCNETServiceAdministrador.UPCNETServiceAdministrador)(this)).getAdministrador(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorResponse> UPCNETUnitTesting.UPCNETServiceAdministrador.UPCNETServiceAdministrador.getAdministradorAsync(UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorRequest request) {
            return base.Channel.getAdministradorAsync(request);
        }
        
        public System.Threading.Tasks.Task<UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorResponse> getAdministradorAsync() {
            UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorRequest inValue = new UPCNETUnitTesting.UPCNETServiceAdministrador.getAdministradorRequest();
            return ((UPCNETUnitTesting.UPCNETServiceAdministrador.UPCNETServiceAdministrador)(this)).getAdministradorAsync(inValue);
        }
    }
}