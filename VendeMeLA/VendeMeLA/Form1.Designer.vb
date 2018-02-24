<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.showVendeFormBtn = New System.Windows.Forms.Button()
        Me.showEmbodegaFormBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(41, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(479, 261)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'showVendeFormBtn
        '
        Me.showVendeFormBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showVendeFormBtn.Location = New System.Drawing.Point(41, 344)
        Me.showVendeFormBtn.Name = "showVendeFormBtn"
        Me.showVendeFormBtn.Size = New System.Drawing.Size(156, 42)
        Me.showVendeFormBtn.TabIndex = 1
        Me.showVendeFormBtn.Text = "VendeLO"
        Me.showVendeFormBtn.UseVisualStyleBackColor = True
        '
        'showEmbodegaFormBtn
        '
        Me.showEmbodegaFormBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showEmbodegaFormBtn.Location = New System.Drawing.Point(364, 344)
        Me.showEmbodegaFormBtn.Name = "showEmbodegaFormBtn"
        Me.showEmbodegaFormBtn.Size = New System.Drawing.Size(156, 42)
        Me.showEmbodegaFormBtn.TabIndex = 2
        Me.showEmbodegaFormBtn.Text = "EmbodegaLO"
        Me.showEmbodegaFormBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 412)
        Me.Controls.Add(Me.showEmbodegaFormBtn)
        Me.Controls.Add(Me.showVendeFormBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "VendeMeLA Systems ..."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents showVendeFormBtn As Button
    Friend WithEvents showEmbodegaFormBtn As Button
End Class
