Imports System.Data.SqlClient

Public Class AntiparasitariosD
    Private ReadOnly Property devolverConexion() As String
        Get
            Return My.Settings.conexion
        End Get
    End Property

    Public Sub Insertar(nombre_atp As String)
        Dim conexion As New SqlConnection(devolverConexion)
        Dim comando As New SqlCommand

        comando.Connection = conexion
        comando.CommandText = "INSERT INTO ATP VALUES (@nombre_atp)"
        comando.Parameters.Add("@nombre_atp", SqlDbType.VarChar).Value = nombre_atp

        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()

    End Sub

    Public Sub Eliminar(id As Integer)
        Dim Conexion As New SqlConnection(devolverConexion)
        Dim Comando As New SqlCommand

        Comando.Connection = Conexion
        Comando.CommandText = "DELETE FROM ATP WHERE idATP = " & id & ""

        Conexion.Open()
        Comando.ExecuteNonQuery()
        Conexion.Close()

    End Sub

    Public Function mostrartodosATP() As DataTable
        Dim consulta As String = "SELECT * FROM ATP"
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

End Class
