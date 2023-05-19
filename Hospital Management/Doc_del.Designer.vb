<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doc_del
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.HospitalDataSet1 = New Hospital_Management.HospitalDataSet1()
        Me.DoctorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DoctorTableAdapter = New Hospital_Management.HospitalDataSet1TableAdapters.DoctorTableAdapter()
        Me.bck_btn = New System.Windows.Forms.Button()
        Me.del_rec = New System.Windows.Forms.Button()
        Me.del = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DocIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecialisationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QualificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HospitalDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.del, Me.DocIDDataGridViewTextBoxColumn, Me.DocNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.SpecialisationDataGridViewTextBoxColumn, Me.QualificationDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.EmailIDDataGridViewTextBoxColumn, Me.SalaryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DoctorBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(14, 32)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(549, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'HospitalDataSet1
        '
        Me.HospitalDataSet1.DataSetName = "HospitalDataSet1"
        Me.HospitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DoctorBindingSource
        '
        Me.DoctorBindingSource.DataMember = "Doctor"
        Me.DoctorBindingSource.DataSource = Me.HospitalDataSet1
        '
        'DoctorTableAdapter
        '
        Me.DoctorTableAdapter.ClearBeforeFill = True
        '
        'bck_btn
        '
        Me.bck_btn.Location = New System.Drawing.Point(633, 31)
        Me.bck_btn.Name = "bck_btn"
        Me.bck_btn.Size = New System.Drawing.Size(125, 29)
        Me.bck_btn.TabIndex = 1
        Me.bck_btn.Text = "Back"
        Me.bck_btn.UseVisualStyleBackColor = True
        '
        'del_rec
        '
        Me.del_rec.Location = New System.Drawing.Point(624, 144)
        Me.del_rec.Name = "del_rec"
        Me.del_rec.Size = New System.Drawing.Size(133, 37)
        Me.del_rec.TabIndex = 2
        Me.del_rec.Text = "Delete Records"
        Me.del_rec.UseVisualStyleBackColor = True
        '
        'del
        '
        Me.del.HeaderText = "To Delete"
        Me.del.MinimumWidth = 6
        Me.del.Name = "del"
        Me.del.Width = 125
        '
        'DocIDDataGridViewTextBoxColumn
        '
        Me.DocIDDataGridViewTextBoxColumn.DataPropertyName = "DocID"
        Me.DocIDDataGridViewTextBoxColumn.HeaderText = "DocID"
        Me.DocIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DocIDDataGridViewTextBoxColumn.Name = "DocIDDataGridViewTextBoxColumn"
        Me.DocIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DocIDDataGridViewTextBoxColumn.Width = 125
        '
        'DocNameDataGridViewTextBoxColumn
        '
        Me.DocNameDataGridViewTextBoxColumn.DataPropertyName = "DocName"
        Me.DocNameDataGridViewTextBoxColumn.HeaderText = "DocName"
        Me.DocNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DocNameDataGridViewTextBoxColumn.Name = "DocNameDataGridViewTextBoxColumn"
        Me.DocNameDataGridViewTextBoxColumn.Width = 125
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.Width = 125
        '
        'SpecialisationDataGridViewTextBoxColumn
        '
        Me.SpecialisationDataGridViewTextBoxColumn.DataPropertyName = "Specialisation"
        Me.SpecialisationDataGridViewTextBoxColumn.HeaderText = "Specialisation"
        Me.SpecialisationDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SpecialisationDataGridViewTextBoxColumn.Name = "SpecialisationDataGridViewTextBoxColumn"
        Me.SpecialisationDataGridViewTextBoxColumn.Width = 125
        '
        'QualificationDataGridViewTextBoxColumn
        '
        Me.QualificationDataGridViewTextBoxColumn.DataPropertyName = "Qualification"
        Me.QualificationDataGridViewTextBoxColumn.HeaderText = "Qualification"
        Me.QualificationDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QualificationDataGridViewTextBoxColumn.Name = "QualificationDataGridViewTextBoxColumn"
        Me.QualificationDataGridViewTextBoxColumn.Width = 125
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.Width = 125
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        Me.ContactNumberDataGridViewTextBoxColumn.Width = 125
        '
        'EmailIDDataGridViewTextBoxColumn
        '
        Me.EmailIDDataGridViewTextBoxColumn.DataPropertyName = "EmailID"
        Me.EmailIDDataGridViewTextBoxColumn.HeaderText = "EmailID"
        Me.EmailIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailIDDataGridViewTextBoxColumn.Name = "EmailIDDataGridViewTextBoxColumn"
        Me.EmailIDDataGridViewTextBoxColumn.Width = 125
        '
        'SalaryDataGridViewTextBoxColumn
        '
        Me.SalaryDataGridViewTextBoxColumn.DataPropertyName = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.HeaderText = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SalaryDataGridViewTextBoxColumn.Name = "SalaryDataGridViewTextBoxColumn"
        Me.SalaryDataGridViewTextBoxColumn.Width = 125
        '
        'Doc_del
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.del_rec)
        Me.Controls.Add(Me.bck_btn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Doc_del"
        Me.Text = "Doc_del"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HospitalDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents HospitalDataSet1 As HospitalDataSet1
    Friend WithEvents DoctorBindingSource As BindingSource
    Friend WithEvents DoctorTableAdapter As HospitalDataSet1TableAdapters.DoctorTableAdapter
    Friend WithEvents bck_btn As Button
    Friend WithEvents del_rec As Button
    Friend WithEvents del As DataGridViewCheckBoxColumn
    Friend WithEvents DocIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DocNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpecialisationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QualificationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
