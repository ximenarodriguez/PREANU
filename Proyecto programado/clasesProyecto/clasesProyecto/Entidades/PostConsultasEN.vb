Public Class PostConsultasEN

#Region "atributos "

    Public Property strID As String
    Public Property strDiag_Nutricional As String
    Public Property strAsistencia As Integer
    Public Property strLugar_Referencia As String
    Public Property strTipo_Consulta As String
    Public Property dblCosto_Consulta As Double
    Public Property strNum_Recibo As String
    Public Property strNombre_Resposable As String
    Public Property strNombre_Estudiante As String


#End Region

#Region "Constructor de la clase"

    ''' <summary>
    ''' Constructor Nulo de la clase
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        strID = String.Empty
        strDiag_Nutricional = String.Empty
        strAsistencia = String.Empty
        strLugar_Referencia = String.Empty
        strTipo_Consulta = String.Empty
        dblCosto_Consulta = 0
        strNum_Recibo = String.Empty
        strNombre_Resposable = String.Empty
        strNombre_Estudiante = String.Empty


    End Sub


    Public Sub New(ByVal pID As String, ByVal pDiag_Nutricional As String, ByVal pAsistencia As String, ByVal pLugar_Referencia As String, ByVal pTipo_Consulta As String,
                   ByVal pCosto_Consulta As Double, ByVal pNum_Recibo As String, ByVal pNombre_Resposable As String, ByVal pNombre_Estudiante As String)

        strID = pID
        strDiag_Nutricional = pDiag_Nutricional
        strAsistencia = pAsistencia
        strLugar_Referencia = pLugar_Referencia
        strTipo_Consulta = pTipo_Consulta
        dblCosto_Consulta = pCosto_Consulta
        strNum_Recibo = pNum_Recibo
        strNombre_Resposable = pNombre_Resposable
        strNombre_Estudiante = pNombre_Estudiante

    End Sub

#End Region

#Region "Metodos de la clase"

    ''' <summary>
    ''' Despliegue de datos de la postcita
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String

        Dim strDatos As String = String.Empty

        strDatos = "Id post consulta: " & strID & vbCrLf &
                    "Diagnostico Nutricional: " & strDiag_Nutricional & vbCrLf &
                    "Asistencia: " & strAsistencia & vbCrLf &
                    "Lugar Referencia: " & strLugar_Referencia & vbCrLf &
                    "Tipo Consulta: " & strTipo_Consulta & vbCrLf &
                    "Costo: " & dblCosto_Consulta & vbCrLf &
                    "Nombre Recibo: " & strNum_Recibo & vbCrLf &
                    "Nombre Responsable: " & strNombre_Resposable & vbCrLf &
                    "Nombre " & strNombre_Estudiante & vbCrLf


        Return strDatos

    End Function

#End Region
End Class
