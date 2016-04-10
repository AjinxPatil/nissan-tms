Public Class regionsearch
    Public nam As String
    Private Sub NamesearchBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NamesearchBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.NamesearchBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StorageDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StorageDataSet.namesearch_Query' table. You can move, or remove it, as needed.
        Me.Namesearch_QueryTableAdapter.Fill(Me.StorageDataSet.namesearch_Query)
        'TODO: This line of code loads data into the 'StorageDataSet.dealer_Query4' table. You can move, or remove it, as needed.
        Me.Dealer_Query4TableAdapter.Fill(Me.StorageDataSet.dealer_Query4)
        'TODO: This line of code loads data into the 'StorageDataSet.dealer_Query3' table. You can move, or remove it, as needed.
        Me.Dealer_Query3TableAdapter.Fill(Me.StorageDataSet.dealer_Query3)
        'TODO: This line of code loads data into the 'StorageDataSet.dealer_Query2' table. You can move, or remove it, as needed.
        Me.Dealer_Query2TableAdapter.Fill(Me.StorageDataSet.dealer_Query2)
        'TODO: This line of code loads data into the 'StorageDataSet.dealer_Query1' table. You can move, or remove it, as needed.
        Me.Dealer_Query1TableAdapter.Fill(Me.StorageDataSet.dealer_Query1)
        'TODO: This line of code loads data into the 'StorageDataSet.namesearch' table. You can move, or remove it, as needed.
        Me.NamesearchTableAdapter.Fill(Me.StorageDataSet.namesearch)
        ComboBox1.Visible = False
        ComboBox2.Visible = False
        ComboBox3.Visible = False
        ComboBox4.Visible = False



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ComboBox1.Visible = True
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        nam = ComboBox1.Text

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ComboBox2.Visible = True
        Button1.Visible = False
        Button2.Visible = False
        Button4.Visible = False
        nam = ComboBox2.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ComboBox3.Visible = True
        Button1.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        nam = ComboBox3.Text
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ComboBox4.Visible = True
        Button2.Visible = False
        Button3.Visible = False
        Button1.Visible = False
        nam = ComboBox4.Text
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.NamesearchTableAdapter.InsertQuery(nam)
        regionsearchresult.Show()
        Me.Hide()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class