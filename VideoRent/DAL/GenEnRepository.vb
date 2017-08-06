Imports System.Data.Entity
Imports VideoRent
'CRUD - http://www.entityframeworktutorial.net/crud-operation-in-connected-scenario-entity-framework.aspx
'Public Class Test(Of T As {IGenRepository(Of DbContext), New})
'End Class
Public Class GenEnRepository(Of T As Class)
    Implements IGenRepository(Of T)

    Private DB As New video_dbEntities

    Private Function GetAll() As IEnumerable(Of T) Implements IGenRepository(Of T).GetAll
        Return DB.Set(Of T)().ToList()
    End Function

    Private Function GetById(id As Integer) As T Implements IGenRepository(Of T).GetById
        Return DB.Set(Of T)().Find(id)
    End Function

    Private Function GetByName(name As String) As T Implements IGenRepository(Of T).GetByName
        Return DB.Set(Of T)().Find(name)
    End Function

    Private Sub Insert(rec As T) Implements IGenRepository(Of T).Insert
        DB.Set(Of T)().Add(rec)
        DB.SaveChanges()
    End Sub

    Private Sub Delete(rec As T) Implements IGenRepository(Of T).Delete
        DB.Set(Of T)().Remove(rec)
        DB.SaveChanges()
    End Sub

    Public Sub Save() Implements IGenRepository(Of T).Save
        DB.SaveChanges()
    End Sub

End Class
