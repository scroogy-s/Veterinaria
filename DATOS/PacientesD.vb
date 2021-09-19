Imports System.Data.SqlClient

Public Class PacientesD
    Private ReadOnly Property devolverConexion() As String
        Get
            Return My.Settings.conexion
        End Get
    End Property

    Public Sub Insertar(nombre As String, raza As Integer, sexo As Boolean, fecha_nac As Date, fecha_alta As Date, fecha_ult_visita As Date, microchip As String, foto As Byte(), idcliente As Integer)
        Dim conexion As New SqlConnection(devolverConexion)
        Dim comando As New SqlCommand

        comando.Connection = conexion
        comando.CommandText = "INSERT INTO Pacientes VALUES (@nombre, @raza, @sexo, @fecha_nac, @fecha_alta, @fecha_ult_visita, @microchip, @foto, @idcliente)"
        comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre
        comando.Parameters.Add("@raza", SqlDbType.Int).Value = raza
        comando.Parameters.Add("@sexo", SqlDbType.Bit).Value = sexo
        comando.Parameters.Add("@fecha_nac", SqlDbType.Date).Value = fecha_nac
        comando.Parameters.Add("@fecha_alta", SqlDbType.Date).Value = fecha_alta
        comando.Parameters.Add("@fecha_ult_visita", SqlDbType.Date).Value = fecha_ult_visita
        comando.Parameters.Add("@microchip", SqlDbType.VarChar).Value = microchip
        comando.Parameters.Add("@foto", SqlDbType.Image).Value = foto
        comando.Parameters.Add("@idcliente", SqlDbType.Int).Value = idcliente
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()

    End Sub

    Public Function Mostrar_Razas_Especies(id As Integer) As DataTable
        Dim consulta As String = "SELECT nombre, idRaza FROM Razas WHERE idEspecie = " & id.ToString
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Function Mostrar_Especies() As DataTable
        Dim consulta As String = "SELECT * FROM Especies"
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Function Devolver_Proximo_Codigo() As String
        Dim consulta As String = "Select Case WHEN MAX(idPaciente) Is NULL THEN 1 WHEN MAX(idPaciente) Is Not NULL THEN MAX(idPaciente) + 1 END FROM Pacientes"
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos.Rows(0)(0).ToString
    End Function

    Public Function Mostrar_Pacientes() As DataTable
        Dim consulta As String = "SELECT * FROM Vista_Pacientes"
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Function Mostrar_PacientesxCliente(id As Integer) As DataTable
        Dim consulta As String = "SELECT * FROM Vista_Pacientes WHERE idCliente = " + id.ToString
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Sub Eliminar_PacientexCliente(id As Integer)
        Dim conexion As New SqlConnection(devolverConexion)
        Dim comando As New SqlCommand
        comando.Connection = conexion

        comando.CommandText = "DELETE FROM Pacientes WHERE idCliente = " + id.ToString

        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Function Ficha_Pacientes(id As Integer) As DataTable
        Dim consulta As String = "SELECT P.*, E.idEspecie FROM Pacientes P INNER JOIN Razas R ON R.idRaza = P.idRaza 
                                                                          INNER JOIN Especies E ON E.idEspecie = R.idEspecie 
                                                                          WHERE idPaciente = " + id.ToString
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Sub Actualizar_Paciente(id As Integer, nombre As String, raza As Integer, sexo As Boolean, fecha_nac As Date, microchip As String)
        Dim conexion As New SqlConnection(devolverConexion)
        Dim comando As New SqlCommand

        comando.Connection = conexion
        comando.CommandText = "UPDATE Pacientes SET nombre = @nombre, idRaza = @raza, sexo = @sexo, fechaNacimiento = @fecha_nac,
                               microchip = @microchip WHERE idPaciente = " + id.ToString
        comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre
        comando.Parameters.Add("@raza", SqlDbType.Int).Value = raza
        comando.Parameters.Add("@sexo", SqlDbType.Bit).Value = sexo
        comando.Parameters.Add("@fecha_nac", SqlDbType.Date).Value = fecha_nac
        comando.Parameters.Add("@microchip", SqlDbType.VarChar).Value = microchip

        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Sub Eliminar_Paciente(id As Integer)
        Dim conexion As New SqlConnection(devolverConexion)
        Dim comando As New SqlCommand
        comando.Connection = conexion

        comando.CommandText = "DELETE FROM Pacientes WHERE idPaciente = " + id.ToString

        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Function Busq_Paciente_id(parametro As String) As DataTable
        Dim consulta As String = "SELECT * FROM Vista_Pacientes WHERE idPaciente = " & parametro
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Function Busq_Paciente_Nombre(parametro As String) As DataTable
        Dim consulta As String = "SELECT * FROM Vista_Pacientes WHERE Nombre like '" & parametro & "%' "
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Function Busq_Paciente_Especie(parametro As String) As DataTable
        Dim consulta As String = "SELECT * FROM Vista_Pacientes WHERE Especie like '" & parametro & "%' "
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Function Busq_Paciente_Raza(parametro As String) As DataTable
        Dim consulta As String = "SELECT * FROM Vista_Pacientes WHERE Raza like '" & parametro & "%' "
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Function Busq_Paciente_Sexo(parametro As String) As DataTable
        Dim consulta As String = "SELECT * FROM Vista_Pacientes WHERE Sexo like '" & parametro & "%' "
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Function Busq_Paciente_Microchip(parametro As String) As DataTable
        Dim consulta As String = "SELECT * FROM Vista_Pacientes WHERE microchip like '" & parametro & "%' "
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Function Busq_Paciente_FechaNac(parametro As String) As DataTable
        Dim consulta As String = "SELECT * FROM Vista_Pacientes WHERE [Fecha de Nac.] like '" & parametro & "%' "
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

End Class
