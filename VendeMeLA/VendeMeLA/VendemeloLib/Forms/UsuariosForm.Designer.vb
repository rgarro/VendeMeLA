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
        Me.clienteMGroup.SuspendLayout()
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
        'UsuariosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 401)
        Me.Controls.Add(Me.clienteMGroup)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UsuariosForm"
        Me.Text = "VendemeLA Usuarios"
        Me.clienteMGroup.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents clienteMGroup As GroupBox
    Friend WithEvents usuariosList As ListBox
End Class
