Public Class Cliente : Inherits Person

    Private name As String
    Private lastName As String
    Private document As Long
    Private celPhone As String
    Private mascota As String

    Public Sub New(name As String, lastName As String, document As Long, celPhone As String, mascota As String)
        Me.name = name
        Me.lastName = lastName
        Me.document = document
        Me.celPhone = celPhone
        Me.mascota = mascota
    End Sub

    Public Property Name2 As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property LastName2 As String
        Get
            Return lastName
        End Get
        Set(value As String)
            lastName = value
        End Set
    End Property

    Public Property Document2 As Long
        Get
            Return document
        End Get
        Set(value As Long)
            document = value
        End Set
    End Property

    Public Property CelPhone2 As String
        Get
            Return celPhone
        End Get
        Set(value As String)
            celPhone = value
        End Set
    End Property

    Public Property Mascota1 As String
        Get
            Return mascota
        End Get
        Set(value As String)
            mascota = value
        End Set
    End Property
End Class
