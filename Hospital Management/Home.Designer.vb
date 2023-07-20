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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Pnt_view = New System.Windows.Forms.Button()
        Me.Pnt_del = New System.Windows.Forms.Button()
        Me.Pnt_updt = New System.Windows.Forms.Button()
        Me.Pnt_add = New System.Windows.Forms.Button()
        Me.all_apmt = New System.Windows.Forms.Button()
        Me.new_apmt = New System.Windows.Forms.Button()
        Me.fin_apmt = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'logout_btn
        '
        Me.logout_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout_btn.Location = New System.Drawing.Point(816, 28)
        Me.logout_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(105, 49)
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
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 28)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(230, 305)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Doctor"
        '
        'Doc_view
        '
        Me.Doc_view.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doc_view.Location = New System.Drawing.Point(12, 226)
        Me.Doc_view.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Doc_view.Name = "Doc_view"
        Me.Doc_view.Size = New System.Drawing.Size(202, 65)
        Me.Doc_view.TabIndex = 4
        Me.Doc_view.Text = "View"
        Me.Doc_view.UseVisualStyleBackColor = True
        '
        'Doc_del
        '
        Me.Doc_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doc_del.Location = New System.Drawing.Point(12, 159)
        Me.Doc_del.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Doc_del.Name = "Doc_del"
        Me.Doc_del.Size = New System.Drawing.Size(202, 66)
        Me.Doc_del.TabIndex = 3
        Me.Doc_del.Text = "Delete"
        Me.Doc_del.UseVisualStyleBackColor = True
        '
        'Doc_updt
        '
        Me.Doc_updt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doc_updt.Location = New System.Drawing.Point(12, 91)
        Me.Doc_updt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Doc_updt.Name = "Doc_updt"
        Me.Doc_updt.Size = New System.Drawing.Size(202, 66)
        Me.Doc_updt.TabIndex = 2
        Me.Doc_updt.Text = "Update"
        Me.Doc_updt.UseVisualStyleBackColor = True
        '
        'Doc_add
        '
        Me.Doc_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doc_add.Location = New System.Drawing.Point(12, 22)
        Me.Doc_add.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Doc_add.Name = "Doc_add"
        Me.Doc_add.Size = New System.Drawing.Size(202, 66)
        Me.Doc_add.TabIndex = 1
        Me.Doc_add.Text = "Add"
        Me.Doc_add.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Pnt_view)
        Me.GroupBox2.Controls.Add(Me.Pnt_del)
        Me.GroupBox2.Controls.Add(Me.Pnt_updt)
        Me.GroupBox2.Controls.Add(Me.Pnt_add)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(566, 28)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(225, 305)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Patient"
        '
        'Pnt_view
        '
        Me.Pnt_view.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pnt_view.Location = New System.Drawing.Point(12, 226)
        Me.Pnt_view.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pnt_view.Name = "Pnt_view"
        Me.Pnt_view.Size = New System.Drawing.Size(202, 66)
        Me.Pnt_view.TabIndex = 4
        Me.Pnt_view.Text = "View"
        Me.Pnt_view.UseVisualStyleBackColor = True
        '
        'Pnt_del
        '
        Me.Pnt_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pnt_del.Location = New System.Drawing.Point(12, 159)
        Me.Pnt_del.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pnt_del.Name = "Pnt_del"
        Me.Pnt_del.Size = New System.Drawing.Size(202, 66)
        Me.Pnt_del.TabIndex = 3
        Me.Pnt_del.Text = "Delete"
        Me.Pnt_del.UseVisualStyleBackColor = True
        '
        'Pnt_updt
        '
        Me.Pnt_updt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pnt_updt.Location = New System.Drawing.Point(12, 91)
        Me.Pnt_updt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pnt_updt.Name = "Pnt_updt"
        Me.Pnt_updt.Size = New System.Drawing.Size(202, 66)
        Me.Pnt_updt.TabIndex = 2
        Me.Pnt_updt.Text = "Update"
        Me.Pnt_updt.UseVisualStyleBackColor = True
        '
        'Pnt_add
        '
        Me.Pnt_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pnt_add.Location = New System.Drawing.Point(12, 22)
        Me.Pnt_add.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pnt_add.Name = "Pnt_add"
        Me.Pnt_add.Size = New System.Drawing.Size(202, 66)
        Me.Pnt_add.TabIndex = 1
        Me.Pnt_add.Text = "Add"
        Me.Pnt_add.UseVisualStyleBackColor = True
        '
        'all_apmt
        '
        Me.all_apmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.all_apmt.Location = New System.Drawing.Point(252, 232)
        Me.all_apmt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.all_apmt.Name = "all_apmt"
        Me.all_apmt.Size = New System.Drawing.Size(315, 104)
        Me.all_apmt.TabIndex = 9
        Me.all_apmt.Text = "View All Appointments"
        Me.all_apmt.UseCompatibleTextRendering = True
        Me.all_apmt.UseVisualStyleBackColor = False
        '
        'new_apmt
        '
        Me.new_apmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_apmt.Location = New System.Drawing.Point(252, 28)
        Me.new_apmt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.new_apmt.Name = "new_apmt"
        Me.new_apmt.Size = New System.Drawing.Size(315, 104)
        Me.new_apmt.TabIndex = 10
        Me.new_apmt.Text = "Book New Appointment"
        Me.new_apmt.UseCompatibleTextRendering = True
        Me.new_apmt.UseVisualStyleBackColor = False
        '
        'fin_apmt
        '
        Me.fin_apmt.BackColor = System.Drawing.SystemColors.Control
        Me.fin_apmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fin_apmt.Location = New System.Drawing.Point(252, 130)
        Me.fin_apmt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fin_apmt.Name = "fin_apmt"
        Me.fin_apmt.Size = New System.Drawing.Size(315, 104)
        Me.fin_apmt.TabIndex = 11
        Me.fin_apmt.Text = "Close Appointment"
        Me.fin_apmt.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 372)
        Me.Controls.Add(Me.fin_apmt)
        Me.Controls.Add(Me.new_apmt)
        Me.Controls.Add(Me.all_apmt)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.logout_btn)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents logout_btn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Doc_view As Button
    Friend WithEvents Doc_del As Button
    Friend WithEvents Doc_updt As Button
    Friend WithEvents Doc_add As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Pnt_view As Button
    Friend WithEvents Pnt_del As Button
    Friend WithEvents Pnt_updt As Button
    Friend WithEvents Pnt_add As Button
    Friend WithEvents all_apmt As Button
    Friend WithEvents new_apmt As Button
    Friend WithEvents fin_apmt As Button
End Class
