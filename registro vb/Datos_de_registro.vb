
Namespace registro_de_trabajador
    Friend Class Datos_de_registro
        Private curpField As String

        Public Property Curp As String
            Get
                Return curpField
            End Get
            Set(value As String)
                curpField = value
            End Set
        End Property

        Private rfcField As String

        Public Property Rfc As String
            Get
                Return rfcField
            End Get
            Set(value As String)
                rfcField = value
            End Set
        End Property

        Private correoField As String

        Public Property Correo As String
            Get
                Return correoField
            End Get
            Set(value As String)
                correoField = value
            End Set
        End Property

        Private phoneField As String

        Public Property Phone As String
            Get
                Return phoneField
            End Get
            Set(value As String)
                phoneField = value
            End Set
        End Property

        Public Sub Datosderegistro(curp As String, rfc As String, correo As String, phone As String)
            curpField = curp
            rfcField = rfc
            correoField = correo
            phoneField = phone
        End Sub
    End Class
End Namespace
