<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesFRM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientesFRM))
        Me.clienteMGroup = New System.Windows.Forms.GroupBox()
        Me.updateClientBTN = New System.Windows.Forms.Button()
        Me.borrarClienteBTN = New System.Windows.Forms.Button()
        Me.clientesList = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clienteNombreTXT = New System.Windows.Forms.TextBox()
        Me.clienteDescuentoTXT = New System.Windows.Forms.TextBox()
        Me.updateClienteBox = New System.Windows.Forms.GroupBox()
        Me.clienteEditDescuento = New System.Windows.Forms.TextBox()
        Me.clienteEditNombreTXT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NuevoCliBtn = New System.Windows.Forms.Button()
        Me.clienteMGroup.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.updateClienteBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'clienteMGroup
        '
        Me.clienteMGroup.Controls.Add(Me.clientesList)
        Me.clienteMGroup.Location = New System.Drawing.Point(246, 20)
        Me.clienteMGroup.Name = "clienteMGroup"
        Me.clienteMGroup.Size = New System.Drawing.Size(192, 326)
        Me.clienteMGroup.TabIndex = 12
        Me.clienteMGroup.TabStop = False
        Me.clienteMGroup.Text = "Manejar Clientes"
        '
        'updateClientBTN
        '
        Me.updateClientBTN.Location = New System.Drawing.Point(9, 101)
        Me.updateClientBTN.Name = "updateClientBTN"
        Me.updateClientBTN.Size = New System.Drawing.Size(75, 23)
        Me.updateClientBTN.TabIndex = 1
        Me.updateClientBTN.Text = "Actualizar"
        Me.updateClientBTN.UseVisualStyleBackColor = True
        '
        'borrarClienteBTN
        '
        Me.borrarClienteBTN.ForeColor = System.Drawing.Color.Red
        Me.borrarClienteBTN.Location = New System.Drawing.Point(125, 101)
        Me.borrarClienteBTN.Name = "borrarClienteBTN"
        Me.borrarClienteBTN.Size = New System.Drawing.Size(75, 23)
        Me.borrarClienteBTN.TabIndex = 0
        Me.borrarClienteBTN.Text = "Borrar"
        Me.borrarClienteBTN.UseVisualStyleBackColor = True
        '
        'clientesList
        '
        Me.clientesList.FormattingEnabled = True
        Me.clientesList.Location = New System.Drawing.Point(6, 19)
        Me.clientesList.Name = "clientesList"
        Me.clientesList.Size = New System.Drawing.Size(163, 290)
        Me.clientesList.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NuevoCliBtn)
        Me.GroupBox1.Controls.Add(Me.clienteDescuentoTXT)
        Me.GroupBox1.Controls.Add(Me.clienteNombreTXT)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 139)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descuento"
        '
        'clienteNombreTXT
        '
        Me.clienteNombreTXT.Location = New System.Drawing.Point(54, 28)
        Me.clienteNombreTXT.Name = "clienteNombreTXT"
        Me.clienteNombreTXT.Size = New System.Drawing.Size(146, 20)
        Me.clienteNombreTXT.TabIndex = 2
        '
        'clienteDescuentoTXT
        '
        Me.clienteDescuentoTXT.Location = New System.Drawing.Point(82, 60)
        Me.clienteDescuentoTXT.Name = "clienteDescuentoTXT"
        Me.clienteDescuentoTXT.Size = New System.Drawing.Size(100, 20)
        Me.clienteDescuentoTXT.TabIndex = 3
        '
        'updateClienteBox
        '
        Me.updateClienteBox.Controls.Add(Me.borrarClienteBTN)
        Me.updateClienteBox.Controls.Add(Me.updateClientBTN)
        Me.updateClienteBox.Controls.Add(Me.clienteEditDescuento)
        Me.updateClienteBox.Controls.Add(Me.clienteEditNombreTXT)
        Me.updateClienteBox.Controls.Add(Me.Label3)
        Me.updateClienteBox.Controls.Add(Me.Label4)
        Me.updateClienteBox.Location = New System.Drawing.Point(12, 185)
        Me.updateClienteBox.Name = "updateClienteBox"
        Me.updateClienteBox.Size = New System.Drawing.Size(217, 130)
        Me.updateClienteBox.TabIndex = 15
        Me.updateClienteBox.TabStop = False
        Me.updateClienteBox.Text = "Actualizar Cliente"
        '
        'clienteEditDescuento
        '
        Me.clienteEditDescuento.Location = New System.Drawing.Point(82, 60)
        Me.clienteEditDescuento.Name = "clienteEditDescuento"
        Me.clienteEditDescuento.Size = New System.Drawing.Size(100, 20)
        Me.clienteEditDescuento.TabIndex = 3
        '
        'clienteEditNombreTXT
        '
        Me.clienteEditNombreTXT.Location = New System.Drawing.Point(54, 28)
        Me.clienteEditNombreTXT.Name = "clienteEditNombreTXT"
        Me.clienteEditNombreTXT.Size = New System.Drawing.Size(146, 20)
        Me.clienteEditNombreTXT.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Descuento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nombre"
        '
        'NuevoCliBtn
        '
        Me.NuevoCliBtn.Location = New System.Drawing.Point(64, 98)
        Me.NuevoCliBtn.Name = "NuevoCliBtn"
        Me.NuevoCliBtn.Size = New System.Drawing.Size(75, 23)
        Me.NuevoCliBtn.TabIndex = 4
        Me.NuevoCliBtn.Text = "Nuevo"
        Me.NuevoCliBtn.UseVisualStyleBackColor = True
        '
        'ClientesFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 368)
        Me.Controls.Add(Me.updateClienteBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.clienteMGroup)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ClientesFRM"
        Me.Text = "VendemeLA Clientes ..."
        Me.clienteMGroup.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.updateClienteBox.ResumeLayout(False)
        Me.updateClienteBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents clienteMGroup As GroupBox
    Friend WithEvents updateClientBTN As Button
    Friend WithEvents borrarClienteBTN As Button
    Friend WithEvents clientesList As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NuevoCliBtn As Button
    Friend WithEvents clienteDescuentoTXT As TextBox
    Friend WithEvents clienteNombreTXT As TextBox
    Friend WithEvents updateClienteBox As GroupBox
    Friend WithEvents clienteEditDescuento As TextBox
    Friend WithEvents clienteEditNombreTXT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
