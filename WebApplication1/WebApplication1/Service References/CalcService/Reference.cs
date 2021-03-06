﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.CalcService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalcService.ISummatorService")]
    public interface ISummatorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISummatorService/GetSum", ReplyAction="http://tempuri.org/ISummatorService/GetSumResponse")]
        int GetSum(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISummatorService/GetSum", ReplyAction="http://tempuri.org/ISummatorService/GetSumResponse")]
        System.Threading.Tasks.Task<int> GetSumAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISummatorServiceChannel : WebApplication1.CalcService.ISummatorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SummatorServiceClient : System.ServiceModel.ClientBase<WebApplication1.CalcService.ISummatorService>, WebApplication1.CalcService.ISummatorService {
        
        public SummatorServiceClient() {
        }
        
        public SummatorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SummatorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SummatorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SummatorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetSum(int a, int b) {
            return base.Channel.GetSum(a, b);
        }
        
        public System.Threading.Tasks.Task<int> GetSumAsync(int a, int b) {
            return base.Channel.GetSumAsync(a, b);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalcService.IMultiplicatorService")]
    public interface IMultiplicatorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMultiplicatorService/GetMult", ReplyAction="http://tempuri.org/IMultiplicatorService/GetMultResponse")]
        int GetMult(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMultiplicatorService/GetMult", ReplyAction="http://tempuri.org/IMultiplicatorService/GetMultResponse")]
        System.Threading.Tasks.Task<int> GetMultAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMultiplicatorServiceChannel : WebApplication1.CalcService.IMultiplicatorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MultiplicatorServiceClient : System.ServiceModel.ClientBase<WebApplication1.CalcService.IMultiplicatorService>, WebApplication1.CalcService.IMultiplicatorService {
        
        public MultiplicatorServiceClient() {
        }
        
        public MultiplicatorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MultiplicatorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MultiplicatorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MultiplicatorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetMult(int a, int b) {
            return base.Channel.GetMult(a, b);
        }
        
        public System.Threading.Tasks.Task<int> GetMultAsync(int a, int b) {
            return base.Channel.GetMultAsync(a, b);
        }
    }
}
