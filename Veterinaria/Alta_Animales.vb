Imports NEGOCIOS
Public Class Alta_Animales
    Dim tabla_animales As New AnimalesN
    Dim animal As New AnimalesN

    Private Sub btn_volver_raza_Click(sender As Object, e As EventArgs) Handles btn_volver_raza.Click
        Me.Close()
        Animales.Show()
    End Sub

    Private Sub Animales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbox_alta_raza.DataSource = tabla_animales.cmb_Valores_Especies()
        cmbox_alta_raza.DisplayMember = "nombre"
        cmbox_alta_raza.ValueMember = "idEspecie"
    End Sub

    Private Sub btn_alta_raza_Click(sender As Object, e As EventArgs) Handles btn_alta_raza.Click
        animal.insertarAnimal(txt_alta_nombre_raza.Text, cmbox_alta_raza.SelectedValue)
        MsgBox("Raza agregada.", MsgBoxStyle.OkOnly, "Alta")
        Animales.Show()
        Me.Close()
    End Sub

End Class