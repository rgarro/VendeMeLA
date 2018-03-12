<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmbodegaloFRM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmbodegaloFRM))
        Me.showEmbodegarBTN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.etiquetaComercialTXT = New System.Windows.Forms.TextBox()
        Me.precioUnidadTXT = New System.Windows.Forms.TextBox()
        Me.cantidadTXT = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'showEmbodegarBTN
        '
        Me.showEmbodegarBTN.Location = New System.Drawing.Point(110, 65)
        Me.showEmbodegarBTN.Name = "showEmbodegarBTN"
        Me.showEmbodegarBTN.Size = New System.Drawing.Size(149, 23)
        Me.showEmbodegarBTN.TabIndex = 0
        Me.showEmbodegarBTN.Text = "Embodegar Nuevo"
        Me.showEmbodegarBTN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Etiqueta Comercial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Precio Unidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cantidad "
        '
        'etiquetaComercialTXT
        '
        Me.etiquetaComercialTXT.Location = New System.Drawing.Point(137, 13)
        Me.etiquetaComercialTXT.Name = "etiquetaComercialTXT"
        Me.etiquetaComercialTXT.Size = New System.Drawing.Size(181, 20)
        Me.etiquetaComercialTXT.TabIndex = 4
        '
        'precioUnidadTXT
        '
        Me.precioUnidadTXT.Location = New System.Drawing.Point(137, 39)
        Me.precioUnidadTXT.Name = "precioUnidadTXT"
        Me.precioUnidadTXT.Size = New System.Drawing.Size(53, 20)
        Me.precioUnidadTXT.TabIndex = 5
        '
        'cantidadTXT
        '
        Me.cantidadTXT.Location = New System.Drawing.Point(245, 39)
        Me.cantidadTXT.Name = "cantidadTXT"
        Me.cantidadTXT.Size = New System.Drawing.Size(73, 20)
        Me.cantidadTXT.TabIndex = 6
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(53, 123)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(483, 188)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'EmbodegaloFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 370)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.cantidadTXT)
        Me.Controls.Add(Me.precioUnidadTXT)
        Me.Controls.Add(Me.etiquetaComercialTXT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.showEmbodegarBTN)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EmbodegaloFRM"
        Me.Text = "EmBodegaLO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents showEmbodegarBTN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents etiquetaComercialTXT As TextBox
    Friend WithEvents precioUnidadTXT As TextBox
    Friend WithEvents cantidadTXT As TextBox
    Friend WithEvents listViewEmbodegados As ListView
    Friend WithEvents ListView1 As ListView
End Class
