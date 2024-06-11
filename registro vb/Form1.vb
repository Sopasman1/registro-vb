
Namespace registro_de_trabajador
    Public Partial Class Form1
        Inherits System.Windows.Forms.Form
        Private contrase As registro_de_trabajador.Contraseña
        Public Sub New()
            InitializeComponent()
            contrase = New registro_de_trabajador.Contraseña("15052618")
        End Sub


        Private Sub Enterbtn_Click(sender As Object, e As EventArgs)
            Dim ventana As registro_de_trabajador.Registro = New registro_de_trabajador.Registro()

            Dim contraseñaingresada = passwordtbox.Text

            If contrase.Verificar(contraseñaingresada) Then
                ventana.Show()
                Hide()
                System.Windows.Forms.MessageBox.Show("Password is rigth")
            Else
                System.Windows.Forms.MessageBox.Show("Password is wrong")
            End If

        End Sub

        Private Sub passwordtbox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If Char.IsLetter(e.KeyChar) Then
                e.Handled = True
            End If
        End Sub


    End Class
End Namespace
