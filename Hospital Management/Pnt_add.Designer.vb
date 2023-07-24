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
        Me.pnt_age_txt = New System.Windows.Forms.TextBox()
        Me.pnt_address_txt = New System.Windows.Forms.TextBox()
        Me.pnt_num_txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bck_btn = New System.Windows.Forms.Button()
        Me.gender = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'add_pnt
        '
        Me.add_pnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_pnt.Location = New System.Drawing.Point(132, 414)
        Me.add_pnt.Margin = New System.Windows.Forms.Padding(4)
        Me.add_pnt.Name = "add_pnt"
        Me.add_pnt.Size = New System.Drawing.Size(279, 46)
        Me.add_pnt.TabIndex = 0
        Me.add_pnt.Text = "Add"
        Me.add_pnt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Age"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 160)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 284)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Contact Number"
        '
        'pnt_name_txt
        '
        Me.pnt_name_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnt_name_txt.Location = New System.Drawing.Point(277, 42)
        Me.pnt_name_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.pnt_name_txt.Name = "pnt_name_txt"
        Me.pnt_name_txt.Size = New System.Drawing.Size(132, 30)
        Me.pnt_name_txt.TabIndex = 6
        '
        'pnt_age_txt
        '
        Me.pnt_age_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnt_age_txt.Location = New System.Drawing.Point(277, 121)
        Me.pnt_age_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.pnt_age_txt.MaxLength = 3
        Me.pnt_age_txt.Name = "pnt_age_txt"
        Me.pnt_age_txt.Size = New System.Drawing.Size(132, 30)
        Me.pnt_age_txt.TabIndex = 8
        '
        'pnt_address_txt
        '
        Me.pnt_address_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnt_address_txt.Location = New System.Drawing.Point(277, 160)
        Me.pnt_address_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.pnt_address_txt.Multiline = True
        Me.pnt_address_txt.Name = "pnt_address_txt"
        Me.pnt_address_txt.Size = New System.Drawing.Size(132, 112)
        Me.pnt_address_txt.TabIndex = 9
        '
        'pnt_num_txt
        '
        Me.pnt_num_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnt_num_txt.Location = New System.Drawing.Point(277, 281)
        Me.pnt_num_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.pnt_num_txt.MaxLength = 10
        Me.pnt_num_txt.Name = "pnt_num_txt"
        Me.pnt_num_txt.Size = New System.Drawing.Size(132, 30)
        Me.pnt_num_txt.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 11)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Enter Patient Details"
        '
        'bck_btn
        '
        Me.bck_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bck_btn.Location = New System.Drawing.Point(445, 6)
        Me.bck_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.bck_btn.Name = "bck_btn"
        Me.bck_btn.Size = New System.Drawing.Size(96, 30)
        Me.bck_btn.TabIndex = 12
        Me.bck_btn.Text = "Back"
        Me.bck_btn.UseVisualStyleBackColor = True
        '
        'gender
        '
        Me.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gender.FormattingEnabled = True
        Me.gender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.gender.Location = New System.Drawing.Point(277, 85)
        Me.gender.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(132, 24)
        Me.gender.TabIndex = 43
        '
        'Pnt_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 492)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.bck_btn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pnt_num_txt)
        Me.Controls.Add(Me.pnt_address_txt)
        Me.Controls.Add(Me.pnt_age_txt)
        Me.Controls.Add(Me.pnt_name_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.add_pnt)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents pnt_age_txt As TextBox
    Friend WithEvents pnt_address_txt As TextBox
    Friend WithEvents pnt_num_txt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents bck_btn As Button
    Friend WithEvents gender As ComboBox
End Class
