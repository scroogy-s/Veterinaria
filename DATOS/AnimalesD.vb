Imports System.Data.SqlClient

Public Class AnimalesD
    Private ReadOnly Property devolverConexion() As String
        Get
            Return My.Settings.conexion
        End Get
    End Property

    Public Sub Insertar(nombre_raza As String, id_especie As Integer)
        Dim conexion As New SqlConnection(devolverConexion)
        Dim comando As New SqlCommand

        comando.Connection = conexion
        comando.CommandText = "INSERT INTO Razas VALUES (@nombre_raza, @id_especie)"
        comando.Parameters.Add("@nombre_raza", SqlDbType.VarChar).Value = nombre_raza
        comando.Parameters.Add("@id_especie", SqlDbType.Int).Value = id_especie
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Sub Eliminar(id As Integer)
        Dim Conexion As New SqlConnection(devolverConexion)
        Dim Comando As New SqlCommand

        Comando.Connection = Conexion
        Comando.CommandText = "DELETE FROM Razas WHERE idRaza = " & id & ""

        Conexion.Open()
        Comando.ExecuteNonQuery()
        Conexion.Close()
    End Sub

    Public Function Mostrar() As DataTable
        Dim consulta As String = "SELECT * FROM Raza_Especie"
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Function cmb_Especies() As DataTable
        Dim consulta As String = "SELECT * FROM Especies"
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

End Class
