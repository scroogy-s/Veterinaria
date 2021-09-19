Imports DATOS

Public Class VeterinariosN
    Dim veterinario As New VeterinariosD

    Public Sub Agregar_Veterinario(nombre As String, matricula As String)
        veterinario.Insertar(nombre, matricula)
    End Sub

    Public Function mostrar_Veterinarios() As DataTable
        Return veterinario.mostrarVeterinarios()
    End Function
End Class
