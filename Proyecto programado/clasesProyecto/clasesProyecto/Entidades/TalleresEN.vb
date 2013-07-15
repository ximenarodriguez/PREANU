Public Class TalleresEN

#Region "atributos "

    Public Property intNum_Taller As Integer
    Public Property intCapacidad As Integer
    Public Property strNombre_Taller As String
    Public Property intNum_Sesiones As Integer

#End Region

#Region "Constructor de la clase"

    ''' <summary>
    ''' Constructor Nulo de la clase
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        intNum_Taller = 0
        intCapacidad = 0
        strNombre_Taller = String.Empty
        intNum_Sesiones = 0

    End Sub

    ''' <summary>
    ''' Construcor con parametros
    ''' </summary>
    ''' <param name="pNum_Taller">ID del taller</param>
    ''' <param name="pCapacidad">Capacidad de pacientes</param>
    ''' <param name="pNombre_Taller">Nombre del taller</param>
    ''' <param name="pNum_Sesiones">Numero de Seciones</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal pNum_Taller As Integer, ByVal pCapacidad As Integer, ByVal pNombre_Taller As String, ByVal pNum_Sesiones As Integer)

        intNum_Taller = pNum_Taller
        intCapacidad = pCapacidad
        strNombre_Taller = pNombre_Taller
        intNum_Sesiones = pNum_Sesiones
    End Sub

#End Region

#Region "Metodos de la clase"

    ''' <summary>
    ''' Despliegue de datos de los talleres
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String

        Dim strDatos As String = String.Empty

        strDatos = "Id Taller: " & intNum_Taller & vbCrLf &
                    "Capacidad de pacientes: " & intCapacidad & vbCrLf &
                    "Nombre del taller: " & strNombre_Taller & vbCrLf

        Return strDatos

    End Function

#End Region
End Class
