<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pnt_add
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
        Me.add_pnt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnt_name_txt = New System.Windows.Forms.TextBox()
        Me.pnt_gen_txt = New System.Windows.Forms.TextBox()
        Me.pnt_age_txt = New System.Windows.Forms.TextBox()
        Me.pnt_address_txt = New System.Windows.Forms.TextBox()
        Me.pnt_num_txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bck_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'add_pnt
        '
        Me.add_pnt.Location = New System.Drawing.Point(28, 242)
        Me.add_pnt.Name = "add_pnt"
        Me.add_pnt.Size = New System.Drawing.Size(209, 38)
        Me.add_pnt.TabIndex = 0
        Me.add_pnt.Text = "Add"
        Me.add_pnt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Age"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Contact Number"
        '
        'pnt_name_txt
        '
        Me.pnt_name_txt.Location = New System.Drawing.Point(137, 40)
        Me.pnt_name_txt.Name = "pnt_name_txt"
        Me.pnt_name_txt.Size = New System.Drawing.Size(100, 20)
        Me.pnt_name_txt.TabIndex = 6
        '
        'pnt_gen_txt
        '
        Me.pnt_gen_txt.Location = New System.Drawing.Point(137, 66)
        Me.pnt_gen_txt.Name = "pnt_gen_txt"
        Me.pnt_gen_txt.Size = New System.Drawing.Size(100, 20)
        Me.pnt_gen_txt.TabIndex = 7
        '
        'pnt_age_txt
        '
        Me.pnt_age_txt.Location = New System.Drawing.Point(137, 92)
        Me.pnt_age_txt.Name = "pnt_age_txt"
        Me.pnt_age_txt.Size = New System.Drawing.Size(100, 20)
        Me.pnt_age_txt.TabIndex = 8
        '
        'pnt_address_txt
        '
        Me.pnt_address_txt.Location = New System.Drawing.Point(137, 118)
        Me.pnt_address_txt.Multiline = True
        Me.pnt_address_txt.Name = "pnt_address_txt"
        Me.pnt_address_txt.Size = New System.Drawing.Size(100, 92)
        Me.pnt_address_txt.TabIndex = 9
        '
        'pnt_num_txt
        '
        Me.pnt_num_txt.Location = New System.Drawing.Point(137, 216)
        Me.pnt_num_txt.Name = "pnt_num_txt"
        Me.pnt_num_txt.Size = New System.Drawing.Size(100, 20)
        Me.pnt_num_txt.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Enter Patient Details"
        '
        'bck_btn
        '
        Me.bck_btn.Location = New System.Drawing.Point(236, 9)
        Me.bck_btn.Name = "bck_btn"
        Me.bck_btn.Size = New System.Drawing.Size(72, 24)
        Me.bck_btn.TabIndex = 12
        Me.bck_btn.Text = "Back"
        Me.bck_btn.UseVisualStyleBackColor = True
        '
        'Pnt_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 309)
        Me.Controls.Add(Me.bck_btn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pnt_num_txt)
        Me.Controls.Add(Me.pnt_address_txt)
        Me.Controls.Add(Me.pnt_age_txt)
        Me.Controls.Add(Me.pnt_gen_txt)
        Me.Controls.Add(Me.pnt_name_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.add_pnt)
        Me.Name = "Pnt_add"
        Me.Text = "Pnt_add"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents add_pnt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pnt_name_txt As TextBox
    Friend WithEvents pnt_gen_txt As TextBox
    Friend WithEvents pnt_age_txt As TextBox
    Friend WithEvents pnt_address_txt As TextBox
    Friend WithEvents pnt_num_txt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents bck_btn As Button
End Class
