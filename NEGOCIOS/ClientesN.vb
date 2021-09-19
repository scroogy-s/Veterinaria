Imports DATOS

Public Class ClientesN
    Dim cliente As New ClientesD
    Public Sub insertarCliente(nombre As String, direccion As String, celular As String, empresa_cel As String, localidad As Integer, fecha_alta As Date, fecha_ult_visita As Date, email As String, foto As Byte())
        cliente.Insertar(nombre, direccion, celular, empresa_cel, localidad, fecha_alta, fecha_ult_visita, email, foto)
    End Sub

    Public Function mostrarClientes() As DataTable
        Return cliente.Mostrar_Clientes()
    End Function

    Public Function mostrarProvincias() As DataTable
        Return cliente.Mostrar_Provincias()
    End Function

    Public Function mostrarLocalidades_Provincias(id As Integer) As DataTable
        Return cliente.Mostrar_Localidades_Provincias(id)
    End Function

    Public Function devolverCP(id As Integer) As String
        Return cliente.Devolver_CP(id)
    End Function

    Public Function devolverProximoCodigo() As String
        Return cliente.Devolver_Proximo_Codigo()
    End Function

    Public Function Busqueda_Clientes_Nombre(parametro As String) As DataTable
        Return cliente.Busq_Clientes_Nombre(parametro)
    End Function

    Public Function Busqueda_Clientes_Direccion(parametro As String) As DataTable
        Return cliente.Busq_Clientes_Direccion(parametro)
    End Function

    Public Function Busqueda_Clientes_Celular(parametro As String) As DataTable
        Return cliente.Busq_Clientes_Celular(parametro)
    End Function

    Public Function Busqueda_Clientes_Localidad(parametro As String) As DataTable
        Return cliente.Busq_Clientes_Localidad(parametro)
    End Function

    Public Function Busqueda_Clientes_Provincia(parametro As String) As DataTable
        Return cliente.Busq_Clientes_Provincia(parametro)
    End Function

    Public Function Busqueda_Clientes_Mail(parametro As String) As DataTable
        Return cliente.Busq_Clientes_Mail(parametro)
    End Function

    Public Function FichaClientes(id As Integer) As DataTable
        Return cliente.Ficha_Clientes(id)
    End Function

    Public Sub Update_Cliente(id As Integer, nombre As String, direccion As String, celular As String, empresa_cel As String, localidad As Integer, email As String)
        cliente.Actualizar_Cliente(id, nombre, direccion, celular, empresa_cel, localidad, email)
    End Sub

    Public Sub Delete_Cliente(id As Integer)
        cliente.Eliminar_Cliente(id)
    End Sub
End Class
