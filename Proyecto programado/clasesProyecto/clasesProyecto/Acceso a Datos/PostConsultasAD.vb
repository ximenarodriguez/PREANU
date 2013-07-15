Public Class PostConsultasAD
    Public Sub InsertarPostCopnsulta(ByVal pPostConsultas As PostConsultasEN)


    End Sub

    Public Sub ModificarPostConsultas(ByVal pPostConsultas As PostConsultasEN)

    End Sub

    Public Sub BorrarPostConsultas(ByVal pPostConsultas As PostConsultasEN)

    End Sub

    Function ObtenerPostConsultasPorID(ByVal pServicioGrupal As String) As PostConsultasEN
        Dim myPostConsultas As PostConsultasEN = Nothing

        Return myPostConsultas
    End Function

    Public Function obtenerTodasPostConsultas() As List(Of PostConsultasEN)
        Dim lsLista As List(Of PostConsultasEN)

        Return lsLista
    End Function
End Class
