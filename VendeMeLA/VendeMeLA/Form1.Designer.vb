﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.clientesBTN = New System.Windows.Forms.Button()
        Me.showEmbodegaFormBtn = New System.Windows.Forms.Button()
        Me.showVendeFormBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.VendeMeLA.My.Resources.Resources._49128P
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(368, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 77)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Usuarios"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'clientesBTN
        '
        Me.clientesBTN.BackColor = System.Drawing.Color.White
        Me.clientesBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientesBTN.Image = Global.VendeMeLA.My.Resources.Resources.clientesIconP
        Me.clientesBTN.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.clientesBTN.Location = New System.Drawing.Point(29, 30)
        Me.clientesBTN.Name = "clientesBTN"
        Me.clientesBTN.Size = New System.Drawing.Size(182, 85)
        Me.clientesBTN.TabIndex = 3
        Me.clientesBTN.Text = "Clientes"
        Me.clientesBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.clientesBTN.UseVisualStyleBackColor = False
        '
        'showEmbodegaFormBtn
        '
        Me.showEmbodegaFormBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showEmbodegaFormBtn.Image = Global.VendeMeLA.My.Resources.Resources.PPfactory_lift_warehouse_icon_icons_com_49903
        Me.showEmbodegaFormBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.showEmbodegaFormBtn.Location = New System.Drawing.Point(320, 266)
        Me.showEmbodegaFormBtn.Name = "showEmbodegaFormBtn"
        Me.showEmbodegaFormBtn.Size = New System.Drawing.Size(225, 83)
        Me.showEmbodegaFormBtn.TabIndex = 2
        Me.showEmbodegaFormBtn.Text = "EmbodegaLO"
        Me.showEmbodegaFormBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.showEmbodegaFormBtn.UseVisualStyleBackColor = True
        '
        'showVendeFormBtn
        '
        Me.showVendeFormBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showVendeFormBtn.Image = Global.VendeMeLA.My.Resources.Resources.Pdescarga
        Me.showVendeFormBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.showVendeFormBtn.Location = New System.Drawing.Point(29, 266)
        Me.showVendeFormBtn.Name = "showVendeFormBtn"
        Me.showVendeFormBtn.Size = New System.Drawing.Size(188, 83)
        Me.showVendeFormBtn.TabIndex = 1
        Me.showVendeFormBtn.Text = "VendeLO"
        Me.showVendeFormBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.showVendeFormBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(545, 257)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 357)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.clientesBTN)
        Me.Controls.Add(Me.showEmbodegaFormBtn)
        Me.Controls.Add(Me.showVendeFormBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = " "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents showVendeFormBtn As Button
    Friend WithEvents showEmbodegaFormBtn As Button
    Friend WithEvents clientesBTN As Button
    Friend WithEvents Button1 As Button
End Class
