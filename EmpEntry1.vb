Imports System.Data.OleDb
Public Class EmpEntry1
    Dim con, sql As String
    Dim connection As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    'Public Variables
    Public id0 As Integer
    Public name0 As String
    Public designation0 As String
    Public Product0 As String
    Public DOJ0 As String
    Public DOL0 As String
    Public DC0 As String

    Private Sub EmpEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StorageDataSet.product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(StorageDataSet.product)
        Me.EmployeeTableAdapter.Fill(StorageDataSet.employee)
        'con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\storage.accdb"
        'connection = New OleDbConnection(con)
        'ds = New DataSet
        'sql = "SELECT * FROM employee"
        'da = New OleDbDataAdapter(sql, con)
        'da.Fill(ds, "Employee")
    End Sub

    Private Sub NextButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextButton1.Click
        Dim id, count As Integer
        count = Me.EmployeeTableAdapter.Count()
        Dim employeeRow As storageDataSet.employeeRow


        'count = ds.Tables("Employee").Rows.Count
        If count = 0 Then
            id = 1
        Else
            employeeRow = StorageDataSet.employee.FindByID(count - 1)
            id = employeeRow.ID + 2
            'id = StorageDataSet.employee(count - 1).ID + 1
        End If
        Dim name, des, prod, dol, doj As String
        Dim dc As Integer
        name = NameTextBox.Text
        des = DesignationComboBox.Text
        prod = ProductComboBox.Text
        doj = DOJPicker.Text
        If DOLCheck.Checked Then
            dol = DOLPicker.Text
        End If
        dc = DealerComboBox.Text
        Me.EmployeeTableAdapter.EmpInsertQuery(id, name, des, prod, doj, dol, dc)
        name0 = name
        id0 = id
        Try
            Me.Validate()
            Me.EmployeeBindingSource.EndEdit()
            Me.EmployeeTableAdapter.Update(Me.StorageDataSet.employee)
            MsgBox("Update successful")
            EmpEntry2.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Update failed")
            Me.Close()
        End Try

        

    End Sub


    Private Sub CancelButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton1.Click
        EmpEntry2.Close()
        Me.Close()
    End Sub

   
    Private Sub ProductComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductComboBox.SelectedIndexChanged

    End Sub
End Class
