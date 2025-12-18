Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then

            Return
        End If

        ' Default credentials - Change these in production!
        If username.ToLower() = "admin" AndAlso password = "admin123" Then

            ' Show main form
            Dim mainForm As New MainForm()
            mainForm.Show()
            Me.Hide()
        Else
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = Char.MinValue
        Else
            txtPassword.PasswordChar = "•"c
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnLogin.PerformClick()
        End If
    End Sub
End Class