<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class regionsearchresult
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
        Dim Dealer_CodeLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim RegionLabel As System.Windows.Forms.Label
        Dim CatagoryLabel As System.Windows.Forms.Label
        Dim Date_of_inaugrationLabel As System.Windows.Forms.Label
        Dim Date_of_pre_SOS_trainingLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(regionsearchresult))
        Me.StorageDataSet = New NTMS2.storageDataSet()
        Me.Namesearch_QueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Namesearch_QueryTableAdapter = New NTMS2.storageDataSetTableAdapters.namesearch_QueryTableAdapter()
        Me.TableAdapterManager = New NTMS2.storageDataSetTableAdapters.TableAdapterManager()
        Me.Namesearch_QueryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Namesearch_QueryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Dealer1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dealer1TableAdapter = New NTMS2.storageDataSetTableAdapters.dealer1TableAdapter()
        Me.Dealer_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.RegionTextBox = New System.Windows.Forms.TextBox()
        Me.CatagoryTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_inaugrationDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Date_of_pre_SOS_trainingDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Dealer_CodeLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        RegionLabel = New System.Windows.Forms.Label()
        CatagoryLabel = New System.Windows.Forms.Label()
        Date_of_inaugrationLabel = New System.Windows.Forms.Label()
        Date_of_pre_SOS_trainingLabel = New System.Windows.Forms.Label()
        CType(Me.StorageDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Namesearch_QueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Namesearch_QueryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Namesearch_QueryBindingNavigator.SuspendLayout()
        CType(Me.Dealer1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dealer_CodeLabel
        '
        Dealer_CodeLabel.AutoSize = True
        Dealer_CodeLabel.Location = New System.Drawing.Point(111, 58)
        Dealer_CodeLabel.Name = "Dealer_CodeLabel"
        Dealer_CodeLabel.Size = New System.Drawing.Size(69, 13)
        Dealer_CodeLabel.TabIndex = 1
        Dealer_CodeLabel.Text = "Dealer-Code:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(111, 97)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Location = New System.Drawing.Point(111, 132)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(51, 13)
        LocationLabel.TabIndex = 5
        LocationLabel.Text = "Location:"
        '
        'RegionLabel
        '
        RegionLabel.AutoSize = True
        RegionLabel.Location = New System.Drawing.Point(111, 169)
        RegionLabel.Name = "RegionLabel"
        RegionLabel.Size = New System.Drawing.Size(44, 13)
        RegionLabel.TabIndex = 7
        RegionLabel.Text = "Region:"
        '
        'CatagoryLabel
        '
        CatagoryLabel.AutoSize = True
        CatagoryLabel.Location = New System.Drawing.Point(111, 203)
        CatagoryLabel.Name = "CatagoryLabel"
        CatagoryLabel.Size = New System.Drawing.Size(51, 13)
        CatagoryLabel.TabIndex = 9
        CatagoryLabel.Text = "catagory:"
        '
        'Date_of_inaugrationLabel
        '
        Date_of_inaugrationLabel.AutoSize = True
        Date_of_inaugrationLabel.Location = New System.Drawing.Point(111, 261)
        Date_of_inaugrationLabel.Name = "Date_of_inaugrationLabel"
        Date_of_inaugrationLabel.Size = New System.Drawing.Size(100, 13)
        Date_of_inaugrationLabel.TabIndex = 11
        Date_of_inaugrationLabel.Text = "Date of inaugration:"
        '
        'Date_of_pre_SOS_trainingLabel
        '
        Date_of_pre_SOS_trainingLabel.AutoSize = True
        Date_of_pre_SOS_trainingLabel.Location = New System.Drawing.Point(111, 308)
        Date_of_pre_SOS_trainingLabel.Name = "Date_of_pre_SOS_trainingLabel"
        Date_of_pre_SOS_trainingLabel.Size = New System.Drawing.Size(125, 13)
        Date_of_pre_SOS_trainingLabel.TabIndex = 13
        Date_of_pre_SOS_trainingLabel.Text = "Date of pre SOS training:"
        '
        'StorageDataSet
        '
        Me.StorageDataSet.DataSetName = "storageDataSet"
        Me.StorageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Namesearch_QueryBindingSource
        '
        Me.Namesearch_QueryBindingSource.DataMember = "namesearch_Query"
        Me.Namesearch_QueryBindingSource.DataSource = Me.StorageDataSet
        '
        'Namesearch_QueryTableAdapter
        '
        Me.Namesearch_QueryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.dealer_dataTableAdapter = Nothing
        Me.TableAdapterManager.dealer1TableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.namesearchTableAdapter = Nothing
        Me.TableAdapterManager.productTableAdapter = Nothing
        Me.TableAdapterManager.testTableAdapter = Nothing
        Me.TableAdapterManager.training_dateTableAdapter = Nothing
        Me.TableAdapterManager.training_statusTableAdapter = Nothing
        Me.TableAdapterManager.tTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NTMS2.storageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Namesearch_QueryBindingNavigator
        '
        Me.Namesearch_QueryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Namesearch_QueryBindingNavigator.BindingSource = Me.Namesearch_QueryBindingSource
        Me.Namesearch_QueryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Namesearch_QueryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Namesearch_QueryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Namesearch_QueryBindingNavigatorSaveItem})
        Me.Namesearch_QueryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Namesearch_QueryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Namesearch_QueryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Namesearch_QueryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Namesearch_QueryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Namesearch_QueryBindingNavigator.Name = "Namesearch_QueryBindingNavigator"
        Me.Namesearch_QueryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Namesearch_QueryBindingNavigator.Size = New System.Drawing.Size(630, 25)
        Me.Namesearch_QueryBindingNavigator.TabIndex = 0
        Me.Namesearch_QueryBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Namesearch_QueryBindingNavigatorSaveItem
        '
        Me.Namesearch_QueryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Namesearch_QueryBindingNavigatorSaveItem.Enabled = False
        Me.Namesearch_QueryBindingNavigatorSaveItem.Image = CType(resources.GetObject("Namesearch_QueryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Namesearch_QueryBindingNavigatorSaveItem.Name = "Namesearch_QueryBindingNavigatorSaveItem"
        Me.Namesearch_QueryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Namesearch_QueryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Dealer1BindingSource
        '
        Me.Dealer1BindingSource.DataMember = "dealer1"
        Me.Dealer1BindingSource.DataSource = Me.StorageDataSet
        '
        'Dealer1TableAdapter
        '
        Me.Dealer1TableAdapter.ClearBeforeFill = True
        '
        'Dealer_CodeTextBox
        '
        Me.Dealer_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dealer1BindingSource, "Dealer-Code", True))
        Me.Dealer_CodeTextBox.Location = New System.Drawing.Point(269, 51)
        Me.Dealer_CodeTextBox.Name = "Dealer_CodeTextBox"
        Me.Dealer_CodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Dealer_CodeTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dealer1BindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(269, 94)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dealer1BindingSource, "Location", True))
        Me.LocationTextBox.Location = New System.Drawing.Point(269, 132)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LocationTextBox.TabIndex = 6
        '
        'RegionTextBox
        '
        Me.RegionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dealer1BindingSource, "Region", True))
        Me.RegionTextBox.Location = New System.Drawing.Point(269, 169)
        Me.RegionTextBox.Name = "RegionTextBox"
        Me.RegionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RegionTextBox.TabIndex = 8
        '
        'CatagoryTextBox
        '
        Me.CatagoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dealer1BindingSource, "catagory", True))
        Me.CatagoryTextBox.Location = New System.Drawing.Point(269, 203)
        Me.CatagoryTextBox.Name = "CatagoryTextBox"
        Me.CatagoryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CatagoryTextBox.TabIndex = 10
        '
        'Date_of_inaugrationDateTimePicker
        '
        Me.Date_of_inaugrationDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Dealer1BindingSource, "Date of inaugration", True))
        Me.Date_of_inaugrationDateTimePicker.Location = New System.Drawing.Point(269, 255)
        Me.Date_of_inaugrationDateTimePicker.Name = "Date_of_inaugrationDateTimePicker"
        Me.Date_of_inaugrationDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_of_inaugrationDateTimePicker.TabIndex = 12
        '
        'Date_of_pre_SOS_trainingDateTimePicker
        '
        Me.Date_of_pre_SOS_trainingDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Dealer1BindingSource, "Date of pre SOS training", True))
        Me.Date_of_pre_SOS_trainingDateTimePicker.Location = New System.Drawing.Point(269, 301)
        Me.Date_of_pre_SOS_trainingDateTimePicker.Name = "Date_of_pre_SOS_trainingDateTimePicker"
        Me.Date_of_pre_SOS_trainingDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_of_pre_SOS_trainingDateTimePicker.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(114, 386)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "prev"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(248, 385)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "next"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(364, 386)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "edit "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'regionsearchresult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 444)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Date_of_pre_SOS_trainingLabel)
        Me.Controls.Add(Me.Date_of_pre_SOS_trainingDateTimePicker)
        Me.Controls.Add(Date_of_inaugrationLabel)
        Me.Controls.Add(Me.Date_of_inaugrationDateTimePicker)
        Me.Controls.Add(CatagoryLabel)
        Me.Controls.Add(Me.CatagoryTextBox)
        Me.Controls.Add(RegionLabel)
        Me.Controls.Add(Me.RegionTextBox)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Dealer_CodeLabel)
        Me.Controls.Add(Me.Dealer_CodeTextBox)
        Me.Controls.Add(Me.Namesearch_QueryBindingNavigator)
        Me.Name = "regionsearchresult"
        Me.Text = "Form2"
        CType(Me.StorageDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Namesearch_QueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Namesearch_QueryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Namesearch_QueryBindingNavigator.ResumeLayout(False)
        Me.Namesearch_QueryBindingNavigator.PerformLayout()
        CType(Me.Dealer1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StorageDataSet As NTMS2.storageDataSet
    Friend WithEvents Namesearch_QueryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Namesearch_QueryTableAdapter As NTMS2.storageDataSetTableAdapters.namesearch_QueryTableAdapter
    Friend WithEvents TableAdapterManager As NTMS2.storageDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Namesearch_QueryBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Namesearch_QueryBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Dealer1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dealer1TableAdapter As NTMS2.storageDataSetTableAdapters.dealer1TableAdapter
    Friend WithEvents Dealer_CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RegionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CatagoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_of_inaugrationDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Date_of_pre_SOS_trainingDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
