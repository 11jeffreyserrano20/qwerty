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
        Me.Fullname = New System.Windows.Forms.TextBox()
        Me.Subject = New System.Windows.Forms.TextBox()
        Me.Score = New System.Windows.Forms.TextBox()
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
        Me.badd.Location = New System.Drawing.Point(180, 263)
        Me.badd.Name = "badd"
        Me.badd.Size = New System.Drawing.Size(75, 23)
        Me.badd.TabIndex = 0
        Me.badd.Text = "ADD"
        Me.badd.UseVisualStyleBackColor = True
        '
        'Bupdate
        '
        Me.Bupdate.Location = New System.Drawing.Point(180, 323)
        Me.Bupdate.Name = "Bupdate"
        Me.Bupdate.Size = New System.Drawing.Size(75, 23)
        Me.Bupdate.TabIndex = 1
        Me.Bupdate.Text = "UPDATE"
        Me.Bupdate.UseVisualStyleBackColor = True
        '
        'Bdelete
        '
        Me.Bdelete.Location = New System.Drawing.Point(180, 380)
        Me.Bdelete.Name = "Bdelete"
        Me.Bdelete.Size = New System.Drawing.Size(75, 23)
        Me.Bdelete.TabIndex = 2
        Me.Bdelete.Text = "DELETE"
        Me.Bdelete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(324, 137)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(300, 190)
        Me.DataGridView1.TabIndex = 3
        '
        'Tsearch
        '
        Me.Tsearch.Location = New System.Drawing.Point(361, 86)
        Me.Tsearch.Name = "Tsearch"
        Me.Tsearch.Size = New System.Drawing.Size(230, 20)
        Me.Tsearch.TabIndex = 4
        '
        'Fullname
        '
        Me.Fullname.Location = New System.Drawing.Point(128, 112)
        Me.Fullname.Name = "Fullname"
        Me.Fullname.Size = New System.Drawing.Size(127, 20)
        Me.Fullname.TabIndex = 5
        '
        'Subject
        '
        Me.Subject.Location = New System.Drawing.Point(128, 148)
        Me.Subject.Name = "Subject"
        Me.Subject.Size = New System.Drawing.Size(127, 20)
        Me.Subject.TabIndex = 6
        '
        'Score
        '
        Me.Score.Location = New System.Drawing.Point(128, 177)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(127, 20)
        Me.Score.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Fullname:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Subject:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Score:"
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
        Me.Label5.Location = New System.Drawing.Point(90, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = " ID"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(805, 479)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Score)
        Me.Controls.Add(Me.Subject)
        Me.Controls.Add(Me.Fullname)
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
    Friend WithEvents Fullname As TextBox
    Friend WithEvents Subject As TextBox
    Friend WithEvents Score As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents id As TextBox
    Friend WithEvents Label5 As Label
End Class
