Imports DATOS
Public Class Vacunaciones_ATPsN
    Dim vac_atp As New Vacunaciones_ATPsD

    Public Function mostrar_Vac_ATPs(id As Integer) As DataTable
        Return vac_atp.Mostrar_Vacunaciones_ATPs(id)
    End Function

    Public Sub insertarVacunacion(idpaciente As Integer, idvacuna As Integer, marcaserie As String, fecha_vac As Date)
        vac_atp.Insertar_Vacunacion(idpaciente, idvacuna, marcaserie, fecha_vac)
    End Sub

    Public Sub insertarVacunacionPendiente(idpaciente As Integer, idvacuna As Integer, fecha_prox_vac As Date)
        vac_atp.Insertar_Vacunacion_Pendiente(idpaciente, idvacuna, fecha_prox_vac)
    End Sub

    Public Sub insertarDesparacitacion(idpaciente As Integer, idatp As Integer, marcaserie As String, fecha_atp As Date)
        vac_atp.Insertar_Desparacitacion(idpaciente, idatp, marcaserie, fecha_atp)
    End Sub

    Public Sub insertarDesparasitacionPendiente(idpaciente As Integer, idatp As Integer, fecha_prox_atp As Date)
        vac_atp.Insertar_Desparasitacion_Pendiente(idpaciente, idatp, fecha_prox_atp)
    End Sub

End Class
