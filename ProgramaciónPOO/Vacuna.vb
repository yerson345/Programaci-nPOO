Public Class Vacuna : Inherits Pet

    Private id As String
    Private nombreVacuna As Long
    Private fechaVacuna As String

    Public Sub New(id As String, nombreVacuna As Long, fechaVacuna As String)
        Me.id = id
        Me.nombreVacuna = nombreVacuna
        Me.fechaVacuna = fechaVacuna
    End Sub

    Public Property Id1 As String
        Get
            Return id
        End Get
        Set(value As String)
            id = value
        End Set
    End Property

    Public Property NombreVacuna1 As Long
        Get
            Return nombreVacuna
        End Get
        Set(value As Long)
            nombreVacuna = value
        End Set
    End Property

    Public Property FechaVacuna1 As String
        Get
            Return fechaVacuna
        End Get
        Set(value As String)
            fechaVacuna = value
        End Set
    End Property
End Class
