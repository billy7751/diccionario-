<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.P = New System.Windows.Forms.Label()
        Me.S = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(318, 77)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(427, 256)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'P
        '
        Me.P.AutoSize = True
        Me.P.ForeColor = System.Drawing.SystemColors.Menu
        Me.P.Location = New System.Drawing.Point(43, 262)
        Me.P.Name = "P"
        Me.P.Size = New System.Drawing.Size(0, 13)
        Me.P.TabIndex = 3
        '
        'S
        '
        Me.S.AutoSize = True
        Me.S.ForeColor = System.Drawing.SystemColors.Menu
        Me.S.Location = New System.Drawing.Point(43, 296)
        Me.S.Name = "S"
        Me.S.Size = New System.Drawing.Size(0, 13)
        Me.S.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(157, 129)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 53)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "ListView"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(157, 210)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 51)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Listas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.S)
        Me.Controls.Add(Me.P)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents P As Label
    Friend WithEvents S As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
