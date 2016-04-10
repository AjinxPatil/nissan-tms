<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpDis
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
        Me.SearchTextBox1 = New System.Windows.Forms.TextBox()
        Me.SearchButton1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProductLabel1 = New System.Windows.Forms.Label()
        Me.NameLabel1 = New System.Windows.Forms.Label()
        Me.DOLLabel1 = New System.Windows.Forms.Label()
        Me.DesignationLabel1 = New System.Windows.Forms.Label()
        Me.DCLabel1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DOJLabel1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrainingstatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StorageDataSet = New NTMS2.storageDataSet()
        Me.TrainingdateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Training_statusTableAdapter = New NTMS2.storageDataSetTableAdapters.training_statusTableAdapter()
        Me.Training_dateTableAdapter = New NTMS2.storageDataSetTableAdapters.training_dateTableAdapter()
        Me.TestTableAdapter = New NTMS2.storageDataSetTableAdapters.testTableAdapter()
        Me.EmployeeTableAdapter = New NTMS2.storageDataSetTableAdapters.employeeTableAdapter()
        Me.TestGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Test1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Test2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Test3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Test4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Test5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Test6DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Test7DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Test8DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Test9DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Test10DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnalysisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainingDateGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Training1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Training2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Training3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Training4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Training5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Training6DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Training7DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Training8DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Training9DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Training10DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Training11DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Training12DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Training13DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Training14DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Training15DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Training16DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Training17DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Training18DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Training19DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Training20DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainingStatusGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Training1DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Training2DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Training3DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Training4DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Training5DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Training6DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Training7DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Training8DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Training9DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Training10DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Training11DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Training12DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Training13DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Training14DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Training15DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Training16DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Training17DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Training18DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Training19DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Training20DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CountLabel1 = New System.Windows.Forms.Label()
        Me.PrevButton1 = New System.Windows.Forms.Button()
        Me.NextButton1 = New System.Windows.Forms.Button()
        Me.DeleteButton1 = New System.Windows.Forms.Button()
        Me.EditButton1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.TrainingstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StorageDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrainingdateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrainingDateGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrainingStatusGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchTextBox1
        '
        Me.SearchTextBox1.Location = New System.Drawing.Point(30, 24)
        Me.SearchTextBox1.Name = "SearchTextBox1"
        Me.SearchTextBox1.Size = New System.Drawing.Size(181, 20)
        Me.SearchTextBox1.TabIndex = 0
        '
        'SearchButton1
        '
        Me.SearchButton1.Location = New System.Drawing.Point(256, 20)
        Me.SearchButton1.Name = "SearchButton1"
        Me.SearchButton1.Size = New System.Drawing.Size(75, 23)
        Me.SearchButton1.TabIndex = 1
        Me.SearchButton1.Text = "Search"
        Me.SearchButton1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ProductLabel1)
        Me.Panel1.Controls.Add(Me.NameLabel1)
        Me.Panel1.Controls.Add(Me.DOLLabel1)
        Me.Panel1.Controls.Add(Me.DesignationLabel1)
        Me.Panel1.Controls.Add(Me.DCLabel1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DOJLabel1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(30, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(494, 169)
        Me.Panel1.TabIndex = 2
        '
        'ProductLabel1
        '
        Me.ProductLabel1.AutoSize = True
        Me.ProductLabel1.Location = New System.Drawing.Point(431, 85)
        Me.ProductLabel1.Name = "ProductLabel1"
        Me.ProductLabel1.Size = New System.Drawing.Size(44, 13)
        Me.ProductLabel1.TabIndex = 3
        Me.ProductLabel1.Text = "Product"
        '
        'NameLabel1
        '
        Me.NameLabel1.AutoSize = True
        Me.NameLabel1.Location = New System.Drawing.Point(21, 17)
        Me.NameLabel1.Name = "NameLabel1"
        Me.NameLabel1.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel1.TabIndex = 0
        Me.NameLabel1.Text = "Name"
        '
        'DOLLabel1
        '
        Me.DOLLabel1.AutoSize = True
        Me.DOLLabel1.Location = New System.Drawing.Point(134, 131)
        Me.DOLLabel1.Name = "DOLLabel1"
        Me.DOLLabel1.Size = New System.Drawing.Size(21, 13)
        Me.DOLLabel1.TabIndex = 7
        Me.DOLLabel1.Text = "dol"
        '
        'DesignationLabel1
        '
        Me.DesignationLabel1.AutoSize = True
        Me.DesignationLabel1.Location = New System.Drawing.Point(21, 40)
        Me.DesignationLabel1.Name = "DesignationLabel1"
        Me.DesignationLabel1.Size = New System.Drawing.Size(63, 13)
        Me.DesignationLabel1.TabIndex = 2
        Me.DesignationLabel1.Text = "Designation"
        '
        'DCLabel1
        '
        Me.DCLabel1.AutoSize = True
        Me.DCLabel1.Location = New System.Drawing.Point(437, 61)
        Me.DCLabel1.Name = "DCLabel1"
        Me.DCLabel1.Size = New System.Drawing.Size(38, 13)
        Me.DCLabel1.TabIndex = 1
        Me.DCLabel1.Text = "Dealer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Date of Leaving"
        '
        'DOJLabel1
        '
        Me.DOJLabel1.AutoSize = True
        Me.DOJLabel1.Location = New System.Drawing.Point(134, 105)
        Me.DOJLabel1.Name = "DOJLabel1"
        Me.DOJLabel1.Size = New System.Drawing.Size(21, 13)
        Me.DOJLabel1.TabIndex = 5
        Me.DOJLabel1.Text = "doj"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Date of Joining"
        '
        'TrainingstatusBindingSource
        '
        Me.TrainingstatusBindingSource.DataMember = "training_status"
        Me.TrainingstatusBindingSource.DataSource = Me.StorageDataSet
        '
        'StorageDataSet
        '
        Me.StorageDataSet.DataSetName = "storageDataSet"
        Me.StorageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TrainingdateBindingSource
        '
        Me.TrainingdateBindingSource.DataMember = "training_date"
        Me.TrainingdateBindingSource.DataSource = Me.StorageDataSet
        '
        'TestBindingSource
        '
        Me.TestBindingSource.DataMember = "test"
        Me.TestBindingSource.DataSource = Me.StorageDataSet
        '
        'Training_statusTableAdapter
        '
        Me.Training_statusTableAdapter.ClearBeforeFill = True
        '
        'Training_dateTableAdapter
        '
        Me.Training_dateTableAdapter.ClearBeforeFill = True
        '
        'TestTableAdapter
        '
        Me.TestTableAdapter.ClearBeforeFill = True
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TestGridView1
        '
        Me.TestGridView1.AllowUserToAddRows = False
        Me.TestGridView1.AllowUserToDeleteRows = False
        Me.TestGridView1.AutoGenerateColumns = False
        Me.TestGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TestGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn2, Me.Test1DataGridViewTextBoxColumn, Me.Test2DataGridViewTextBoxColumn, Me.Test3DataGridViewTextBoxColumn, Me.Test4DataGridViewTextBoxColumn, Me.Test5DataGridViewTextBoxColumn, Me.Test6DataGridViewTextBoxColumn, Me.Test7DataGridViewTextBoxColumn, Me.Test8DataGridViewTextBoxColumn, Me.Test9DataGridViewTextBoxColumn, Me.Test10DataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.PercentageDataGridViewTextBoxColumn, Me.AnalysisDataGridViewTextBoxColumn})
        Me.TestGridView1.DataSource = Me.TestBindingSource
        Me.TestGridView1.Location = New System.Drawing.Point(30, 426)
        Me.TestGridView1.Name = "TestGridView1"
        Me.TestGridView1.ReadOnly = True
        Me.TestGridView1.Size = New System.Drawing.Size(494, 60)
        Me.TestGridView1.TabIndex = 5
        '
        'IDDataGridViewTextBoxColumn2
        '
        Me.IDDataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn2.Name = "IDDataGridViewTextBoxColumn2"
        Me.IDDataGridViewTextBoxColumn2.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn2.Visible = False
        '
        'Test1DataGridViewTextBoxColumn
        '
        Me.Test1DataGridViewTextBoxColumn.DataPropertyName = "Test 1"
        Me.Test1DataGridViewTextBoxColumn.HeaderText = "Test 1"
        Me.Test1DataGridViewTextBoxColumn.Name = "Test1DataGridViewTextBoxColumn"
        Me.Test1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Test2DataGridViewTextBoxColumn
        '
        Me.Test2DataGridViewTextBoxColumn.DataPropertyName = "Test 2"
        Me.Test2DataGridViewTextBoxColumn.HeaderText = "Test 2"
        Me.Test2DataGridViewTextBoxColumn.Name = "Test2DataGridViewTextBoxColumn"
        Me.Test2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Test3DataGridViewTextBoxColumn
        '
        Me.Test3DataGridViewTextBoxColumn.DataPropertyName = "Test 3"
        Me.Test3DataGridViewTextBoxColumn.HeaderText = "Test 3"
        Me.Test3DataGridViewTextBoxColumn.Name = "Test3DataGridViewTextBoxColumn"
        Me.Test3DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Test4DataGridViewTextBoxColumn
        '
        Me.Test4DataGridViewTextBoxColumn.DataPropertyName = "Test 4"
        Me.Test4DataGridViewTextBoxColumn.HeaderText = "Test 4"
        Me.Test4DataGridViewTextBoxColumn.Name = "Test4DataGridViewTextBoxColumn"
        Me.Test4DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Test5DataGridViewTextBoxColumn
        '
        Me.Test5DataGridViewTextBoxColumn.DataPropertyName = "Test 5"
        Me.Test5DataGridViewTextBoxColumn.HeaderText = "Test 5"
        Me.Test5DataGridViewTextBoxColumn.Name = "Test5DataGridViewTextBoxColumn"
        Me.Test5DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Test6DataGridViewTextBoxColumn
        '
        Me.Test6DataGridViewTextBoxColumn.DataPropertyName = "Test 6"
        Me.Test6DataGridViewTextBoxColumn.HeaderText = "Test 6"
        Me.Test6DataGridViewTextBoxColumn.Name = "Test6DataGridViewTextBoxColumn"
        Me.Test6DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Test7DataGridViewTextBoxColumn
        '
        Me.Test7DataGridViewTextBoxColumn.DataPropertyName = "Test 7"
        Me.Test7DataGridViewTextBoxColumn.HeaderText = "Test 7"
        Me.Test7DataGridViewTextBoxColumn.Name = "Test7DataGridViewTextBoxColumn"
        Me.Test7DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Test8DataGridViewTextBoxColumn
        '
        Me.Test8DataGridViewTextBoxColumn.DataPropertyName = "Test 8"
        Me.Test8DataGridViewTextBoxColumn.HeaderText = "Test 8"
        Me.Test8DataGridViewTextBoxColumn.Name = "Test8DataGridViewTextBoxColumn"
        Me.Test8DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Test9DataGridViewTextBoxColumn
        '
        Me.Test9DataGridViewTextBoxColumn.DataPropertyName = "Test 9"
        Me.Test9DataGridViewTextBoxColumn.HeaderText = "Test 9"
        Me.Test9DataGridViewTextBoxColumn.Name = "Test9DataGridViewTextBoxColumn"
        Me.Test9DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Test10DataGridViewTextBoxColumn
        '
        Me.Test10DataGridViewTextBoxColumn.DataPropertyName = "Test 10"
        Me.Test10DataGridViewTextBoxColumn.HeaderText = "Test 10"
        Me.Test10DataGridViewTextBoxColumn.Name = "Test10DataGridViewTextBoxColumn"
        Me.Test10DataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PercentageDataGridViewTextBoxColumn
        '
        Me.PercentageDataGridViewTextBoxColumn.DataPropertyName = "Percentage"
        Me.PercentageDataGridViewTextBoxColumn.HeaderText = "Percentage"
        Me.PercentageDataGridViewTextBoxColumn.Name = "PercentageDataGridViewTextBoxColumn"
        Me.PercentageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AnalysisDataGridViewTextBoxColumn
        '
        Me.AnalysisDataGridViewTextBoxColumn.DataPropertyName = "Analysis"
        Me.AnalysisDataGridViewTextBoxColumn.HeaderText = "Analysis"
        Me.AnalysisDataGridViewTextBoxColumn.Name = "AnalysisDataGridViewTextBoxColumn"
        Me.AnalysisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TrainingDateGridView1
        '
        Me.TrainingDateGridView1.AllowUserToAddRows = False
        Me.TrainingDateGridView1.AllowUserToDeleteRows = False
        Me.TrainingDateGridView1.AutoGenerateColumns = False
        Me.TrainingDateGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TrainingDateGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.Training1DataGridViewTextBoxColumn, Me.Training2DataGridViewTextBoxColumn, Me.Training3DataGridViewTextBoxColumn, Me.Training4DataGridViewTextBoxColumn, Me.Training5DataGridViewTextBoxColumn, Me.Training6DataGridViewTextBoxColumn, Me.Training7DataGridViewTextBoxColumn, Me.Training8DataGridViewTextBoxColumn, Me.Training9DataGridViewTextBoxColumn, Me.Training10DataGridViewTextBoxColumn, Me.Training11DataGridViewTextBoxColumn, Me.Training12DataGridViewTextBoxColumn, Me.Training13DataGridViewTextBoxColumn, Me.Training14DataGridViewTextBoxColumn, Me.Training15DataGridViewTextBoxColumn, Me.Training16DataGridViewTextBoxColumn, Me.Training17DataGridViewTextBoxColumn, Me.Training18DataGridViewTextBoxColumn, Me.Training19DataGridViewTextBoxColumn, Me.Training20DataGridViewTextBoxColumn})
        Me.TrainingDateGridView1.DataSource = Me.TrainingdateBindingSource
        Me.TrainingDateGridView1.Location = New System.Drawing.Point(30, 346)
        Me.TrainingDateGridView1.Name = "TrainingDateGridView1"
        Me.TrainingDateGridView1.ReadOnly = True
        Me.TrainingDateGridView1.Size = New System.Drawing.Size(494, 56)
        Me.TrainingDateGridView1.TabIndex = 4
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn1.Visible = False
        '
        'Training1DataGridViewTextBoxColumn
        '
        Me.Training1DataGridViewTextBoxColumn.DataPropertyName = "Training 1"
        Me.Training1DataGridViewTextBoxColumn.HeaderText = "Training 1"
        Me.Training1DataGridViewTextBoxColumn.Name = "Training1DataGridViewTextBoxColumn"
        Me.Training1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Training2DataGridViewTextBoxColumn
        '
        Me.Training2DataGridViewTextBoxColumn.DataPropertyName = "Training 2"
        Me.Training2DataGridViewTextBoxColumn.HeaderText = "Training 2"
        Me.Training2DataGridViewTextBoxColumn.Name = "Training2DataGridViewTextBoxColumn"
        Me.Training2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Training3DataGridViewTextBoxColumn
        '
        Me.Training3DataGridViewTextBoxColumn.DataPropertyName = "Training 3"
        Me.Training3DataGridViewTextBoxColumn.HeaderText = "Training 3"
        Me.Training3DataGridViewTextBoxColumn.Name = "Training3DataGridViewTextBoxColumn"
        Me.Training3DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Training4DataGridViewTextBoxColumn
        '
        Me.Training4DataGridViewTextBoxColumn.DataPropertyName = "Training 4"
        Me.Training4DataGridViewTextBoxColumn.HeaderText = "Training 4"
        Me.Training4DataGridViewTextBoxColumn.Name = "Training4DataGridViewTextBoxColumn"
        Me.Training4DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Training5DataGridViewTextBoxColumn
        '
        Me.Training5DataGridViewTextBoxColumn.DataPropertyName = "Training 5"
        Me.Training5DataGridViewTextBoxColumn.HeaderText = "Training 5"
        Me.Training5DataGridViewTextBoxColumn.Name = "Training5DataGridViewTextBoxColumn"
        Me.Training5DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Training6DataGridViewTextBoxColumn
        '
        Me.Training6DataGridViewTextBoxColumn.DataPropertyName = "Training 6"
        Me.Training6DataGridViewTextBoxColumn.HeaderText = "Training 6"
        Me.Training6DataGridViewTextBoxColumn.Name = "Training6DataGridViewTextBoxColumn"
        Me.Training6DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Training7DataGridViewTextBoxColumn
        '
        Me.Training7DataGridViewTextBoxColumn.DataPropertyName = "Training 7"
        Me.Training7DataGridViewTextBoxColumn.HeaderText = "Training 7"
        Me.Training7DataGridViewTextBoxColumn.Name = "Training7DataGridViewTextBoxColumn"
        Me.Training7DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Training8DataGridViewTextBoxColumn
        '
        Me.Training8DataGridViewTextBoxColumn.DataPropertyName = "Training 8"
        Me.Training8DataGridViewTextBoxColumn.HeaderText = "Training 8"
        Me.Training8DataGridViewTextBoxColumn.Name = "Training8DataGridViewTextBoxColumn"
        Me.Training8DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Training9DataGridViewTextBoxColumn
        '
        Me.Training9DataGridViewTextBoxColumn.DataPropertyName = "Training 9"
        Me.Training9DataGridViewTextBoxColumn.HeaderText = "Training 9"
        Me.Training9DataGridViewTextBoxColumn.Name = "Training9DataGridViewTextBoxColumn"
        Me.Training9DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Training10DataGridViewTextBoxColumn
        '
        Me.Training10DataGridViewTextBoxColumn.DataPropertyName = "Training 10"
        Me.Training10DataGridViewTextBoxColumn.HeaderText = "Training 10"
        Me.Training10DataGridViewTextBoxColumn.Name = "Training10DataGridViewTextBoxColumn"
        Me.Training10DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Training11DataGridViewTextBoxColumn
        '
        Me.Training11DataGridViewTextBoxColumn.DataPropertyName = "Training 11"
        Me.Training11DataGridViewTextBoxColumn.HeaderText = "Training 11"
        Me.Training11DataGridViewTextBoxColumn.Name = "Training11DataGridViewTextBoxColumn"
        Me.Training11DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Training12DataGridViewTextBoxColumn
        '
        Me.Training12DataGridViewTextBoxColumn.DataPropertyName = "Training 12"
        Me.Training12DataGridViewTextBoxColumn.HeaderText = "Training 12"
        Me.Training12DataGridViewTextBoxColumn.Name = "Training12DataGridViewTextBoxColumn"
        Me.Training12DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Training13DataGridViewTextBoxColumn
        '
        Me.Training13DataGridViewTextBoxColumn.DataPropertyName = "Training 13"
        Me.Training13DataGridViewTextBoxColumn.HeaderText = "Training 13"
        Me.Training13DataGridViewTextBoxColumn.Name = "Training13DataGridViewTextBoxColumn"
        Me.Training13DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Training14DataGridViewTextBoxColumn
        '
        Me.Training14DataGridViewTextBoxColumn.DataPropertyName = "Training 14"
        Me.Training14DataGridViewTextBoxColumn.HeaderText = "Training 14"
        Me.Training14DataGridViewTextBoxColumn.Name = "Training14DataGridViewTextBoxColumn"
        Me.Training14DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Training15DataGridViewTextBoxColumn
        '
        Me.Training15DataGridViewTextBoxColumn.DataPropertyName = "Training 15"
        Me.Training15DataGridViewTextBoxColumn.HeaderText = "Training 15"
        Me.Training15DataGridViewTextBoxColumn.Name = "Training15DataGridViewTextBoxColumn"
        Me.Training15DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Training16DataGridViewTextBoxColumn
        '
        Me.Training16DataGridViewTextBoxColumn.DataPropertyName = "Training 16"
        Me.Training16DataGridViewTextBoxColumn.HeaderText = "Training 16"
        Me.Training16DataGridViewTextBoxColumn.Name = "Training16DataGridViewTextBoxColumn"
        Me.Training16DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Training17DataGridViewTextBoxColumn
        '
        Me.Training17DataGridViewTextBoxColumn.DataPropertyName = "Training 17"
        Me.Training17DataGridViewTextBoxColumn.HeaderText = "Training 17"
        Me.Training17DataGridViewTextBoxColumn.Name = "Training17DataGridViewTextBoxColumn"
        Me.Training17DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Training18DataGridViewTextBoxColumn
        '
        Me.Training18DataGridViewTextBoxColumn.DataPropertyName = "Training 18"
        Me.Training18DataGridViewTextBoxColumn.HeaderText = "Training 18"
        Me.Training18DataGridViewTextBoxColumn.Name = "Training18DataGridViewTextBoxColumn"
        Me.Training18DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Training19DataGridViewTextBoxColumn
        '
        Me.Training19DataGridViewTextBoxColumn.DataPropertyName = "Training 19"
        Me.Training19DataGridViewTextBoxColumn.HeaderText = "Training 19"
        Me.Training19DataGridViewTextBoxColumn.Name = "Training19DataGridViewTextBoxColumn"
        Me.Training19DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Training20DataGridViewTextBoxColumn
        '
        Me.Training20DataGridViewTextBoxColumn.DataPropertyName = "Training 20"
        Me.Training20DataGridViewTextBoxColumn.HeaderText = "Training 20"
        Me.Training20DataGridViewTextBoxColumn.Name = "Training20DataGridViewTextBoxColumn"
        Me.Training20DataGridViewTextBoxColumn.ReadOnly = True
        '
        'TrainingStatusGridView1
        '
        Me.TrainingStatusGridView1.AllowUserToAddRows = False
        Me.TrainingStatusGridView1.AllowUserToDeleteRows = False
        Me.TrainingStatusGridView1.AutoGenerateColumns = False
        Me.TrainingStatusGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TrainingStatusGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.Training1DataGridViewCheckBoxColumn, Me.Training2DataGridViewCheckBoxColumn, Me.Training3DataGridViewCheckBoxColumn, Me.Training4DataGridViewCheckBoxColumn, Me.Training5DataGridViewCheckBoxColumn, Me.Training6DataGridViewCheckBoxColumn, Me.Training7DataGridViewCheckBoxColumn, Me.Training8DataGridViewCheckBoxColumn, Me.Training9DataGridViewCheckBoxColumn, Me.Training10DataGridViewCheckBoxColumn, Me.Training11DataGridViewCheckBoxColumn, Me.Training12DataGridViewCheckBoxColumn, Me.Training13DataGridViewCheckBoxColumn, Me.Training14DataGridViewCheckBoxColumn, Me.Training15DataGridViewCheckBoxColumn, Me.Training16DataGridViewCheckBoxColumn, Me.Training17DataGridViewCheckBoxColumn, Me.Training18DataGridViewCheckBoxColumn, Me.Training19DataGridViewCheckBoxColumn, Me.Training20DataGridViewCheckBoxColumn})
        Me.TrainingStatusGridView1.DataSource = Me.TrainingstatusBindingSource
        Me.TrainingStatusGridView1.Location = New System.Drawing.Point(30, 281)
        Me.TrainingStatusGridView1.Name = "TrainingStatusGridView1"
        Me.TrainingStatusGridView1.ReadOnly = True
        Me.TrainingStatusGridView1.Size = New System.Drawing.Size(494, 59)
        Me.TrainingStatusGridView1.TabIndex = 3
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'Training1DataGridViewCheckBoxColumn
        '
        Me.Training1DataGridViewCheckBoxColumn.DataPropertyName = "Training 1"
        Me.Training1DataGridViewCheckBoxColumn.HeaderText = "Training 1"
        Me.Training1DataGridViewCheckBoxColumn.Name = "Training1DataGridViewCheckBoxColumn"
        Me.Training1DataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Training2DataGridViewCheckBoxColumn
        '
        Me.Training2DataGridViewCheckBoxColumn.DataPropertyName = "Training 2"
        Me.Training2DataGridViewCheckBoxColumn.HeaderText = "Training 2"
        Me.Training2DataGridViewCheckBoxColumn.Name = "Training2DataGridViewCheckBoxColumn"
        Me.Training2DataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Training3DataGridViewCheckBoxColumn
        '
        Me.Training3DataGridViewCheckBoxColumn.DataPropertyName = "Training 3"
        Me.Training3DataGridViewCheckBoxColumn.HeaderText = "Training 3"
        Me.Training3DataGridViewCheckBoxColumn.Name = "Training3DataGridViewCheckBoxColumn"
        Me.Training3DataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Training4DataGridViewCheckBoxColumn
        '
        Me.Training4DataGridViewCheckBoxColumn.DataPropertyName = "Training 4"
        Me.Training4DataGridViewCheckBoxColumn.HeaderText = "Training 4"
        Me.Training4DataGridViewCheckBoxColumn.Name = "Training4DataGridViewCheckBoxColumn"
        Me.Training4DataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Training5DataGridViewCheckBoxColumn
        '
        Me.Training5DataGridViewCheckBoxColumn.DataPropertyName = "Training 5"
        Me.Training5DataGridViewCheckBoxColumn.HeaderText = "Training 5"
        Me.Training5DataGridViewCheckBoxColumn.Name = "Training5DataGridViewCheckBoxColumn"
        Me.Training5DataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Training6DataGridViewCheckBoxColumn
        '
        Me.Training6DataGridViewCheckBoxColumn.DataPropertyName = "Training 6"
        Me.Training6DataGridViewCheckBoxColumn.HeaderText = "Training 6"
        Me.Training6DataGridViewCheckBoxColumn.Name = "Training6DataGridViewCheckBoxColumn"
        Me.Training6DataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Training7DataGridViewCheckBoxColumn
        '
        Me.Training7DataGridViewCheckBoxColumn.DataPropertyName = "Training 7"
        Me.Training7DataGridViewCheckBoxColumn.HeaderText = "Training 7"
        Me.Training7DataGridViewCheckBoxColumn.Name = "Training7DataGridViewCheckBoxColumn"
        Me.Training7DataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Training8DataGridViewCheckBoxColumn
        '
        Me.Training8DataGridViewCheckBoxColumn.DataPropertyName = "Training 8"
        Me.Training8DataGridViewCheckBoxColumn.HeaderText = "Training 8"
        Me.Training8DataGridViewCheckBoxColumn.Name = "Training8DataGridViewCheckBoxColumn"
        Me.Training8DataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Training9DataGridViewCheckBoxColumn
        '
        Me.Training9DataGridViewCheckBoxColumn.DataPropertyName = "Training 9"
        Me.Training9DataGridViewCheckBoxColumn.HeaderText = "Training 9"
        Me.Training9DataGridViewCheckBoxColumn.Name = "Training9DataGridViewCheckBoxColumn"
        Me.Training9DataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Training10DataGridViewCheckBoxColumn
        '
        Me.Training10DataGridViewCheckBoxColumn.DataPropertyName = "Training 10"
        Me.Training10DataGridViewCheckBoxColumn.HeaderText = "Training 10"
        Me.Training10DataGridViewCheckBoxColumn.Name = "Training10DataGridViewCheckBoxColumn"
        Me.Training10DataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Training11DataGridViewCheckBoxColumn
        '
        Me.Training11DataGridViewCheckBoxColumn.DataPropertyName = "Training 11"
        Me.Training11DataGridViewCheckBoxColumn.HeaderText = "Training 11"
        Me.Training11DataGridViewCheckBoxColumn.Name = "Training11DataGridViewCheckBoxColumn"
        Me.Training11DataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Training12DataGridViewCheckBoxColumn
        '
        Me.Training12DataGridViewCheckBoxColumn.DataPropertyName = "Training 12"
        Me.Training12DataGridViewCheckBoxColumn.HeaderText = "Training 12"
        Me.Training12DataGridViewCheckBoxColumn.Name = "Training12DataGridViewCheckBoxColumn"
        Me.Training12DataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Training13DataGridViewCheckBoxColumn
        '
        Me.Training13DataGridViewCheckBoxColumn.DataPropertyName = "Training 13"
        Me.Training13DataGridViewCheckBoxColumn.HeaderText = "Training 13"
        Me.Training13DataGridViewCheckBoxColumn.Name = "Training13DataGridViewCheckBoxColumn"
        Me.Training13DataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Training14DataGridViewCheckBoxColumn
        '
        Me.Training14DataGridViewCheckBoxColumn.DataPropertyName = "Training 14"
        Me.Training14DataGridViewCheckBoxColumn.HeaderText = "Training 14"
        Me.Training14DataGridViewCheckBoxColumn.Name = "Training14DataGridViewCheckBoxColumn"
        Me.Training14DataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Training15DataGridViewCheckBoxColumn
        '
        Me.Training15DataGridViewCheckBoxColumn.DataPropertyName = "Training 15"
        Me.Training15DataGridViewCheckBoxColumn.HeaderText = "Training 15"
        Me.Training15DataGridViewCheckBoxColumn.Name = "Training15DataGridViewCheckBoxColumn"
        Me.Training15DataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Training16DataGridViewCheckBoxColumn
        '
        Me.Training16DataGridViewCheckBoxColumn.DataPropertyName = "Training 16"
        Me.Training16DataGridViewCheckBoxColumn.HeaderText = "Training 16"
        Me.Training16DataGridViewCheckBoxColumn.Name = "Training16DataGridViewCheckBoxColumn"
        Me.Training16DataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Training17DataGridViewCheckBoxColumn
        '
        Me.Training17DataGridViewCheckBoxColumn.DataPropertyName = "Training 17"
        Me.Training17DataGridViewCheckBoxColumn.HeaderText = "Training 17"
        Me.Training17DataGridViewCheckBoxColumn.Name = "Training17DataGridViewCheckBoxColumn"
        Me.Training17DataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Training18DataGridViewCheckBoxColumn
        '
        Me.Training18DataGridViewCheckBoxColumn.DataPropertyName = "Training 18"
        Me.Training18DataGridViewCheckBoxColumn.HeaderText = "Training 18"
        Me.Training18DataGridViewCheckBoxColumn.Name = "Training18DataGridViewCheckBoxColumn"
        Me.Training18DataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Training19DataGridViewCheckBoxColumn
        '
        Me.Training19DataGridViewCheckBoxColumn.DataPropertyName = "Training 19"
        Me.Training19DataGridViewCheckBoxColumn.HeaderText = "Training 19"
        Me.Training19DataGridViewCheckBoxColumn.Name = "Training19DataGridViewCheckBoxColumn"
        Me.Training19DataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Training20DataGridViewCheckBoxColumn
        '
        Me.Training20DataGridViewCheckBoxColumn.DataPropertyName = "Training 20"
        Me.Training20DataGridViewCheckBoxColumn.HeaderText = "Training 20"
        Me.Training20DataGridViewCheckBoxColumn.Name = "Training20DataGridViewCheckBoxColumn"
        Me.Training20DataGridViewCheckBoxColumn.ReadOnly = True
        '
        'CountLabel1
        '
        Me.CountLabel1.AutoSize = True
        Me.CountLabel1.Location = New System.Drawing.Point(480, 24)
        Me.CountLabel1.Name = "CountLabel1"
        Me.CountLabel1.Size = New System.Drawing.Size(35, 13)
        Me.CountLabel1.TabIndex = 6
        Me.CountLabel1.Text = "Count"
        '
        'PrevButton1
        '
        Me.PrevButton1.Location = New System.Drawing.Point(167, 244)
        Me.PrevButton1.Name = "PrevButton1"
        Me.PrevButton1.Size = New System.Drawing.Size(44, 24)
        Me.PrevButton1.TabIndex = 7
        Me.PrevButton1.Text = "Prev"
        Me.PrevButton1.UseVisualStyleBackColor = True
        '
        'NextButton1
        '
        Me.NextButton1.Location = New System.Drawing.Point(360, 244)
        Me.NextButton1.Name = "NextButton1"
        Me.NextButton1.Size = New System.Drawing.Size(37, 24)
        Me.NextButton1.TabIndex = 8
        Me.NextButton1.Text = "Next"
        Me.NextButton1.UseVisualStyleBackColor = True
        '
        'DeleteButton1
        '
        Me.DeleteButton1.Location = New System.Drawing.Point(247, 245)
        Me.DeleteButton1.Name = "DeleteButton1"
        Me.DeleteButton1.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton1.TabIndex = 9
        Me.DeleteButton1.Text = "Delete"
        Me.DeleteButton1.UseVisualStyleBackColor = True
        '
        'EditButton1
        '
        Me.EditButton1.Location = New System.Drawing.Point(449, 244)
        Me.EditButton1.Name = "EditButton1"
        Me.EditButton1.Size = New System.Drawing.Size(75, 23)
        Me.EditButton1.TabIndex = 10
        Me.EditButton1.Text = "Edit"
        Me.EditButton1.UseVisualStyleBackColor = True
        '
        'EmpDis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 498)
        Me.Controls.Add(Me.EditButton1)
        Me.Controls.Add(Me.DeleteButton1)
        Me.Controls.Add(Me.NextButton1)
        Me.Controls.Add(Me.PrevButton1)
        Me.Controls.Add(Me.CountLabel1)
        Me.Controls.Add(Me.TestGridView1)
        Me.Controls.Add(Me.TrainingDateGridView1)
        Me.Controls.Add(Me.TrainingStatusGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SearchButton1)
        Me.Controls.Add(Me.SearchTextBox1)
        Me.Name = "EmpDis"
        Me.Text = "EmpDis"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TrainingstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StorageDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrainingdateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrainingDateGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrainingStatusGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SearchButton1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DOLLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DOJLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProductLabel1 As System.Windows.Forms.Label
    Friend WithEvents DesignationLabel1 As System.Windows.Forms.Label
    Friend WithEvents DCLabel1 As System.Windows.Forms.Label
    Friend WithEvents NameLabel1 As System.Windows.Forms.Label
    Friend WithEvents StorageDataSet As NTMS2.storageDataSet
    Friend WithEvents TrainingstatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Training_statusTableAdapter As NTMS2.storageDataSetTableAdapters.training_statusTableAdapter
    Friend WithEvents TrainingdateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Training_dateTableAdapter As NTMS2.storageDataSetTableAdapters.training_dateTableAdapter
    Friend WithEvents TestBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TestTableAdapter As NTMS2.storageDataSetTableAdapters.testTableAdapter
    Friend WithEvents EmployeeTableAdapter As NTMS2.storageDataSetTableAdapters.employeeTableAdapter
    Friend WithEvents TestGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TrainingDateGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TrainingStatusGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CountLabel1 As System.Windows.Forms.Label
    Friend WithEvents PrevButton1 As System.Windows.Forms.Button
    Friend WithEvents NextButton1 As System.Windows.Forms.Button
    Friend WithEvents IDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Test1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Test2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Test3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Test4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Test5DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Test6DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Test7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Test8DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Test9DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Test10DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PercentageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnalysisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Training1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Training2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Training3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Training4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Training5DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Training6DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Training7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Training8DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Training9DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Training10DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Training11DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Training12DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Training13DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Training14DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Training15DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Training16DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Training17DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Training18DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Training19DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Training20DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Training1DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Training2DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Training3DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Training4DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Training5DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Training6DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Training7DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Training8DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Training9DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Training10DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Training11DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Training12DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Training13DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Training14DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Training15DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Training16DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Training17DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Training18DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Training19DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Training20DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DeleteButton1 As System.Windows.Forms.Button
    Friend WithEvents EditButton1 As System.Windows.Forms.Button
End Class
