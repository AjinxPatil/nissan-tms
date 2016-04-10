Public Class LoginForm1
    Dim usr0, usr1, usr2 As String
    Dim pass As String
    Dim access As Boolean
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        access = False
        usr0 = "AjinxParesh"
        usr1 = "rahulsaini"
        usr2 = "ericsumitra"
        pass = "dealerconference"

    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If UsernameTextBox.Text = usr0 Or usr1 Or usr2 Then
            If PasswordTextBox.Text = pass Then
                access = True
            End If
        End If
        If access = True Then
            Me.Close()
        Else
            Windows.Forms.




        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


End Class
