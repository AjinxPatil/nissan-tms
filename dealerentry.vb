Public Class dealerentry

    Private Sub Dealer1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dealer1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Dealer1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StorageDataSet)

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StorageDataSet.dealer1' table. You can move, or remove it, as needed.
        Me.Dealer1TableAdapter.Fill(Me.StorageDataSet.dealer1)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim name, location, region, cat, doi, dos As String
        Dim code As Integer
        code = Dealer_CodeTextBox.Text
        name = NameTextBox.Text
        location = ComboBox1.Text
        region = ComboBox2.Text
        cat = ComboBox3.Text
        doi = Date_of_inaugrationDateTimePicker.Text
        dos = Date_of_pre_SOS_trainingDateTimePicker.Text
        Me.Dealer1TableAdapter.InsertQuery(code, name, location, region, cat, doi, dos)
        Try
            Me.Validate()
            Me.Dealer1BindingSource.EndEdit()
            Me.Dealer1TableAdapter.Update(Me.StorageDataSet.dealer1)
            MsgBox("Update successful")
            Dealer_CodeTextBox.Text = ""

            NameTextBox.Text = ""

            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
            Date_of_inaugrationDateTimePicker.Text = ""
            Date_of_pre_SOS_trainingDateTimePicker.Text = ""


        Catch ex As Exception
            MsgBox("Update failed")
            Me.Close()
        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        regionsearch.Show()
    End Sub
End Class