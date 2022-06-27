Public Class Pet

    Private idPet As String
    Private namePet As String
    Private breed As String
    Private personPet As String

    Public Sub New(idPet As String, namePet As String, breed As String, personPet As String)
        Me.idPet = idPet
        Me.namePet = namePet
        Me.breed = breed
        Me.personPet = personPet
    End Sub

    Public Property IdPet1 As String
        Get
            Return idPet
        End Get
        Set(value As String)
            idPet = value
        End Set
    End Property

    Public Property NamePet1 As String
        Get
            Return namePet
        End Get
        Set(value As String)
            namePet = value
        End Set
    End Property

    Public Property Breed1 As String
        Get
            Return breed
        End Get
        Set(value As String)
            breed = value
        End Set
    End Property

    Public Property PersonPet1 As String
        Get
            Return personPet
        End Get
        Set(value As String)
            personPet = value
        End Set
    End Property

    Public Function register() As Boolean
        Console.WriteLine("Pet Sucellfull")
        Return True
    End Function
End Class
