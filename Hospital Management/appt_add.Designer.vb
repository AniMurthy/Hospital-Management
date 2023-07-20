<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class appt_add
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
        Me.pnt_select = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PatientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HospitalDataSet = New Hospital_Management.HospitalDataSet()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.doc_select = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DocIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecialisationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoctorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.appmt_time = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PntID_txt = New System.Windows.Forms.TextBox()
        Me.DocID_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Add_apt = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PatientsTableAdapter = New Hospital_Management.HospitalDataSetTableAdapters.PatientsTableAdapter()
        Me.DoctorTableAdapter = New Hospital_Management.HospitalDataSetTableAdapters.DoctorTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pnt_select, Me.PatientIDDataGridViewTextBoxColumn, Me.PatientNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PatientsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(28, 44)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(639, 232)
        Me.DataGridView1.TabIndex = 0
        '
        'pnt_select
        '
        Me.pnt_select.HeaderText = "Select"
        Me.pnt_select.MinimumWidth = 6
        Me.pnt_select.Name = "pnt_select"
        Me.pnt_select.Width = 125
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
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.doc_select, Me.DocIDDataGridViewTextBoxColumn, Me.DocNameDataGridViewTextBoxColumn, Me.SpecialisationDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.DoctorBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(693, 44)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(638, 232)
        Me.DataGridView2.TabIndex = 1
        '
        'doc_select
        '
        Me.doc_select.HeaderText = "Select"
        Me.doc_select.MinimumWidth = 6
        Me.doc_select.Name = "doc_select"
        Me.doc_select.Width = 125
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
        'SpecialisationDataGridViewTextBoxColumn
        '
        Me.SpecialisationDataGridViewTextBoxColumn.DataPropertyName = "Specialisation"
        Me.SpecialisationDataGridViewTextBoxColumn.HeaderText = "Specialisation"
        Me.SpecialisationDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SpecialisationDataGridViewTextBoxColumn.Name = "SpecialisationDataGridViewTextBoxColumn"
        Me.SpecialisationDataGridViewTextBoxColumn.Width = 125
        '
        'DoctorBindingSource
        '
        Me.DoctorBindingSource.DataMember = "Doctor"
        Me.DoctorBindingSource.DataSource = Me.HospitalDataSet
        '
        'appmt_time
        '
        Me.appmt_time.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.appmt_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.appmt_time.Location = New System.Drawing.Point(523, 388)
        Me.appmt_time.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.appmt_time.Name = "appmt_time"
        Me.appmt_time.Size = New System.Drawing.Size(265, 26)
        Me.appmt_time.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Patient ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(270, 330)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Doctor ID"
        '
        'PntID_txt
        '
        Me.PntID_txt.Location = New System.Drawing.Point(54, 388)
        Me.PntID_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PntID_txt.Name = "PntID_txt"
        Me.PntID_txt.Size = New System.Drawing.Size(160, 26)
        Me.PntID_txt.TabIndex = 5
        '
        'DocID_txt
        '
        Me.DocID_txt.Location = New System.Drawing.Point(273, 388)
        Me.DocID_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DocID_txt.Name = "DocID_txt"
        Me.DocID_txt.Size = New System.Drawing.Size(168, 26)
        Me.DocID_txt.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(520, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Appointment Time"
        '
        'Add_apt
        '
        Me.Add_apt.Location = New System.Drawing.Point(888, 364)
        Me.Add_apt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Add_apt.Name = "Add_apt"
        Me.Add_apt.Size = New System.Drawing.Size(212, 51)
        Me.Add_apt.TabIndex = 8
        Me.Add_apt.Text = "Add Appointment"
        Me.Add_apt.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Patient"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(701, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Doctor"
        '
        'PatientsTableAdapter
        '
        Me.PatientsTableAdapter.ClearBeforeFill = True
        '
        'DoctorTableAdapter
        '
        Me.DoctorTableAdapter.ClearBeforeFill = True
        '
        'appt_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 455)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Add_apt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DocID_txt)
        Me.Controls.Add(Me.PntID_txt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.appmt_time)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "appt_add"
        Me.Text = "appt_add"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents HospitalDataSet As HospitalDataSet
    Friend WithEvents PatientsBindingSource As BindingSource
    Friend WithEvents PatientsTableAdapter As HospitalDataSetTableAdapters.PatientsTableAdapter
    Friend WithEvents pnt_select As DataGridViewButtonColumn
    Friend WithEvents PatientIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DoctorBindingSource As BindingSource
    Friend WithEvents DoctorTableAdapter As HospitalDataSetTableAdapters.DoctorTableAdapter
    Friend WithEvents doc_select As DataGridViewButtonColumn
    Friend WithEvents DocIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DocNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpecialisationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents appmt_time As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PntID_txt As TextBox
    Friend WithEvents DocID_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Add_apt As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
