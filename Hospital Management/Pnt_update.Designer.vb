<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pnt_update
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
        Me.components = New System.ComponentModel.Container()
        Me.bck_btn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.update_pnt = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.update = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PatientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HospitalDataSet = New Hospital_Management.HospitalDataSet()
        Me.PatientsTableAdapter = New Hospital_Management.HospitalDataSetTableAdapters.PatientsTableAdapter()
        Me.pnt_num_txt = New System.Windows.Forms.TextBox()
        Me.pnt_address_txt = New System.Windows.Forms.TextBox()
        Me.pnt_age_txt = New System.Windows.Forms.TextBox()
        Me.pnt_name_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gender = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bck_btn
        '
        Me.bck_btn.Location = New System.Drawing.Point(1206, 43)
        Me.bck_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bck_btn.Name = "bck_btn"
        Me.bck_btn.Size = New System.Drawing.Size(108, 37)
        Me.bck_btn.TabIndex = 25
        Me.bck_btn.Text = "Back"
        Me.bck_btn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 18)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Update Patient Details"
        '
        'update_pnt
        '
        Me.update_pnt.Location = New System.Drawing.Point(652, 754)
        Me.update_pnt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.update_pnt.Name = "update_pnt"
        Me.update_pnt.Size = New System.Drawing.Size(171, 58)
        Me.update_pnt.TabIndex = 13
        Me.update_pnt.Text = "Update Records"
        Me.update_pnt.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.update, Me.PatientIDDataGridViewTextBoxColumn, Me.PatientNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PatientsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(30, 43)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(1167, 246)
        Me.DataGridView1.TabIndex = 26
        '
        'update
        '
        Me.update.HeaderText = "To Update"
        Me.update.MinimumWidth = 8
        Me.update.Name = "update"
        Me.update.ReadOnly = True
        Me.update.Width = 90
        '
        'PatientIDDataGridViewTextBoxColumn
        '
        Me.PatientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID"
        Me.PatientIDDataGridViewTextBoxColumn.HeaderText = "PatientID"
        Me.PatientIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PatientIDDataGridViewTextBoxColumn.Name = "PatientIDDataGridViewTextBoxColumn"
        Me.PatientIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatientIDDataGridViewTextBoxColumn.Width = 112
        '
        'PatientNameDataGridViewTextBoxColumn
        '
        Me.PatientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName"
        Me.PatientNameDataGridViewTextBoxColumn.HeaderText = "PatientName"
        Me.PatientNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PatientNameDataGridViewTextBoxColumn.Name = "PatientNameDataGridViewTextBoxColumn"
        Me.PatientNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatientNameDataGridViewTextBoxColumn.Width = 137
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        Me.GenderDataGridViewTextBoxColumn.Width = 99
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.ReadOnly = True
        Me.AgeDataGridViewTextBoxColumn.Width = 74
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.AddressDataGridViewTextBoxColumn.Width = 104
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        Me.ContactNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.ContactNumberDataGridViewTextBoxColumn.Width = 157
        '
        'PatientsBindingSource
        '
        Me.PatientsBindingSource.DataMember = "Patients"
        Me.PatientsBindingSource.DataSource = Me.HospitalDataSet
        '
        'HospitalDataSet
        '
        Me.HospitalDataSet.DataSetName = "HospitalDataSet"
        Me.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientsTableAdapter
        '
        Me.PatientsTableAdapter.ClearBeforeFill = True
        '
        'pnt_num_txt
        '
        Me.pnt_num_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnt_num_txt.Location = New System.Drawing.Point(764, 615)
        Me.pnt_num_txt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnt_num_txt.Name = "pnt_num_txt"
        Me.pnt_num_txt.Size = New System.Drawing.Size(148, 35)
        Me.pnt_num_txt.TabIndex = 37
        '
        'pnt_address_txt
        '
        Me.pnt_address_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnt_address_txt.Location = New System.Drawing.Point(764, 465)
        Me.pnt_address_txt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnt_address_txt.Multiline = True
        Me.pnt_address_txt.Name = "pnt_address_txt"
        Me.pnt_address_txt.Size = New System.Drawing.Size(148, 139)
        Me.pnt_address_txt.TabIndex = 36
        '
        'pnt_age_txt
        '
        Me.pnt_age_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnt_age_txt.Location = New System.Drawing.Point(764, 425)
        Me.pnt_age_txt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnt_age_txt.Name = "pnt_age_txt"
        Me.pnt_age_txt.Size = New System.Drawing.Size(148, 35)
        Me.pnt_age_txt.TabIndex = 35
        '
        'pnt_name_txt
        '
        Me.pnt_name_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnt_name_txt.Location = New System.Drawing.Point(764, 345)
        Me.pnt_name_txt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnt_name_txt.Name = "pnt_name_txt"
        Me.pnt_name_txt.Size = New System.Drawing.Size(148, 35)
        Me.pnt_name_txt.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(562, 620)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 29)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Contact Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(562, 469)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 29)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(562, 429)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 29)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Age"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(562, 389)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 29)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Gender"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(562, 349)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 29)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Name"
        '
        'gender
        '
        Me.gender.FormattingEnabled = True
        Me.gender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.gender.Location = New System.Drawing.Point(764, 390)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(148, 28)
        Me.gender.TabIndex = 44
        '
        'Pnt_update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1431, 832)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.pnt_num_txt)
        Me.Controls.Add(Me.pnt_address_txt)
        Me.Controls.Add(Me.pnt_age_txt)
        Me.Controls.Add(Me.pnt_name_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.bck_btn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.update_pnt)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Pnt_update"
        Me.Text = "Pnt_update"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bck_btn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents update_pnt As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents HospitalDataSet As HospitalDataSet
    Friend WithEvents PatientsBindingSource As BindingSource
    Friend WithEvents PatientsTableAdapter As HospitalDataSetTableAdapters.PatientsTableAdapter
    Friend WithEvents update As DataGridViewButtonColumn
    Friend WithEvents PatientIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents pnt_num_txt As TextBox
    Friend WithEvents pnt_address_txt As TextBox
    Friend WithEvents pnt_age_txt As TextBox
    Friend WithEvents pnt_name_txt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents gender As ComboBox
End Class
