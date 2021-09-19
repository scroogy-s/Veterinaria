Imports DATOS

Public Class VacunasN
    Dim vacuna As New VacunasD

    Public Sub insertarVacuna(nombre As String, descripcion As String)
        vacuna.Insertar(nombre, descripcion)
    End Sub

    Public Sub eliminarVacuna(id As Integer)
        vacuna.Eliminar(id)
    End Sub

    Public Function mostrarVacunas() As DataTable
        Return vacuna.mostrarVacunas()
    End Function
End Class
