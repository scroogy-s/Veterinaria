Imports DATOS

Public Class GuarderiaN
    Dim guarderia As New GuarderiaD

    Public Sub ingresarPaciente_Guard(idpaciente As Integer, fecha_ingreso As Date, fecha_egreso As Date, costodiario As String, seña As String,
                        incluyesalida As Boolean, alimento As String, notas As String)
        guarderia.Insertar(idpaciente, fecha_ingreso, fecha_egreso, costodiario, seña, incluyesalida, alimento, notas)
    End Sub

    Public Function mostrarGuarderia() As DataTable
        Return guarderia.Mostrar_Guarderia()
    End Function

    Public Function TraerDatosGuarderia(id As Integer) As DataTable
        Return guarderia.Traer_Datos_Ingresado(id)
    End Function

    Public Sub Update_Estado(id As Integer)
        guarderia.Actualizar_Estado(id)
    End Sub

    Public Function Historial_Guard(desde As Date, hasta As Date) As DataTable
        Return guarderia.Historial_Guarderia(desde, hasta)
    End Function

    Public Function Detalles_Guarderia(id As Integer) As DataTable
        Return guarderia.Traer_Detalles_Guarderia(id)
    End Function

    Public Sub Update_Detalles(id As Integer, fecha_ingreso As Date, fecha_egreso As Date, alimento As String, notas As String)
        guarderia.Actualizar_Detalles(id, fecha_ingreso, fecha_egreso, alimento, notas)
    End Sub

    Public Function TraerDatosEliminacion(id As Integer) As DataTable
        Return guarderia.Traer_Eliminacion(id)
    End Function

    Public Sub Delete_Registro_Guarderia(id As Integer)
        guarderia.Eliminar_Registro_Guarderia(id)
    End Sub
End Class
