'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class payment
    Public Property paymentID As Integer
    Public Property memberID As Integer
    Public Property rentID As Long
    Public Property amount As Decimal
    Public Property paymentDate As Nullable(Of Date)

    Public Overridable Property member As member

End Class