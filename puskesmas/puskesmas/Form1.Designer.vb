<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lbllogin = New Label()
        Button2 = New Button()
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        pb1 = New PictureBox()
        CheckBox1 = New CheckBox()
        CType(pb1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbllogin
        ' 
        lbllogin.AutoSize = True
        lbllogin.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbllogin.Location = New Point(76, 18)
        lbllogin.Name = "lbllogin"
        lbllogin.Size = New Size(288, 32)
        lbllogin.TabIndex = 0
        lbllogin.Text = "PUSKESMAS LOGIN"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.MenuHighlight
        Button2.Location = New Point(245, 440)
        Button2.Name = "Button2"
        Button2.Size = New Size(151, 54)
        Button2.TabIndex = 1
        Button2.Text = "CANCEL"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.MenuHighlight
        Button1.Location = New Point(51, 440)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 54)
        Button1.TabIndex = 2
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(51, 350)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(343, 27)
        TextBox1.TabIndex = 3
        TextBox1.Tag = ""
        TextBox1.Text = "Username"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(51, 397)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(343, 27)
        TextBox2.TabIndex = 4
        TextBox2.Text = "Password"
        ' 
        ' pb1
        ' 
        pb1.Image = My.Resources.Resources.loginawal
        pb1.Location = New Point(95, 69)
        pb1.Name = "pb1"
        pb1.Size = New Size(269, 251)
        pb1.SizeMode = PictureBoxSizeMode.StretchImage
        pb1.TabIndex = 5
        pb1.TabStop = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox1.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        CheckBox1.Location = New Point(51, 511)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(208, 27)
        CheckBox1.TabIndex = 6
        CheckBox1.Text = "SHOW PASSWORD"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ClientSize = New Size(445, 552)
        Controls.Add(CheckBox1)
        Controls.Add(pb1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(lbllogin)
        Name = "Form1"
        Text = "Form1"
        CType(pb1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbllogin As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox

End Class
