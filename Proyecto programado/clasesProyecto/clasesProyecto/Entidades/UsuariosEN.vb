Public Class UsuariosEN

#Region "Propiedades"

    Public Property strLogin As String
    Public Property strNombre As String
    Public Property strContraseña As String
    Public Property strPerfil As String

#End Region


#Region "Constructores de la clase"
    ''' <summary>
    ''' constructor nulo
    ''' </summary>
    ''' <remarks></remarks>

    Public Sub New()
        strLogin = String.Empty
        strNombre = String.Empty
        strContraseña = String.Empty
        strPerfil = False

    End Sub

    ''' <summary>
    ''' Constructor con paremetros
    ''' </summary>
    ''' <param name="pLoginID">ID del usuario</param>
    ''' <param name="pNombre">Nombre del usaurio</param>
    ''' <param name="pClave">Contraseña del usuario</param>
    ''' <param name="pPerfil">Perfil del usuario</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal pLoginID As String, ByVal pNombre As String, ByVal pClave As String, ByVal pPerfil As String)
        strLogin = pLoginID
        strNombre = pNombre
        strContraseña = pClave
        strPerfil = pPerfil
    End Sub
#End Region

End Class
