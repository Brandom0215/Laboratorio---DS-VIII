Public Class Menu

    Private Sub ButtonOpenModule_Click(sender As Object, e As EventArgs) Handles ButtonOpenModule.Click
        Form1.Show()
        Form1.BringToFront()
        Me.Hide()
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

End Class
