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
        Me.HospitalDataSet = New Hospital_Management.HospitalDataSet()
        Me.DoctorTableAdapter = New Hospital_Management.HospitalDataSetTableAdapters.DoctorTableAdapter()
        Me.bck_btn = New System.Windows.Forms.Button()
        Me.del_rec = New System.Windows.Forms.Button()
        Me.DoctorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.del = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DocIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecialisationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QualificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExperienceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.del, Me.DocIDDataGridViewTextBoxColumn, Me.DocNameDataGridViewTextBoxColumn, Me.SpecialisationDataGridViewTextBoxColumn, Me.QualificationDataGridViewTextBoxColumn, Me.ExperienceDataGridViewTextBoxColumn, Me.SalaryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DoctorBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 40)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(949, 430)
        Me.DataGridView1.TabIndex = 0
        '
        'HospitalDataSet
        '
        Me.HospitalDataSet.DataSetName = "HospitalDataSet1"
        Me.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DoctorTableAdapter
        '
        Me.DoctorTableAdapter.ClearBeforeFill = True
        '
        'bck_btn
        '
        Me.bck_btn.Location = New System.Drawing.Point(980, 40)
        Me.bck_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bck_btn.Name = "bck_btn"
        Me.bck_btn.Size = New System.Drawing.Size(141, 36)
        Me.bck_btn.TabIndex = 1
        Me.bck_btn.Text = "Back"
        Me.bck_btn.UseVisualStyleBackColor = True
        '
        'del_rec
        '
        Me.del_rec.Location = New System.Drawing.Point(971, 155)
        Me.del_rec.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.del_rec.Name = "del_rec"
        Me.del_rec.Size = New System.Drawing.Size(150, 46)
        Me.del_rec.TabIndex = 2
        Me.del_rec.Text = "Delete Records"
        Me.del_rec.UseVisualStyleBackColor = True
        '
        'DoctorBindingSource
        '
        Me.DoctorBindingSource.DataMember = "Doctor"
        Me.DoctorBindingSource.DataSource = Me.HospitalDataSet
        '
        'del
        '
        Me.del.HeaderText = "To Delete"
        Me.del.MinimumWidth = 6
        Me.del.Name = "del"
        Me.del.Width = 84
        '
        'DocIDDataGridViewTextBoxColumn
        '
        Me.DocIDDataGridViewTextBoxColumn.DataPropertyName = "DocID"
        Me.DocIDDataGridViewTextBoxColumn.HeaderText = "DocID"
        Me.DocIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DocIDDataGridViewTextBoxColumn.Name = "DocIDDataGridViewTextBoxColumn"
        Me.DocIDDataGridViewTextBoxColumn.Width = 91
        '
        'DocNameDataGridViewTextBoxColumn
        '
        Me.DocNameDataGridViewTextBoxColumn.DataPropertyName = "DocName"
        Me.DocNameDataGridViewTextBoxColumn.HeaderText = "DocName"
        Me.DocNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DocNameDataGridViewTextBoxColumn.Name = "DocNameDataGridViewTextBoxColumn"
        Me.DocNameDataGridViewTextBoxColumn.Width = 116
        '
        'SpecialisationDataGridViewTextBoxColumn
        '
        Me.SpecialisationDataGridViewTextBoxColumn.DataPropertyName = "Specialisation"
        Me.SpecialisationDataGridViewTextBoxColumn.HeaderText = "Specialisation"
        Me.SpecialisationDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SpecialisationDataGridViewTextBoxColumn.Name = "SpecialisationDataGridViewTextBoxColumn"
        Me.SpecialisationDataGridViewTextBoxColumn.Width = 143
        '
        'QualificationDataGridViewTextBoxColumn
        '
        Me.QualificationDataGridViewTextBoxColumn.DataPropertyName = "Qualification"
        Me.QualificationDataGridViewTextBoxColumn.HeaderText = "Qualification"
        Me.QualificationDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.QualificationDataGridViewTextBoxColumn.Name = "QualificationDataGridViewTextBoxColumn"
        Me.QualificationDataGridViewTextBoxColumn.Width = 132
        '
        'ExperienceDataGridViewTextBoxColumn
        '
        Me.ExperienceDataGridViewTextBoxColumn.DataPropertyName = "Experience"
        Me.ExperienceDataGridViewTextBoxColumn.HeaderText = "Experience"
        Me.ExperienceDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ExperienceDataGridViewTextBoxColumn.Name = "ExperienceDataGridViewTextBoxColumn"
        Me.ExperienceDataGridViewTextBoxColumn.Width = 124
        '
        'SalaryDataGridViewTextBoxColumn
        '
        Me.SalaryDataGridViewTextBoxColumn.DataPropertyName = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.HeaderText = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SalaryDataGridViewTextBoxColumn.Name = "SalaryDataGridViewTextBoxColumn"
        Me.SalaryDataGridViewTextBoxColumn.Width = 89
        '
        'Doc_del
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 562)
        Me.Controls.Add(Me.del_rec)
        Me.Controls.Add(Me.bck_btn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Doc_del"
        Me.Text = "Doc_del"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents HospitalDataSet As HospitalDataSet
    Friend WithEvents DoctorTableAdapter As HospitalDataSetTableAdapters.DoctorTableAdapter
    Friend WithEvents bck_btn As Button
    Friend WithEvents del_rec As Button
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DoctorBindingSource As BindingSource
    Friend WithEvents del As DataGridViewCheckBoxColumn
    Friend WithEvents DocIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DocNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpecialisationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QualificationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExperienceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
