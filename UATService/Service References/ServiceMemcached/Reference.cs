﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UATService.ServiceMemcached {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceMemcached.ClientServiceSoap")]
    public interface ClientServiceSoap {
        
        // CODEGEN: Generating message contract since element name requestXML from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Request", ReplyAction="*")]
        UATService.ServiceMemcached.RequestResponse Request(UATService.ServiceMemcached.RequestRequest request);
        
        // CODEGEN: Generating message contract since element name requestXML from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CommRequest", ReplyAction="*")]
        UATService.ServiceMemcached.CommRequestResponse CommRequest(UATService.ServiceMemcached.CommRequestRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RequestRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Request", Namespace="http://tempuri.org/", Order=0)]
        public UATService.ServiceMemcached.RequestRequestBody Body;
        
        public RequestRequest() {
        }
        
        public RequestRequest(UATService.ServiceMemcached.RequestRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RequestRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string requestXML;
        
        public RequestRequestBody() {
        }
        
        public RequestRequestBody(string requestXML) {
            this.requestXML = requestXML;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RequestResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RequestResponse", Namespace="http://tempuri.org/", Order=0)]
        public UATService.ServiceMemcached.RequestResponseBody Body;
        
        public RequestResponse() {
        }
        
        public RequestResponse(UATService.ServiceMemcached.RequestResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RequestResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string RequestResult;
        
        public RequestResponseBody() {
        }
        
        public RequestResponseBody(string RequestResult) {
            this.RequestResult = RequestResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CommRequestRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CommRequest", Namespace="http://tempuri.org/", Order=0)]
        public UATService.ServiceMemcached.CommRequestRequestBody Body;
        
        public CommRequestRequest() {
        }
        
        public CommRequestRequest(UATService.ServiceMemcached.CommRequestRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CommRequestRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string requestXML;
        
        public CommRequestRequestBody() {
        }
        
        public CommRequestRequestBody(string requestXML) {
            this.requestXML = requestXML;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CommRequestResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CommRequestResponse", Namespace="http://tempuri.org/", Order=0)]
        public UATService.ServiceMemcached.CommRequestResponseBody Body;
        
        public CommRequestResponse() {
        }
        
        public CommRequestResponse(UATService.ServiceMemcached.CommRequestResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CommRequestResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CommRequestResult;
        
        public CommRequestResponseBody() {
        }
        
        public CommRequestResponseBody(string CommRequestResult) {
            this.CommRequestResult = CommRequestResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ClientServiceSoapChannel : UATService.ServiceMemcached.ClientServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClientServiceSoapClient : System.ServiceModel.ClientBase<UATService.ServiceMemcached.ClientServiceSoap>, UATService.ServiceMemcached.ClientServiceSoap {
        
        public ClientServiceSoapClient() {
        }
        
        public ClientServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClientServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UATService.ServiceMemcached.RequestResponse UATService.ServiceMemcached.ClientServiceSoap.Request(UATService.ServiceMemcached.RequestRequest request) {
            return base.Channel.Request(request);
        }
        
        public string Request(string requestXML) {
            UATService.ServiceMemcached.RequestRequest inValue = new UATService.ServiceMemcached.RequestRequest();
            inValue.Body = new UATService.ServiceMemcached.RequestRequestBody();
            inValue.Body.requestXML = requestXML;
            UATService.ServiceMemcached.RequestResponse retVal = ((UATService.ServiceMemcached.ClientServiceSoap)(this)).Request(inValue);
            return retVal.Body.RequestResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UATService.ServiceMemcached.CommRequestResponse UATService.ServiceMemcached.ClientServiceSoap.CommRequest(UATService.ServiceMemcached.CommRequestRequest request) {
            return base.Channel.CommRequest(request);
        }
        
        public string CommRequest(string requestXML) {
            UATService.ServiceMemcached.CommRequestRequest inValue = new UATService.ServiceMemcached.CommRequestRequest();
            inValue.Body = new UATService.ServiceMemcached.CommRequestRequestBody();
            inValue.Body.requestXML = requestXML;
            UATService.ServiceMemcached.CommRequestResponse retVal = ((UATService.ServiceMemcached.ClientServiceSoap)(this)).CommRequest(inValue);
            return retVal.Body.CommRequestResult;
        }
    }
}