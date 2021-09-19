Imports System.Data.SqlClient

Public Class Vacunaciones_ATPsD

    Private ReadOnly Property devolverConexion() As String
        Get
            Return My.Settings.conexion
        End Get
    End Property

    Public Function Mostrar_Vacunaciones_ATPs(id As Integer) As DataTable
        Dim consulta As String = "SELECT * FROM Vacunas_ATP WHERE idPaciente = " & id
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Sub Insertar_Vacunacion(idpaciente As Integer, idvacuna As Integer, marcaserie As String, fecha_vac As Date)
        Dim conexion As New SqlConnection(devolverConexion)
        Dim comando As New SqlCommand

        comando.Connection = conexion
        comando.CommandText = "INSERT INTO Vacunaciones VALUES (@idpaciente, @idvacuna, @marcaserie, @fecha_vac)"
        comando.Parameters.Add("@idpaciente", SqlDbType.Int).Value = idpaciente
        comando.Parameters.Add("@idvacuna", SqlDbType.Int).Value = idvacuna
        comando.Parameters.Add("@marcaserie", SqlDbType.VarChar).Value = marcaserie
        comando.Parameters.Add("@fecha_vac", SqlDbType.Date).Value = fecha_vac
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()

    End Sub

    Public Sub Insertar_Vacunacion_Pendiente(idpaciente As Integer, idvacuna As Integer, fecha_prox_vac As Date)
        Dim conexion As New SqlConnection(devolverConexion)
        Dim comando As New SqlCommand

        comando.Connection = conexion
        comando.CommandText = "INSERT INTO VacunacionesPendientes VALUES (@idpaciente, @idvacuna, @fecha_prox_vac, ident_current('Vacunaciones'))"
        comando.Parameters.Add("@idpaciente", SqlDbType.Int).Value = idpaciente
        comando.Parameters.Add("@idvacuna", SqlDbType.Int).Value = idvacuna
        comando.Parameters.Add("@fecha_prox_vac", SqlDbType.Date).Value = fecha_prox_vac
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()

    End Sub

    Public Sub Insertar_Desparacitacion(idpaciente As Integer, idatp As Integer, marcaserie As String, fecha_atp As Date)
        Dim conexion As New SqlConnection(devolverConexion)
        Dim comando As New SqlCommand

        comando.Connection = conexion
        comando.CommandText = "INSERT INTO Desparacitaciones VALUES (@idpaciente, @idatp, @marcaserie, @fecha_atp)"
        comando.Parameters.Add("@idpaciente", SqlDbType.Int).Value = idpaciente
        comando.Parameters.Add("@idatp", SqlDbType.Int).Value = idatp
        comando.Parameters.Add("@marcaserie", SqlDbType.VarChar).Value = marcaserie
        comando.Parameters.Add("@fecha_atp", SqlDbType.Date).Value = fecha_atp
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()

    End Sub

    Public Sub Insertar_Desparasitacion_Pendiente(idpaciente As Integer, idatp As Integer, fecha_prox_atp As Date)
        Dim conexion As New SqlConnection(devolverConexion)
        Dim comando As New SqlCommand

        comando.Connection = conexion
        comando.CommandText = "INSERT INTO DesparacitacionesPendientes VALUES (@idpaciente, @idatp, @fecha_prox_atp, ident_current('Desparacitaciones'))"
        comando.Parameters.Add("@idpaciente", SqlDbType.Int).Value = idpaciente
        comando.Parameters.Add("@idatp", SqlDbType.Int).Value = idatp
        comando.Parameters.Add("@fecha_prox_atp", SqlDbType.Date).Value = fecha_prox_atp
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()

    End Sub

End Class
