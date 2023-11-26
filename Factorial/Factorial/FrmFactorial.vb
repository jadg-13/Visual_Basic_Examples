Public Class FrmFactorial

    'Made by: José A. Durán G. (jadg13)

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click

        Dim factorial As New Factorial
        Dim number As Integer = Convert.ToInt32(TxtNumber.Text)

        Dim opt As Integer = CmbOption.SelectedIndex
        Try
            Select Case opt
                Case 0
                    LblFactorial.Text = factorial.CalculateByFor(number)
                Case 1
                    LblFactorial.Text = factorial.CalculateByWhile(number)
                Case 2
                    LblFactorial.Text = factorial.CalculateByDoWhile(number)
                Case 3
                    LblFactorial.Text = factorial.CalculateByRecursion(number)
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
