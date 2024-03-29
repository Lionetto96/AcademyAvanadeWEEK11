﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/ClassLibrary_Core.Entities")]
    public partial class Employee : object
    {
        
        private string EmployeeCodeField;
        
        private string FirstNameField;
        
        private string IdField;
        
        private string LastNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmployeeCode
        {
            get
            {
                return this.EmployeeCodeField;
            }
            set
            {
                this.EmployeeCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeService.IEmployeeService")]
    public interface IEmployeeService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployee", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeResponse")]
        EmployeeService.Employee GetEmployee(string firstName, string lastname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployee", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeResponse")]
        System.Threading.Tasks.Task<EmployeeService.Employee> GetEmployeeAsync(string firstName, string lastname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/AddEmployee", ReplyAction="http://tempuri.org/IEmployeeService/AddEmployeeResponse")]
        bool AddEmployee(EmployeeService.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/AddEmployee", ReplyAction="http://tempuri.org/IEmployeeService/AddEmployeeResponse")]
        System.Threading.Tasks.Task<bool> AddEmployeeAsync(EmployeeService.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployees", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeesResponse")]
        System.Collections.Generic.List<EmployeeService.Employee> GetEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployees", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<EmployeeService.Employee>> GetEmployeesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface IEmployeeServiceChannel : EmployeeService.IEmployeeService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<EmployeeService.IEmployeeService>, EmployeeService.IEmployeeService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public EmployeeServiceClient() : 
                base(EmployeeServiceClient.GetDefaultBinding(), EmployeeServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IEmployeeService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EmployeeServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(EmployeeServiceClient.GetBindingForEndpoint(endpointConfiguration), EmployeeServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EmployeeServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(EmployeeServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EmployeeServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(EmployeeServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public EmployeeService.Employee GetEmployee(string firstName, string lastname)
        {
            return base.Channel.GetEmployee(firstName, lastname);
        }
        
        public System.Threading.Tasks.Task<EmployeeService.Employee> GetEmployeeAsync(string firstName, string lastname)
        {
            return base.Channel.GetEmployeeAsync(firstName, lastname);
        }
        
        public bool AddEmployee(EmployeeService.Employee employee)
        {
            return base.Channel.AddEmployee(employee);
        }
        
        public System.Threading.Tasks.Task<bool> AddEmployeeAsync(EmployeeService.Employee employee)
        {
            return base.Channel.AddEmployeeAsync(employee);
        }
        
        public System.Collections.Generic.List<EmployeeService.Employee> GetEmployees()
        {
            return base.Channel.GetEmployees();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<EmployeeService.Employee>> GetEmployeesAsync()
        {
            return base.Channel.GetEmployeesAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IEmployeeService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IEmployeeService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary1/EmployeeService/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return EmployeeServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IEmployeeService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return EmployeeServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IEmployeeService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IEmployeeService,
        }
    }
}
