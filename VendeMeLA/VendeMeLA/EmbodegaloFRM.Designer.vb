﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.editArticuloBox = New System.Windows.Forms.GroupBox()
        Me.EetiquetaComercialTXT = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.editArticuloBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'showEmbodegarBTN
        '
        Me.showEmbodegarBTN.Location = New System.Drawing.Point(93, 105)
        Me.showEmbodegarBTN.Name = "showEmbodegarBTN"
        Me.showEmbodegarBTN.Size = New System.Drawing.Size(149, 23)
        Me.showEmbodegarBTN.TabIndex = 0
        Me.showEmbodegarBTN.Text = "Embodegar Nuevo"
        Me.showEmbodegarBTN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Etiqueta Comercial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Precio Unidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(170, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cantidad "
        '
        'etiquetaComercialTXT
        '
        Me.etiquetaComercialTXT.Location = New System.Drawing.Point(111, 22)
        Me.etiquetaComercialTXT.Name = "etiquetaComercialTXT"
        Me.etiquetaComercialTXT.Size = New System.Drawing.Size(181, 20)
        Me.etiquetaComercialTXT.TabIndex = 4
        '
        'precioUnidadTXT
        '
        Me.precioUnidadTXT.Location = New System.Drawing.Point(111, 58)
        Me.precioUnidadTXT.Name = "precioUnidadTXT"
        Me.precioUnidadTXT.Size = New System.Drawing.Size(53, 20)
        Me.precioUnidadTXT.TabIndex = 5
        '
        'cantidadTXT
        '
        Me.cantidadTXT.Location = New System.Drawing.Point(219, 58)
        Me.cantidadTXT.Name = "cantidadTXT"
        Me.cantidadTXT.Size = New System.Drawing.Size(73, 20)
        Me.cantidadTXT.TabIndex = 6
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 22
        Me.ListBox1.Location = New System.Drawing.Point(12, 153)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(353, 180)
        Me.ListBox1.TabIndex = 7
        '
        'editArticuloBox
        '
        Me.editArticuloBox.Controls.Add(Me.EetiquetaComercialTXT)
        Me.editArticuloBox.Location = New System.Drawing.Point(400, 2)
        Me.editArticuloBox.Name = "editArticuloBox"
        Me.editArticuloBox.Size = New System.Drawing.Size(233, 215)
        Me.editArticuloBox.TabIndex = 8
        Me.editArticuloBox.TabStop = False
        Me.editArticuloBox.Text = "Actualizar Articulo"
        Me.editArticuloBox.Visible = False
        '
        'EetiquetaComercialTXT
        '
        Me.EetiquetaComercialTXT.Location = New System.Drawing.Point(24, 29)
        Me.EetiquetaComercialTXT.Name = "EetiquetaComercialTXT"
        Me.EetiquetaComercialTXT.Size = New System.Drawing.Size(181, 20)
        Me.EetiquetaComercialTXT.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.etiquetaComercialTXT)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.showEmbodegarBTN)
        Me.GroupBox1.Controls.Add(Me.cantidadTXT)
        Me.GroupBox1.Controls.Add(Me.precioUnidadTXT)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 134)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Articulo"
        '
        'EmbodegaloFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 359)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.editArticuloBox)
        Me.Controls.Add(Me.ListBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EmbodegaloFRM"
        Me.Text = "EmBodegaLO"
        Me.editArticuloBox.ResumeLayout(False)
        Me.editArticuloBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents showEmbodegarBTN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents etiquetaComercialTXT As TextBox
    Friend WithEvents precioUnidadTXT As TextBox
    Friend WithEvents cantidadTXT As TextBox
    Friend WithEvents listViewEmbodegados As ListView
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents editArticuloBox As GroupBox
    Friend WithEvents EetiquetaComercialTXT As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
