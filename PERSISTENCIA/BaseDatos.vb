Imports LOGICA
Imports MySql.Data.MySqlClient
Imports Persona
Public Class BaseDatos
    Private conexion As MySqlConnection = New MySqlConnection()
    Private comando As MySqlCommand = New MySqlCommand()

    Private tabla As String = "personas"
    Private comandoConexion =
        "Server=127.0.0.1;" &
        "DataBase=pruebamysql;" &
        "UID=admin;" &
        "PWD=1234;" &
        "Port=3306;"
    Private Sub conexion2()
        conexion.ConnectionString = comandoConexion
        conexion.Open()
        comando.Connection = conexion
    End Sub
    Private Sub insertar(unaPersona As Persona)
        conexion2()
        comando.CommandText = "INSERT INTO " & tabla &
        "VALUES('" & unaPersona.getId & "','" & unaPersona.getNombre & "','" & unaPersona.getApellido & "','" & unaPersona.getCurso & "','" & unaPersona.getFecha & ");"
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub
    Private Sub eliminar(unaId As Integer)
        conexion2()
        comando.CommandText = "DELETE FROM " & tabla & "WHERE  Id = " & unaId & ";"
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub
    Private Sub modificar(unaPersona As Persona)
        conexion2()
        comando.CommandText = "UPDATE " & tabla & "SET Nombre = " & unaPersona.getNombre & ", Apellido = " &
        ", Curso = " & unaPersona.getCurso & ", Fecha = " & unaPersona.getFecha & "WHERE Id = " & unaPersona.getId & ";"
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub
End Class
