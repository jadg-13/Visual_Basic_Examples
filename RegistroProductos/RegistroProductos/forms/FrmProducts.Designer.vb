<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProducts
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.TxtAmount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtIVA = New System.Windows.Forms.TextBox()
        Me.ChkIsIVA = New System.Windows.Forms.CheckBox()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GrpRegister = New System.Windows.Forms.GroupBox()
        Me.DgvProducts = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GrpRegister.SuspendLayout()
        CType(Me.DgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.BtnClear)
        Me.GroupBox1.Controls.Add(Me.TxtAmount)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtIVA)
        Me.GroupBox1.Controls.Add(Me.ChkIsIVA)
        Me.GroupBox1.Controls.Add(Me.TxtPrice)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtDescription)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(852, 240)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del producto"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = Global.RegistroProductos.My.Resources.Resources.eliminar
        Me.BtnEliminar.Location = New System.Drawing.Point(741, 157)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(85, 62)
        Me.BtnEliminar.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.BtnEliminar, "Eliminar")
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Image = Global.RegistroProductos.My.Resources.Resources.registro
        Me.BtnSave.Location = New System.Drawing.Point(741, 89)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(85, 62)
        Me.BtnSave.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Guardar")
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Image = Global.RegistroProductos.My.Resources.Resources.codigo_limpio
        Me.BtnClear.Location = New System.Drawing.Point(741, 21)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(85, 62)
        Me.BtnClear.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.BtnClear, "Nuevo")
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'TxtAmount
        '
        Me.TxtAmount.Enabled = False
        Me.TxtAmount.Location = New System.Drawing.Point(576, 184)
        Me.TxtAmount.Name = "TxtAmount"
        Me.TxtAmount.Size = New System.Drawing.Size(130, 22)
        Me.TxtAmount.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(483, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Precio Venta:"
        '
        'TxtIVA
        '
        Me.TxtIVA.Enabled = False
        Me.TxtIVA.Location = New System.Drawing.Point(318, 184)
        Me.TxtIVA.Name = "TxtIVA"
        Me.TxtIVA.Size = New System.Drawing.Size(130, 22)
        Me.TxtIVA.TabIndex = 9
        '
        'ChkIsIVA
        '
        Me.ChkIsIVA.AutoSize = True
        Me.ChkIsIVA.Location = New System.Drawing.Point(259, 186)
        Me.ChkIsIVA.Name = "ChkIsIVA"
        Me.ChkIsIVA.Size = New System.Drawing.Size(53, 20)
        Me.ChkIsIVA.TabIndex = 8
        Me.ChkIsIVA.Text = "IVA:"
        Me.ChkIsIVA.UseVisualStyleBackColor = True
        '
        'TxtPrice
        '
        Me.TxtPrice.Location = New System.Drawing.Point(98, 184)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(130, 22)
        Me.TxtPrice.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Precio:"
        '
        'TxtDescription
        '
        Me.TxtDescription.Location = New System.Drawing.Point(116, 93)
        Me.TxtDescription.Multiline = True
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(590, 66)
        Me.TxtDescription.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripción:"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(344, 45)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(362, 22)
        Me.TxtName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre:"
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(98, 42)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(118, 22)
        Me.TxtID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'GrpRegister
        '
        Me.GrpRegister.Controls.Add(Me.DgvProducts)
        Me.GrpRegister.Location = New System.Drawing.Point(31, 272)
        Me.GrpRegister.Name = "GrpRegister"
        Me.GrpRegister.Size = New System.Drawing.Size(852, 382)
        Me.GrpRegister.TabIndex = 1
        Me.GrpRegister.TabStop = False
        Me.GrpRegister.Text = "Registros guardados: 0"
        '
        'DgvProducts
        '
        Me.DgvProducts.AllowUserToAddRows = False
        Me.DgvProducts.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(1)
        Me.DgvProducts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvProducts.Location = New System.Drawing.Point(3, 18)
        Me.DgvProducts.Name = "DgvProducts"
        Me.DgvProducts.ReadOnly = True
        Me.DgvProducts.RowHeadersWidth = 51
        Me.DgvProducts.RowTemplate.Height = 24
        Me.DgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvProducts.Size = New System.Drawing.Size(846, 361)
        Me.DgvProducts.TabIndex = 0
        '
        'FrmProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 666)
        Me.Controls.Add(Me.GrpRegister)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrpRegister.ResumeLayout(False)
        CType(Me.DgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAmount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtIVA As TextBox
    Friend WithEvents ChkIsIVA As CheckBox
    Friend WithEvents TxtPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDescription As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GrpRegister As GroupBox
    Friend WithEvents DgvProducts As DataGridView
    Friend WithEvents BtnEliminar As Button
End Class
