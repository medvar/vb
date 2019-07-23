Public Class Form1
    Private Sub BnIngresar_Click(sender As Object, e As EventArgs) Handles BnIngresar.Click
        Dim usuario As String
        Dim contrase1, contrase2, contrase3 As String
        contrase1 = "CED"
        contrase2 = "Progra2019"
        contrase3 = "2002"

        Dim ContraseIngresada As String
        ContraseIngresada = LCase(TxbContraseña.Text)
        usuario = TxbUsuario.Text

        If LCase(contrase1) = ContraseIngresada Then
            Dim msg1 As String = "Bienvenido " + usuario

            MessageBox.Show(UCase(msg1),
                            "BIENVENIDO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

        ElseIf LCase(contrase2) = ContraseIngresada Then
            Dim msg1 As String = "Bienvenido " + usuario

            MessageBox.Show(UCase(msg1),
                            "BIENVENIDO ",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

        ElseIf LCase(contrase3) = ContraseIngresada Then
            Dim msg1 As String = "Bienvenido " + usuario

            MessageBox.Show(UCase(msg1),
                            "BIENVENIDO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

        Else
            Dim msg1 As String = "Contraseña incorrecta"

            MessageBox.Show(UCase(msg1),
                            "ERROR",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class
