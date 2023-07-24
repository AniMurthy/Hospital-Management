<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doc_update
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
        Me.DoctorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HospitalDataSet = New Hospital_Management.HospitalDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.name_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.age_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.contact_txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.email_txt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sal_txt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.updt_btn = New System.Windows.Forms.Button()
        Me.DoctorTableAdapter = New Hospital_Management.HospitalDataSetTableAdapters.DoctorTableAdapter()
        Me.gender = New System.Windows.Forms.ComboBox()
        Me.spl_cmb = New System.Windows.Forms.ComboBox()
        Me.qual_cmb = New System.Windows.Forms.ComboBox()
        Me.update = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DocIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecialisationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QualificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExperienceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bck_btn
        '
        Me.bck_btn.Location = New System.Drawing.Point(1436, 15)
        Me.bck_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bck_btn.Name = "bck_btn"
        Me.bck_btn.Size = New System.Drawing.Size(109, 51)
        Me.bck_btn.TabIndex = 0
        Me.bck_btn.Text = "Back"
        Me.bck_btn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.update, Me.DocIDDataGridViewTextBoxColumn, Me.DocNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.SpecialisationDataGridViewTextBoxColumn, Me.QualificationDataGridViewTextBoxColumn, Me.ExperienceDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.EmailIDDataGridViewTextBoxColumn, Me.SalaryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DoctorBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 15)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1370, 284)
        Me.DataGridView1.TabIndex = 1
        '
        'DoctorBindingSource
        '
        Me.DoctorBindingSource.DataMember = "Doctor"
        Me.DoctorBindingSource.DataSource = Me.HospitalDataSet
        '
        'HospitalDataSet
        '
        Me.HospitalDataSet.DataSetName = "HospitalDataSet"
        Me.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(549, 374)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'name_txt
        '
        Me.name_txt.Location = New System.Drawing.Point(696, 371)
        Me.name_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.name_txt.Name = "name_txt"
        Me.name_txt.Size = New System.Drawing.Size(112, 26)
        Me.name_txt.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(549, 409)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Gender"
        '
        'age_txt
        '
        Me.age_txt.Location = New System.Drawing.Point(696, 436)
        Me.age_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.age_txt.Name = "age_txt"
        Me.age_txt.Size = New System.Drawing.Size(112, 26)
        Me.age_txt.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(549, 439)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Experience"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(549, 474)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Specialisation"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(549, 501)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Qualification"
        '
        'contact_txt
        '
        Me.contact_txt.Location = New System.Drawing.Point(696, 534)
        Me.contact_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.contact_txt.MaxLength = 10
        Me.contact_txt.Name = "contact_txt"
        Me.contact_txt.Size = New System.Drawing.Size(112, 26)
        Me.contact_txt.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(549, 536)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Contact Number"
        '
        'email_txt
        '
        Me.email_txt.Location = New System.Drawing.Point(696, 569)
        Me.email_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.Size = New System.Drawing.Size(112, 26)
        Me.email_txt.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(549, 571)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Email"
        '
        'sal_txt
        '
        Me.sal_txt.Location = New System.Drawing.Point(696, 601)
        Me.sal_txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sal_txt.Name = "sal_txt"
        Me.sal_txt.Size = New System.Drawing.Size(112, 26)
        Me.sal_txt.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(549, 604)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Salary"
        '
        'updt_btn
        '
        Me.updt_btn.Location = New System.Drawing.Point(758, 688)
        Me.updt_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.updt_btn.Name = "updt_btn"
        Me.updt_btn.Size = New System.Drawing.Size(202, 29)
        Me.updt_btn.TabIndex = 18
        Me.updt_btn.Text = "Update Record"
        Me.updt_btn.UseVisualStyleBackColor = True
        '
        'DoctorTableAdapter
        '
        Me.DoctorTableAdapter.ClearBeforeFill = True
        '
        'gender
        '
        Me.gender.FormattingEnabled = True
        Me.gender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.gender.Location = New System.Drawing.Point(696, 401)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(121, 28)
        Me.gender.TabIndex = 43
        '
        'spl_cmb
        '
        Me.spl_cmb.FormattingEnabled = True
        Me.spl_cmb.Items.AddRange(New Object() {"OBGYN", "Surgery", "Psychiatry", "Neurology", "Cardiology", "Ophthalmology", "Dermatology", "Pediatrics"})
        Me.spl_cmb.Location = New System.Drawing.Point(696, 466)
        Me.spl_cmb.Name = "spl_cmb"
        Me.spl_cmb.Size = New System.Drawing.Size(121, 28)
        Me.spl_cmb.TabIndex = 44
        '
        'qual_cmb
        '
        Me.qual_cmb.FormattingEnabled = True
        Me.qual_cmb.Items.AddRange(New Object() {"MBBS", "MBBS,MD", "MBBS,MD,PHD"})
        Me.qual_cmb.Location = New System.Drawing.Point(696, 501)
        Me.qual_cmb.Name = "qual_cmb"
        Me.qual_cmb.Size = New System.Drawing.Size(121, 28)
        Me.qual_cmb.TabIndex = 45
        '
        'update
        '
        Me.update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.update.HeaderText = "Click button to update values"
        Me.update.MinimumWidth = 6
        Me.update.Name = "update"
        Me.update.Text = ""
        Me.update.Width = 157
        '
        'DocIDDataGridViewTextBoxColumn
        '
        Me.DocIDDataGridViewTextBoxColumn.DataPropertyName = "DocID"
        Me.DocIDDataGridViewTextBoxColumn.HeaderText = "DocID"
        Me.DocIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DocIDDataGridViewTextBoxColumn.Name = "DocIDDataGridViewTextBoxColumn"
        Me.DocIDDataGridViewTextBoxColumn.ReadOnly = True
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
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.Width = 99
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
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        Me.ContactNumberDataGridViewTextBoxColumn.Width = 157
        '
        'EmailIDDataGridViewTextBoxColumn
        '
        Me.EmailIDDataGridViewTextBoxColumn.DataPropertyName = "EmailID"
        Me.EmailIDDataGridViewTextBoxColumn.HeaderText = "EmailID"
        Me.EmailIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EmailIDDataGridViewTextBoxColumn.Name = "EmailIDDataGridViewTextBoxColumn"
        Me.EmailIDDataGridViewTextBoxColumn.Width = 101
        '
        'SalaryDataGridViewTextBoxColumn
        '
        Me.SalaryDataGridViewTextBoxColumn.DataPropertyName = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.HeaderText = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SalaryDataGridViewTextBoxColumn.Name = "SalaryDataGridViewTextBoxColumn"
        Me.SalaryDataGridViewTextBoxColumn.Width = 89
        '
        'Doc_update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1554, 735)
        Me.Controls.Add(Me.qual_cmb)
        Me.Controls.Add(Me.spl_cmb)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.updt_btn)
        Me.Controls.Add(Me.sal_txt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.email_txt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.contact_txt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.age_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.name_txt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.bck_btn)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Doc_update"
        Me.Text = "Doc_update"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bck_btn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents name_txt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents age_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents contact_txt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents email_txt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents sal_txt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents updt_btn As Button
    Friend WithEvents HospitalDataSet As HospitalDataSet
    Friend WithEvents DoctorBindingSource As BindingSource
    Friend WithEvents DoctorTableAdapter As HospitalDataSetTableAdapters.DoctorTableAdapter
    Friend WithEvents gender As ComboBox
    Friend WithEvents spl_cmb As ComboBox
    Friend WithEvents qual_cmb As ComboBox
    Friend WithEvents update As DataGridViewButtonColumn
    Friend WithEvents DocIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DocNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpecialisationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QualificationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExperienceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
