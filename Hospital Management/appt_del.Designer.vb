<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class appt_del
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
        Me.AppointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HospitalDataSet = New Hospital_Management.HospitalDataSet()
        Me.bck_btn = New System.Windows.Forms.Button()
        Me.AppointmentsTableAdapter = New Hospital_Management.HospitalDataSetTableAdapters.AppointmentsTableAdapter()
        Me.del_rec = New System.Windows.Forms.Button()
        Me.del = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AptIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointmentTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PntIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.del, Me.AptIDDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.AppointmentTimeDataGridViewTextBoxColumn, Me.PntIDDataGridViewTextBoxColumn, Me.DOCIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AppointmentsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(34, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1301, 356)
        Me.DataGridView1.TabIndex = 0
        '
        'AppointmentsBindingSource
        '
        Me.AppointmentsBindingSource.DataMember = "Appointments"
        Me.AppointmentsBindingSource.DataSource = Me.HospitalDataSet
        '
        'HospitalDataSet
        '
        Me.HospitalDataSet.DataSetName = "HospitalDataSet"
        Me.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bck_btn
        '
        Me.bck_btn.Location = New System.Drawing.Point(1341, 42)
        Me.bck_btn.Name = "bck_btn"
        Me.bck_btn.Size = New System.Drawing.Size(204, 89)
        Me.bck_btn.TabIndex = 1
        Me.bck_btn.Text = "Back"
        Me.bck_btn.UseVisualStyleBackColor = True
        '
        'AppointmentsTableAdapter
        '
        Me.AppointmentsTableAdapter.ClearBeforeFill = True
        '
        'del_rec
        '
        Me.del_rec.Location = New System.Drawing.Point(1341, 294)
        Me.del_rec.Name = "del_rec"
        Me.del_rec.Size = New System.Drawing.Size(204, 84)
        Me.del_rec.TabIndex = 2
        Me.del_rec.Text = "Close"
        Me.del_rec.UseVisualStyleBackColor = True
        '
        'del
        '
        Me.del.HeaderText = "Close Appointment"
        Me.del.MinimumWidth = 8
        Me.del.Name = "del"
        Me.del.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.del.Width = 150
        '
        'AptIDDataGridViewTextBoxColumn
        '
        Me.AptIDDataGridViewTextBoxColumn.DataPropertyName = "AptID"
        Me.AptIDDataGridViewTextBoxColumn.HeaderText = "AptID"
        Me.AptIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AptIDDataGridViewTextBoxColumn.Name = "AptIDDataGridViewTextBoxColumn"
        Me.AptIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.AptIDDataGridViewTextBoxColumn.Width = 150
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.Width = 150
        '
        'AppointmentTimeDataGridViewTextBoxColumn
        '
        Me.AppointmentTimeDataGridViewTextBoxColumn.DataPropertyName = "AppointmentTime"
        Me.AppointmentTimeDataGridViewTextBoxColumn.HeaderText = "AppointmentTime"
        Me.AppointmentTimeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AppointmentTimeDataGridViewTextBoxColumn.Name = "AppointmentTimeDataGridViewTextBoxColumn"
        Me.AppointmentTimeDataGridViewTextBoxColumn.Width = 150
        '
        'PntIDDataGridViewTextBoxColumn
        '
        Me.PntIDDataGridViewTextBoxColumn.DataPropertyName = "PntID"
        Me.PntIDDataGridViewTextBoxColumn.HeaderText = "PntID"
        Me.PntIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PntIDDataGridViewTextBoxColumn.Name = "PntIDDataGridViewTextBoxColumn"
        Me.PntIDDataGridViewTextBoxColumn.Width = 150
        '
        'DOCIDDataGridViewTextBoxColumn
        '
        Me.DOCIDDataGridViewTextBoxColumn.DataPropertyName = "DOCID"
        Me.DOCIDDataGridViewTextBoxColumn.HeaderText = "DOCID"
        Me.DOCIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DOCIDDataGridViewTextBoxColumn.Name = "DOCIDDataGridViewTextBoxColumn"
        Me.DOCIDDataGridViewTextBoxColumn.Width = 150
        '
        'appt_del
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1557, 726)
        Me.Controls.Add(Me.del_rec)
        Me.Controls.Add(Me.bck_btn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "appt_del"
        Me.Text = "appt_del"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents bck_btn As Button
    Friend WithEvents HospitalDataSet As HospitalDataSet
    Friend WithEvents AppointmentsBindingSource As BindingSource
    Friend WithEvents AppointmentsTableAdapter As HospitalDataSetTableAdapters.AppointmentsTableAdapter
    Friend WithEvents del_rec As Button
    Friend WithEvents del As DataGridViewCheckBoxColumn
    Friend WithEvents AptIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AppointmentTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PntIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOCIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
