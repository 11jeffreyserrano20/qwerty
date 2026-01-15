<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.badd = New System.Windows.Forms.Button()
        Me.Bupdate = New System.Windows.Forms.Button()
        Me.Bdelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Tsearch = New System.Windows.Forms.TextBox()
        Me.studentsname = New System.Windows.Forms.TextBox()
        Me.adress = New System.Windows.Forms.TextBox()
        Me.schoollevel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'badd
        '
        Me.badd.Location = New System.Drawing.Point(425, 297)
        Me.badd.Name = "badd"
        Me.badd.Size = New System.Drawing.Size(75, 23)
        Me.badd.TabIndex = 0
        Me.badd.Text = "ADD"
        Me.badd.UseVisualStyleBackColor = True
        '
        'Bupdate
        '
        Me.Bupdate.Location = New System.Drawing.Point(425, 335)
        Me.Bupdate.Name = "Bupdate"
        Me.Bupdate.Size = New System.Drawing.Size(75, 23)
        Me.Bupdate.TabIndex = 1
        Me.Bupdate.Text = "UPDATE"
        Me.Bupdate.UseVisualStyleBackColor = True
        '
        'Bdelete
        '
        Me.Bdelete.Location = New System.Drawing.Point(425, 378)
        Me.Bdelete.Name = "Bdelete"
        Me.Bdelete.Size = New System.Drawing.Size(75, 23)
        Me.Bdelete.TabIndex = 2
        Me.Bdelete.Text = "DELETE"
        Me.Bdelete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(107, 277)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(300, 190)
        Me.DataGridView1.TabIndex = 3
        '
        'Tsearch
        '
        Me.Tsearch.Location = New System.Drawing.Point(138, 242)
        Me.Tsearch.Name = "Tsearch"
        Me.Tsearch.Size = New System.Drawing.Size(230, 20)
        Me.Tsearch.TabIndex = 4
        '
        'studentsname
        '
        Me.studentsname.Location = New System.Drawing.Point(128, 112)
        Me.studentsname.Name = "studentsname"
        Me.studentsname.Size = New System.Drawing.Size(127, 20)
        Me.studentsname.TabIndex = 5
        '
        'adress
        '
        Me.adress.Location = New System.Drawing.Point(128, 148)
        Me.adress.Name = "adress"
        Me.adress.Size = New System.Drawing.Size(127, 20)
        Me.adress.TabIndex = 6
        '
        'schoollevel
        '
        Me.schoollevel.Location = New System.Drawing.Point(128, 177)
        Me.schoollevel.Name = "schoollevel"
        Me.schoollevel.Size = New System.Drawing.Size(127, 20)
        Me.schoollevel.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "StudentsName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Adress"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "School level"
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(128, 86)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(127, 20)
        Me.id.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = " ID"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(805, 479)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.schoollevel)
        Me.Controls.Add(Me.adress)
        Me.Controls.Add(Me.studentsname)
        Me.Controls.Add(Me.Tsearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Bdelete)
        Me.Controls.Add(Me.Bupdate)
        Me.Controls.Add(Me.badd)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents badd As Button
    Friend WithEvents Bupdate As Button
    Friend WithEvents Bdelete As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Tsearch As TextBox
    Friend WithEvents studentsname As TextBox
    Friend WithEvents adress As TextBox
    Friend WithEvents schoollevel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents id As TextBox
    Friend WithEvents Label5 As Label
End Class
