Imports DATOS

Public Class PacientesN
    Dim paciente As New PacientesD

    Public Sub insertarPaciente(nombre As String, raza As Integer, sexo As Boolean, fechanac As Date, fecha_alta As Date, fecha_ult_visita As Date, microchip As String, foto As Byte(), idcliente As Integer)
        paciente.Insertar(nombre, raza, sexo, fechanac, fecha_alta, fecha_ult_visita, microchip, foto, idcliente)
    End Sub

    Public Function Especies() As DataTable
        Return paciente.Mostrar_Especies()
    End Function

    Public Function devolverProximoCodigo() As String
        Return paciente.Devolver_Proximo_Codigo()
    End Function

    Public Function Razas(id As Integer) As DataTable
        Return paciente.Mostrar_Razas_Especies(id)
    End Function

    Public Function MostrarPacientes() As DataTable
        Return paciente.Mostrar_Pacientes()
    End Function

    Public Function MostrarPacientesxClientes(id As Integer) As DataTable
        Return paciente.Mostrar_PacientesxCliente(id)
    End Function

    Public Sub Delete_PacientexCliente(id As Integer)
        paciente.Eliminar_PacientexCliente(id)
    End Sub

    Public Function FichaPacientes(id As Integer) As DataTable
        Return paciente.Ficha_Pacientes(id)
    End Function

    Public Sub Update_Paciente(id As Integer, nombre As String, raza As Integer, sexo As Boolean, fecha_nac As Date, microchip As String)
        paciente.Actualizar_Paciente(id, nombre, raza, sexo, fecha_nac, microchip)
    End Sub

    Public Sub Delete_Paciente(id As Integer)
        paciente.Eliminar_Paciente(id)
    End Sub

    Public Function Busqueda_Paciente_Nombre(parametro As String) As DataTable
        Return paciente.Busq_Paciente_Nombre(parametro)
    End Function

    Public Function Busqueda_Paciente_Especie(parametro As String) As DataTable
        Return paciente.Busq_Paciente_Especie(parametro)
    End Function

    Public Function Busqueda_Paciente_Raza(parametro As String) As DataTable
        Return paciente.Busq_Paciente_Raza(parametro)
    End Function

    Public Function Busqueda_Paciente_Sexo(parametro As String) As DataTable
        Return paciente.Busq_Paciente_Sexo(parametro)
    End Function

    Public Function Busqueda_Paciente_Microchip(parametro As String) As DataTable
        Return paciente.Busq_Paciente_Microchip(parametro)
    End Function

    Public Function Busqueda_Paciente_FechaNac(parametro As String) As DataTable
        Return paciente.Busq_Paciente_FechaNac(parametro)
    End Function

    Public Function busqueda_Paciente_Id(id As Integer) As DataTable
        Return paciente.Busq_Paciente_id(id)
    End Function
End Class
