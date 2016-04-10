<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpEdit
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
        Me.TestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StorageDataSet = New NTMS2.storageDataSet()
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
        Me.TrainingdateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.TrainingstatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NameLabel1 = New System.Windows.Forms.Label()
        Me.DesignationLabel1 = New System.Windows.Forms.Label()
        Me.ProductLabel1 = New System.Windows.Forms.Label()
        Me.DOJLabel1 = New System.Windows.Forms.Label()
        Me.DOLLabel1 = New System.Windows.Forms.Label()
        Me.DCLabel1 = New System.Windows.Forms.Label()
        Me.NameLabel2 = New System.Windows.Forms.Label()
        Me.DesignationLabel2 = New System.Windows.Forms.Label()
        Me.ProductLabel2 = New System.Windows.Forms.Label()
        Me.DOJLabel2 = New System.Windows.Forms.Label()
        Me.DOLLabel2 = New System.Windows.Forms.Label()
        Me.DCLabel2 = New System.Windows.Forms.Label()
        Me.ProductComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DOLCheck = New System.Windows.Forms.CheckBox()
        Me.DOLPicker = New System.Windows.Forms.DateTimePicker()
        Me.DOJPicker = New System.Windows.Forms.DateTimePicker()
        Me.DealerComboBox = New System.Windows.Forms.ComboBox()
        Me.DesignationComboBox = New System.Windows.Forms.ComboBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateButton1 = New System.Windows.Forms.Button()
        Me.CancelButton1 = New System.Windows.Forms.Button()
        Me.Training_statusTableAdapter = New NTMS2.storageDataSetTableAdapters.training_statusTableAdapter()
        Me.Training_dateTableAdapter = New NTMS2.storageDataSetTableAdapters.training_dateTableAdapter()
        Me.TestTableAdapter = New NTMS2.storageDataSetTableAdapters.testTableAdapter()
        Me.EmployeeTableAdapter = New NTMS2.storageDataSetTableAdapters.employeeTableAdapter()
        Me.ProductTableAdapter = New NTMS2.storageDataSetTableAdapters.productTableAdapter()
        CType(Me.TestGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StorageDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrainingDateGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrainingdateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrainingStatusGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrainingstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TestGridView1
        '
        Me.TestGridView1.AllowUserToAddRows = False
        Me.TestGridView1.AllowUserToDeleteRows = False
        Me.TestGridView1.AutoGenerateColumns = False
        Me.TestGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TestGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn2, Me.Test1DataGridViewTextBoxColumn, Me.Test2DataGridViewTextBoxColumn, Me.Test3DataGridViewTextBoxColumn, Me.Test4DataGridViewTextBoxColumn, Me.Test5DataGridViewTextBoxColumn, Me.Test6DataGridViewTextBoxColumn, Me.Test7DataGridViewTextBoxColumn, Me.Test8DataGridViewTextBoxColumn, Me.Test9DataGridViewTextBoxColumn, Me.Test10DataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.PercentageDataGridViewTextBoxColumn, Me.AnalysisDataGridViewTextBoxColumn})
        Me.TestGridView1.DataSource = Me.TestBindingSource
        Me.TestGridView1.Location = New System.Drawing.Point(29, 408)
        Me.TestGridView1.Name = "TestGridView1"
        Me.TestGridView1.Size = New System.Drawing.Size(494, 60)
        Me.TestGridView1.TabIndex = 8
        '
        'IDDataGridViewTextBoxColumn2
        '
        Me.IDDataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn2.Name = "IDDataGridViewTextBoxColumn2"
        '
        'Test1DataGridViewTextBoxColumn
        '
        Me.Test1DataGridViewTextBoxColumn.DataPropertyName = "Test 1"
        Me.Test1DataGridViewTextBoxColumn.HeaderText = "Test 1"
        Me.Test1DataGridViewTextBoxColumn.Name = "Test1DataGridViewTextBoxColumn"
        '
        'Test2DataGridViewTextBoxColumn
        '
        Me.Test2DataGridViewTextBoxColumn.DataPropertyName = "Test 2"
        Me.Test2DataGridViewTextBoxColumn.HeaderText = "Test 2"
        Me.Test2DataGridViewTextBoxColumn.Name = "Test2DataGridViewTextBoxColumn"
        '
        'Test3DataGridViewTextBoxColumn
        '
        Me.Test3DataGridViewTextBoxColumn.DataPropertyName = "Test 3"
        Me.Test3DataGridViewTextBoxColumn.HeaderText = "Test 3"
        Me.Test3DataGridViewTextBoxColumn.Name = "Test3DataGridViewTextBoxColumn"
        '
        'Test4DataGridViewTextBoxColumn
        '
        Me.Test4DataGridViewTextBoxColumn.DataPropertyName = "Test 4"
        Me.Test4DataGridViewTextBoxColumn.HeaderText = "Test 4"
        Me.Test4DataGridViewTextBoxColumn.Name = "Test4DataGridViewTextBoxColumn"
        '
        'Test5DataGridViewTextBoxColumn
        '
        Me.Test5DataGridViewTextBoxColumn.DataPropertyName = "Test 5"
        Me.Test5DataGridViewTextBoxColumn.HeaderText = "Test 5"
        Me.Test5DataGridViewTextBoxColumn.Name = "Test5DataGridViewTextBoxColumn"
        '
        'Test6DataGridViewTextBoxColumn
        '
        Me.Test6DataGridViewTextBoxColumn.DataPropertyName = "Test 6"
        Me.Test6DataGridViewTextBoxColumn.HeaderText = "Test 6"
        Me.Test6DataGridViewTextBoxColumn.Name = "Test6DataGridViewTextBoxColumn"
        '
        'Test7DataGridViewTextBoxColumn
        '
        Me.Test7DataGridViewTextBoxColumn.DataPropertyName = "Test 7"
        Me.Test7DataGridViewTextBoxColumn.HeaderText = "Test 7"
        Me.Test7DataGridViewTextBoxColumn.Name = "Test7DataGridViewTextBoxColumn"
        '
        'Test8DataGridViewTextBoxColumn
        '
        Me.Test8DataGridViewTextBoxColumn.DataPropertyName = "Test 8"
        Me.Test8DataGridViewTextBoxColumn.HeaderText = "Test 8"
        Me.Test8DataGridViewTextBoxColumn.Name = "Test8DataGridViewTextBoxColumn"
        '
        'Test9DataGridViewTextBoxColumn
        '
        Me.Test9DataGridViewTextBoxColumn.DataPropertyName = "Test 9"
        Me.Test9DataGridViewTextBoxColumn.HeaderText = "Test 9"
        Me.Test9DataGridViewTextBoxColumn.Name = "Test9DataGridViewTextBoxColumn"
        '
        'Test10DataGridViewTextBoxColumn
        '
        Me.Test10DataGridViewTextBoxColumn.DataPropertyName = "Test 10"
        Me.Test10DataGridViewTextBoxColumn.HeaderText = "Test 10"
        Me.Test10DataGridViewTextBoxColumn.Name = "Test10DataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'PercentageDataGridViewTextBoxColumn
        '
        Me.PercentageDataGridViewTextBoxColumn.DataPropertyName = "Percentage"
        Me.PercentageDataGridViewTextBoxColumn.HeaderText = "Percentage"
        Me.PercentageDataGridViewTextBoxColumn.Name = "PercentageDataGridViewTextBoxColumn"
        '
        'AnalysisDataGridViewTextBoxColumn
        '
        Me.AnalysisDataGridViewTextBoxColumn.DataPropertyName = "Analysis"
        Me.AnalysisDataGridViewTextBoxColumn.HeaderText = "Analysis"
        Me.AnalysisDataGridViewTextBoxColumn.Name = "AnalysisDataGridViewTextBoxColumn"
        '
        'TestBindingSource
        '
        Me.TestBindingSource.DataMember = "test"
        Me.TestBindingSource.DataSource = Me.StorageDataSet
        '
        'StorageDataSet
        '
        Me.StorageDataSet.DataSetName = "storageDataSet"
        Me.StorageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TrainingDateGridView1
        '
        Me.TrainingDateGridView1.AllowUserToAddRows = False
        Me.TrainingDateGridView1.AllowUserToDeleteRows = False
        Me.TrainingDateGridView1.AutoGenerateColumns = False
        Me.TrainingDateGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TrainingDateGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.Training1DataGridViewTextBoxColumn, Me.Training2DataGridViewTextBoxColumn, Me.Training3DataGridViewTextBoxColumn, Me.Training4DataGridViewTextBoxColumn, Me.Training5DataGridViewTextBoxColumn, Me.Training6DataGridViewTextBoxColumn, Me.Training7DataGridViewTextBoxColumn, Me.Training8DataGridViewTextBoxColumn, Me.Training9DataGridViewTextBoxColumn, Me.Training10DataGridViewTextBoxColumn, Me.Training11DataGridViewTextBoxColumn, Me.Training12DataGridViewTextBoxColumn, Me.Training13DataGridViewTextBoxColumn, Me.Training14DataGridViewTextBoxColumn, Me.Training15DataGridViewTextBoxColumn, Me.Training16DataGridViewTextBoxColumn, Me.Training17DataGridViewTextBoxColumn, Me.Training18DataGridViewTextBoxColumn, Me.Training19DataGridViewTextBoxColumn, Me.Training20DataGridViewTextBoxColumn})
        Me.TrainingDateGridView1.DataSource = Me.TrainingdateBindingSource
        Me.TrainingDateGridView1.Location = New System.Drawing.Point(29, 346)
        Me.TrainingDateGridView1.Name = "TrainingDateGridView1"
        Me.TrainingDateGridView1.Size = New System.Drawing.Size(494, 56)
        Me.TrainingDateGridView1.TabIndex = 7
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'Training1DataGridViewTextBoxColumn
        '
        Me.Training1DataGridViewTextBoxColumn.DataPropertyName = "Training 1"
        Me.Training1DataGridViewTextBoxColumn.HeaderText = "Training 1"
        Me.Training1DataGridViewTextBoxColumn.Name = "Training1DataGridViewTextBoxColumn"
        '
        'Training2DataGridViewTextBoxColumn
        '
        Me.Training2DataGridViewTextBoxColumn.DataPropertyName = "Training 2"
        Me.Training2DataGridViewTextBoxColumn.HeaderText = "Training 2"
        Me.Training2DataGridViewTextBoxColumn.Name = "Training2DataGridViewTextBoxColumn"
        '
        'Training3DataGridViewTextBoxColumn
        '
        Me.Training3DataGridViewTextBoxColumn.DataPropertyName = "Training 3"
        Me.Training3DataGridViewTextBoxColumn.HeaderText = "Training 3"
        Me.Training3DataGridViewTextBoxColumn.Name = "Training3DataGridViewTextBoxColumn"
        '
        'Training4DataGridViewTextBoxColumn
        '
        Me.Training4DataGridViewTextBoxColumn.DataPropertyName = "Training 4"
        Me.Training4DataGridViewTextBoxColumn.HeaderText = "Training 4"
        Me.Training4DataGridViewTextBoxColumn.Name = "Training4DataGridViewTextBoxColumn"
        '
        'Training5DataGridViewTextBoxColumn
        '
        Me.Training5DataGridViewTextBoxColumn.DataPropertyName = "Training 5"
        Me.Training5DataGridViewTextBoxColumn.HeaderText = "Training 5"
        Me.Training5DataGridViewTextBoxColumn.Name = "Training5DataGridViewTextBoxColumn"
        '
        'Training6DataGridViewTextBoxColumn
        '
        Me.Training6DataGridViewTextBoxColumn.DataPropertyName = "Training 6"
        Me.Training6DataGridViewTextBoxColumn.HeaderText = "Training 6"
        Me.Training6DataGridViewTextBoxColumn.Name = "Training6DataGridViewTextBoxColumn"
        '
        'Training7DataGridViewTextBoxColumn
        '
        Me.Training7DataGridViewTextBoxColumn.DataPropertyName = "Training 7"
        Me.Training7DataGridViewTextBoxColumn.HeaderText = "Training 7"
        Me.Training7DataGridViewTextBoxColumn.Name = "Training7DataGridViewTextBoxColumn"
        '
        'Training8DataGridViewTextBoxColumn
        '
        Me.Training8DataGridViewTextBoxColumn.DataPropertyName = "Training 8"
        Me.Training8DataGridViewTextBoxColumn.HeaderText = "Training 8"
        Me.Training8DataGridViewTextBoxColumn.Name = "Training8DataGridViewTextBoxColumn"
        '
        'Training9DataGridViewTextBoxColumn
        '
        Me.Training9DataGridViewTextBoxColumn.DataPropertyName = "Training 9"
        Me.Training9DataGridViewTextBoxColumn.HeaderText = "Training 9"
        Me.Training9DataGridViewTextBoxColumn.Name = "Training9DataGridViewTextBoxColumn"
        '
        'Training10DataGridViewTextBoxColumn
        '
        Me.Training10DataGridViewTextBoxColumn.DataPropertyName = "Training 10"
        Me.Training10DataGridViewTextBoxColumn.HeaderText = "Training 10"
        Me.Training10DataGridViewTextBoxColumn.Name = "Training10DataGridViewTextBoxColumn"
        '
        'Training11DataGridViewTextBoxColumn
        '
        Me.Training11DataGridViewTextBoxColumn.DataPropertyName = "Training 11"
        Me.Training11DataGridViewTextBoxColumn.HeaderText = "Training 11"
        Me.Training11DataGridViewTextBoxColumn.Name = "Training11DataGridViewTextBoxColumn"
        '
        'Training12DataGridViewTextBoxColumn
        '
        Me.Training12DataGridViewTextBoxColumn.DataPropertyName = "Training 12"
        Me.Training12DataGridViewTextBoxColumn.HeaderText = "Training 12"
        Me.Training12DataGridViewTextBoxColumn.Name = "Training12DataGridViewTextBoxColumn"
        '
        'Training13DataGridViewTextBoxColumn
        '
        Me.Training13DataGridViewTextBoxColumn.DataPropertyName = "Training 13"
        Me.Training13DataGridViewTextBoxColumn.HeaderText = "Training 13"
        Me.Training13DataGridViewTextBoxColumn.Name = "Training13DataGridViewTextBoxColumn"
        '
        'Training14DataGridViewTextBoxColumn
        '
        Me.Training14DataGridViewTextBoxColumn.DataPropertyName = "Training 14"
        Me.Training14DataGridViewTextBoxColumn.HeaderText = "Training 14"
        Me.Training14DataGridViewTextBoxColumn.Name = "Training14DataGridViewTextBoxColumn"
        '
        'Training15DataGridViewTextBoxColumn
        '
        Me.Training15DataGridViewTextBoxColumn.DataPropertyName = "Training 15"
        Me.Training15DataGridViewTextBoxColumn.HeaderText = "Training 15"
        Me.Training15DataGridViewTextBoxColumn.Name = "Training15DataGridViewTextBoxColumn"
        '
        'Training16DataGridViewTextBoxColumn
        '
        Me.Training16DataGridViewTextBoxColumn.DataPropertyName = "Training 16"
        Me.Training16DataGridViewTextBoxColumn.HeaderText = "Training 16"
        Me.Training16DataGridViewTextBoxColumn.Name = "Training16DataGridViewTextBoxColumn"
        '
        'Training17DataGridViewTextBoxColumn
        '
        Me.Training17DataGridViewTextBoxColumn.DataPropertyName = "Training 17"
        Me.Training17DataGridViewTextBoxColumn.HeaderText = "Training 17"
        Me.Training17DataGridViewTextBoxColumn.Name = "Training17DataGridViewTextBoxColumn"
        '
        'Training18DataGridViewTextBoxColumn
        '
        Me.Training18DataGridViewTextBoxColumn.DataPropertyName = "Training 18"
        Me.Training18DataGridViewTextBoxColumn.HeaderText = "Training 18"
        Me.Training18DataGridViewTextBoxColumn.Name = "Training18DataGridViewTextBoxColumn"
        '
        'Training19DataGridViewTextBoxColumn
        '
        Me.Training19DataGridViewTextBoxColumn.DataPropertyName = "Training 19"
        Me.Training19DataGridViewTextBoxColumn.HeaderText = "Training 19"
        Me.Training19DataGridViewTextBoxColumn.Name = "Training19DataGridViewTextBoxColumn"
        '
        'Training20DataGridViewTextBoxColumn
        '
        Me.Training20DataGridViewTextBoxColumn.DataPropertyName = "Training 20"
        Me.Training20DataGridViewTextBoxColumn.HeaderText = "Training 20"
        Me.Training20DataGridViewTextBoxColumn.Name = "Training20DataGridViewTextBoxColumn"
        '
        'TrainingdateBindingSource
        '
        Me.TrainingdateBindingSource.DataMember = "training_date"
        Me.TrainingdateBindingSource.DataSource = Me.StorageDataSet
        '
        'TrainingStatusGridView1
        '
        Me.TrainingStatusGridView1.AllowUserToAddRows = False
        Me.TrainingStatusGridView1.AllowUserToDeleteRows = False
        Me.TrainingStatusGridView1.AutoGenerateColumns = False
        Me.TrainingStatusGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TrainingStatusGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.Training1DataGridViewCheckBoxColumn, Me.Training2DataGridViewCheckBoxColumn, Me.Training3DataGridViewCheckBoxColumn, Me.Training4DataGridViewCheckBoxColumn, Me.Training5DataGridViewCheckBoxColumn, Me.Training6DataGridViewCheckBoxColumn, Me.Training7DataGridViewCheckBoxColumn, Me.Training8DataGridViewCheckBoxColumn, Me.Training9DataGridViewCheckBoxColumn, Me.Training10DataGridViewCheckBoxColumn, Me.Training11DataGridViewCheckBoxColumn, Me.Training12DataGridViewCheckBoxColumn, Me.Training13DataGridViewCheckBoxColumn, Me.Training14DataGridViewCheckBoxColumn, Me.Training15DataGridViewCheckBoxColumn, Me.Training16DataGridViewCheckBoxColumn, Me.Training17DataGridViewCheckBoxColumn, Me.Training18DataGridViewCheckBoxColumn, Me.Training19DataGridViewCheckBoxColumn, Me.Training20DataGridViewCheckBoxColumn})
        Me.TrainingStatusGridView1.DataSource = Me.TrainingstatusBindingSource
        Me.TrainingStatusGridView1.Location = New System.Drawing.Point(29, 281)
        Me.TrainingStatusGridView1.Name = "TrainingStatusGridView1"
        Me.TrainingStatusGridView1.Size = New System.Drawing.Size(494, 59)
        Me.TrainingStatusGridView1.TabIndex = 6
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'Training1DataGridViewCheckBoxColumn
        '
        Me.Training1DataGridViewCheckBoxColumn.DataPropertyName = "Training 1"
        Me.Training1DataGridViewCheckBoxColumn.HeaderText = "Training 1"
        Me.Training1DataGridViewCheckBoxColumn.Name = "Training1DataGridViewCheckBoxColumn"
        '
        'Training2DataGridViewCheckBoxColumn
        '
        Me.Training2DataGridViewCheckBoxColumn.DataPropertyName = "Training 2"
        Me.Training2DataGridViewCheckBoxColumn.HeaderText = "Training 2"
        Me.Training2DataGridViewCheckBoxColumn.Name = "Training2DataGridViewCheckBoxColumn"
        '
        'Training3DataGridViewCheckBoxColumn
        '
        Me.Training3DataGridViewCheckBoxColumn.DataPropertyName = "Training 3"
        Me.Training3DataGridViewCheckBoxColumn.HeaderText = "Training 3"
        Me.Training3DataGridViewCheckBoxColumn.Name = "Training3DataGridViewCheckBoxColumn"
        '
        'Training4DataGridViewCheckBoxColumn
        '
        Me.Training4DataGridViewCheckBoxColumn.DataPropertyName = "Training 4"
        Me.Training4DataGridViewCheckBoxColumn.HeaderText = "Training 4"
        Me.Training4DataGridViewCheckBoxColumn.Name = "Training4DataGridViewCheckBoxColumn"
        '
        'Training5DataGridViewCheckBoxColumn
        '
        Me.Training5DataGridViewCheckBoxColumn.DataPropertyName = "Training 5"
        Me.Training5DataGridViewCheckBoxColumn.HeaderText = "Training 5"
        Me.Training5DataGridViewCheckBoxColumn.Name = "Training5DataGridViewCheckBoxColumn"
        '
        'Training6DataGridViewCheckBoxColumn
        '
        Me.Training6DataGridViewCheckBoxColumn.DataPropertyName = "Training 6"
        Me.Training6DataGridViewCheckBoxColumn.HeaderText = "Training 6"
        Me.Training6DataGridViewCheckBoxColumn.Name = "Training6DataGridViewCheckBoxColumn"
        '
        'Training7DataGridViewCheckBoxColumn
        '
        Me.Training7DataGridViewCheckBoxColumn.DataPropertyName = "Training 7"
        Me.Training7DataGridViewCheckBoxColumn.HeaderText = "Training 7"
        Me.Training7DataGridViewCheckBoxColumn.Name = "Training7DataGridViewCheckBoxColumn"
        '
        'Training8DataGridViewCheckBoxColumn
        '
        Me.Training8DataGridViewCheckBoxColumn.DataPropertyName = "Training 8"
        Me.Training8DataGridViewCheckBoxColumn.HeaderText = "Training 8"
        Me.Training8DataGridViewCheckBoxColumn.Name = "Training8DataGridViewCheckBoxColumn"
        '
        'Training9DataGridViewCheckBoxColumn
        '
        Me.Training9DataGridViewCheckBoxColumn.DataPropertyName = "Training 9"
        Me.Training9DataGridViewCheckBoxColumn.HeaderText = "Training 9"
        Me.Training9DataGridViewCheckBoxColumn.Name = "Training9DataGridViewCheckBoxColumn"
        '
        'Training10DataGridViewCheckBoxColumn
        '
        Me.Training10DataGridViewCheckBoxColumn.DataPropertyName = "Training 10"
        Me.Training10DataGridViewCheckBoxColumn.HeaderText = "Training 10"
        Me.Training10DataGridViewCheckBoxColumn.Name = "Training10DataGridViewCheckBoxColumn"
        '
        'Training11DataGridViewCheckBoxColumn
        '
        Me.Training11DataGridViewCheckBoxColumn.DataPropertyName = "Training 11"
        Me.Training11DataGridViewCheckBoxColumn.HeaderText = "Training 11"
        Me.Training11DataGridViewCheckBoxColumn.Name = "Training11DataGridViewCheckBoxColumn"
        '
        'Training12DataGridViewCheckBoxColumn
        '
        Me.Training12DataGridViewCheckBoxColumn.DataPropertyName = "Training 12"
        Me.Training12DataGridViewCheckBoxColumn.HeaderText = "Training 12"
        Me.Training12DataGridViewCheckBoxColumn.Name = "Training12DataGridViewCheckBoxColumn"
        '
        'Training13DataGridViewCheckBoxColumn
        '
        Me.Training13DataGridViewCheckBoxColumn.DataPropertyName = "Training 13"
        Me.Training13DataGridViewCheckBoxColumn.HeaderText = "Training 13"
        Me.Training13DataGridViewCheckBoxColumn.Name = "Training13DataGridViewCheckBoxColumn"
        '
        'Training14DataGridViewCheckBoxColumn
        '
        Me.Training14DataGridViewCheckBoxColumn.DataPropertyName = "Training 14"
        Me.Training14DataGridViewCheckBoxColumn.HeaderText = "Training 14"
        Me.Training14DataGridViewCheckBoxColumn.Name = "Training14DataGridViewCheckBoxColumn"
        '
        'Training15DataGridViewCheckBoxColumn
        '
        Me.Training15DataGridViewCheckBoxColumn.DataPropertyName = "Training 15"
        Me.Training15DataGridViewCheckBoxColumn.HeaderText = "Training 15"
        Me.Training15DataGridViewCheckBoxColumn.Name = "Training15DataGridViewCheckBoxColumn"
        '
        'Training16DataGridViewCheckBoxColumn
        '
        Me.Training16DataGridViewCheckBoxColumn.DataPropertyName = "Training 16"
        Me.Training16DataGridViewCheckBoxColumn.HeaderText = "Training 16"
        Me.Training16DataGridViewCheckBoxColumn.Name = "Training16DataGridViewCheckBoxColumn"
        '
        'Training17DataGridViewCheckBoxColumn
        '
        Me.Training17DataGridViewCheckBoxColumn.DataPropertyName = "Training 17"
        Me.Training17DataGridViewCheckBoxColumn.HeaderText = "Training 17"
        Me.Training17DataGridViewCheckBoxColumn.Name = "Training17DataGridViewCheckBoxColumn"
        '
        'Training18DataGridViewCheckBoxColumn
        '
        Me.Training18DataGridViewCheckBoxColumn.DataPropertyName = "Training 18"
        Me.Training18DataGridViewCheckBoxColumn.HeaderText = "Training 18"
        Me.Training18DataGridViewCheckBoxColumn.Name = "Training18DataGridViewCheckBoxColumn"
        '
        'Training19DataGridViewCheckBoxColumn
        '
        Me.Training19DataGridViewCheckBoxColumn.DataPropertyName = "Training 19"
        Me.Training19DataGridViewCheckBoxColumn.HeaderText = "Training 19"
        Me.Training19DataGridViewCheckBoxColumn.Name = "Training19DataGridViewCheckBoxColumn"
        '
        'Training20DataGridViewCheckBoxColumn
        '
        Me.Training20DataGridViewCheckBoxColumn.DataPropertyName = "Training 20"
        Me.Training20DataGridViewCheckBoxColumn.HeaderText = "Training 20"
        Me.Training20DataGridViewCheckBoxColumn.Name = "Training20DataGridViewCheckBoxColumn"
        '
        'TrainingstatusBindingSource
        '
        Me.TrainingstatusBindingSource.DataMember = "training_status"
        Me.TrainingstatusBindingSource.DataSource = Me.StorageDataSet
        '
        'NameLabel1
        '
        Me.NameLabel1.AutoSize = True
        Me.NameLabel1.Location = New System.Drawing.Point(26, 55)
        Me.NameLabel1.Name = "NameLabel1"
        Me.NameLabel1.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel1.TabIndex = 9
        Me.NameLabel1.Text = "Name"
        '
        'DesignationLabel1
        '
        Me.DesignationLabel1.AutoSize = True
        Me.DesignationLabel1.Location = New System.Drawing.Point(26, 92)
        Me.DesignationLabel1.Name = "DesignationLabel1"
        Me.DesignationLabel1.Size = New System.Drawing.Size(63, 13)
        Me.DesignationLabel1.TabIndex = 10
        Me.DesignationLabel1.Text = "Designation"
        '
        'ProductLabel1
        '
        Me.ProductLabel1.AutoSize = True
        Me.ProductLabel1.Location = New System.Drawing.Point(26, 125)
        Me.ProductLabel1.Name = "ProductLabel1"
        Me.ProductLabel1.Size = New System.Drawing.Size(44, 13)
        Me.ProductLabel1.TabIndex = 11
        Me.ProductLabel1.Text = "Product"
        '
        'DOJLabel1
        '
        Me.DOJLabel1.AutoSize = True
        Me.DOJLabel1.Location = New System.Drawing.Point(26, 160)
        Me.DOJLabel1.Name = "DOJLabel1"
        Me.DOJLabel1.Size = New System.Drawing.Size(78, 13)
        Me.DOJLabel1.TabIndex = 12
        Me.DOJLabel1.Text = "Date of Joining"
        '
        'DOLLabel1
        '
        Me.DOLLabel1.AutoSize = True
        Me.DOLLabel1.Location = New System.Drawing.Point(21, 195)
        Me.DOLLabel1.Name = "DOLLabel1"
        Me.DOLLabel1.Size = New System.Drawing.Size(83, 13)
        Me.DOLLabel1.TabIndex = 13
        Me.DOLLabel1.Text = "Date of Leaving"
        '
        'DCLabel1
        '
        Me.DCLabel1.AutoSize = True
        Me.DCLabel1.Location = New System.Drawing.Point(26, 228)
        Me.DCLabel1.Name = "DCLabel1"
        Me.DCLabel1.Size = New System.Drawing.Size(66, 13)
        Me.DCLabel1.TabIndex = 14
        Me.DCLabel1.Text = "Dealer Code"
        '
        'NameLabel2
        '
        Me.NameLabel2.AutoSize = True
        Me.NameLabel2.Location = New System.Drawing.Point(335, 59)
        Me.NameLabel2.Name = "NameLabel2"
        Me.NameLabel2.Size = New System.Drawing.Size(39, 13)
        Me.NameLabel2.TabIndex = 15
        Me.NameLabel2.Text = "Label7"
        '
        'DesignationLabel2
        '
        Me.DesignationLabel2.AutoSize = True
        Me.DesignationLabel2.Location = New System.Drawing.Point(335, 92)
        Me.DesignationLabel2.Name = "DesignationLabel2"
        Me.DesignationLabel2.Size = New System.Drawing.Size(39, 13)
        Me.DesignationLabel2.TabIndex = 16
        Me.DesignationLabel2.Text = "Label8"
        '
        'ProductLabel2
        '
        Me.ProductLabel2.AutoSize = True
        Me.ProductLabel2.Location = New System.Drawing.Point(335, 122)
        Me.ProductLabel2.Name = "ProductLabel2"
        Me.ProductLabel2.Size = New System.Drawing.Size(39, 13)
        Me.ProductLabel2.TabIndex = 17
        Me.ProductLabel2.Text = "Label9"
        '
        'DOJLabel2
        '
        Me.DOJLabel2.AutoSize = True
        Me.DOJLabel2.Location = New System.Drawing.Point(335, 160)
        Me.DOJLabel2.Name = "DOJLabel2"
        Me.DOJLabel2.Size = New System.Drawing.Size(45, 13)
        Me.DOJLabel2.TabIndex = 18
        Me.DOJLabel2.Text = "Label10"
        '
        'DOLLabel2
        '
        Me.DOLLabel2.AutoSize = True
        Me.DOLLabel2.Location = New System.Drawing.Point(335, 195)
        Me.DOLLabel2.Name = "DOLLabel2"
        Me.DOLLabel2.Size = New System.Drawing.Size(45, 13)
        Me.DOLLabel2.TabIndex = 19
        Me.DOLLabel2.Text = "Label11"
        '
        'DCLabel2
        '
        Me.DCLabel2.AutoSize = True
        Me.DCLabel2.Location = New System.Drawing.Point(335, 231)
        Me.DCLabel2.Name = "DCLabel2"
        Me.DCLabel2.Size = New System.Drawing.Size(45, 13)
        Me.DCLabel2.TabIndex = 20
        Me.DCLabel2.Text = "Label12"
        '
        'ProductComboBox
        '
        Me.ProductComboBox.DataSource = Me.ProductBindingSource
        Me.ProductComboBox.DisplayMember = "Product"
        Me.ProductComboBox.FormattingEnabled = True
        Me.ProductComboBox.Location = New System.Drawing.Point(131, 122)
        Me.ProductComboBox.Name = "ProductComboBox"
        Me.ProductComboBox.Size = New System.Drawing.Size(173, 21)
        Me.ProductComboBox.TabIndex = 27
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "product"
        Me.ProductBindingSource.DataSource = Me.StorageDataSet
        '
        'DOLCheck
        '
        Me.DOLCheck.AutoSize = True
        Me.DOLCheck.Location = New System.Drawing.Point(110, 193)
        Me.DOLCheck.Name = "DOLCheck"
        Me.DOLCheck.Size = New System.Drawing.Size(15, 14)
        Me.DOLCheck.TabIndex = 26
        Me.DOLCheck.UseVisualStyleBackColor = True
        '
        'DOLPicker
        '
        Me.DOLPicker.CustomFormat = "dd-mm-yyyy"
        Me.DOLPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DOLPicker.Location = New System.Drawing.Point(131, 188)
        Me.DOLPicker.Name = "DOLPicker"
        Me.DOLPicker.Size = New System.Drawing.Size(173, 20)
        Me.DOLPicker.TabIndex = 25
        Me.DOLPicker.Value = New Date(2011, 1, 25, 0, 0, 0, 0)
        '
        'DOJPicker
        '
        Me.DOJPicker.CustomFormat = "dd-mm-yyyy"
        Me.DOJPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DOJPicker.Location = New System.Drawing.Point(131, 160)
        Me.DOJPicker.Name = "DOJPicker"
        Me.DOJPicker.Size = New System.Drawing.Size(173, 20)
        Me.DOJPicker.TabIndex = 24
        Me.DOJPicker.Value = New Date(2011, 1, 25, 0, 0, 0, 0)
        '
        'DealerComboBox
        '
        Me.DealerComboBox.FormattingEnabled = True
        Me.DealerComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.DealerComboBox.Location = New System.Drawing.Point(131, 228)
        Me.DealerComboBox.Name = "DealerComboBox"
        Me.DealerComboBox.Size = New System.Drawing.Size(173, 21)
        Me.DealerComboBox.TabIndex = 23
        '
        'DesignationComboBox
        '
        Me.DesignationComboBox.FormattingEnabled = True
        Me.DesignationComboBox.Items.AddRange(New Object() {"SM", "SC", "CRM", "CRE"})
        Me.DesignationComboBox.Location = New System.Drawing.Point(131, 89)
        Me.DesignationComboBox.Name = "DesignationComboBox"
        Me.DesignationComboBox.Size = New System.Drawing.Size(173, 21)
        Me.DesignationComboBox.TabIndex = 22
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(131, 52)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(173, 20)
        Me.NameTextBox.TabIndex = 21
        '
        'UpdateButton1
        '
        Me.UpdateButton1.Location = New System.Drawing.Point(299, 501)
        Me.UpdateButton1.Name = "UpdateButton1"
        Me.UpdateButton1.Size = New System.Drawing.Size(75, 23)
        Me.UpdateButton1.TabIndex = 28
        Me.UpdateButton1.Text = "Update"
        Me.UpdateButton1.UseVisualStyleBackColor = True
        '
        'CancelButton1
        '
        Me.CancelButton1.Location = New System.Drawing.Point(403, 501)
        Me.CancelButton1.Name = "CancelButton1"
        Me.CancelButton1.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton1.TabIndex = 29
        Me.CancelButton1.Text = "Cancel"
        Me.CancelButton1.UseVisualStyleBackColor = True
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
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'EmpEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 536)
        Me.Controls.Add(Me.CancelButton1)
        Me.Controls.Add(Me.UpdateButton1)
        Me.Controls.Add(Me.ProductComboBox)
        Me.Controls.Add(Me.DOLCheck)
        Me.Controls.Add(Me.DOLPicker)
        Me.Controls.Add(Me.DOJPicker)
        Me.Controls.Add(Me.DealerComboBox)
        Me.Controls.Add(Me.DesignationComboBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.DCLabel2)
        Me.Controls.Add(Me.DOLLabel2)
        Me.Controls.Add(Me.DOJLabel2)
        Me.Controls.Add(Me.ProductLabel2)
        Me.Controls.Add(Me.DesignationLabel2)
        Me.Controls.Add(Me.NameLabel2)
        Me.Controls.Add(Me.DCLabel1)
        Me.Controls.Add(Me.DOLLabel1)
        Me.Controls.Add(Me.DOJLabel1)
        Me.Controls.Add(Me.ProductLabel1)
        Me.Controls.Add(Me.DesignationLabel1)
        Me.Controls.Add(Me.NameLabel1)
        Me.Controls.Add(Me.TestGridView1)
        Me.Controls.Add(Me.TrainingDateGridView1)
        Me.Controls.Add(Me.TrainingStatusGridView1)
        Me.Name = "EmpEdit"
        Me.Text = "EmpEdit"
        CType(Me.TestGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StorageDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrainingDateGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrainingdateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrainingStatusGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrainingstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TestGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TrainingDateGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TrainingStatusGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents StorageDataSet As NTMS2.storageDataSet
    Friend WithEvents TrainingstatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Training_statusTableAdapter As NTMS2.storageDataSetTableAdapters.training_statusTableAdapter
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
    Friend WithEvents TrainingdateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Training_dateTableAdapter As NTMS2.storageDataSetTableAdapters.training_dateTableAdapter
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
    Friend WithEvents TestBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TestTableAdapter As NTMS2.storageDataSetTableAdapters.testTableAdapter
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
    Friend WithEvents NameLabel1 As System.Windows.Forms.Label
    Friend WithEvents DesignationLabel1 As System.Windows.Forms.Label
    Friend WithEvents ProductLabel1 As System.Windows.Forms.Label
    Friend WithEvents DOJLabel1 As System.Windows.Forms.Label
    Friend WithEvents DOLLabel1 As System.Windows.Forms.Label
    Friend WithEvents DCLabel1 As System.Windows.Forms.Label
    Friend WithEvents NameLabel2 As System.Windows.Forms.Label
    Friend WithEvents DesignationLabel2 As System.Windows.Forms.Label
    Friend WithEvents ProductLabel2 As System.Windows.Forms.Label
    Friend WithEvents DOJLabel2 As System.Windows.Forms.Label
    Friend WithEvents DOLLabel2 As System.Windows.Forms.Label
    Friend WithEvents DCLabel2 As System.Windows.Forms.Label
    Friend WithEvents ProductComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DOLCheck As System.Windows.Forms.CheckBox
    Friend WithEvents DOLPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DOJPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DealerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DesignationComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeTableAdapter As NTMS2.storageDataSetTableAdapters.employeeTableAdapter
    Friend WithEvents UpdateButton1 As System.Windows.Forms.Button
    Friend WithEvents CancelButton1 As System.Windows.Forms.Button
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductTableAdapter As NTMS2.storageDataSetTableAdapters.productTableAdapter
End Class
