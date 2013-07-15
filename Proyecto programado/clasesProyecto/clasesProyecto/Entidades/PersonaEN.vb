Public Class PersonaEN

#Region "atributos de la clase"


    Public Property ID As String
    Public Property NombreCompleto As String
    
#End Region

#Region "Constructor de la clase"

    ''' <summary>
    ''' Constructor Nulo de la clase
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        ID = String.Empty
        NombreCompleto = String.Empty
        
    End Sub


    ''' <summary>
    ''' Constructor con todos los atributos de la persona
    ''' </summary>
    ''' <param name="pCedula">Cedula </param>
    ''' <param name="pNombre">Nombre completo</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal pCedula As String, ByVal pNombre As String, ByVal )

        ID = pCedula
        NombreCompleto = pNombre
    End Sub

#End Region



End Class
