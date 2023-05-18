<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pnt_del
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
        Me.bck_btn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PatientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.del = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HospitalDataSet = New Hospital_Management.HospitalDataSet()
        Me.HospitalDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientsTableAdapter = New Hospital_Management.HospitalDataSetTableAdapters.PatientsTableAdapter()
        Me.del_rec = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HospitalDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bck_btn
        '
        Me.bck_btn.Location = New System.Drawing.Point(807, 12)
        Me.bck_btn.Name = "bck_btn"
        Me.bck_btn.Size = New System.Drawing.Size(85, 36)
        Me.bck_btn.TabIndex = 0
        Me.bck_btn.Text = "Back"
        Me.bck_btn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientIDDataGridViewTextBoxColumn, Me.PatientNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.del})
        Me.DataGridView1.DataSource = Me.PatientsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(745, 114)
        Me.DataGridView1.TabIndex = 1
        '
        'PatientIDDataGridViewTextBoxColumn
        '
        Me.PatientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID"
        Me.PatientIDDataGridViewTextBoxColumn.HeaderText = "PatientID"
        Me.PatientIDDataGridViewTextBoxColumn.Name = "PatientIDDataGridViewTextBoxColumn"
        Me.PatientIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PatientNameDataGridViewTextBoxColumn
        '
        Me.PatientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName"
        Me.PatientNameDataGridViewTextBoxColumn.HeaderText = "PatientName"
        Me.PatientNameDataGridViewTextBoxColumn.Name = "PatientNameDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        '
        'del
        '
        Me.del.HeaderText = "To Delete"
        Me.del.Name = "del"
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
        'HospitalDataSetBindingSource
        '
        Me.HospitalDataSetBindingSource.DataSource = Me.HospitalDataSet
        Me.HospitalDataSetBindingSource.Position = 0
        '
        'PatientsTableAdapter
        '
        Me.PatientsTableAdapter.ClearBeforeFill = True
        '
        'del_rec
        '
        Me.del_rec.Location = New System.Drawing.Point(775, 77)
        Me.del_rec.Name = "del_rec"
        Me.del_rec.Size = New System.Drawing.Size(116, 48)
        Me.del_rec.TabIndex = 2
        Me.del_rec.Text = "Delete Records"
        Me.del_rec.UseVisualStyleBackColor = True
        '
        'Pnt_del
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 450)
        Me.Controls.Add(Me.del_rec)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.bck_btn)
        Me.Name = "Pnt_del"
        Me.Text = "Pnt_del"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HospitalDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bck_btn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents HospitalDataSetBindingSource As BindingSource
    Friend WithEvents HospitalDataSet As HospitalDataSet
    Friend WithEvents PatientsBindingSource As BindingSource
    Friend WithEvents PatientsTableAdapter As HospitalDataSetTableAdapters.PatientsTableAdapter
    Friend WithEvents PatientIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents del As DataGridViewCheckBoxColumn
    Friend WithEvents del_rec As Button
End Class
