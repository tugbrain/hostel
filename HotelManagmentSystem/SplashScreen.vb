Public Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 3000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Dim loginForm As New LoginForm()
        loginForm.Show()
        Me.Hide()
    End Sub
End Class