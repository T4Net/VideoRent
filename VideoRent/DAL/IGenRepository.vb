Imports System.Data.Entity
Public Interface IGenRepository(Of T)
    Function GetAll() As IEnumerable(Of T)
    Function GetById(id As Integer) As T
    Function GetByName(name As String) As T
    Sub Insert(rec As T)
    Sub Delete(rec As T)
    Sub Save()
End Interface
