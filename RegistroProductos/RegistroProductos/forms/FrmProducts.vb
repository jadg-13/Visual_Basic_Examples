Public Class FrmProducts
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Clear()
    End Sub

    Private Sub Clear()
        TxtID.Clear()
        TxtName.Clear()
        TxtDescription.Clear()
        TxtPrice.Clear()
        ChkIsIVA.Checked = False
        TxtIVA.Clear()
        TxtAmount.Clear()
        TxtID.Focus()
    End Sub

    Private Sub calcAmount()
        Dim product As New Product(0, "", "", Val(TxtPrice.Text), ChkIsIVA.Checked)
        TxtIVA.Text = product.GetIVA()
        TxtAmount.Text = product.GetAmount()
    End Sub

    Private Sub ChkIsIVA_CheckedChanged(sender As Object, e As EventArgs) Handles ChkIsIVA.CheckedChanged
        calcAmount()
    End Sub

    Private Sub TxtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrice.KeyPress
        'verifica si solo introducen numeros positivos y borrar 

        If Not (Char.IsNumber(e.KeyChar)) And (Asc(e.KeyChar) <> 8) And (Asc(e.KeyChar) <> 13) Then
            e.Handled = True
            MsgBox("Solo se permiten numeros positivos", MsgBoxStyle.Information, "Advertencia")
            TxtPrice.Focus()

        End If
        If (Asc(e.KeyChar) = 13) Then
            calcAmount()
        End If

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim product As New Product(Val(TxtID.Text), TxtName.Text, TxtDescription.Text, Val(TxtPrice.Text), ChkIsIVA.Checked)

        Dim dao As New ProductDao()
        Dim productFound As Product = dao.GetByID(product.Id)
        Dim result As Boolean = False
        If (productFound IsNot Nothing) Then
            result = dao.Update(productFound, product)
        Else
            result = dao.Save(product)
        End If
        If result Then
            MsgBox("Producto guardado correctamente", MsgBoxStyle.Information, "Informacion")
            Clear()
        Else
            MsgBox("Error al guardar el producto", MsgBoxStyle.Critical, "Error")
        End If
        ShowProducts()
    End Sub

    Private Sub ShowProducts()
        Dim dao As New ProductDao()
        DgvProducts.DataSource = dao.GetTable()
        DgvProducts.Refresh()
        GrpRegister.Text = "Registros guardados: " & DgvProducts.RowCount
    End Sub

    Private Sub FrmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowProducts()
    End Sub

    Private Sub DgvProducts_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvProducts.CellDoubleClick
        Dim row As Integer = DgvProducts.CurrentRow.Index
        TxtID.Text = DgvProducts.Item(0, row).Value
        TxtName.Text = DgvProducts.Item(1, row).Value
        TxtDescription.Text = DgvProducts.Item(2, row).Value
        TxtPrice.Text = DgvProducts.Item(3, row).Value
        ChkIsIVA.Checked = DgvProducts.Item(4, row).Value
        calcAmount()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        'preguntar si se desea eliminar el registro
        If MsgBox("¿Desea eliminar el registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim product As New Product(Val(TxtID.Text), TxtName.Text, TxtDescription.Text, Val(TxtPrice.Text), ChkIsIVA.Checked)
        Dim dao As New ProductDao()
        Dim productFound As Product = dao.GetByID(product.Id)
        Dim result As Boolean = False
        If (productFound IsNot Nothing) Then
            result = dao.Delete(productFound)

        End If
        If result Then
            MsgBox("Producto eliminado correctamente", MsgBoxStyle.Information, "Informacion")
            Clear()
        Else
            MsgBox("Error al eliminar el producto", MsgBoxStyle.Critical, "Error")
        End If
        ShowProducts()
    End Sub

    Private Sub TxtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtID.KeyPress
        'permitir solo numeros enteros positivos, borrar y la tecla enter
        If Not (Char.IsNumber(e.KeyChar)) And (Asc(e.KeyChar) <> 8) And (Asc(e.KeyChar) <> 13) Then
            e.Handled = True
            MsgBox("Solo se permiten numeros enteros positivos", MsgBoxStyle.Information, "Advertencia")
            TxtID.Focus()

        End If
    End Sub
End Class