Public Class ListViewGroupSorter
    Implements IComparer

    Private order As SortOrder

    ' Stores the sort order.
    Public Sub New(theOrder As SortOrder)
        order = theOrder
    End Sub 'NewNew

    ' Compares the groups by header value, using the saved sort
    ' order to return the correct value.
    Public Function Compare(x As Object, y As Object) As Integer _
        Implements IComparer.Compare
        Dim result As Integer = String.Compare(
            CType(x, ListViewGroup).Header,
            CType(y, ListViewGroup).Header)
        If order = SortOrder.Ascending Then
            Return result
        Else
            Return -result
        End If
    End Function 'Compare
End Class
