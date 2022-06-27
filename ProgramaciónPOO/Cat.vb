Public Class Cat : Inherits Pet
    Private numberLifes As Integer


    Public Sub New(idPet As String, namePet As String, breed As String, personPet As String, numberLifes As Integer)
        MyBase.New(idPet, namePet, breed, personPet)
        Me.numberLifes = numberLifes
    End Sub

    Public Property NumberLifes1 As Integer
        Get
            Return numberLifes
        End Get
        Set(value As Integer)
            numberLifes = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class
