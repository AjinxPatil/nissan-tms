Public Class EmpEntry2
    Dim id1 As Integer
    Dim i, n As Integer
    Private Sub EmpEntry2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        id1 = EmpEntry1.id0
        Label1.Text = "Enter Training and Tests details for employee " + EmpEntry1.name0
        Me.Training_statusTableAdapter.InsertQuery(id1)
        Me.Training_dateTableAdapter.InsertQuery(id1)
        Me.TestTableAdapter.InsertQuery(id1)
        Me.Training_dateTableAdapter.FillBy(Me.StorageDataSet.training_date, id1)
        Me.Training_statusTableAdapter.FillBy(Me.StorageDataSet.training_status, id1)
        Me.TestTableAdapter.FillBy(Me.StorageDataSet.test, id1)


    End Sub

    Private Sub OKButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton1.Click
        Me.Training_statusTableAdapter.Update(Me.StorageDataSet)
        Me.Training_dateTableAdapter.Update(Me.StorageDataSet)
        Me.TestTableAdapter.Update(Me.StorageDataSet)
        
        EmpEntry1.Close()
        Me.Close()
    End Sub

    Private Sub BackButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton1.Click
        EmpEntry1.Show()
        Me.Hide()
    End Sub
End Class