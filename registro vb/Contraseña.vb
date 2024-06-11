
Namespace registro_de_trabajador
    Friend Class Contraseña
        Private digitosField As String

        Public Sub New(digitos As String)
            digitosField = digitos
        End Sub

        Public ReadOnly Property Digitos As String
            Get
                Return digitosField
            End Get
        End Property

        Public Function Verificar(digitosingresados As String) As Boolean
            Return Equals(digitosField, digitosingresados)
        End Function
    End Class
End Namespace
