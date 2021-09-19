Imports System.Data.SqlClient

Public Class VacunasD
    Private ReadOnly Property devolverConexion() As String
        Get
            Return My.Settings.conexion
        End Get
    End Property

    Public Sub Insertar(nombre_vacuna As String, descripcion_vacuna As String)
        Dim conexion As New SqlConnection(devolverConexion)
        Dim comando As New SqlCommand

        comando.Connection = conexion
        'Comando.CommandText = "INSERT INTO Vacunas VALUES ('" & nombre_vacuna & "', '" & descripcion_vacuna & "')"
        comando.CommandText = "INSERT INTO Vacunas VALUES (@nombre_vacuna, @descripcion_vacuna)"
        comando.Parameters.Add("@nombre_vacuna", SqlDbType.VarChar).Value = nombre_vacuna
        comando.Parameters.Add("@descripcion_vacuna", SqlDbType.VarChar).Value = descripcion_vacuna

        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Sub Eliminar(id As Integer)
        Dim Conexion As New SqlConnection(devolverConexion)
        Dim Comando As New SqlCommand

        Comando.Connection = Conexion
        Comando.CommandText = "DELETE FROM Vacunas WHERE idVacuna = " & id & ""

        Conexion.Open()
        Comando.ExecuteNonQuery()
        Conexion.Close()
    End Sub

    Public Function mostrarVacunas() As DataTable
        Dim consulta As String = "SELECT * FROM Vacunas"
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

End Class
