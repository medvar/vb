Public Class Form1
    Private Sub BnIngresar_Click(sender As Object, e As EventArgs) Handles BnIngresar.Click

        Dim usuario As String
        Dim contrase1, contrase2, contrase3 As String
        Dim msg1, tipo As String
        msg1 = ""
        tipo = ""

        contrase1 = "CED"
        contrase2 = "Progra2019"
        contrase3 = "2002"

        Dim ContraseIngresada As String
        ContraseIngresada = LCase(TxbContraseña.Text)
        usuario = TxbUsuario.Text

        If LCase(contrase1) = ContraseIngresada Then
            msg1 = "Bienvenido " + usuario
        ElseIf LCase(contrase2) = ContraseIngresada Then
            msg1 = "Bienvenido " + usuario
        ElseIf LCase(contrase3) = ContraseIngresada Then
            msg1 = "Bienvenido " + usuario
        Else
            msg1 = "Contraseña incorrecta"
            tipo = "ERROR"
        End If

        MessageBox.Show(UCase(msg1),
                           tipo,
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Exclamation)
    End Sub
End Class
