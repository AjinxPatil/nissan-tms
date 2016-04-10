Imports System.Data.OleDb

Public Class EmpDis
    Dim search As String
    Dim inc, id As Integer
    Public id0 As Integer

    Private Sub EmpDis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inc = 0
        Call FieldStatusChange(False)

    End Sub

    Private Sub SearchButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchButton1.Click
        search = String.Concat("%", SearchTextBox1.Text, "%")
        Me.EmployeeTableAdapter.FillByName(Me.StorageDataSet.employee, search)
        inc = 0
        Call Display()

    End Sub

    Private Sub Display()
        id = Me.StorageDataSet.employee(inc).ID
        NameLabel1.Text = Me.StorageDataSet.employee(inc)._Employee_Name
        DesignationLabel1.Text = Me.StorageDataSet.employee(inc).Designation
        ProductLabel1.Text = Me.StorageDataSet.employee(inc).Product
        DCLabel1.Text = Me.StorageDataSet.employee(inc)._Dealer_Code
        'Coding for untyped dataset is as follows:
        'id = ds.Tables("EmployeeByName").Rows(inc).Item(0)
        'NameLabel1.Text = ds.Tables("EmployeeByName").Rows(inc).Item(1)
        'DesignationLabel1.Text = ds.Tables("EmployeeByName").Rows(inc).Item(2)
        'ProductLabel1.Text = ds.Tables("EmployeeByName").Rows(inc).Item(3)
        'DOJLabel1.Text = ds.Tables("EmployeeByName").Rows(inc).Item(4)
        'DOLLabel1.Text = ds.Tables("EmployeeByName").Rows(inc).Item(5)
        'DCLabel1.Text = ds.Tables("EmployeeByName").Rows(inc).Item(6)
        CountLabel1.Text = id
        Call FieldStatusChange(True)
        Me.Training_statusTableAdapter.FillBy(Me.StorageDataSet.training_status, id)
        Me.Training_dateTableAdapter.FillBy(Me.StorageDataSet.training_date, id)
        Me.TestTableAdapter.FillBy(Me.StorageDataSet.test, id)

    End Sub

    Private Sub FieldStatusChange(ByVal vis As Boolean)
        TrainingStatusGridView1.Visible = vis
        TrainingDateGridView1.Visible = vis
        TestGridView1.Visible = vis
        NextButton1.Enabled = vis
        PrevButton1.Enabled = vis
        EditButton1.Enabled = vis
        Panel1.Visible = vis

    End Sub

    Private Sub NextButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextButton1.Click
        inc = inc + 1
        Try
            Dim check As Boolean
            check = Me.StorageDataSet.employee(inc).HasErrors
        Catch e1 As Exception
            inc = inc - 1
        End Try
        Call Display()

    End Sub

    Private Sub PrevButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrevButton1.Click
        inc = inc - 1
        Try
            Dim check As Boolean
            check = Me.StorageDataSet.employee(inc).HasErrors
        Catch e1 As Exception
            inc = inc + 1
        End Try
        Call Display()

    End Sub

    Private Sub DeleteButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton1.Click
        Me.StorageDataSet.employee.Rows(inc).Delete()
        Me.EmployeeTableAdapter.Update(Me.StorageDataSet.employee)
        SearchTextBox1.Text = ""
        Call FieldStatusChange(False)

    End Sub

    Private Sub EditButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton1.Click
        SearchTextBox1.Text = ""
        id0 = id
        EmpEdit.ShowDialog()
        Call FieldStatusChange(False)


    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class