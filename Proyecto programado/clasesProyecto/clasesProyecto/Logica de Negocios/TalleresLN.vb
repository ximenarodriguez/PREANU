Public Class TalleresLN
    Public Sub InsertarTalleres(ByVal pTalleres As TalleresEN)


    End Sub

    Public Sub ModificarTalleres(ByVal pTalleres As TalleresEN)

    End Sub

    Public Sub BorrarTalleres(ByVal pTalleres As TalleresEN)

    End Sub

    Function ObtenerTalleresPorIDTaller(ByVal pTalleres As String) As TalleresEN
        Dim myTalleres As TalleresEN = Nothing

        Return myTalleres
    End Function

    Public Function obtenerTodosTalleres() As List(Of TalleresEN)
        Dim lsLista As List(Of TalleresEN)

        Return lsLista
    End Function
End Class
