Public Class ViewModel
    Public Property Data As List(Of Person)

    Public Sub New()
        Data = New List(Of Person)() From {
            New Person With {
                .Name = "David",
                .Height = 180
            },
            New Person With {
                .Name = "Michael",
                .Height = 170
            },
            New Person With {
                .Name = "Steve",
                .Height = 160
            },
            New Person With {
                .Name = "Joel",
                .Height = 182
            }
        }
    End Sub

End Class