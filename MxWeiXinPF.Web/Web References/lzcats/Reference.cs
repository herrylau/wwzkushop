﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.17929
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.17929 版自动生成。
// 
#pragma warning disable 1591

namespace MxWeiXinPF.Web.lzcats {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ILzServicesSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(object[]))]
    public partial class ILzServices : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback LZ_GetBlanceOperationCompleted;
        
        private System.Threading.SendOrPostCallback LZ_EditPwdOperationCompleted;
        
        private System.Threading.SendOrPostCallback LZ_SendSmsOperationCompleted;
        
        private System.Threading.SendOrPostCallback LZ_SendSmsDOperationCompleted;
        
        private System.Threading.SendOrPostCallback LZ_GetReportsOperationCompleted;
        
        private System.Threading.SendOrPostCallback LZ_GetReceiveOperationCompleted;
        
        private System.Threading.SendOrPostCallback LZ_SetSignLoginOperationCompleted;
        
        private System.Threading.SendOrPostCallback LZ_SetSignLoginCancelOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ILzServices() {
            this.Url = global::MxWeiXinPF.Web.Properties.Settings.Default.MxWeiXinPF_Web_lzcats_ILzServices;
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
        public event LZ_GetBlanceCompletedEventHandler LZ_GetBlanceCompleted;
        
        /// <remarks/>
        public event LZ_EditPwdCompletedEventHandler LZ_EditPwdCompleted;
        
        /// <remarks/>
        public event LZ_SendSmsCompletedEventHandler LZ_SendSmsCompleted;
        
        /// <remarks/>
        public event LZ_SendSmsDCompletedEventHandler LZ_SendSmsDCompleted;
        
        /// <remarks/>
        public event LZ_GetReportsCompletedEventHandler LZ_GetReportsCompleted;
        
        /// <remarks/>
        public event LZ_GetReceiveCompletedEventHandler LZ_GetReceiveCompleted;
        
        /// <remarks/>
        public event LZ_SetSignLoginCompletedEventHandler LZ_SetSignLoginCompleted;
        
        /// <remarks/>
        public event LZ_SetSignLoginCancelCompletedEventHandler LZ_SetSignLoginCancelCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/LZ_GetBlance", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string LZ_GetBlance(string loginname, string password) {
            object[] results = this.Invoke("LZ_GetBlance", new object[] {
                        loginname,
                        password});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void LZ_GetBlanceAsync(string loginname, string password) {
            this.LZ_GetBlanceAsync(loginname, password, null);
        }
        
        /// <remarks/>
        public void LZ_GetBlanceAsync(string loginname, string password, object userState) {
            if ((this.LZ_GetBlanceOperationCompleted == null)) {
                this.LZ_GetBlanceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLZ_GetBlanceOperationCompleted);
            }
            this.InvokeAsync("LZ_GetBlance", new object[] {
                        loginname,
                        password}, this.LZ_GetBlanceOperationCompleted, userState);
        }
        
        private void OnLZ_GetBlanceOperationCompleted(object arg) {
            if ((this.LZ_GetBlanceCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LZ_GetBlanceCompleted(this, new LZ_GetBlanceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/LZ_EditPwd", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string LZ_EditPwd(string loginname, string password, string newpwd) {
            object[] results = this.Invoke("LZ_EditPwd", new object[] {
                        loginname,
                        password,
                        newpwd});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void LZ_EditPwdAsync(string loginname, string password, string newpwd) {
            this.LZ_EditPwdAsync(loginname, password, newpwd, null);
        }
        
        /// <remarks/>
        public void LZ_EditPwdAsync(string loginname, string password, string newpwd, object userState) {
            if ((this.LZ_EditPwdOperationCompleted == null)) {
                this.LZ_EditPwdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLZ_EditPwdOperationCompleted);
            }
            this.InvokeAsync("LZ_EditPwd", new object[] {
                        loginname,
                        password,
                        newpwd}, this.LZ_EditPwdOperationCompleted, userState);
        }
        
        private void OnLZ_EditPwdOperationCompleted(object arg) {
            if ((this.LZ_EditPwdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LZ_EditPwdCompleted(this, new LZ_EditPwdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/LZ_SendSms", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string LZ_SendSms(string loginname, string password, string telphone, string content, string dsdate) {
            object[] results = this.Invoke("LZ_SendSms", new object[] {
                        loginname,
                        password,
                        telphone,
                        content,
                        dsdate});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void LZ_SendSmsAsync(string loginname, string password, string telphone, string content, string dsdate) {
            this.LZ_SendSmsAsync(loginname, password, telphone, content, dsdate, null);
        }
        
        /// <remarks/>
        public void LZ_SendSmsAsync(string loginname, string password, string telphone, string content, string dsdate, object userState) {
            if ((this.LZ_SendSmsOperationCompleted == null)) {
                this.LZ_SendSmsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLZ_SendSmsOperationCompleted);
            }
            this.InvokeAsync("LZ_SendSms", new object[] {
                        loginname,
                        password,
                        telphone,
                        content,
                        dsdate}, this.LZ_SendSmsOperationCompleted, userState);
        }
        
        private void OnLZ_SendSmsOperationCompleted(object arg) {
            if ((this.LZ_SendSmsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LZ_SendSmsCompleted(this, new LZ_SendSmsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/LZ_SendSmsD", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string LZ_SendSmsD(string loginname, string password, string telphone, string content, string dsdate, string dm) {
            object[] results = this.Invoke("LZ_SendSmsD", new object[] {
                        loginname,
                        password,
                        telphone,
                        content,
                        dsdate,
                        dm});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void LZ_SendSmsDAsync(string loginname, string password, string telphone, string content, string dsdate, string dm) {
            this.LZ_SendSmsDAsync(loginname, password, telphone, content, dsdate, dm, null);
        }
        
        /// <remarks/>
        public void LZ_SendSmsDAsync(string loginname, string password, string telphone, string content, string dsdate, string dm, object userState) {
            if ((this.LZ_SendSmsDOperationCompleted == null)) {
                this.LZ_SendSmsDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLZ_SendSmsDOperationCompleted);
            }
            this.InvokeAsync("LZ_SendSmsD", new object[] {
                        loginname,
                        password,
                        telphone,
                        content,
                        dsdate,
                        dm}, this.LZ_SendSmsDOperationCompleted, userState);
        }
        
        private void OnLZ_SendSmsDOperationCompleted(object arg) {
            if ((this.LZ_SendSmsDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LZ_SendSmsDCompleted(this, new LZ_SendSmsDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/LZ_GetReports", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string LZ_GetReports(string loginname, string password) {
            object[] results = this.Invoke("LZ_GetReports", new object[] {
                        loginname,
                        password});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void LZ_GetReportsAsync(string loginname, string password) {
            this.LZ_GetReportsAsync(loginname, password, null);
        }
        
        /// <remarks/>
        public void LZ_GetReportsAsync(string loginname, string password, object userState) {
            if ((this.LZ_GetReportsOperationCompleted == null)) {
                this.LZ_GetReportsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLZ_GetReportsOperationCompleted);
            }
            this.InvokeAsync("LZ_GetReports", new object[] {
                        loginname,
                        password}, this.LZ_GetReportsOperationCompleted, userState);
        }
        
        private void OnLZ_GetReportsOperationCompleted(object arg) {
            if ((this.LZ_GetReportsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LZ_GetReportsCompleted(this, new LZ_GetReportsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/LZ_GetReceive", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public object[] LZ_GetReceive(string loginname, string password) {
            object[] results = this.Invoke("LZ_GetReceive", new object[] {
                        loginname,
                        password});
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        public void LZ_GetReceiveAsync(string loginname, string password) {
            this.LZ_GetReceiveAsync(loginname, password, null);
        }
        
        /// <remarks/>
        public void LZ_GetReceiveAsync(string loginname, string password, object userState) {
            if ((this.LZ_GetReceiveOperationCompleted == null)) {
                this.LZ_GetReceiveOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLZ_GetReceiveOperationCompleted);
            }
            this.InvokeAsync("LZ_GetReceive", new object[] {
                        loginname,
                        password}, this.LZ_GetReceiveOperationCompleted, userState);
        }
        
        private void OnLZ_GetReceiveOperationCompleted(object arg) {
            if ((this.LZ_GetReceiveCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LZ_GetReceiveCompleted(this, new LZ_GetReceiveCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/LZ_SetSignLogin", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string LZ_SetSignLogin(string SignKey) {
            object[] results = this.Invoke("LZ_SetSignLogin", new object[] {
                        SignKey});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void LZ_SetSignLoginAsync(string SignKey) {
            this.LZ_SetSignLoginAsync(SignKey, null);
        }
        
        /// <remarks/>
        public void LZ_SetSignLoginAsync(string SignKey, object userState) {
            if ((this.LZ_SetSignLoginOperationCompleted == null)) {
                this.LZ_SetSignLoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLZ_SetSignLoginOperationCompleted);
            }
            this.InvokeAsync("LZ_SetSignLogin", new object[] {
                        SignKey}, this.LZ_SetSignLoginOperationCompleted, userState);
        }
        
        private void OnLZ_SetSignLoginOperationCompleted(object arg) {
            if ((this.LZ_SetSignLoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LZ_SetSignLoginCompleted(this, new LZ_SetSignLoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/LZ_SetSignLoginCancel", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string LZ_SetSignLoginCancel(string SignKey) {
            object[] results = this.Invoke("LZ_SetSignLoginCancel", new object[] {
                        SignKey});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void LZ_SetSignLoginCancelAsync(string SignKey) {
            this.LZ_SetSignLoginCancelAsync(SignKey, null);
        }
        
        /// <remarks/>
        public void LZ_SetSignLoginCancelAsync(string SignKey, object userState) {
            if ((this.LZ_SetSignLoginCancelOperationCompleted == null)) {
                this.LZ_SetSignLoginCancelOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLZ_SetSignLoginCancelOperationCompleted);
            }
            this.InvokeAsync("LZ_SetSignLoginCancel", new object[] {
                        SignKey}, this.LZ_SetSignLoginCancelOperationCompleted, userState);
        }
        
        private void OnLZ_SetSignLoginCancelOperationCompleted(object arg) {
            if ((this.LZ_SetSignLoginCancelCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LZ_SetSignLoginCancelCompleted(this, new LZ_SetSignLoginCancelCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void LZ_GetBlanceCompletedEventHandler(object sender, LZ_GetBlanceCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LZ_GetBlanceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LZ_GetBlanceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void LZ_EditPwdCompletedEventHandler(object sender, LZ_EditPwdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LZ_EditPwdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LZ_EditPwdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void LZ_SendSmsCompletedEventHandler(object sender, LZ_SendSmsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LZ_SendSmsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LZ_SendSmsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void LZ_SendSmsDCompletedEventHandler(object sender, LZ_SendSmsDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LZ_SendSmsDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LZ_SendSmsDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void LZ_GetReportsCompletedEventHandler(object sender, LZ_GetReportsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LZ_GetReportsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LZ_GetReportsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void LZ_GetReceiveCompletedEventHandler(object sender, LZ_GetReceiveCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LZ_GetReceiveCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LZ_GetReceiveCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public object[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((object[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void LZ_SetSignLoginCompletedEventHandler(object sender, LZ_SetSignLoginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LZ_SetSignLoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LZ_SetSignLoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void LZ_SetSignLoginCancelCompletedEventHandler(object sender, LZ_SetSignLoginCancelCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LZ_SetSignLoginCancelCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LZ_SetSignLoginCancelCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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