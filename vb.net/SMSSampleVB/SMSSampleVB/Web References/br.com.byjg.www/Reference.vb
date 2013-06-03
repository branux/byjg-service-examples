﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3603
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.3603.
'
Namespace br.com.byjg.www
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="SMSServiceBinding", [Namespace]:="urn:SMSService")>  _
    Partial Public Class SMSService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private obterVersaoOperationCompleted As System.Threading.SendOrPostCallback
        
        Private enviarSMSOperationCompleted As System.Threading.SendOrPostCallback
        
        Private enviarSMS2OperationCompleted As System.Threading.SendOrPostCallback
        
        Private enviarListaSMSOperationCompleted As System.Threading.SendOrPostCallback
        
        Private recursosOperationCompleted As System.Threading.SendOrPostCallback
        
        Private creditosOperationCompleted As System.Threading.SendOrPostCallback
        
        Private enviarSMSInternacionalOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.SMSSampleVB.My.MySettings.Default.SMSSampleVB_br_com_byjg_www_SMSService
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event obterVersaoCompleted As obterVersaoCompletedEventHandler
        
        '''<remarks/>
        Public Event enviarSMSCompleted As enviarSMSCompletedEventHandler
        
        '''<remarks/>
        Public Event enviarSMS2Completed As enviarSMS2CompletedEventHandler
        
        '''<remarks/>
        Public Event enviarListaSMSCompleted As enviarListaSMSCompletedEventHandler
        
        '''<remarks/>
        Public Event recursosCompleted As recursosCompletedEventHandler
        
        '''<remarks/>
        Public Event creditosCompleted As creditosCompletedEventHandler
        
        '''<remarks/>
        Public Event enviarSMSInternacionalCompleted As enviarSMSInternacionalCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:SMSServiceAction", RequestNamespace:="urn:http://www.byjg.com.br", ResponseNamespace:="urn:http://www.byjg.com.br")>  _
        Public Function obterVersao() As <System.Xml.Serialization.SoapElementAttribute("obterVersaoResponse")> String
            Dim results() As Object = Me.Invoke("obterVersao", New Object(-1) {})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub obterVersaoAsync()
            Me.obterVersaoAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub obterVersaoAsync(ByVal userState As Object)
            If (Me.obterVersaoOperationCompleted Is Nothing) Then
                Me.obterVersaoOperationCompleted = AddressOf Me.OnobterVersaoOperationCompleted
            End If
            Me.InvokeAsync("obterVersao", New Object(-1) {}, Me.obterVersaoOperationCompleted, userState)
        End Sub
        
        Private Sub OnobterVersaoOperationCompleted(ByVal arg As Object)
            If (Not (Me.obterVersaoCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent obterVersaoCompleted(Me, New obterVersaoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:SMSServiceAction", RequestNamespace:="urn:http://www.byjg.com.br", ResponseNamespace:="urn:http://www.byjg.com.br")>  _
        Public Function enviarSMS(ByVal ddd As String, ByVal celular As String, ByVal mensagem As String, ByVal usuario As String, ByVal senha As String) As <System.Xml.Serialization.SoapElementAttribute("enviarSMSResponse")> String
            Dim results() As Object = Me.Invoke("enviarSMS", New Object() {ddd, celular, mensagem, usuario, senha})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub enviarSMSAsync(ByVal ddd As String, ByVal celular As String, ByVal mensagem As String, ByVal usuario As String, ByVal senha As String)
            Me.enviarSMSAsync(ddd, celular, mensagem, usuario, senha, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub enviarSMSAsync(ByVal ddd As String, ByVal celular As String, ByVal mensagem As String, ByVal usuario As String, ByVal senha As String, ByVal userState As Object)
            If (Me.enviarSMSOperationCompleted Is Nothing) Then
                Me.enviarSMSOperationCompleted = AddressOf Me.OnenviarSMSOperationCompleted
            End If
            Me.InvokeAsync("enviarSMS", New Object() {ddd, celular, mensagem, usuario, senha}, Me.enviarSMSOperationCompleted, userState)
        End Sub
        
        Private Sub OnenviarSMSOperationCompleted(ByVal arg As Object)
            If (Not (Me.enviarSMSCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent enviarSMSCompleted(Me, New enviarSMSCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:SMSServiceAction", RequestNamespace:="urn:http://www.byjg.com.br", ResponseNamespace:="urn:http://www.byjg.com.br")>  _
        Public Function enviarSMS2(ByVal ddd As String, ByVal celular As String, ByVal mensagem As String, ByVal usuario As String, ByVal senha As String, ByVal senderid As String) As <System.Xml.Serialization.SoapElementAttribute("enviarSMS2Response")> String
            Dim results() As Object = Me.Invoke("enviarSMS2", New Object() {ddd, celular, mensagem, usuario, senha, senderid})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub enviarSMS2Async(ByVal ddd As String, ByVal celular As String, ByVal mensagem As String, ByVal usuario As String, ByVal senha As String, ByVal senderid As String)
            Me.enviarSMS2Async(ddd, celular, mensagem, usuario, senha, senderid, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub enviarSMS2Async(ByVal ddd As String, ByVal celular As String, ByVal mensagem As String, ByVal usuario As String, ByVal senha As String, ByVal senderid As String, ByVal userState As Object)
            If (Me.enviarSMS2OperationCompleted Is Nothing) Then
                Me.enviarSMS2OperationCompleted = AddressOf Me.OnenviarSMS2OperationCompleted
            End If
            Me.InvokeAsync("enviarSMS2", New Object() {ddd, celular, mensagem, usuario, senha, senderid}, Me.enviarSMS2OperationCompleted, userState)
        End Sub
        
        Private Sub OnenviarSMS2OperationCompleted(ByVal arg As Object)
            If (Not (Me.enviarSMS2CompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent enviarSMS2Completed(Me, New enviarSMS2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:SMSServiceAction", RequestNamespace:="urn:http://www.byjg.com.br", ResponseNamespace:="urn:http://www.byjg.com.br")>  _
        Public Function enviarListaSMS(ByVal lista As String, ByVal mensagem As String, ByVal usuario As String, ByVal senha As String, ByVal senderid As String) As <System.Xml.Serialization.SoapElementAttribute("enviarListaSMSResponse")> String
            Dim results() As Object = Me.Invoke("enviarListaSMS", New Object() {lista, mensagem, usuario, senha, senderid})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub enviarListaSMSAsync(ByVal lista As String, ByVal mensagem As String, ByVal usuario As String, ByVal senha As String, ByVal senderid As String)
            Me.enviarListaSMSAsync(lista, mensagem, usuario, senha, senderid, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub enviarListaSMSAsync(ByVal lista As String, ByVal mensagem As String, ByVal usuario As String, ByVal senha As String, ByVal senderid As String, ByVal userState As Object)
            If (Me.enviarListaSMSOperationCompleted Is Nothing) Then
                Me.enviarListaSMSOperationCompleted = AddressOf Me.OnenviarListaSMSOperationCompleted
            End If
            Me.InvokeAsync("enviarListaSMS", New Object() {lista, mensagem, usuario, senha, senderid}, Me.enviarListaSMSOperationCompleted, userState)
        End Sub
        
        Private Sub OnenviarListaSMSOperationCompleted(ByVal arg As Object)
            If (Not (Me.enviarListaSMSCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent enviarListaSMSCompleted(Me, New enviarListaSMSCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:SMSServiceAction", RequestNamespace:="urn:http://www.byjg.com.br", ResponseNamespace:="urn:http://www.byjg.com.br")>  _
        Public Function recursos(ByVal usuario As String, ByVal senha As String) As <System.Xml.Serialization.SoapElementAttribute("recursosResponse")> String
            Dim results() As Object = Me.Invoke("recursos", New Object() {usuario, senha})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub recursosAsync(ByVal usuario As String, ByVal senha As String)
            Me.recursosAsync(usuario, senha, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub recursosAsync(ByVal usuario As String, ByVal senha As String, ByVal userState As Object)
            If (Me.recursosOperationCompleted Is Nothing) Then
                Me.recursosOperationCompleted = AddressOf Me.OnrecursosOperationCompleted
            End If
            Me.InvokeAsync("recursos", New Object() {usuario, senha}, Me.recursosOperationCompleted, userState)
        End Sub
        
        Private Sub OnrecursosOperationCompleted(ByVal arg As Object)
            If (Not (Me.recursosCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent recursosCompleted(Me, New recursosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:SMSServiceAction", RequestNamespace:="urn:http://www.byjg.com.br", ResponseNamespace:="urn:http://www.byjg.com.br")>  _
        Public Function creditos(ByVal usuario As String, ByVal senha As String) As <System.Xml.Serialization.SoapElementAttribute("creditosResponse")> String
            Dim results() As Object = Me.Invoke("creditos", New Object() {usuario, senha})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub creditosAsync(ByVal usuario As String, ByVal senha As String)
            Me.creditosAsync(usuario, senha, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub creditosAsync(ByVal usuario As String, ByVal senha As String, ByVal userState As Object)
            If (Me.creditosOperationCompleted Is Nothing) Then
                Me.creditosOperationCompleted = AddressOf Me.OncreditosOperationCompleted
            End If
            Me.InvokeAsync("creditos", New Object() {usuario, senha}, Me.creditosOperationCompleted, userState)
        End Sub
        
        Private Sub OncreditosOperationCompleted(ByVal arg As Object)
            If (Not (Me.creditosCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent creditosCompleted(Me, New creditosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:SMSServiceAction", RequestNamespace:="urn:http://www.byjg.com.br", ResponseNamespace:="urn:http://www.byjg.com.br")>  _
        Public Function enviarSMSInternacional(ByVal codpais As String, ByVal ddd As String, ByVal celular As String, ByVal mensagem As String, ByVal usuario As String, ByVal senha As String) As <System.Xml.Serialization.SoapElementAttribute("enviarSMSInternacionalResponse")> String
            Dim results() As Object = Me.Invoke("enviarSMSInternacional", New Object() {codpais, ddd, celular, mensagem, usuario, senha})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub enviarSMSInternacionalAsync(ByVal codpais As String, ByVal ddd As String, ByVal celular As String, ByVal mensagem As String, ByVal usuario As String, ByVal senha As String)
            Me.enviarSMSInternacionalAsync(codpais, ddd, celular, mensagem, usuario, senha, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub enviarSMSInternacionalAsync(ByVal codpais As String, ByVal ddd As String, ByVal celular As String, ByVal mensagem As String, ByVal usuario As String, ByVal senha As String, ByVal userState As Object)
            If (Me.enviarSMSInternacionalOperationCompleted Is Nothing) Then
                Me.enviarSMSInternacionalOperationCompleted = AddressOf Me.OnenviarSMSInternacionalOperationCompleted
            End If
            Me.InvokeAsync("enviarSMSInternacional", New Object() {codpais, ddd, celular, mensagem, usuario, senha}, Me.enviarSMSInternacionalOperationCompleted, userState)
        End Sub
        
        Private Sub OnenviarSMSInternacionalOperationCompleted(ByVal arg As Object)
            If (Not (Me.enviarSMSInternacionalCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent enviarSMSInternacionalCompleted(Me, New enviarSMSInternacionalCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")>  _
    Public Delegate Sub obterVersaoCompletedEventHandler(ByVal sender As Object, ByVal e As obterVersaoCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class obterVersaoCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")>  _
    Public Delegate Sub enviarSMSCompletedEventHandler(ByVal sender As Object, ByVal e As enviarSMSCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class enviarSMSCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")>  _
    Public Delegate Sub enviarSMS2CompletedEventHandler(ByVal sender As Object, ByVal e As enviarSMS2CompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class enviarSMS2CompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")>  _
    Public Delegate Sub enviarListaSMSCompletedEventHandler(ByVal sender As Object, ByVal e As enviarListaSMSCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class enviarListaSMSCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")>  _
    Public Delegate Sub recursosCompletedEventHandler(ByVal sender As Object, ByVal e As recursosCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class recursosCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")>  _
    Public Delegate Sub creditosCompletedEventHandler(ByVal sender As Object, ByVal e As creditosCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class creditosCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")>  _
    Public Delegate Sub enviarSMSInternacionalCompletedEventHandler(ByVal sender As Object, ByVal e As enviarSMSInternacionalCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class enviarSMSInternacionalCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
End Namespace