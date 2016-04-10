Public Class EmpEdit
    Dim id As Integer
    Private Sub EmpEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StorageDataSet.product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.StorageDataSet.product)
        ''TODO: This line of code loads data into the 'StorageDataSet.test' table. You can move, or remove it, as needed.
        'Me.TestTableAdapter.Fill(Me.StorageDataSet.test)
        ''TODO: This line of code loads data into the 'StorageDataSet.training_date' table. You can move, or remove it, as needed.
        'Me.Training_dateTableAdapter.Fill(Me.StorageDataSet.training_date)
        ''TODO: This line of code loads data into the 'StorageDataSet.training_status' table. You can move, or remove it, as needed.
        'Me.Training_statusTableAdapter.Fill(Me.StorageDataSet.training_status)
        id = EmpDis.id0
        Me.Training_statusTableAdapter.FillBy(Me.StorageDataSet.training_status, id)
        Me.Training_dateTableAdapter.FillBy(Me.StorageDataSet.training_date, id)
        Me.TestTableAdapter.FillBy(Me.StorageDataSet.test, id)
        Me.EmployeeTableAdapter.FillByID(Me.StorageDataSet.employee, id)
        NameLabel2.Text = Me.StorageDataSet.employee(0)._Employee_Name
        DesignationLabel2.Text = Me.StorageDataSet.employee(0).Designation
        ProductLabel2.Text = Me.StorageDataSet.employee(0).Product
        DOJLabel2.Text = Me.StorageDataSet.employee(0)._Date_of_Joining
        DOLLabel2.Text = Me.StorageDataSet.employee(0)._Date_of_Leaving
        DCLabel2.Text = Me.StorageDataSet.employee(0)._Dealer_Code

    End Sub

    Private Sub UpdateButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton1.Click
        Me.StorageDataSet.employee(0)._Employee_Name = NameTextBox.Text
        Me.StorageDataSet.employee(0).Designation = DesignationComboBox.Text
        Me.StorageDataSet.employee(0).Product = ProductComboBox.Text
        Me.StorageDataSet.employee(0)._Date_of_Joining = DOJPicker.Text
        If DOLCheck.Checked = True Then
            Me.StorageDataSet.employee(0)._Date_of_Leaving = DOLPicker.Text
        End If
        Me.StorageDataSet.employee(0)._Dealer_Code = DealerComboBox.Text
        Me.EmployeeTableAdapter.Update(Me.StorageDataSet.employee)
        Me.Training_statusTableAdapter.Update(Me.StorageDataSet.training_status)
        Me.Training_dateTableAdapter.Update(Me.StorageDataSet.training_date)
        Me.TestTableAdapter.Update(Me.StorageDataSet.test)
        Me.Close()

    End Sub

    Private Sub CancelButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton1.Click
        Me.Close()
    End Sub
End Class