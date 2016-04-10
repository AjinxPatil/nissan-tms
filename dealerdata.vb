Public Class dealerdata

    Private Sub Dealer_dataBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dealer_dataBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Dealer_dataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StorageDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StorageDataSet.dealer_data' table. You can move, or remove it, as needed.
        Me.Dealer_dataTableAdapter.Fill(Me.StorageDataSet.dealer_data)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim code As Integer
        code = TextBox1.Text
        Me.Dealer_dataTableAdapter.InsertQuery(code)
        Try
            Me.Validate()
            Me.Dealer_dataBindingSource.EndEdit()
            Me.Dealer_dataTableAdapter.Update(Me.StorageDataSet.dealer_data)
            MsgBox("Update successful")
            empstatus.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Update failed")
            Me.Close()
        End Try



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim inc As Integer
        Me.StorageDataSet.dealer_data.Rows(inc).Delete()
        Me.Dealer_dataTableAdapter.Update(Me.StorageDataSet.dealer_data)
        TextBox1.Text = ""

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        empstatus.Show()
        Me.Hide()

    End Sub
End Class