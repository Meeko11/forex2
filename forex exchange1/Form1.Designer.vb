<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CRT1 = New System.Windows.Forms.ComboBox()
        Me.CRT2 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.CPT = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(144, 373)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(263, 50)
        Me.TextBox1.TabIndex = 0
        '
        'CRT1
        '
        Me.CRT1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CRT1.FormattingEnabled = True
        Me.CRT1.Items.AddRange(New Object() {"US DOLLAR", "HKG DOLLAR ", "CND DOLLAR ", "IND RUPEE", "SRL RUPEE", "UAE DINAR", "UK POUND", "JPN YEN ", "EURO", "PH PESO"})
        Me.CRT1.Location = New System.Drawing.Point(183, 162)
        Me.CRT1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CRT1.Name = "CRT1"
        Me.CRT1.Size = New System.Drawing.Size(176, 28)
        Me.CRT1.TabIndex = 1
        '
        'CRT2
        '
        Me.CRT2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CRT2.FormattingEnabled = True
        Me.CRT2.Items.AddRange(New Object() {"US DOLLAR", "HKG DOLLAR ", "CND DOLLAR ", "IND RUPEE", "SRL RUPEE", "UAE DINAR", "PHP PESO", "UK POUND", "JPN YEN ", "EURO", "PH PESO"})
        Me.CRT2.Location = New System.Drawing.Point(183, 262)
        Me.CRT2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CRT2.Name = "CRT2"
        Me.CRT2.Size = New System.Drawing.Size(176, 28)
        Me.CRT2.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(144, 78)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(263, 45)
        Me.TextBox2.TabIndex = 5
        '
        'CPT
        '
        Me.CPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPT.Location = New System.Drawing.Point(144, 442)
        Me.CPT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CPT.Name = "CPT"
        Me.CPT.Size = New System.Drawing.Size(264, 49)
        Me.CPT.TabIndex = 6
        Me.CPT.Text = "COMPUTE"
        Me.CPT.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(243, 207)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(61, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(243, 299)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 521)
        Me.Controls.Add(Me.CPT)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CRT2)
        Me.Controls.Add(Me.CRT1)
        Me.Controls.Add(Me.TextBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "form1"
        Me.Text = "forex exchange"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CRT1 As ComboBox
    Friend WithEvents CRT2 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CPT As Button
End Class
