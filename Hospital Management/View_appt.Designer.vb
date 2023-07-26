<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_appt
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
        Me.bck_btn = New System.Windows.Forms.Button()
        Me.HospitalDataSet = New Hospital_Management.HospitalDataSet()
        Me.HospitalDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentsTableAdapter = New Hospital_Management.HospitalDataSetTableAdapters.AppointmentsTableAdapter()
        Me.AptIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PntIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HospitalDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AptIDDataGridViewTextBoxColumn, Me.PntIDDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.AppointmentTimeDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AppointmentsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(24, 41)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1261, 544)
        Me.DataGridView1.TabIndex = 0
        '
        'bck_btn
        '
        Me.bck_btn.Location = New System.Drawing.Point(1291, 41)
        Me.bck_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bck_btn.Name = "bck_btn"
        Me.bck_btn.Size = New System.Drawing.Size(121, 46)
        Me.bck_btn.TabIndex = 1
        Me.bck_btn.Text = "Back"
        Me.bck_btn.UseVisualStyleBackColor = True
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
        'AppointmentsBindingSource
        '
        Me.AppointmentsBindingSource.DataMember = "Appointments"
        Me.AppointmentsBindingSource.DataSource = Me.HospitalDataSet
        '
        'AppointmentsTableAdapter
        '
        Me.AppointmentsTableAdapter.ClearBeforeFill = True
        '
        'AptIDDataGridViewTextBoxColumn
        '
        Me.AptIDDataGridViewTextBoxColumn.DataPropertyName = "AptID"
        Me.AptIDDataGridViewTextBoxColumn.HeaderText = "AptID"
        Me.AptIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AptIDDataGridViewTextBoxColumn.Name = "AptIDDataGridViewTextBoxColumn"
        Me.AptIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.AptIDDataGridViewTextBoxColumn.Width = 125
        '
        'PntIDDataGridViewTextBoxColumn
        '
        Me.PntIDDataGridViewTextBoxColumn.DataPropertyName = "PntID"
        Me.PntIDDataGridViewTextBoxColumn.HeaderText = "PntID"
        Me.PntIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PntIDDataGridViewTextBoxColumn.Name = "PntIDDataGridViewTextBoxColumn"
        Me.PntIDDataGridViewTextBoxColumn.Width = 125
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DocID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "DocID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'AppointmentTimeDataGridViewTextBoxColumn
        '
        Me.AppointmentTimeDataGridViewTextBoxColumn.DataPropertyName = "AppointmentTime"
        Me.AppointmentTimeDataGridViewTextBoxColumn.HeaderText = "AppointmentTime"
        Me.AppointmentTimeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AppointmentTimeDataGridViewTextBoxColumn.Name = "AppointmentTimeDataGridViewTextBoxColumn"
        Me.AppointmentTimeDataGridViewTextBoxColumn.Width = 125
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.Width = 125
        '
        'View_appt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1422, 594)
        Me.Controls.Add(Me.bck_btn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "View_appt"
        Me.Text = "View_appt"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HospitalDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents bck_btn As Button
    Friend WithEvents DOCIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HospitalDataSetBindingSource As BindingSource
    Friend WithEvents HospitalDataSet As HospitalDataSet
    Friend WithEvents AppointmentsBindingSource As BindingSource
    Friend WithEvents AppointmentsTableAdapter As HospitalDataSetTableAdapters.AppointmentsTableAdapter
    Friend WithEvents AptIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PntIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
