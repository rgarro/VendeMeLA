<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VendeloFRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VendeloFRM))
        Me.articulosList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.preventaList = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.removerBtn = New System.Windows.Forms.Button()
        Me.labelTotal = New System.Windows.Forms.Label()
        Me.completarVentaBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.clientesList = New System.Windows.Forms.ListBox()
        Me.agregarBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'articulosList
        '
        Me.articulosList.FormattingEnabled = True
        Me.articulosList.Location = New System.Drawing.Point(12, 43)
        Me.articulosList.Name = "articulosList"
        Me.articulosList.Size = New System.Drawing.Size(234, 251)
        Me.articulosList.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("BankGothic Md BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Articulos Disponibles"
        '
        'preventaList
        '
        Me.preventaList.Location = New System.Drawing.Point(287, 43)
        Me.preventaList.Name = "preventaList"
        Me.preventaList.Size = New System.Drawing.Size(307, 133)
        Me.preventaList.TabIndex = 2
        Me.preventaList.UseCompatibleStateImageBehavior = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("BankGothic Md BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(278, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 14)
        Me.Label2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("BankGothic Md BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(284, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PreVenta"
        '
        'removerBtn
        '
        Me.removerBtn.Font = New System.Drawing.Font("BankGothic Md BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removerBtn.ForeColor = System.Drawing.Color.Orange
        Me.removerBtn.Location = New System.Drawing.Point(621, 43)
        Me.removerBtn.Name = "removerBtn"
        Me.removerBtn.Size = New System.Drawing.Size(75, 23)
        Me.removerBtn.TabIndex = 5
        Me.removerBtn.Text = "Remover"
        Me.removerBtn.UseVisualStyleBackColor = True
        '
        'labelTotal
        '
        Me.labelTotal.AutoSize = True
        Me.labelTotal.Font = New System.Drawing.Font("BankGothic Md BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTotal.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.labelTotal.Location = New System.Drawing.Point(485, 192)
        Me.labelTotal.Name = "labelTotal"
        Me.labelTotal.Size = New System.Drawing.Size(63, 14)
        Me.labelTotal.TabIndex = 6
        Me.labelTotal.Text = "Total :"
        '
        'completarVentaBtn
        '
        Me.completarVentaBtn.Font = New System.Drawing.Font("BankGothic Md BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.completarVentaBtn.ForeColor = System.Drawing.Color.Green
        Me.completarVentaBtn.Location = New System.Drawing.Point(308, 353)
        Me.completarVentaBtn.Name = "completarVentaBtn"
        Me.completarVentaBtn.Size = New System.Drawing.Size(307, 23)
        Me.completarVentaBtn.TabIndex = 7
        Me.completarVentaBtn.Text = "Completar Venta"
        Me.completarVentaBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.Font = New System.Drawing.Font("BankGothic Md BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(362, 379)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 14)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "mensajes de flujo aqui"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(229, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Haga click en el articulo para gregar 1 a la venta"
        '
        'clientesList
        '
        Me.clientesList.FormattingEnabled = True
        Me.clientesList.Location = New System.Drawing.Point(287, 192)
        Me.clientesList.Name = "clientesList"
        Me.clientesList.Size = New System.Drawing.Size(163, 95)
        Me.clientesList.TabIndex = 10
        '
        'agregarBtn
        '
        Me.agregarBtn.Font = New System.Drawing.Font("BankGothic Md BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agregarBtn.ForeColor = System.Drawing.Color.Orange
        Me.agregarBtn.Location = New System.Drawing.Point(621, 82)
        Me.agregarBtn.Name = "agregarBtn"
        Me.agregarBtn.Size = New System.Drawing.Size(75, 23)
        Me.agregarBtn.TabIndex = 11
        Me.agregarBtn.Text = "Agregar"
        Me.agregarBtn.UseVisualStyleBackColor = True
        '
        'VendeloFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 393)
        Me.Controls.Add(Me.agregarBtn)
        Me.Controls.Add(Me.clientesList)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.completarVentaBtn)
        Me.Controls.Add(Me.labelTotal)
        Me.Controls.Add(Me.removerBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.preventaList)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.articulosList)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VendeloFRM"
        Me.Text = "VendeLO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents articulosList As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents preventaList As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents removerBtn As Button
    Friend WithEvents labelTotal As Label
    Friend WithEvents completarVentaBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents clientesList As ListBox
    Friend WithEvents agregarBtn As Button
End Class
