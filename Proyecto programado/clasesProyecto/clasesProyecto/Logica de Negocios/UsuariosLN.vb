Public Class UsuariosLN
    Public Sub InsertarUsuarios(ByVal pUsuarios As UsuariosEN)


    End Sub

    Public Sub ModificarUsuarios(ByVal pUsuarios As UsuariosEN)

    End Sub

    Public Sub BorrarUsuarios(ByVal pUsuarios As UsuariosEN)

    End Sub

    Function ObtenerUsuariosPorlogin(ByVal pUsuarios As UsuariosEN) As UsuariosEN
        Dim myUsuarios As UsuariosEN = Nothing

        Return myUsuarios
    End Function

    Public Function obtenerTodosUsuarios() As List(Of UsuariosEN)
        Dim lsLista As List(Of UsuariosEN)

        Return lsLista
    End Function
End Class
