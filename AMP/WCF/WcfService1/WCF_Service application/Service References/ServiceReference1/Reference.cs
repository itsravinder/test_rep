﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Service_application.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.test_webserviceSoap")]
    public interface test_webserviceSoap {
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sayHello", ReplyAction="*")]
        WCF_Service_application.ServiceReference1.sayHelloResponse sayHello(WCF_Service_application.ServiceReference1.sayHelloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sayHello", ReplyAction="*")]
        System.Threading.Tasks.Task<WCF_Service_application.ServiceReference1.sayHelloResponse> sayHelloAsync(WCF_Service_application.ServiceReference1.sayHelloRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class sayHelloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="sayHello", Namespace="http://tempuri.org/", Order=0)]
        public WCF_Service_application.ServiceReference1.sayHelloRequestBody Body;
        
        public sayHelloRequest() {
        }
        
        public sayHelloRequest(WCF_Service_application.ServiceReference1.sayHelloRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class sayHelloRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        public sayHelloRequestBody() {
        }
        
        public sayHelloRequestBody(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class sayHelloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="sayHelloResponse", Namespace="http://tempuri.org/", Order=0)]
        public WCF_Service_application.ServiceReference1.sayHelloResponseBody Body;
        
        public sayHelloResponse() {
        }
        
        public sayHelloResponse(WCF_Service_application.ServiceReference1.sayHelloResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class sayHelloResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sayHelloResult;
        
        public sayHelloResponseBody() {
        }
        
        public sayHelloResponseBody(string sayHelloResult) {
            this.sayHelloResult = sayHelloResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface test_webserviceSoapChannel : WCF_Service_application.ServiceReference1.test_webserviceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class test_webserviceSoapClient : System.ServiceModel.ClientBase<WCF_Service_application.ServiceReference1.test_webserviceSoap>, WCF_Service_application.ServiceReference1.test_webserviceSoap {
        
        public test_webserviceSoapClient() {
        }
        
        public test_webserviceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public test_webserviceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public test_webserviceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public test_webserviceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WCF_Service_application.ServiceReference1.sayHelloResponse WCF_Service_application.ServiceReference1.test_webserviceSoap.sayHello(WCF_Service_application.ServiceReference1.sayHelloRequest request) {
            return base.Channel.sayHello(request);
        }
        
        public string sayHello(string name) {
            WCF_Service_application.ServiceReference1.sayHelloRequest inValue = new WCF_Service_application.ServiceReference1.sayHelloRequest();
            inValue.Body = new WCF_Service_application.ServiceReference1.sayHelloRequestBody();
            inValue.Body.name = name;
            WCF_Service_application.ServiceReference1.sayHelloResponse retVal = ((WCF_Service_application.ServiceReference1.test_webserviceSoap)(this)).sayHello(inValue);
            return retVal.Body.sayHelloResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WCF_Service_application.ServiceReference1.sayHelloResponse> WCF_Service_application.ServiceReference1.test_webserviceSoap.sayHelloAsync(WCF_Service_application.ServiceReference1.sayHelloRequest request) {
            return base.Channel.sayHelloAsync(request);
        }
        
        public System.Threading.Tasks.Task<WCF_Service_application.ServiceReference1.sayHelloResponse> sayHelloAsync(string name) {
            WCF_Service_application.ServiceReference1.sayHelloRequest inValue = new WCF_Service_application.ServiceReference1.sayHelloRequest();
            inValue.Body = new WCF_Service_application.ServiceReference1.sayHelloRequestBody();
            inValue.Body.name = name;
            return ((WCF_Service_application.ServiceReference1.test_webserviceSoap)(this)).sayHelloAsync(inValue);
        }
    }
}