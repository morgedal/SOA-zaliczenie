﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Editor.LexerService {
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ETokenType", Namespace="http://schemas.datacontract.org/2004/07/Services")]
    public enum ETokenType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        E_KEYWORD = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        E_ID = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        E_NUMBER = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        E_STRING = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        E_ROUND_BRACKET = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        E_CURLY_BRACKET = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        E_SQUARE_BRACKET = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        E_SEMICOLON = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        E_UNARY_FRONT_OPERATOR = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        E_UNARY_BACK_OPERATOR = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        E_BINARY_OPERATOR = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        E_COMMENT = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        E_ERROR = 12,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        E_EMPTY = 13,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LexerService.ILexerService")]
    public interface ILexerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILexerService/GetTokenList", ReplyAction="http://tempuri.org/ILexerService/GetTokenListResponse")]
        System.Collections.Generic.KeyValuePair<string, Editor.LexerService.ETokenType>[] GetTokenList(string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILexerService/GetTokenList", ReplyAction="http://tempuri.org/ILexerService/GetTokenListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.KeyValuePair<string, Editor.LexerService.ETokenType>[]> GetTokenListAsync(string code);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILexerServiceChannel : Editor.LexerService.ILexerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LexerServiceClient : System.ServiceModel.ClientBase<Editor.LexerService.ILexerService>, Editor.LexerService.ILexerService {
        
        public LexerServiceClient() {
        }
        
        public LexerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LexerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LexerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LexerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.KeyValuePair<string, Editor.LexerService.ETokenType>[] GetTokenList(string code) {
            return base.Channel.GetTokenList(code);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.KeyValuePair<string, Editor.LexerService.ETokenType>[]> GetTokenListAsync(string code) {
            return base.Channel.GetTokenListAsync(code);
        }
    }
}
