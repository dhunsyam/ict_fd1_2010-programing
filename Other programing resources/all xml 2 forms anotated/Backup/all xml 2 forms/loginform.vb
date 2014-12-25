Public Class loginform


    Private Sub BLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLogin.Click

        ' this is the main form which opens an executing the application
        ' if the use uses "owner" as the login code then the "ownform" (i.e. ownerform) is displayed
        ' otherwise the "custform" (i.e. customerform) is displayed

        If TPassword.Text = "owner" Then

            'creates an instance of "ownerform"
            Dim ownform As New ownerform()
            ' this displays the form
            ownform.Show()
        Else
            'see above
            Dim custform As New customerform()
            'see above
            custform.Show()
        End If


    End Sub

    Private Sub BLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLogout.Click

        ' this closes the "loginform" - "Me" refers to itself
        ' and closes the application

        Me.Close()
        Application.Exit()

    End Sub
End Class
