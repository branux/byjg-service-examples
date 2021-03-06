﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3603
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.3603.
// 
#pragma warning disable 1591

namespace SMSSample.br.com.byjg.www {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SMSServiceBinding", Namespace="urn:SMSService")]
    public partial class SMSService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback obterVersaoOperationCompleted;
        
        private System.Threading.SendOrPostCallback enviarSMSOperationCompleted;
        
        private System.Threading.SendOrPostCallback enviarSMS2OperationCompleted;
        
        private System.Threading.SendOrPostCallback enviarListaSMSOperationCompleted;
        
        private System.Threading.SendOrPostCallback recursosOperationCompleted;
        
        private System.Threading.SendOrPostCallback creditosOperationCompleted;
        
        private System.Threading.SendOrPostCallback enviarSMSInternacionalOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SMSService() {
            this.Url = global::SMSSample.Properties.Settings.Default.SMSSample_br_com_byjg_www_SMSService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event obterVersaoCompletedEventHandler obterVersaoCompleted;
        
        /// <remarks/>
        public event enviarSMSCompletedEventHandler enviarSMSCompleted;
        
        /// <remarks/>
        public event enviarSMS2CompletedEventHandler enviarSMS2Completed;
        
        /// <remarks/>
        public event enviarListaSMSCompletedEventHandler enviarListaSMSCompleted;
        
        /// <remarks/>
        public event recursosCompletedEventHandler recursosCompleted;
        
        /// <remarks/>
        public event creditosCompletedEventHandler creditosCompleted;
        
        /// <remarks/>
        public event enviarSMSInternacionalCompletedEventHandler enviarSMSInternacionalCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:SMSServiceAction", RequestNamespace="urn:http://www.byjg.com.br", ResponseNamespace="urn:http://www.byjg.com.br")]
        [return: System.Xml.Serialization.SoapElementAttribute("obterVersaoResponse")]
        public string obterVersao() {
            object[] results = this.Invoke("obterVersao", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void obterVersaoAsync() {
            this.obterVersaoAsync(null);
        }
        
        /// <remarks/>
        public void obterVersaoAsync(object userState) {
            if ((this.obterVersaoOperationCompleted == null)) {
                this.obterVersaoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnobterVersaoOperationCompleted);
            }
            this.InvokeAsync("obterVersao", new object[0], this.obterVersaoOperationCompleted, userState);
        }
        
        private void OnobterVersaoOperationCompleted(object arg) {
            if ((this.obterVersaoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.obterVersaoCompleted(this, new obterVersaoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:SMSServiceAction", RequestNamespace="urn:http://www.byjg.com.br", ResponseNamespace="urn:http://www.byjg.com.br")]
        [return: System.Xml.Serialization.SoapElementAttribute("enviarSMSResponse")]
        public string enviarSMS(string ddd, string celular, string mensagem, string usuario, string senha) {
            object[] results = this.Invoke("enviarSMS", new object[] {
                        ddd,
                        celular,
                        mensagem,
                        usuario,
                        senha});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void enviarSMSAsync(string ddd, string celular, string mensagem, string usuario, string senha) {
            this.enviarSMSAsync(ddd, celular, mensagem, usuario, senha, null);
        }
        
        /// <remarks/>
        public void enviarSMSAsync(string ddd, string celular, string mensagem, string usuario, string senha, object userState) {
            if ((this.enviarSMSOperationCompleted == null)) {
                this.enviarSMSOperationCompleted = new System.Threading.SendOrPostCallback(this.OnenviarSMSOperationCompleted);
            }
            this.InvokeAsync("enviarSMS", new object[] {
                        ddd,
                        celular,
                        mensagem,
                        usuario,
                        senha}, this.enviarSMSOperationCompleted, userState);
        }
        
        private void OnenviarSMSOperationCompleted(object arg) {
            if ((this.enviarSMSCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.enviarSMSCompleted(this, new enviarSMSCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:SMSServiceAction", RequestNamespace="urn:http://www.byjg.com.br", ResponseNamespace="urn:http://www.byjg.com.br")]
        [return: System.Xml.Serialization.SoapElementAttribute("enviarSMS2Response")]
        public string enviarSMS2(string ddd, string celular, string mensagem, string usuario, string senha, string senderid) {
            object[] results = this.Invoke("enviarSMS2", new object[] {
                        ddd,
                        celular,
                        mensagem,
                        usuario,
                        senha,
                        senderid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void enviarSMS2Async(string ddd, string celular, string mensagem, string usuario, string senha, string senderid) {
            this.enviarSMS2Async(ddd, celular, mensagem, usuario, senha, senderid, null);
        }
        
        /// <remarks/>
        public void enviarSMS2Async(string ddd, string celular, string mensagem, string usuario, string senha, string senderid, object userState) {
            if ((this.enviarSMS2OperationCompleted == null)) {
                this.enviarSMS2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnenviarSMS2OperationCompleted);
            }
            this.InvokeAsync("enviarSMS2", new object[] {
                        ddd,
                        celular,
                        mensagem,
                        usuario,
                        senha,
                        senderid}, this.enviarSMS2OperationCompleted, userState);
        }
        
        private void OnenviarSMS2OperationCompleted(object arg) {
            if ((this.enviarSMS2Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.enviarSMS2Completed(this, new enviarSMS2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:SMSServiceAction", RequestNamespace="urn:http://www.byjg.com.br", ResponseNamespace="urn:http://www.byjg.com.br")]
        [return: System.Xml.Serialization.SoapElementAttribute("enviarListaSMSResponse")]
        public string enviarListaSMS(string lista, string mensagem, string usuario, string senha, string senderid) {
            object[] results = this.Invoke("enviarListaSMS", new object[] {
                        lista,
                        mensagem,
                        usuario,
                        senha,
                        senderid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void enviarListaSMSAsync(string lista, string mensagem, string usuario, string senha, string senderid) {
            this.enviarListaSMSAsync(lista, mensagem, usuario, senha, senderid, null);
        }
        
        /// <remarks/>
        public void enviarListaSMSAsync(string lista, string mensagem, string usuario, string senha, string senderid, object userState) {
            if ((this.enviarListaSMSOperationCompleted == null)) {
                this.enviarListaSMSOperationCompleted = new System.Threading.SendOrPostCallback(this.OnenviarListaSMSOperationCompleted);
            }
            this.InvokeAsync("enviarListaSMS", new object[] {
                        lista,
                        mensagem,
                        usuario,
                        senha,
                        senderid}, this.enviarListaSMSOperationCompleted, userState);
        }
        
        private void OnenviarListaSMSOperationCompleted(object arg) {
            if ((this.enviarListaSMSCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.enviarListaSMSCompleted(this, new enviarListaSMSCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:SMSServiceAction", RequestNamespace="urn:http://www.byjg.com.br", ResponseNamespace="urn:http://www.byjg.com.br")]
        [return: System.Xml.Serialization.SoapElementAttribute("recursosResponse")]
        public string recursos(string usuario, string senha) {
            object[] results = this.Invoke("recursos", new object[] {
                        usuario,
                        senha});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void recursosAsync(string usuario, string senha) {
            this.recursosAsync(usuario, senha, null);
        }
        
        /// <remarks/>
        public void recursosAsync(string usuario, string senha, object userState) {
            if ((this.recursosOperationCompleted == null)) {
                this.recursosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnrecursosOperationCompleted);
            }
            this.InvokeAsync("recursos", new object[] {
                        usuario,
                        senha}, this.recursosOperationCompleted, userState);
        }
        
        private void OnrecursosOperationCompleted(object arg) {
            if ((this.recursosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.recursosCompleted(this, new recursosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:SMSServiceAction", RequestNamespace="urn:http://www.byjg.com.br", ResponseNamespace="urn:http://www.byjg.com.br")]
        [return: System.Xml.Serialization.SoapElementAttribute("creditosResponse")]
        public string creditos(string usuario, string senha) {
            object[] results = this.Invoke("creditos", new object[] {
                        usuario,
                        senha});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void creditosAsync(string usuario, string senha) {
            this.creditosAsync(usuario, senha, null);
        }
        
        /// <remarks/>
        public void creditosAsync(string usuario, string senha, object userState) {
            if ((this.creditosOperationCompleted == null)) {
                this.creditosOperationCompleted = new System.Threading.SendOrPostCallback(this.OncreditosOperationCompleted);
            }
            this.InvokeAsync("creditos", new object[] {
                        usuario,
                        senha}, this.creditosOperationCompleted, userState);
        }
        
        private void OncreditosOperationCompleted(object arg) {
            if ((this.creditosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.creditosCompleted(this, new creditosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:SMSServiceAction", RequestNamespace="urn:http://www.byjg.com.br", ResponseNamespace="urn:http://www.byjg.com.br")]
        [return: System.Xml.Serialization.SoapElementAttribute("enviarSMSInternacionalResponse")]
        public string enviarSMSInternacional(string codpais, string ddd, string celular, string mensagem, string usuario, string senha) {
            object[] results = this.Invoke("enviarSMSInternacional", new object[] {
                        codpais,
                        ddd,
                        celular,
                        mensagem,
                        usuario,
                        senha});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void enviarSMSInternacionalAsync(string codpais, string ddd, string celular, string mensagem, string usuario, string senha) {
            this.enviarSMSInternacionalAsync(codpais, ddd, celular, mensagem, usuario, senha, null);
        }
        
        /// <remarks/>
        public void enviarSMSInternacionalAsync(string codpais, string ddd, string celular, string mensagem, string usuario, string senha, object userState) {
            if ((this.enviarSMSInternacionalOperationCompleted == null)) {
                this.enviarSMSInternacionalOperationCompleted = new System.Threading.SendOrPostCallback(this.OnenviarSMSInternacionalOperationCompleted);
            }
            this.InvokeAsync("enviarSMSInternacional", new object[] {
                        codpais,
                        ddd,
                        celular,
                        mensagem,
                        usuario,
                        senha}, this.enviarSMSInternacionalOperationCompleted, userState);
        }
        
        private void OnenviarSMSInternacionalOperationCompleted(object arg) {
            if ((this.enviarSMSInternacionalCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.enviarSMSInternacionalCompleted(this, new enviarSMSInternacionalCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void obterVersaoCompletedEventHandler(object sender, obterVersaoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class obterVersaoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal obterVersaoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void enviarSMSCompletedEventHandler(object sender, enviarSMSCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class enviarSMSCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal enviarSMSCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void enviarSMS2CompletedEventHandler(object sender, enviarSMS2CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class enviarSMS2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal enviarSMS2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void enviarListaSMSCompletedEventHandler(object sender, enviarListaSMSCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class enviarListaSMSCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal enviarListaSMSCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void recursosCompletedEventHandler(object sender, recursosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class recursosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal recursosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void creditosCompletedEventHandler(object sender, creditosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class creditosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal creditosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void enviarSMSInternacionalCompletedEventHandler(object sender, enviarSMSInternacionalCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class enviarSMSInternacionalCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal enviarSMSInternacionalCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591