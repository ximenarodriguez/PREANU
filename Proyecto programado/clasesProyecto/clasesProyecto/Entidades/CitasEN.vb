Public Class CitasEN

#Region "atributos "

    Public Property strID As String
    Public Property strTipo_Cita As String
    Public Property dtFecha As Date
    Public Property strHora As String
    Public Property intNum_Consultorio As Integer
    Public Property strNombre_Servicio As String
    Public Property strRazon_Consulta As String
    Public Property strTipo_Consulta As String

#End Region

#Region "Constructor de la clase"

    ''' <summary>
    ''' Constructor Nulo de la clase
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        IDCita = String.Empty
        TipoCita = String.Empty
        FechaCita = CType("01/01/1000", Date)
        HoraCita = 0
        NumeroConsultorio = String.Empty
        NombreServicio = String.Empty
        RazonConsulta = String.Empty
        TipoConsulta = String.Empty
    End Sub

    ''' <summary>
    ''' Constructo con parametros
    ''' </summary>
    ''' <param name="pIDCita">Numero Identificaion de citas</param>
    ''' <param name="pTipoCita">Tipo de cita</param>
    ''' <param name="pFechaCita">Fecha de la cita</param>
    ''' <param name="pHoraCita">Hora de la cita</param>
    ''' <param name="pNumneroConsultorio">Numero del consutorio</param>
    ''' <param name="pNombreServicio">Nombre del Servicio</param>
    ''' <param name="pRazonConsulta">Razon de la Consultas</param>
    ''' <param name="pTipoConsulta">Tipo de consulta</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal pIDCita As String, ByVal pTipoCita As String, ByVal pFechaCita As Date, ByVal pHoraCita As String, ByVal pNumneroConsultorio As String,
                   ByVal pNombreServicio As String, ByVal pRazonConsulta As String, ByVal pTipoConsulta As String)

        strID = pIDCita
        strTipo_Cita = pTipoCita
        dtFecha = pFechaCita
        strHora = pHoraCita
        intNum_Consultorio = pNumneroConsultorio
        strNombre_Servicio = pNombreServicio
        strRazon_Consulta = pRazonConsulta
        strTipo_Consulta = pTipoCita

    End Sub

#End Region

#Region "Metodos de la clase"

    ''' <summary>
    ''' Despliegue de datos de la cita
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String

        Dim strDatos As String = String.Empty

        strDatos = "Id cita: " & strID & vbCrLf &
                    "Tipo Cita: " & strTipo_Cita & vbCrLf &
                    "Fecha de cita: " & dtFecha & vbCrLf &
                    "Horas cita: " & strHora & vbCrLf &
                    "Numero del consutorio: " & intNum_Consultorio & vbCrLf &
                    "Nombre Servicio: " & strNombre_Servicio & vbCrLf &
                    "Razon Consulta: " & strRazon_Consulta & vbCrLf &
                    "Tipo consulta: " & strTipo_Consulta & vbCrLf


        Return strDatos

    End Function

#End Region


End Class
