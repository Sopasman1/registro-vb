
Namespace registro_de_trabajador
    Friend Class Datos_de_persona
        Private nombreField As String

        Public Property Nombre As String
            Get
                Return nombreField
            End Get
            Set(value As String)
                nombreField = value
            End Set
        End Property

        Private apellidoPaternoField As String

        Public Property ApellidoPaterno As String
            Get
                Return apellidoPaternoField
            End Get
            Set(value As String)
                apellidoPaternoField = value
            End Set
        End Property

        Private apellidomaternoField As String

        Public Property Apellidomaterno As String
            Get
                Return apellidomaternoField
            End Get
            Set(value As String)
                apellidomaternoField = value
            End Set
        End Property

        Private cumpleField As Date

        Public Property Cumple As Date
            Get
                Return cumpleField
            End Get
            Set(value As Date)
                cumpleField = value
            End Set
        End Property

        Private edadField As String

        Public Property Edad As String
            Get
                Return edadField
            End Get
            Set(value As String)
                edadField = value
            End Set
        End Property

        Public Sub New()
            edadField = ""
            apellidoPaternoField = ""
            apellidomaternoField = ""
            cumpleField = Date.MinValue
        End Sub

        Public Overrides Function ToString() As String
            Return nombreField.ToString() & apellidoPaternoField.ToString() & apellidomaternoField.ToString() & cumpleField.ToString() & edadField.ToString()
        End Function
    End Class
End Namespace
