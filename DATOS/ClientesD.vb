Imports System.Data.SqlClient

Public Class ClientesD
    Private ReadOnly Property devolverConexion() As String
        Get
            Return My.Settings.conexion
        End Get
    End Property

    Public Sub Insertar(nombre As String, direccion As String, celular As String, empresa_cel As String, localidad As Integer, fecha_alta As Date, fecha_ult_visita As Date, email As String, foto As Byte())
        Dim conexion As New SqlConnection(devolverConexion)
        Dim comando As New SqlCommand

        comando.Connection = conexion
        comando.CommandText = "INSERT INTO Clientes VALUES (@nombre, @direccion, @celular, @empresa_cel, @localidad, @fecha_alta, @fecha_ult_visita, @email, @foto)"
        comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre
        comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = direccion
        comando.Parameters.Add("@celular", SqlDbType.VarChar).Value = celular
        comando.Parameters.Add("@empresa_cel", SqlDbType.VarChar).Value = empresa_cel
        comando.Parameters.Add("@localidad", SqlDbType.Int).Value = localidad
        comando.Parameters.Add("@fecha_alta", SqlDbType.Date).Value = fecha_alta
        comando.Parameters.Add("@fecha_ult_visita", SqlDbType.Date).Value = fecha_ult_visita
        comando.Parameters.Add("@email", SqlDbType.VarChar).Value = email
        comando.Parameters.Add("@foto", SqlDbType.Image).Value = foto
        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()

    End Sub

    Public Function Mostrar_Clientes() As DataTable
        Dim consulta As String = "SELECT * FROM Vista_Clientes"
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Function Mostrar_Provincias() As DataTable
        Dim consulta As String = "SELECT * FROM Provincia"
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Function Mostrar_Localidades_Provincias(id As Integer) As DataTable
        Dim consulta As String = "SELECT idLocalidad, nombre FROM Localidad WHERE idProvincia = " & id & ""
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Function Devolver_CP(id As Integer) As String
        Dim consulta As String = "SELECT codigoPostal FROM Localidad WHERE idLocalidad = " & id & ""
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos.Rows(0)(0).ToString
    End Function

    'Public Sub Eliminar(id As Integer)
    '    Dim Conexion As New SqlConnection(devolverConexion)
    '    Dim Comando As New SqlCommand

    '    Comando.Connection = Conexion
    '    Comando.CommandText = "DELETE FROM Clientes WHERE idCliente = " & id & ""
    '    Conexion.Open()
    '    Comando.ExecuteNonQuery()
    '    Conexion.Close()
    'End Sub

    Public Function Devolver_Proximo_Codigo() As String
        Dim consulta As String = "Select Case WHEN MAX(idCliente) Is NULL THEN 1 WHEN MAX(idCliente) Is Not NULL THEN MAX(idCliente) + 1 END FROM Clientes"
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos.Rows(0)(0).ToString
    End Function

    Public Function Busq_Clientes_Nombre(parametro As String) As DataTable
        Dim consulta As String = "SELECT * FROM Vista_Clientes WHERE Cliente like '" & parametro & "%' "
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Function Busq_Clientes_Direccion(parametro As String) As DataTable
        Dim consulta As String = "SELECT * FROM Vista_Clientes WHERE Direccion like '" & parametro & "%' "
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Function Busq_Clientes_Celular(parametro As String) As DataTable
        Dim consulta As String = "SELECT * FROM Vista_Clientes WHERE Celular like '" & parametro & "%' "
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Function Busq_Clientes_Localidad(parametro As String) As DataTable
        Dim consulta As String = "SELECT * FROM Vista_Clientes WHERE Localidad like '" & parametro & "%' "
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Function Busq_Clientes_Provincia(parametro As String) As DataTable
        Dim consulta As String = "SELECT * FROM Vista_Clientes WHERE Provincia like '" & parametro & "%' "
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Function Busq_Clientes_Mail(parametro As String) As DataTable
        Dim consulta As String = "SELECT * FROM Vista_Clientes WHERE eMail like '" & parametro & "%' "
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Function Ficha_Clientes(id As Integer) As DataTable
        Dim consulta As String = "SELECT C.*, P.idProvincia FROM Clientes C INNER JOIN Localidad L ON L.idLocalidad = C.idLocalidad 
                                                                          INNER JOIN Provincia P ON P.idProvincia = L.idProvincia 
                                                                          WHERE idCliente = " + id.ToString
        Dim adaptador As New SqlDataAdapter(consulta, devolverConexion)
        Dim TablaDatos As New DataTable
        adaptador.Fill(TablaDatos)
        Return TablaDatos
    End Function

    Public Sub Actualizar_Cliente(id As Integer, nombre As String, direccion As String, celular As String, empresa_cel As String, localidad As Integer,
                                  email As String)
        Dim conexion As New SqlConnection(devolverConexion)
        Dim comando As New SqlCommand

        comando.Connection = conexion
        comando.CommandText = "UPDATE Clientes SET apellidoNombre = @nombre, direccion = @direccion, celular = @celular, empresaCelular = @empresa_cel,
                               idLocalidad = @localidad, correoElectronico = @email WHERE idCliente = " + id.ToString
        comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre
        comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = direccion
        comando.Parameters.Add("@celular", SqlDbType.VarChar).Value = celular
        comando.Parameters.Add("@empresa_cel", SqlDbType.VarChar).Value = empresa_cel
        comando.Parameters.Add("@localidad", SqlDbType.Int).Value = localidad
        comando.Parameters.Add("@email", SqlDbType.VarChar).Value = email

        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Public Sub Eliminar_Cliente(id As Integer)
        Dim conexion As New SqlConnection(devolverConexion)
        Dim comando As New SqlCommand
        comando.Connection = conexion

        comando.CommandText = "DELETE FROM Clientes WHERE idCliente = " + id.ToString

        conexion.Open()
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub
End Class
