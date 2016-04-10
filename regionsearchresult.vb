
Public Class regionsearchresult
    Public inc As Integer
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StorageDataSet.dealer1' table. You can move, or remove it, as needed.
        Me.Dealer1TableAdapter.Fill(Me.StorageDataSet.dealer1)
        'TODO: This line of code loads data into the 'StorageDataSet.namesearch_Query' table. You can move, or remove it, as needed.
        Me.Namesearch_QueryTableAdapter.Fill(Me.StorageDataSet.namesearch_Query)
        inc = 0
        Call display()
    End Sub
    Private Sub display()
        Dealer_CodeTextBox.Text = Me.StorageDataSet.namesearch_Query(inc)._Dealer_Code
        NameTextBox.Text = Me.StorageDataSet.namesearch_Query(inc).Name
        LocationTextBox.Text = Me.StorageDataSet.namesearch_Query(inc).Location
        RegionTextBox.Text = Me.StorageDataSet.namesearch_Query(inc)._Region
        CatagoryTextBox.Text = Me.StorageDataSet.namesearch_Query(inc).catagory
        Date_of_inaugrationDateTimePicker.Text = Me.StorageDataSet.namesearch_Query(inc).Date_of_inaugration
        Date_of_pre_SOS_trainingDateTimePicker.Text = Me.StorageDataSet.namesearch_Query(inc).Date_of_pre_SOS_training
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        inc = inc - 1
        Try
            Dim ch As Boolean
            ch = Me.StorageDataSet.namesearch_Query(inc).HasErrors
        Catch ex As Exception
            inc = inc + 1


        End Try
        Call display()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        inc = inc + 1
        Try
            Dim ch As Boolean
            ch = Me.StorageDataSet.namesearch_Query(inc).HasErrors
        Catch ex As Exception
            inc = inc - 1


        End Try
        Call display()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        editdealer.ShowDialog()


    End Sub
End Class