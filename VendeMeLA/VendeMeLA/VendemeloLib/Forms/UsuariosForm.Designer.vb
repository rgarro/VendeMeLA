<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuariosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsuariosForm))
        Me.clienteMGroup = New System.Windows.Forms.GroupBox()
        Me.usuariosList = New System.Windows.Forms.ListBox()
        Me.nuevoUsuarioBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.usuarioTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.claveTxt = New System.Windows.Forms.TextBox()
        Me.es_cajeroCk = New System.Windows.Forms.CheckBox()
        Me.es_admin = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.errorsLabel = New System.Windows.Forms.Label()
        Me.actionLabel = New System.Windows.Forms.Label()
        Me.clienteMGroup.SuspendLayout()
        Me.nuevoUsuarioBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'clienteMGroup
        '
        Me.clienteMGroup.Controls.Add(Me.usuariosList)
        Me.clienteMGroup.Location = New System.Drawing.Point(30, 27)
        Me.clienteMGroup.Name = "clienteMGroup"
        Me.clienteMGroup.Size = New System.Drawing.Size(192, 326)
        Me.clienteMGroup.TabIndex = 13
        Me.clienteMGroup.TabStop = False
        Me.clienteMGroup.Text = "Manejar Usuarios"
        '
        'usuariosList
        '
        Me.usuariosList.FormattingEnabled = True
        Me.usuariosList.Location = New System.Drawing.Point(6, 19)
        Me.usuariosList.Name = "usuariosList"
        Me.usuariosList.Size = New System.Drawing.Size(163, 290)
        Me.usuariosList.TabIndex = 13
        '
        'nuevoUsuarioBox
        '
        Me.nuevoUsuarioBox.Controls.Add(Me.Button1)
        Me.nuevoUsuarioBox.Controls.Add(Me.es_admin)
        Me.nuevoUsuarioBox.Controls.Add(Me.es_cajeroCk)
        Me.nuevoUsuarioBox.Controls.Add(Me.claveTxt)
        Me.nuevoUsuarioBox.Controls.Add(Me.Label2)
        Me.nuevoUsuarioBox.Controls.Add(Me.Label1)
        Me.nuevoUsuarioBox.Controls.Add(Me.usuarioTxt)
        Me.nuevoUsuarioBox.Location = New System.Drawing.Point(249, 12)
        Me.nuevoUsuarioBox.Name = "nuevoUsuarioBox"
        Me.nuevoUsuarioBox.Size = New System.Drawing.Size(200, 171)
        Me.nuevoUsuarioBox.TabIndex = 14
        Me.nuevoUsuarioBox.TabStop = False
        Me.nuevoUsuarioBox.Text = "Nuevo Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario"
        '
        'usuarioTxt
        '
        Me.usuarioTxt.Location = New System.Drawing.Point(67, 30)
        Me.usuarioTxt.Name = "usuarioTxt"
        Me.usuarioTxt.Size = New System.Drawing.Size(112, 20)
        Me.usuarioTxt.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Clave"
        '
        'claveTxt
        '
        Me.claveTxt.Location = New System.Drawing.Point(67, 68)
        Me.claveTxt.Name = "claveTxt"
        Me.claveTxt.Size = New System.Drawing.Size(112, 20)
        Me.claveTxt.TabIndex = 3
        '
        'es_cajeroCk
        '
        Me.es_cajeroCk.AutoSize = True
        Me.es_cajeroCk.Location = New System.Drawing.Point(67, 95)
        Me.es_cajeroCk.Name = "es_cajeroCk"
        Me.es_cajeroCk.Size = New System.Drawing.Size(69, 17)
        Me.es_cajeroCk.TabIndex = 4
        Me.es_cajeroCk.Text = "es cajero"
        Me.es_cajeroCk.UseVisualStyleBackColor = True
        '
        'es_admin
        '
        Me.es_admin.AutoSize = True
        Me.es_admin.Location = New System.Drawing.Point(67, 119)
        Me.es_admin.Name = "es_admin"
        Me.es_admin.Size = New System.Drawing.Size(68, 17)
        Me.es_admin.TabIndex = 5
        Me.es_admin.Text = "es admin"
        Me.es_admin.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(49, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'errorsLabel
        '
        Me.errorsLabel.AutoSize = True
        Me.errorsLabel.Font = New System.Drawing.Font("PanRoman", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.errorsLabel.ForeColor = System.Drawing.Color.Red
        Me.errorsLabel.Location = New System.Drawing.Point(247, 186)
        Me.errorsLabel.Name = "errorsLabel"
        Me.errorsLabel.Size = New System.Drawing.Size(0, 11)
        Me.errorsLabel.TabIndex = 17
        '
        'actionLabel
        '
        Me.actionLabel.AutoSize = True
        Me.actionLabel.Font = New System.Drawing.Font("BankGothic Md BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.actionLabel.ForeColor = System.Drawing.Color.DarkGreen
        Me.actionLabel.Location = New System.Drawing.Point(33, 378)
        Me.actionLabel.Name = "actionLabel"
        Me.actionLabel.Size = New System.Drawing.Size(0, 14)
        Me.actionLabel.TabIndex = 18
        '
        'UsuariosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 401)
        Me.Controls.Add(Me.actionLabel)
        Me.Controls.Add(Me.errorsLabel)
        Me.Controls.Add(Me.nuevoUsuarioBox)
        Me.Controls.Add(Me.clienteMGroup)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UsuariosForm"
        Me.Text = "VendemeLA Usuarios"
        Me.clienteMGroup.ResumeLayout(False)
        Me.nuevoUsuarioBox.ResumeLayout(False)
        Me.nuevoUsuarioBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents clienteMGroup As GroupBox
    Friend WithEvents usuariosList As ListBox
    Friend WithEvents nuevoUsuarioBox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents usuarioTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents claveTxt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents es_admin As CheckBox
    Friend WithEvents es_cajeroCk As CheckBox
    Friend WithEvents errorsLabel As Label
    Friend WithEvents actionLabel As Label
End Class
