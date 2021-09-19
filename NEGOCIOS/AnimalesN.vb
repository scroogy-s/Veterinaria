Imports DATOS
Public Class AnimalesN
    Dim animal As New AnimalesD

    Public Sub insertarAnimal(nombre As String, id_especie As Integer)
        animal.Insertar(nombre, id_especie)
    End Sub

    Public Sub eliminarAnimal(id As Integer)
        animal.Eliminar(id)
    End Sub

    Public Function mostrarAnimales_Especies() As DataTable
        Return animal.Mostrar()
    End Function

    Public Function cmb_Valores_Especies() As DataTable
        Return animal.cmb_Especies()
    End Function
End Class
