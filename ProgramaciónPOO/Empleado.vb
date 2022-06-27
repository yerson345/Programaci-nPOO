Public Class Empleado : Inherits Person


    Private name As String
    Private lastName As String
    Private document As Long
    Private celPhone As String
    Private cargo As String
    Private tarProfesion As String

    Public Sub New(name As String, lastName As String, document As Long, celPhone As String, cargo As String, tarProfesion As String)
        Me.name = name
        Me.lastName = lastName
        Me.document = document
        Me.celPhone = celPhone
        Me.cargo = cargo
        Me.tarProfesion = tarProfesion
    End Sub

    Public Property Name1 As String
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

    Public Property Cargo1 As String
        Get
            Return cargo
        End Get
        Set(value As String)
            cargo = value
        End Set
    End Property

    Public Property TarProfesion1 As String
        Get
            Return tarProfesion
        End Get
        Set(value As String)
            tarProfesion = value
        End Set
    End Property
End Class
