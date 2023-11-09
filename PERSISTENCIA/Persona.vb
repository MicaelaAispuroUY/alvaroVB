Friend Class Persona
    Private Id As Integer
    Private Nombre As String
    Private Apellido As String
    Private Curso As String
    Private Fecha As String

    Public Sub setId(unaId As Integer)
        Id = unaId
    End Sub
    Public Function getId() As Integer
        Return Id
    End Function
    Public Sub setNombre(unNombre As String)
        Nombre = unNombre
    End Sub
    Public Function getNombre() As String
        Return Nombre
    End Function
    Public Sub setApellido(unApellido As String)
        Apellido = unApellido
    End Sub
    Public Function getApellido() As String
        Return Apellido
    End Function
    Public Sub setCurso(unCurso As String)
        Curso = unCurso
    End Sub
    Public Function getCurso() As String
        Return Curso
    End Function
    Public Sub setFecha(unaFecha As String)
        Fecha = unaFecha
    End Sub
    Public Function getFecha() As String
        Return Fecha
    End Function


End Class
