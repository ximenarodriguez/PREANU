Public Class ServivioGrupalLN

    Public Sub InsertarServicioGrupal(ByVal pSevicioIndividual As ServicioGrupalEN)


    End Sub

    Public Sub ModificarServicioGrupal(ByVal pServicioIndividual As ServicioIndividualEN)

    End Sub

    Public Sub BorrarServicioGrupal(ByVal pSServicioGrupal As ServicioIndividualEN)

    End Sub

    Function ObtenerServicioGrupalPorIDServicio(ByVal pServicioGrupal As String) As ServicioIndividualEN
        Dim myServicioIndividual As ServicioIndividualEN = Nothing

        Return myServicioIndividual
    End Function

    Public Function obtenerTodosServicioGrupal() As List(Of ServicioGrupalEN)
        Dim lsLista As List(Of ServicioGrupalEN)

        Return lsLista
    End Function

End Class
