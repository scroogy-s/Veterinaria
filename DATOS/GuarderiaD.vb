Imports System.Data.SqlClient
Imports System.Globalization

Public Class GuarderiaD

    Private ReadOnly Property devolverConexion() As String
        Get
            Return My.Settings.conexion
        End Get
    End Property

    Public Sub Insertar(idpaciente As Integer, fecha_ingreso As Date, fecha_egreso As Date, costodiario As String, seña As String,
                        incluyesalida As Boolean, alimento As String, notas As String)
        Dim conexion As New SqlConnection(devolverConexion)
        Dim comando As New SqlCommand

        comando.Connection = conexion
        comando.CommandText = "INSERT INTO Guarderia VALUES (@idpaciente, @fecha_ingreso, @fecha_egreso, @costodiario, @seña, @incluyesalida,
                                @alimento, @notas, 0)"
        comando.Parameters.Add("@idpaciente", SqlDbType.Int).Value = idpaciente
        comando.Parameters.Add("@fecha_ingreso", SqlDbType.Date).Value = fecha_ingreso
        comando.Parameters.Add("@fecha_egreso", SqlDbType.Date).Value = fecha_egreso
        comando.Parameters.Add("@costodiario", SqlDbType.VarChar).Value = costodiario
        comando.Parameters.Add("@seña", SqlDbType.VarChar).Value = seña
        comando.Parameters.Add("@incluyesalida", SqlDbType.Bit).Value = incluyesalida
        comando.Parameters.Add("@alimento", SqlDbType.VarChar).Value = alimento
        comando.Parameters.Add("@notas", SqlDbType.VarChar).Value = notas
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()

    End Sub

    Public Function Mostrar_Guarderia() As DataTable
        Dim consulta As String = "SELECT * FROM vista_Guarderia"
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Function Traer_Datos_Ingresado(id As Integer) As DataTable
        Dim consulta As String = "SELECT G.fechaIngreso, C.apellidoNombre, P.nombre, G.costoDiario, G.fechaEgreso, G.incluyeSalida, G.seña
                                    FROM Guarderia G
                                    INNER JOIN Pacientes P ON P.idPaciente = G.idPaciente
                                    INNER JOIN Clientes C ON C.idCliente = P.idCliente WHERE G.idGuarderia =" & id
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Sub Actualizar_Estado(id As Integer)
        Dim conexion As New SqlConnection(devolverConexion)
        Dim comando As New SqlCommand

        comando.Connection = conexion
        comando.CommandText = "UPDATE Guarderia SET estado = 1 WHERE idGuarderia = " + id.ToString

        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Function Historial_Guarderia(desde As Date, hasta As Date) As DataTable
        Dim ingreso As String = desde.Date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
        Dim salida As String = hasta.Date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
        Dim consulta As String = "SELECT * FROM Historial_Guarderia WHERE Ingreso >= '" & ingreso & "' and Salida <= '" & salida & "'"
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Function Traer_Detalles_Guarderia(id As Integer) As DataTable
        Dim consulta As String = "SELECT C.apellidoNombre, C.direccion, C.celular, P.nombre, P.Especie, P.Raza, P.Sexo, P.[Fecha de Nac.], G.fechaIngreso, G.costoDiario, G.fechaEgreso, G.incluyeSalida, G.seña, G.alimento, G.notas
                                    FROM Guarderia G
                                    INNER JOIN Vista_Pacientes P ON P.idPaciente = G.idPaciente
                                    INNER JOIN Clientes C ON C.idCliente = P.idCliente WHERE G.idGuarderia =" & id
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Sub Actualizar_Detalles(id As Integer, fechaingreso As Date, fechaegreso As Date, alimento As String, notas As String)
        Dim conexion As New SqlConnection(devolverConexion)
        Dim comando As New SqlCommand

        comando.Connection = conexion
        comando.CommandText = "UPDATE Guarderia SET fechaIngreso = '" & fechaingreso & "', fechaEgreso = '" & fechaegreso & "',
                                alimento = '" & alimento & "', notas = '" & notas & "'
                                WHERE idGuarderia = " + id.ToString

        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Function Traer_Eliminacion(id As Integer) As DataTable
        Dim consulta As String = "SELECT G.fechaIngreso, C.apellidoNombre, P.nombre
                                    FROM Guarderia G
                                    INNER JOIN Pacientes P ON P.idPaciente = G.idPaciente
                                    INNER JOIN Clientes C ON C.idCliente = P.idCliente WHERE G.idGuarderia =" & id
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Sub Eliminar_Registro_Guarderia(id As Integer)
        Dim conexion As New SqlConnection(devolverConexion)
        Dim comando As New SqlCommand
        comando.Connection = conexion

        comando.CommandText = "DELETE FROM Guarderia WHERE idGuarderia = " + id.ToString

        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

End Class
