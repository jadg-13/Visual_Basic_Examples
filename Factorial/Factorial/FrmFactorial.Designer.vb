<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFactorial
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtNumber = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmbOption = New System.Windows.Forms.ComboBox()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.LblFactorial = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtNumber)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(179, 93)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresa un número entero"
        '
        'TxtNumber
        '
        Me.TxtNumber.Location = New System.Drawing.Point(21, 43)
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(123, 22)
        Me.TxtNumber.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmbOption)
        Me.GroupBox2.Location = New System.Drawing.Point(236, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(229, 93)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selecciona la metodología a usar"
        '
        'CmbOption
        '
        Me.CmbOption.FormattingEnabled = True
        Me.CmbOption.Items.AddRange(New Object() {"For", "While", "Do ... While", "Recursividad"})
        Me.CmbOption.Location = New System.Drawing.Point(19, 41)
        Me.CmbOption.Name = "CmbOption"
        Me.CmbOption.Size = New System.Drawing.Size(191, 24)
        Me.CmbOption.TabIndex = 0
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(32, 137)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(433, 73)
        Me.BtnCalculate.TabIndex = 2
        Me.BtnCalculate.Text = "Calcular"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'LblFactorial
        '
        Me.LblFactorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFactorial.Location = New System.Drawing.Point(29, 241)
        Me.LblFactorial.Name = "LblFactorial"
        Me.LblFactorial.Size = New System.Drawing.Size(436, 83)
        Me.LblFactorial.TabIndex = 3
        Me.LblFactorial.Text = "0"
        Me.LblFactorial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmFactorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 372)
        Me.Controls.Add(Me.LblFactorial)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmFactorial"
        Me.Text = "Factorial de un numero | jadg13"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CmbOption As ComboBox
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents LblFactorial As Label
End Class
