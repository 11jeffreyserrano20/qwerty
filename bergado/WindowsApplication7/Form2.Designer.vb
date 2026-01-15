<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.fname = New System.Windows.Forms.TextBox()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.age = New System.Windows.Forms.TextBox()
        Me.uname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.male = New System.Windows.Forms.RadioButton()
        Me.female = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pimage = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.pimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fname
        '
        Me.fname.Location = New System.Drawing.Point(410, 164)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(143, 20)
        Me.fname.TabIndex = 0
        '
        'lname
        '
        Me.lname.Location = New System.Drawing.Point(410, 200)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(143, 20)
        Me.lname.TabIndex = 1
        '
        'age
        '
        Me.age.Location = New System.Drawing.Point(410, 275)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(143, 20)
        Me.age.TabIndex = 2
        '
        'uname
        '
        Me.uname.Location = New System.Drawing.Point(410, 314)
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(143, 20)
        Me.uname.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(344, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(343, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(349, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Gender:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(344, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Username:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(478, 406)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Enter:"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(344, 353)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Password:"
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(410, 349)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(143, 20)
        Me.pass.TabIndex = 9
        Me.pass.Text = " "
        '
        'male
        '
        Me.male.AutoSize = True
        Me.male.Location = New System.Drawing.Point(410, 241)
        Me.male.Name = "male"
        Me.male.Size = New System.Drawing.Size(48, 17)
        Me.male.TabIndex = 11
        Me.male.TabStop = True
        Me.male.Text = "Male"
        Me.male.UseVisualStyleBackColor = True
        '
        'female
        '
        Me.female.AutoSize = True
        Me.female.Location = New System.Drawing.Point(464, 241)
        Me.female.Name = "female"
        Me.female.Size = New System.Drawing.Size(59, 17)
        Me.female.TabIndex = 12
        Me.female.TabStop = True
        Me.female.Text = "Female"
        Me.female.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(349, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Age:"
        '
        'pimage
        '
        Me.pimage.Location = New System.Drawing.Point(413, 24)
        Me.pimage.Name = "pimage"
        Me.pimage.Size = New System.Drawing.Size(143, 107)
        Me.pimage.TabIndex = 14
        Me.pimage.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(432, 135)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(397, 406)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(410, 380)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(143, 20)
        Me.email.TabIndex = 17
        Me.email.Text = " "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(344, 383)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(344, 387)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Email"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 527)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.pimage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.female)
        Me.Controls.Add(Me.male)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.uname)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.fname)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.pimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fname As TextBox
    Friend WithEvents lname As TextBox
    Friend WithEvents age As TextBox
    Friend WithEvents uname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents pass As TextBox
    Friend WithEvents male As RadioButton
    Friend WithEvents female As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents pimage As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents email As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
