Imports LOGICA
Imports PERSISTENCIA
Public Class Principal
    Dim insertar As Persona = New Persona



    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim unaPersona As Persona = New Persona
        unaPersona.setId(txtId.Text())
        unaPersona.setNombre(txtNombre.Text())
        unaPersona.setApellido(txtApellido.Text())
        unaPersona.setCurso(txtCurso.Text())
        unaPersona.setFecha(txtFecha.Text())
        insertar(unaPersona)

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim unaPersona As Persona = New Persona
        unaPersona.setId(txtModId.Text())
        unaPersona.setNombre(txtModNombre.Text())
        unaPersona.setApellido(txtModApellido.Text())
        unaPersona.setCurso(txtModCurso.Text())
        unaPersona.setFecha(txtModFecha.Text())
        modificar(unaPersona)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim id As Integer
        id = txtBajaId.Text()
        eliminar(id)
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
