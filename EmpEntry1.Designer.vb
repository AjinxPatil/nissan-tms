<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpEntry1
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
        Dim Date_of_JoiningLabel As System.Windows.Forms.Label
        Dim Date_of_LeavingLabel As System.Windows.Forms.Label
        Me.NextButton1 = New System.Windows.Forms.Button()
        Me.CancelButton1 = New System.Windows.Forms.Button()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DesignationComboBox = New System.Windows.Forms.ComboBox()
        Me.StorageDataSet = New NTMS2.storageDataSet()
        Me.DealerComboBox = New System.Windows.Forms.ComboBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New NTMS2.storageDataSetTableAdapters.employeeTableAdapter()
        Me.TableAdapterManager = New NTMS2.storageDataSetTableAdapters.TableAdapterManager()
        Me.DOJPicker = New System.Windows.Forms.DateTimePicker()
        Me.DOLPicker = New System.Windows.Forms.DateTimePicker()
        Me.DOLCheck = New System.Windows.Forms.CheckBox()
        Me.ProductComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProductTableAdapter = New NTMS2.storageDataSetTableAdapters.productTableAdapter()
        Date_of_JoiningLabel = New System.Windows.Forms.Label()
        Date_of_LeavingLabel = New System.Windows.Forms.Label()
        CType(Me.StorageDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Date_of_JoiningLabel
        '
        Date_of_JoiningLabel.AutoSize = True
        Date_of_JoiningLabel.Location = New System.Drawing.Point(46, 229)
        Date_of_JoiningLabel.Name = "Date_of_JoiningLabel"
        Date_of_JoiningLabel.Size = New System.Drawing.Size(84, 13)
        Date_of_JoiningLabel.TabIndex = 13
        Date_of_JoiningLabel.Text = "Date-of-Joining :"
        '
        'Date_of_LeavingLabel
        '
        Date_of_LeavingLabel.AutoSize = True
        Date_of_LeavingLabel.Location = New System.Drawing.Point(46, 282)
        Date_of_LeavingLabel.Name = "Date_of_LeavingLabel"
        Date_of_LeavingLabel.Size = New System.Drawing.Size(89, 13)
        Date_of_LeavingLabel.TabIndex = 14
        Date_of_LeavingLabel.Text = "Date-of-Leaving :"
        '
        'NextButton1
        '
        Me.NextButton1.Location = New System.Drawing.Point(173, 374)
        Me.NextButton1.Name = "NextButton1"
        Me.NextButton1.Size = New System.Drawing.Size(75, 23)
        Me.NextButton1.TabIndex = 0
        Me.NextButton1.Text = "Next"
        Me.NextButton1.UseVisualStyleBackColor = True
        '
        'CancelButton1
        '
        Me.CancelButton1.Location = New System.Drawing.Point(271, 374)
        Me.CancelButton1.Name = "CancelButton1"
        Me.CancelButton1.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton1.TabIndex = 1
        Me.CancelButton1.Text = "Cancel"
        Me.CancelButton1.UseVisualStyleBackColor = True
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(173, 57)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(173, 20)
        Me.NameTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Designation :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Dealer Code"
        '
        'DesignationComboBox
        '
        Me.DesignationComboBox.FormattingEnabled = True
        Me.DesignationComboBox.Items.AddRange(New Object() {"SM", "SC", "CRM", "CRE"})
        Me.DesignationComboBox.Location = New System.Drawing.Point(173, 110)
        Me.DesignationComboBox.Name = "DesignationComboBox"
        Me.DesignationComboBox.Size = New System.Drawing.Size(173, 21)
        Me.DesignationComboBox.TabIndex = 9
        '
        'StorageDataSet
        '
        Me.StorageDataSet.DataSetName = "storageDataSet"
        Me.StorageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DealerComboBox
        '
        Me.DealerComboBox.FormattingEnabled = True
        Me.DealerComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.DealerComboBox.Location = New System.Drawing.Point(173, 322)
        Me.DealerComboBox.Name = "DealerComboBox"
        Me.DealerComboBox.Size = New System.Drawing.Size(173, 21)
        Me.DealerComboBox.TabIndex = 13
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.StorageDataSet
        Me.BindingSource1.Position = 0
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "employee"
        Me.EmployeeBindingSource.DataSource = Me.StorageDataSet
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dealer_dataTableAdapter = Nothing
        Me.TableAdapterManager.dealer1TableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.productTableAdapter = Nothing
        Me.TableAdapterManager.testTableAdapter = Nothing
        Me.TableAdapterManager.training_dateTableAdapter = Nothing
        Me.TableAdapterManager.training_statusTableAdapter = Nothing
        Me.TableAdapterManager.tTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NTMS2.storageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DOJPicker
        '
        Me.DOJPicker.CustomFormat = "dd-mm-yyyy"
        Me.DOJPicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeBindingSource, "Date-of-Joining", True))
        Me.DOJPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DOJPicker.Location = New System.Drawing.Point(173, 223)
        Me.DOJPicker.Name = "DOJPicker"
        Me.DOJPicker.Size = New System.Drawing.Size(173, 20)
        Me.DOJPicker.TabIndex = 14
        Me.DOJPicker.Value = New Date(2011, 1, 25, 0, 0, 0, 0)
        '
        'DOLPicker
        '
        Me.DOLPicker.CustomFormat = "dd-mm-yyyy"
        Me.DOLPicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeBindingSource, "Date-of-Leaving", True))
        Me.DOLPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DOLPicker.Location = New System.Drawing.Point(173, 276)
        Me.DOLPicker.Name = "DOLPicker"
        Me.DOLPicker.Size = New System.Drawing.Size(173, 20)
        Me.DOLPicker.TabIndex = 15
        Me.DOLPicker.Value = New Date(2011, 1, 25, 0, 0, 0, 0)
        '
        'DOLCheck
        '
        Me.DOLCheck.AutoSize = True
        Me.DOLCheck.Location = New System.Drawing.Point(152, 281)
        Me.DOLCheck.Name = "DOLCheck"
        Me.DOLCheck.Size = New System.Drawing.Size(15, 14)
        Me.DOLCheck.TabIndex = 16
        Me.DOLCheck.UseVisualStyleBackColor = True
        '
        'ProductComboBox
        '
        Me.ProductComboBox.DataSource = Me.ProductBindingSource
        Me.ProductComboBox.DisplayMember = "Product"
        Me.ProductComboBox.FormattingEnabled = True
        Me.ProductComboBox.Location = New System.Drawing.Point(173, 163)
        Me.ProductComboBox.Name = "ProductComboBox"
        Me.ProductComboBox.Size = New System.Drawing.Size(173, 21)
        Me.ProductComboBox.TabIndex = 17
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "product"
        Me.ProductBindingSource.DataSource = Me.StorageDataSet
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Product :"
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'EmpEntry1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 426)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProductComboBox)
        Me.Controls.Add(Me.DOLCheck)
        Me.Controls.Add(Date_of_LeavingLabel)
        Me.Controls.Add(Me.DOLPicker)
        Me.Controls.Add(Date_of_JoiningLabel)
        Me.Controls.Add(Me.DOJPicker)
        Me.Controls.Add(Me.DealerComboBox)
        Me.Controls.Add(Me.DesignationComboBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.CancelButton1)
        Me.Controls.Add(Me.NextButton1)
        Me.Name = "EmpEntry1"
        Me.Text = "Adding an employee"
        CType(Me.StorageDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NextButton1 As System.Windows.Forms.Button
    Friend WithEvents CancelButton1 As System.Windows.Forms.Button
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DesignationComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DealerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents StorageDataSet As NTMS2.storageDataSet
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter As NTMS2.storageDataSetTableAdapters.employeeTableAdapter
    Friend WithEvents TableAdapterManager As NTMS2.storageDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DOJPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DOLPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DOLCheck As System.Windows.Forms.CheckBox
    Friend WithEvents ProductComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductTableAdapter As NTMS2.storageDataSetTableAdapters.productTableAdapter

End Class
