Imports System.ServiceModel
Imports System.ServiceModel.Description

<ServiceContract>
Public Interface ServerWCFInterface

    <OperationContract>
    Function ServerWCFCall() As String

    <OperationContract>
    Function AsyncServerWCFCall() As Task(Of String)

End Interface