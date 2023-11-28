Public Class ProductDao

    'guardar temporalmente los productos
    Private Shared products As New List(Of Product)

    Public Function Save(product As Product) As Boolean
        Try
            products.Add(product)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function GetAll() As List(Of Product)
        Return products
    End Function

    Public Function GetByID(id As Integer) As Product
        Dim product As Product = Nothing
        For Each p As Product In products
            If p.Id = id Then
                product = p
                Exit For
            End If
        Next
        Return product
    End Function

    Public Function Update(productOld As Product, product As Product) As Boolean
        Dim index As Integer = products.IndexOf(productOld)
        If index <> -1 Then
            products(index) = product
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Delete(product As Product) As Boolean
        Dim index As Integer = products.IndexOf(product)
        If index <> -1 Then
            products.RemoveAt(index)
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GetTable() As DataTable
        Dim table As New DataTable()
        table.Columns.Add("ID")
        table.Columns.Add("Nombre")
        table.Columns.Add("Descripcion")
        table.Columns.Add("Precio")
        table.Columns.Add("IVA")
        table.Columns.Add("Total")

        For Each p As Product In products
            Dim row As DataRow = table.NewRow()
            row("ID") = p.Id
            row("Nombre") = p.Name
            row("Descripcion") = p.Description
            row("Precio") = p.Price
            row("IVA") = p.GetIVA()
            row("Total") = p.GetAmount()
            table.Rows.Add(row)
        Next

        Return table
    End Function
End Class
