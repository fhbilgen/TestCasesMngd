﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuggerNet.DemoServiceClient {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DemoServiceClient.IDemoService")]
    public interface IDemoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/GetHostName", ReplyAction="http://tempuri.org/IDemoService/GetHostNameResponse")]
        string GetHostName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/GetHostName", ReplyAction="http://tempuri.org/IDemoService/GetHostNameResponse")]
        System.Threading.Tasks.Task<string> GetHostNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/Echo", ReplyAction="http://tempuri.org/IDemoService/EchoResponse")]
        string Echo(string strInput);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/Echo", ReplyAction="http://tempuri.org/IDemoService/EchoResponse")]
        System.Threading.Tasks.Task<string> EchoAsync(string strInput);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/Ping", ReplyAction="http://tempuri.org/IDemoService/PingResponse")]
        string Ping();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/Ping", ReplyAction="http://tempuri.org/IDemoService/PingResponse")]
        System.Threading.Tasks.Task<string> PingAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/GetHostTime", ReplyAction="http://tempuri.org/IDemoService/GetHostTimeResponse")]
        System.DateTime GetHostTime();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/GetHostTime", ReplyAction="http://tempuri.org/IDemoService/GetHostTimeResponse")]
        System.Threading.Tasks.Task<System.DateTime> GetHostTimeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/CauseException", ReplyAction="http://tempuri.org/IDemoService/CauseExceptionResponse")]
        void CauseException();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/CauseException", ReplyAction="http://tempuri.org/IDemoService/CauseExceptionResponse")]
        System.Threading.Tasks.Task CauseExceptionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/NeverReturn", ReplyAction="http://tempuri.org/IDemoService/NeverReturnResponse")]
        void NeverReturn();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/NeverReturn", ReplyAction="http://tempuri.org/IDemoService/NeverReturnResponse")]
        System.Threading.Tasks.Task NeverReturnAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/GuessGender", ReplyAction="http://tempuri.org/IDemoService/GuessGenderResponse")]
        BuggerNetSvc.Sex GuessGender(BuggerNetSvc.PersonInfo pi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/GuessGender", ReplyAction="http://tempuri.org/IDemoService/GuessGenderResponse")]
        System.Threading.Tasks.Task<BuggerNetSvc.Sex> GuessGenderAsync(BuggerNetSvc.PersonInfo pi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/GetPerson", ReplyAction="http://tempuri.org/IDemoService/GetPersonResponse")]
        BuggerNetSvc.PersonInfo GetPerson();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/GetPerson", ReplyAction="http://tempuri.org/IDemoService/GetPersonResponse")]
        System.Threading.Tasks.Task<BuggerNetSvc.PersonInfo> GetPersonAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/Delay", ReplyAction="http://tempuri.org/IDemoService/DelayResponse")]
        void Delay(int Duration);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/Delay", ReplyAction="http://tempuri.org/IDemoService/DelayResponse")]
        System.Threading.Tasks.Task DelayAsync(int Duration);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDemoServiceChannel : BuggerNet.DemoServiceClient.IDemoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DemoServiceClient : System.ServiceModel.ClientBase<BuggerNet.DemoServiceClient.IDemoService>, BuggerNet.DemoServiceClient.IDemoService {
        
        public DemoServiceClient() {
        }
        
        public DemoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DemoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DemoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DemoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetHostName() {
            return base.Channel.GetHostName();
        }
        
        public System.Threading.Tasks.Task<string> GetHostNameAsync() {
            return base.Channel.GetHostNameAsync();
        }
        
        public string Echo(string strInput) {
            return base.Channel.Echo(strInput);
        }
        
        public System.Threading.Tasks.Task<string> EchoAsync(string strInput) {
            return base.Channel.EchoAsync(strInput);
        }
        
        public string Ping() {
            return base.Channel.Ping();
        }
        
        public System.Threading.Tasks.Task<string> PingAsync() {
            return base.Channel.PingAsync();
        }
        
        public System.DateTime GetHostTime() {
            return base.Channel.GetHostTime();
        }
        
        public System.Threading.Tasks.Task<System.DateTime> GetHostTimeAsync() {
            return base.Channel.GetHostTimeAsync();
        }
        
        public void CauseException() {
            base.Channel.CauseException();
        }
        
        public System.Threading.Tasks.Task CauseExceptionAsync() {
            return base.Channel.CauseExceptionAsync();
        }
        
        public void NeverReturn() {
            base.Channel.NeverReturn();
        }
        
        public System.Threading.Tasks.Task NeverReturnAsync() {
            return base.Channel.NeverReturnAsync();
        }
        
        public BuggerNetSvc.Sex GuessGender(BuggerNetSvc.PersonInfo pi) {
            return base.Channel.GuessGender(pi);
        }
        
        public System.Threading.Tasks.Task<BuggerNetSvc.Sex> GuessGenderAsync(BuggerNetSvc.PersonInfo pi) {
            return base.Channel.GuessGenderAsync(pi);
        }
        
        public BuggerNetSvc.PersonInfo GetPerson() {
            return base.Channel.GetPerson();
        }
        
        public System.Threading.Tasks.Task<BuggerNetSvc.PersonInfo> GetPersonAsync() {
            return base.Channel.GetPersonAsync();
        }
        
        public void Delay(int Duration) {
            base.Channel.Delay(Duration);
        }
        
        public System.Threading.Tasks.Task DelayAsync(int Duration) {
            return base.Channel.DelayAsync(Duration);
        }
    }
}
