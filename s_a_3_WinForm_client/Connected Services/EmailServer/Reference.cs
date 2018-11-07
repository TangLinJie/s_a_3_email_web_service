﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace s_a_3_client.EmailServer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://EmailUtils", ConfigurationName="EmailServer.EmailServices")]
    public interface EmailServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="validateEmailAddressReturn")]
        bool validateEmailAddress(string _url);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="validateEmailAddressReturn")]
        System.Threading.Tasks.Task<bool> validateEmailAddressAsync(string _url);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="sendEmailBatchReturn")]
        bool sendEmailBatch(string[] _url, string _payload);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="sendEmailBatchReturn")]
        System.Threading.Tasks.Task<bool> sendEmailBatchAsync(string[] _url, string _payload);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="sendEmailReturn")]
        bool sendEmail(string _url, string _payload);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="sendEmailReturn")]
        System.Threading.Tasks.Task<bool> sendEmailAsync(string _url, string _payload);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EmailServicesChannel : s_a_3_client.EmailServer.EmailServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmailServicesClient : System.ServiceModel.ClientBase<s_a_3_client.EmailServer.EmailServices>, s_a_3_client.EmailServer.EmailServices {
        
        public EmailServicesClient() {
        }
        
        public EmailServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmailServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmailServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmailServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool validateEmailAddress(string _url) {
            return base.Channel.validateEmailAddress(_url);
        }
        
        public System.Threading.Tasks.Task<bool> validateEmailAddressAsync(string _url) {
            return base.Channel.validateEmailAddressAsync(_url);
        }
        
        public bool sendEmailBatch(string[] _url, string _payload) {
            return base.Channel.sendEmailBatch(_url, _payload);
        }
        
        public System.Threading.Tasks.Task<bool> sendEmailBatchAsync(string[] _url, string _payload) {
            return base.Channel.sendEmailBatchAsync(_url, _payload);
        }
        
        public bool sendEmail(string _url, string _payload) {
            return base.Channel.sendEmail(_url, _payload);
        }
        
        public System.Threading.Tasks.Task<bool> sendEmailAsync(string _url, string _payload) {
            return base.Channel.sendEmailAsync(_url, _payload);
        }
    }
}
