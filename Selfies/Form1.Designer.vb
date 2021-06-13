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
        Me.btn_Cheer = New System.Windows.Forms.Button()
        Me.btn_Connect = New System.Windows.Forms.Button()
        Me.lbl_Vote = New System.Windows.Forms.Label()
        Me.pic_Cheer = New System.Windows.Forms.PictureBox()
        Me.pic_Connect = New System.Windows.Forms.PictureBox()
        Me.btn_Select = New System.Windows.Forms.Button()
        Me.lbl_Choose = New System.Windows.Forms.Label()
        Me.lbl_Thanks = New System.Windows.Forms.Label()
        Me.btn_Exit = New System.Windows.Forms.Button()
        CType(Me.pic_Cheer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Connect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cheer
        '
        Me.btn_Cheer.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cheer.Location = New System.Drawing.Point(88, 128)
        Me.btn_Cheer.Name = "btn_Cheer"
        Me.btn_Cheer.Size = New System.Drawing.Size(270, 59)
        Me.btn_Cheer.TabIndex = 0
        Me.btn_Cheer.Text = "Finalist ""Cheer"""
        Me.btn_Cheer.UseVisualStyleBackColor = True
        '
        'btn_Connect
        '
        Me.btn_Connect.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Connect.Location = New System.Drawing.Point(610, 128)
        Me.btn_Connect.Name = "btn_Connect"
        Me.btn_Connect.Size = New System.Drawing.Size(270, 59)
        Me.btn_Connect.TabIndex = 1
        Me.btn_Connect.Text = "Finalist ""Connect"""
        Me.btn_Connect.UseVisualStyleBackColor = True
        '
        'lbl_Vote
        '
        Me.lbl_Vote.AutoSize = True
        Me.lbl_Vote.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Vote.Location = New System.Drawing.Point(205, 41)
        Me.lbl_Vote.Name = "lbl_Vote"
        Me.lbl_Vote.Size = New System.Drawing.Size(578, 42)
        Me.lbl_Vote.TabIndex = 3
        Me.lbl_Vote.Text = "Vote for the Best Campus Selfie"
        '
        'pic_Cheer
        '
        Me.pic_Cheer.Location = New System.Drawing.Point(27, 211)
        Me.pic_Cheer.Name = "pic_Cheer"
        Me.pic_Cheer.Size = New System.Drawing.Size(381, 429)
        Me.pic_Cheer.TabIndex = 4
        Me.pic_Cheer.TabStop = False
        '
        'pic_Connect
        '
        Me.pic_Connect.Location = New System.Drawing.Point(561, 211)
        Me.pic_Connect.Name = "pic_Connect"
        Me.pic_Connect.Size = New System.Drawing.Size(381, 429)
        Me.pic_Connect.TabIndex = 5
        Me.pic_Connect.TabStop = False
        '
        'btn_Select
        '
        Me.btn_Select.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Select.Location = New System.Drawing.Point(371, 678)
        Me.btn_Select.Name = "btn_Select"
        Me.btn_Select.Size = New System.Drawing.Size(234, 59)
        Me.btn_Select.TabIndex = 6
        Me.btn_Select.Text = "Select Selfie"
        Me.btn_Select.UseVisualStyleBackColor = True
        '
        'lbl_Choose
        '
        Me.lbl_Choose.AutoSize = True
        Me.lbl_Choose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Choose.Location = New System.Drawing.Point(82, 762)
        Me.lbl_Choose.Name = "lbl_Choose"
        Me.lbl_Choose.Size = New System.Drawing.Size(804, 31)
        Me.lbl_Choose.TabIndex = 7
        Me.lbl_Choose.Text = "Choose the best selfie and then click the Select Selfie button"
        '
        'lbl_Thanks
        '
        Me.lbl_Thanks.AutoSize = True
        Me.lbl_Thanks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Thanks.Location = New System.Drawing.Point(365, 805)
        Me.lbl_Thanks.Name = "lbl_Thanks"
        Me.lbl_Thanks.Size = New System.Drawing.Size(240, 31)
        Me.lbl_Thanks.TabIndex = 8
        Me.lbl_Thanks.Text = "Thanks for voting"
        '
        'btn_Exit
        '
        Me.btn_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.Location = New System.Drawing.Point(371, 867)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(234, 59)
        Me.btn_Exit.TabIndex = 9
        Me.btn_Exit.Text = "Exit Window"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 960)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.lbl_Thanks)
        Me.Controls.Add(Me.lbl_Choose)
        Me.Controls.Add(Me.btn_Select)
        Me.Controls.Add(Me.pic_Connect)
        Me.Controls.Add(Me.pic_Cheer)
        Me.Controls.Add(Me.lbl_Vote)
        Me.Controls.Add(Me.btn_Connect)
        Me.Controls.Add(Me.btn_Cheer)
        Me.Name = "Form1"
        Me.Text = "Vote for the Best Campus Selfie Finalist Pictures"
        CType(Me.pic_Cheer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Connect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Cheer As Button
    Friend WithEvents btn_Connect As Button
    Friend WithEvents lbl_Vote As Label
    Friend WithEvents pic_Cheer As PictureBox
    Friend WithEvents pic_Connect As PictureBox
    Friend WithEvents btn_Select As Button
    Friend WithEvents lbl_Choose As Label
    Friend WithEvents lbl_Thanks As Label
    Friend WithEvents btn_Exit As Button
End Class
