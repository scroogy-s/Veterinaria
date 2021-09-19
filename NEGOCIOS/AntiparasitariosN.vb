Imports DATOS

Public Class AntiparasitariosN
    Dim atp As New AntiparasitariosD

    Public Sub insertarATP(nombre As String)
        atp.Insertar(nombre)
    End Sub

    Public Sub eliminarATP(id As Integer)
        atp.Eliminar(id)
    End Sub

    Public Function mostrarATP() As DataTable
        Return atp.mostrartodosATP()
    End Function

End Class
