Public Class SevicioIndividualLN
    Public Sub InsertarSevicioIndividual(ByVal pSevicioIndividual As ServicioIndividualEN)


    End Sub

    Public Sub ModificarServicioIndividual(ByVal pServicioIndividual As ServicioIndividualEN)

    End Sub

    Public Sub BorrarServicioIndividual(ByVal pServicioIndividual As ServicioIndividualEN)

    End Sub

    Function ObtenerServicioIndividualPorIDServicio(ByVal pServicioIndividual As String) As ServicioIndividualEN
        Dim myServicioIndividual As ServicioIndividualEN = Nothing

        Return myServicioIndividual
    End Function

    Public Function obtenerTodosServicioIndividual() As List(Of ServicioIndividualEN)
        Dim lsLista As List(Of ServicioIndividualEN)

        Return lsLista
    End Function

End Class
