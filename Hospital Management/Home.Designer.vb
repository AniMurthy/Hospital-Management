<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Me.logout_btn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Doc_view = New System.Windows.Forms.Button()
        Me.Doc_del = New System.Windows.Forms.Button()
        Me.Doc_updt = New System.Windows.Forms.Button()
        Me.Doc_add = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Pnt_view = New System.Windows.Forms.Button()
        Me.Pnt_del = New System.Windows.Forms.Button()
        Me.Pnt_updt = New System.Windows.Forms.Button()
        Me.Pnt_add = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.new_apmt = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'logout_btn
        '
        Me.logout_btn.Location = New System.Drawing.Point(544, 18)
        Me.logout_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(70, 29)
        Me.logout_btn.TabIndex = 6
        Me.logout_btn.Text = "Logout"
        Me.logout_btn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Doc_view)
        Me.GroupBox1.Controls.Add(Me.Doc_del)
        Me.GroupBox1.Controls.Add(Me.Doc_updt)
        Me.GroupBox1.Controls.Add(Me.Doc_add)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(153, 197)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Doc_view
        '
        Me.Doc_view.Location = New System.Drawing.Point(8, 151)
        Me.Doc_view.Margin = New System.Windows.Forms.Padding(2)
        Me.Doc_view.Name = "Doc_view"
        Me.Doc_view.Size = New System.Drawing.Size(135, 36)
        Me.Doc_view.TabIndex = 4
        Me.Doc_view.Text = "View"
        Me.Doc_view.UseVisualStyleBackColor = True
        '
        'Doc_del
        '
        Me.Doc_del.Location = New System.Drawing.Point(8, 111)
        Me.Doc_del.Margin = New System.Windows.Forms.Padding(2)
        Me.Doc_del.Name = "Doc_del"
        Me.Doc_del.Size = New System.Drawing.Size(135, 36)
        Me.Doc_del.TabIndex = 3
        Me.Doc_del.Text = "Delete"
        Me.Doc_del.UseVisualStyleBackColor = True
        '
        'Doc_updt
        '
        Me.Doc_updt.Location = New System.Drawing.Point(8, 71)
        Me.Doc_updt.Margin = New System.Windows.Forms.Padding(2)
        Me.Doc_updt.Name = "Doc_updt"
        Me.Doc_updt.Size = New System.Drawing.Size(135, 36)
        Me.Doc_updt.TabIndex = 2
        Me.Doc_updt.Text = "Update"
        Me.Doc_updt.UseVisualStyleBackColor = True
        '
        'Doc_add
        '
        Me.Doc_add.Location = New System.Drawing.Point(8, 31)
        Me.Doc_add.Margin = New System.Windows.Forms.Padding(2)
        Me.Doc_add.Name = "Doc_add"
        Me.Doc_add.Size = New System.Drawing.Size(135, 36)
        Me.Doc_add.TabIndex = 1
        Me.Doc_add.Text = "Add"
        Me.Doc_add.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Doctor"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Pnt_view)
        Me.GroupBox2.Controls.Add(Me.Pnt_del)
        Me.GroupBox2.Controls.Add(Me.Pnt_updt)
        Me.GroupBox2.Controls.Add(Me.Pnt_add)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(377, 18)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(153, 197)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Pnt_view
        '
        Me.Pnt_view.Location = New System.Drawing.Point(8, 151)
        Me.Pnt_view.Margin = New System.Windows.Forms.Padding(2)
        Me.Pnt_view.Name = "Pnt_view"
        Me.Pnt_view.Size = New System.Drawing.Size(135, 36)
        Me.Pnt_view.TabIndex = 4
        Me.Pnt_view.Text = "View"
        Me.Pnt_view.UseVisualStyleBackColor = True
        '
        'Pnt_del
        '
        Me.Pnt_del.Location = New System.Drawing.Point(8, 111)
        Me.Pnt_del.Margin = New System.Windows.Forms.Padding(2)
        Me.Pnt_del.Name = "Pnt_del"
        Me.Pnt_del.Size = New System.Drawing.Size(135, 36)
        Me.Pnt_del.TabIndex = 3
        Me.Pnt_del.Text = "Delete"
        Me.Pnt_del.UseVisualStyleBackColor = True
        '
        'Pnt_updt
        '
        Me.Pnt_updt.Location = New System.Drawing.Point(8, 71)
        Me.Pnt_updt.Margin = New System.Windows.Forms.Padding(2)
        Me.Pnt_updt.Name = "Pnt_updt"
        Me.Pnt_updt.Size = New System.Drawing.Size(135, 36)
        Me.Pnt_updt.TabIndex = 2
        Me.Pnt_updt.Text = "Update"
        Me.Pnt_updt.UseVisualStyleBackColor = True
        '
        'Pnt_add
        '
        Me.Pnt_add.Location = New System.Drawing.Point(8, 31)
        Me.Pnt_add.Margin = New System.Windows.Forms.Padding(2)
        Me.Pnt_add.Name = "Pnt_add"
        Me.Pnt_add.Size = New System.Drawing.Size(135, 36)
        Me.Pnt_add.TabIndex = 1
        Me.Pnt_add.Text = "Add"
        Me.Pnt_add.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Patient"
        '
        'new_apmt
        '
        Me.new_apmt.Location = New System.Drawing.Point(168, 27)
        Me.new_apmt.Margin = New System.Windows.Forms.Padding(2)
        Me.new_apmt.Name = "new_apmt"
        Me.new_apmt.Size = New System.Drawing.Size(210, 92)
        Me.new_apmt.TabIndex = 9
        Me.new_apmt.Text = "View All Appointments"
        Me.new_apmt.UseCompatibleTextRendering = True
        Me.new_apmt.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(168, 123)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 92)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Book New Appointment"
        Me.Button1.UseCompatibleTextRendering = True
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 311)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.new_apmt)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.logout_btn)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents logout_btn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Doc_view As Button
    Friend WithEvents Doc_del As Button
    Friend WithEvents Doc_updt As Button
    Friend WithEvents Doc_add As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Pnt_view As Button
    Friend WithEvents Pnt_del As Button
    Friend WithEvents Pnt_updt As Button
    Friend WithEvents Pnt_add As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents new_apmt As Button
    Friend WithEvents Button1 As Button
End Class
