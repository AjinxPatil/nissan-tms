
Public Class editdealer
    Public inc1 As Integer



    Private Sub Dealer1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dealer1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Dealer1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StorageDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inc1 = regionsearchresult.inc
        'TODO: This line of code loads data into the 'StorageDataSet.dealerdataQuery' table. You can move, or remove it, as needed.
        Me.DealerdataQueryTableAdapter.Fill(Me.StorageDataSet.dealerdataQuery)
        'TODO: This line of code loads data into the 'StorageDataSet.dealer1' table. You can move, or remove it, as needed.
        Me.Dealer1TableAdapter.Fill(Me.StorageDataSet.dealer1)
        Label2.Text = Me.StorageDataSet.dealer1(inc1)._Dealer_Code
        Label3.Text = Me.StorageDataSet.dealer1(inc1).Name
        Label4.Text = Me.StorageDataSet.dealer1(inc1).Location
        Label6.Text = Me.StorageDataSet.dealer1(inc1)._Region
        Label7.Text = Me.StorageDataSet.dealer1(inc1).catagory
        Label8.Text = Me.StorageDataSet.dealer1(inc1).Date_of_inaugration
        Label9.Text = Me.StorageDataSet.dealer1(inc1).Date_of_pre_SOS_training

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.StorageDataSet.dealer1(0)._Dealer_Code = Dealer_CodeTextBox.Text
        Me.StorageDataSet.dealer1(0).Name = NameTextBox.Text
        Me.StorageDataSet.dealer1(0).Location = LocationTextBox.Text
        Me.StorageDataSet.dealer1(0)._Region = RegionTextBox.Text
        Me.StorageDataSet.dealer1(0).catagory = CatagoryTextBox.Text
        Me.StorageDataSet.dealer1(0).Date_of_inaugration = Date_of_inaugrationDateTimePicker.Text
        Me.StorageDataSet.dealer1(0).Date_of_pre_SOS_training = Date_of_pre_SOS_trainingDateTimePicker.Text
        Try
            Me.Validate()
            Me.Dealer1BindingSource.EndEdit()
            Me.Dealer1TableAdapter.Update(Me.StorageDataSet.dealer1)
            MsgBox("Update successful")
            Dealer_CodeTextBox.Text = ""

            NameTextBox.Text = ""

            LocationTextBox.Text = ""
            RegionTextBox.Text = ""
            CatagoryTextBox.Text = ""
            Date_of_inaugrationDateTimePicker.Text = ""
            Date_of_pre_SOS_trainingDateTimePicker.Text = ""


        Catch ex As Exception
            MsgBox("Update failed")
            Me.Close()
        End Try
    End Sub
End Class