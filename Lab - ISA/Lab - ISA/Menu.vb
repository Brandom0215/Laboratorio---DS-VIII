''' <summary>
''' Formulario de Menú Principal para la navegación hacia los módulos del sistema.
''' </summary>
Public Class Menu

    ''' <summary>
    ''' Muestra el formulario principal (Form1) y oculta el menú actual.
    ''' </summary>
    Private Sub ButtonOpenModule_Click(sender As Object, e As EventArgs) Handles ButtonOpenModule.Click
        Try
            My.Forms.Form1.Show()
            My.Forms.Form1.BringToFront()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("No se pudo abrir el módulo principal: " & ex.Message,
                            "Error de Navegación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Cierra el formulario del menú principal.
    ''' </summary>
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Try
            Me.Close()
        Catch ex As Exception
            Application.Exit()
        End Try
    End Sub

End Class
