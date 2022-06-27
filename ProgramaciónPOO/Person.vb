Public Class Person
    Private name As String
    Private lastName As String
    Private document As Long
    Private celPhone As String

    Public Sub New(name As String, lastName As String, document As Long, celPhone As String)
        Me.name = name
        Me.lastName = lastName
        Me.document = document
        Me.celPhone = celPhone
    End Sub

    Public Sub New()
        name = ""
        lastName = ""
        document = 0
        celPhone = ""
    End Sub

    Public Property name1 As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property LastName1 As String
        Get
            Return lastName
        End Get
        Set(value As String)
            lastName = value
        End Set
    End Property

    Public Property Document1 As Long
        Get
            Return document
        End Get
        Set(value As Long)
            document = value
        End Set
    End Property

    Public Property CelPhone1 As String
        Get
            Return celPhone
        End Get
        Set(value As String)
            celPhone = value
        End Set
    End Property


End Class
