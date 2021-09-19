Imports System.Data.SqlClient

Public Class VeterinariosD

    Private ReadOnly Property devolverConexion() As String
        Get
            Return My.Settings.conexion
        End Get
    End Property

    Public Sub Insertar(nombre_veterinario As String, matricula As String)
        Dim conexion As New SqlConnection(devolverConexion)
        Dim comando As New SqlCommand

        comando.Connection = conexion
        comando.CommandText = "INSERT INTO Veterinarios VALUES (@nombre_veterinario, @matricula)"
        comando.Parameters.Add("@nombre_veterinario", SqlDbType.VarChar).Value = nombre_veterinario
        comando.Parameters.Add("@matricula", SqlDbType.VarChar).Value = matricula

        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Function mostrarVeterinarios() As DataTable
        Dim consulta As String = "SELECT * FROM Veterinarios"
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

End Class
