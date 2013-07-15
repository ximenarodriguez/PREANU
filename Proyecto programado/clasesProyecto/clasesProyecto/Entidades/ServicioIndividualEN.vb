Public Class ServicioIndividualEN

#Region "atributos "

    Public Property intNum_Servicio As Integer
    Public Property strNombre_Servicio As String

#End Region

#Region "Constructor de la clase"

    ''' <summary>
    ''' Constructor Nulo de la clase
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        intNum_Servicio = 0
        strNombre_Servicio = String.Empty


    End Sub

    ''' <summary>
    ''' Constructor con parametros
    ''' </summary>
    ''' <param name="pNum_Servicio">ID Servicio</param>
    ''' <param name="strNombre_Servicio">Nombre del Servicio</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal pNum_Servicio As Integer, ByVal strNombre_Servicio As String)

        intNum_Servicio = pNum_Servicio
        strNombre_Servicio = strNombre_Servicio
    End Sub

#End Region

#Region "Metodos de la clase"

    ''' <summary>
    ''' Despliegue de datos del Servicio
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String

        Dim strDatos As String = String.Empty

        strDatos = "Id Servicio: " & intNum_Servicio & vbCrLf &
                    "Nombre del Servicio: " & strNombre_Servicio & vbCrLf

        Return strDatos

    End Function

#End Region
End Class
