﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.FirstWebServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FirstWebServiceReference.IHelloWorldservice")]
    public interface IHelloWorldservice {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWorldservice/Message", ReplyAction="http://tempuri.org/IHelloWorldservice/MessageResponse")]
        string Message();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWorldservice/Message", ReplyAction="http://tempuri.org/IHelloWorldservice/MessageResponse")]
        System.Threading.Tasks.Task<string> MessageAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWorldservice/add", ReplyAction="http://tempuri.org/IHelloWorldservice/addResponse")]
        int add(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWorldservice/add", ReplyAction="http://tempuri.org/IHelloWorldservice/addResponse")]
        System.Threading.Tasks.Task<int> addAsync(int x, int y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHelloWorldserviceChannel : Client.FirstWebServiceReference.IHelloWorldservice, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloWorldserviceClient : System.ServiceModel.ClientBase<Client.FirstWebServiceReference.IHelloWorldservice>, Client.FirstWebServiceReference.IHelloWorldservice {
        
        public HelloWorldserviceClient() {
        }
        
        public HelloWorldserviceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloWorldserviceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldserviceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldserviceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Message() {
            return base.Channel.Message();
        }
        
        public System.Threading.Tasks.Task<string> MessageAsync() {
            return base.Channel.MessageAsync();
        }
        
        public int add(int x, int y) {
            return base.Channel.add(x, y);
        }
        
        public System.Threading.Tasks.Task<int> addAsync(int x, int y) {
            return base.Channel.addAsync(x, y);
        }
    }
}
