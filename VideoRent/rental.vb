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

Partial Public Class rental
    Public Property rentID As Long
    Public Property CopyID As Integer
    Public Property rentalDate As Date
    Public Property returnDate As Nullable(Of Date)
    Public Property memberID As Nullable(Of Integer)
    Public Property employeeID As Integer
    Public Property rentalTime As Date
    Public Property currentlyHiring As Nullable(Of SByte)

    Public Overridable Property member As member

End Class