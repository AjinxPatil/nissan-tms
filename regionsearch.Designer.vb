<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class regionsearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(regionsearch))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.StorageDataSet = New NTMS2.storageDataSet()
        Me.NamesearchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NamesearchTableAdapter = New NTMS2.storageDataSetTableAdapters.namesearchTableAdapter()
        Me.TableAdapterManager = New NTMS2.storageDataSetTableAdapters.TableAdapterManager()
        Me.NamesearchBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.NamesearchBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Dealer_Query1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dealer_Query1TableAdapter = New NTMS2.storageDataSetTableAdapters.dealer_Query1TableAdapter()
        Me.Dealer_Query2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dealer_Query2TableAdapter = New NTMS2.storageDataSetTableAdapters.dealer_Query2TableAdapter()
        Me.Dealer_Query3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dealer_Query3TableAdapter = New NTMS2.storageDataSetTableAdapters.dealer_Query3TableAdapter()
        Me.Dealer_Query4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dealer_Query4TableAdapter = New NTMS2.storageDataSetTableAdapters.dealer_Query4TableAdapter()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Namesearch_QueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Namesearch_QueryTableAdapter = New NTMS2.storageDataSetTableAdapters.namesearch_QueryTableAdapter()
        CType(Me.StorageDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamesearchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamesearchBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NamesearchBindingNavigator.SuspendLayout()
        CType(Me.Dealer_Query1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dealer_Query2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dealer_Query3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dealer_Query4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Namesearch_QueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 43)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "North"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(28, 173)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 50)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "East"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(310, 37)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(71, 43)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "South"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(310, 173)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(71, 45)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "West"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.Dealer_Query1BindingSource
        Me.ComboBox1.DisplayMember = "Name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(117, 51)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(105, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.Dealer_Query2BindingSource
        Me.ComboBox2.DisplayMember = "Name"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(414, 37)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(117, 21)
        Me.ComboBox2.TabIndex = 5
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.Dealer_Query3BindingSource
        Me.ComboBox3.DisplayMember = "Name"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(117, 197)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(111, 21)
        Me.ComboBox3.TabIndex = 6
        '
        'ComboBox4
        '
        Me.ComboBox4.DataSource = Me.Dealer_Query4BindingSource
        Me.ComboBox4.DisplayMember = "Name"
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(414, 191)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(106, 21)
        Me.ComboBox4.TabIndex = 7
        '
        'StorageDataSet
        '
        Me.StorageDataSet.DataSetName = "storageDataSet"
        Me.StorageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NamesearchBindingSource
        '
        Me.NamesearchBindingSource.DataMember = "namesearch"
        Me.NamesearchBindingSource.DataSource = Me.StorageDataSet
        '
        'NamesearchTableAdapter
        '
        Me.NamesearchTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dealer_dataTableAdapter = Nothing
        Me.TableAdapterManager.dealer1TableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.namesearchTableAdapter = Me.NamesearchTableAdapter
        Me.TableAdapterManager.productTableAdapter = Nothing
        Me.TableAdapterManager.testTableAdapter = Nothing
        Me.TableAdapterManager.training_dateTableAdapter = Nothing
        Me.TableAdapterManager.training_statusTableAdapter = Nothing
        Me.TableAdapterManager.tTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NTMS2.storageDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NamesearchBindingNavigator
        '
        Me.NamesearchBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.NamesearchBindingNavigator.BindingSource = Me.NamesearchBindingSource
        Me.NamesearchBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.NamesearchBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.NamesearchBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.NamesearchBindingNavigatorSaveItem})
        Me.NamesearchBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.NamesearchBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.NamesearchBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.NamesearchBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.NamesearchBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.NamesearchBindingNavigator.Name = "NamesearchBindingNavigator"
        Me.NamesearchBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.NamesearchBindingNavigator.Size = New System.Drawing.Size(569, 25)
        Me.NamesearchBindingNavigator.TabIndex = 8
        Me.NamesearchBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'NamesearchBindingNavigatorSaveItem
        '
        Me.NamesearchBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NamesearchBindingNavigatorSaveItem.Image = CType(resources.GetObject("NamesearchBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.NamesearchBindingNavigatorSaveItem.Name = "NamesearchBindingNavigatorSaveItem"
        Me.NamesearchBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.NamesearchBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Dealer_Query1BindingSource
        '
        Me.Dealer_Query1BindingSource.DataMember = "dealer Query1"
        Me.Dealer_Query1BindingSource.DataSource = Me.StorageDataSet
        '
        'Dealer_Query1TableAdapter
        '
        Me.Dealer_Query1TableAdapter.ClearBeforeFill = True
        '
        'Dealer_Query2BindingSource
        '
        Me.Dealer_Query2BindingSource.DataMember = "dealer Query2"
        Me.Dealer_Query2BindingSource.DataSource = Me.StorageDataSet
        '
        'Dealer_Query2TableAdapter
        '
        Me.Dealer_Query2TableAdapter.ClearBeforeFill = True
        '
        'Dealer_Query3BindingSource
        '
        Me.Dealer_Query3BindingSource.DataMember = "dealer Query3"
        Me.Dealer_Query3BindingSource.DataSource = Me.StorageDataSet
        '
        'Dealer_Query3TableAdapter
        '
        Me.Dealer_Query3TableAdapter.ClearBeforeFill = True
        '
        'Dealer_Query4BindingSource
        '
        Me.Dealer_Query4BindingSource.DataMember = "dealer Query4"
        Me.Dealer_Query4BindingSource.DataSource = Me.StorageDataSet
        '
        'Dealer_Query4TableAdapter
        '
        Me.Dealer_Query4TableAdapter.ClearBeforeFill = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(168, 301)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(174, 38)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Search"
        Me.Button5.UseVisualStyleBackColor = True
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 379)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.NamesearchBindingNavigator)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "form1"
        CType(Me.StorageDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamesearchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamesearchBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NamesearchBindingNavigator.ResumeLayout(False)
        Me.NamesearchBindingNavigator.PerformLayout()
        CType(Me.Dealer_Query1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dealer_Query2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dealer_Query3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dealer_Query4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Namesearch_QueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents StorageDataSet As NTMS2.storageDataSet
    Friend WithEvents NamesearchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NamesearchTableAdapter As NTMS2.storageDataSetTableAdapters.namesearchTableAdapter
    Friend WithEvents TableAdapterManager As NTMS2.storageDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NamesearchBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents NamesearchBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Dealer_Query1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dealer_Query1TableAdapter As NTMS2.storageDataSetTableAdapters.dealer_Query1TableAdapter
    Friend WithEvents Dealer_Query2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dealer_Query2TableAdapter As NTMS2.storageDataSetTableAdapters.dealer_Query2TableAdapter
    Friend WithEvents Dealer_Query3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dealer_Query3TableAdapter As NTMS2.storageDataSetTableAdapters.dealer_Query3TableAdapter
    Friend WithEvents Dealer_Query4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dealer_Query4TableAdapter As NTMS2.storageDataSetTableAdapters.dealer_Query4TableAdapter
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Namesearch_QueryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Namesearch_QueryTableAdapter As NTMS2.storageDataSetTableAdapters.namesearch_QueryTableAdapter
End Class
