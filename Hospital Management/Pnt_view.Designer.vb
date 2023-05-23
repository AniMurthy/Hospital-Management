<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pnt_view
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
        Me.PatientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HospitalDataSet = New Hospital_Management.HospitalDataSet()
        Me.PatientsTableAdapter = New Hospital_Management.HospitalDataSetTableAdapters.PatientsTableAdapter()
        Me.bck_btn = New System.Windows.Forms.Button()
        'Me.HospitalDataSet1 = New Hospital_Management.HospitalDataSet1()
        Me.PatientsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        'Me.PatientsTableAdapter1 = New Hospital_Management.HospitalDataSet1TableAdapters.PatientsTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.HospitalDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientIDDataGridViewTextBoxColumn, Me.PatientNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PatientsBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridView1.Size = New System.Drawing.Size(832, 229)
        Me.DataGridView1.TabIndex = 0
        '
        'PatientIDDataGridViewTextBoxColumn
        '
        Me.PatientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID"
        Me.PatientIDDataGridViewTextBoxColumn.HeaderText = "PatientID"
        Me.PatientIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatientIDDataGridViewTextBoxColumn.Name = "PatientIDDataGridViewTextBoxColumn"
        Me.PatientIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatientIDDataGridViewTextBoxColumn.Width = 125
        '
        'PatientNameDataGridViewTextBoxColumn
        '
        Me.PatientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName"
        Me.PatientNameDataGridViewTextBoxColumn.HeaderText = "PatientName"
        Me.PatientNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatientNameDataGridViewTextBoxColumn.Name = "PatientNameDataGridViewTextBoxColumn"
        Me.PatientNameDataGridViewTextBoxColumn.Width = 125
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.Width = 125
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.Width = 125
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.Width = 125
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        Me.ContactNumberDataGridViewTextBoxColumn.Width = 125
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
        'bck_btn
        '
        Me.bck_btn.Location = New System.Drawing.Point(888, 9)
        Me.bck_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.bck_btn.Name = "bck_btn"
        Me.bck_btn.Size = New System.Drawing.Size(165, 47)
        Me.bck_btn.TabIndex = 1
        Me.bck_btn.Text = "Back"
        Me.bck_btn.UseVisualStyleBackColor = True
        '
        'HospitalDataSet1
        '
        'Me.HospitalDataSet1.DataSetName = "HospitalDataSet1"
        'Me.HospitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientsBindingSource1
        '
        'Me.PatientsBindingSource1.DataMember = "Patients"
        'Me.PatientsBindingSource1.DataSource = Me.HospitalDataSet1
        '
        'PatientsTableAdapter1
        '
        'Me.PatientsTableAdapter1.ClearBeforeFill = True
        '
        'Pnt_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.bck_btn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Pnt_view"
        Me.Text = "Pnt_view"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.HospitalDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents HospitalDataSet As HospitalDataSet
    Friend WithEvents PatientsBindingSource As BindingSource
    Friend WithEvents PatientsTableAdapter As HospitalDataSetTableAdapters.PatientsTableAdapter
    Friend WithEvents PatientIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents bck_btn As Button
    'Friend WithEvents HospitalDataSet1 As HospitalDataSet1
    Friend WithEvents PatientsBindingSource1 As BindingSource
    'Friend WithEvents PatientsTableAdapter1 As HospitalDataSet1TableAdapters.PatientsTableAdapter
End Class
