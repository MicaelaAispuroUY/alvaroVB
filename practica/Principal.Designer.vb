<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnCancelar = New Button()
        btnAgregar = New Button()
        txtId = New TextBox()
        lblId = New Label()
        lblFecha = New Label()
        lblCurso = New Label()
        lblApellido = New Label()
        lblNombre = New Label()
        txtFecha = New TextBox()
        txtCurso = New TextBox()
        txtApellido = New TextBox()
        txtNombre = New TextBox()
        lblAlta = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblListar = New Label()
        Label1 = New Label()
        txtBajaId = New TextBox()
        txtModNombre = New TextBox()
        txtModApellido = New TextBox()
        txtModCurso = New TextBox()
        txtModFecha = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        txtModId = New TextBox()
        btnModificar = New Button()
        btnListar = New Button()
        btnEliminar = New Button()
        DataGridView1 = New DataGridView()
        Id = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        Apellido = New DataGridViewTextBoxColumn()
        Curso = New DataGridViewTextBoxColumn()
        Fecha = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(25, 332)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 0
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(25, 193)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(75, 23)
        btnAgregar.TabIndex = 1
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(96, 35)
        txtId.Name = "txtId"
        txtId.Size = New Size(100, 23)
        txtId.TabIndex = 2
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.Location = New Point(46, 43)
        lblId.Name = "lblId"
        lblId.Size = New Size(17, 15)
        lblId.TabIndex = 3
        lblId.Text = "Id"
        ' 
        ' lblFecha
        ' 
        lblFecha.AutoSize = True
        lblFecha.Location = New Point(25, 161)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(38, 15)
        lblFecha.TabIndex = 4
        lblFecha.Text = "Fecha"
        ' 
        ' lblCurso
        ' 
        lblCurso.AutoSize = True
        lblCurso.Location = New Point(25, 132)
        lblCurso.Name = "lblCurso"
        lblCurso.Size = New Size(38, 15)
        lblCurso.TabIndex = 5
        lblCurso.Text = "Curso"
        ' 
        ' lblApellido
        ' 
        lblApellido.AutoSize = True
        lblApellido.Location = New Point(12, 103)
        lblApellido.Name = "lblApellido"
        lblApellido.Size = New Size(51, 15)
        lblApellido.TabIndex = 6
        lblApellido.Text = "Apellido"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(12, 74)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(51, 15)
        lblNombre.TabIndex = 7
        lblNombre.Text = "Nombre"
        ' 
        ' txtFecha
        ' 
        txtFecha.Location = New Point(96, 153)
        txtFecha.Name = "txtFecha"
        txtFecha.Size = New Size(100, 23)
        txtFecha.TabIndex = 8
        ' 
        ' txtCurso
        ' 
        txtCurso.Location = New Point(96, 124)
        txtCurso.Name = "txtCurso"
        txtCurso.Size = New Size(100, 23)
        txtCurso.TabIndex = 9
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(96, 95)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(100, 23)
        txtApellido.TabIndex = 10
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(96, 66)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 11
        ' 
        ' lblAlta
        ' 
        lblAlta.AutoSize = True
        lblAlta.Location = New Point(118, 9)
        lblAlta.Name = "lblAlta"
        lblAlta.Size = New Size(73, 15)
        lblAlta.TabIndex = 12
        lblAlta.Text = "Alta persona"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(284, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 15)
        Label2.TabIndex = 13
        Label2.Text = "Modificar persona"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(303, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 15)
        Label3.TabIndex = 14
        Label3.Text = "Baja persona"
        ' 
        ' lblListar
        ' 
        lblListar.AutoSize = True
        lblListar.Location = New Point(686, 9)
        lblListar.Name = "lblListar"
        lblListar.Size = New Size(85, 15)
        lblListar.TabIndex = 15
        lblListar.Text = "Listar personas"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(233, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(17, 15)
        Label1.TabIndex = 17
        Label1.Text = "Id"
        ' 
        ' txtBajaId
        ' 
        txtBajaId.Location = New Point(283, 35)
        txtBajaId.Name = "txtBajaId"
        txtBajaId.Size = New Size(100, 23)
        txtBajaId.TabIndex = 16
        ' 
        ' txtModNombre
        ' 
        txtModNombre.Location = New Point(303, 163)
        txtModNombre.Name = "txtModNombre"
        txtModNombre.Size = New Size(100, 23)
        txtModNombre.TabIndex = 29
        ' 
        ' txtModApellido
        ' 
        txtModApellido.Location = New Point(303, 192)
        txtModApellido.Name = "txtModApellido"
        txtModApellido.Size = New Size(100, 23)
        txtModApellido.TabIndex = 28
        ' 
        ' txtModCurso
        ' 
        txtModCurso.Location = New Point(303, 221)
        txtModCurso.Name = "txtModCurso"
        txtModCurso.Size = New Size(100, 23)
        txtModCurso.TabIndex = 27
        ' 
        ' txtModFecha
        ' 
        txtModFecha.Location = New Point(303, 250)
        txtModFecha.Name = "txtModFecha"
        txtModFecha.Size = New Size(100, 23)
        txtModFecha.TabIndex = 26
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(219, 171)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 15)
        Label5.TabIndex = 25
        Label5.Text = "Nombre"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(219, 200)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 15)
        Label6.TabIndex = 24
        Label6.Text = "Apellido"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(232, 229)
        Label7.Name = "Label7"
        Label7.Size = New Size(38, 15)
        Label7.TabIndex = 23
        Label7.Text = "Curso"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(232, 258)
        Label8.Name = "Label8"
        Label8.Size = New Size(38, 15)
        Label8.TabIndex = 22
        Label8.Text = "Fecha"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(253, 140)
        Label9.Name = "Label9"
        Label9.Size = New Size(17, 15)
        Label9.TabIndex = 21
        Label9.Text = "Id"
        ' 
        ' txtModId
        ' 
        txtModId.Location = New Point(303, 132)
        txtModId.Name = "txtModId"
        txtModId.Size = New Size(100, 23)
        txtModId.TabIndex = 20
        ' 
        ' btnModificar
        ' 
        btnModificar.Location = New Point(232, 290)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(75, 23)
        btnModificar.TabIndex = 19
        btnModificar.Text = "Aceptar"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnListar
        ' 
        btnListar.Location = New Point(686, 39)
        btnListar.Name = "btnListar"
        btnListar.Size = New Size(75, 23)
        btnListar.TabIndex = 30
        btnListar.Text = "Listar"
        btnListar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(284, 66)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 31
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Id, Nombre, Apellido, Curso, Fecha})
        DataGridView1.Location = New Point(459, 75)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(525, 280)
        DataGridView1.TabIndex = 32
        ' 
        ' Id
        ' 
        Id.HeaderText = "Id"
        Id.Name = "Id"
        ' 
        ' Nombre
        ' 
        Nombre.HeaderText = "Nombre"
        Nombre.Name = "Nombre"
        ' 
        ' Apellido
        ' 
        Apellido.HeaderText = "Apellido"
        Apellido.Name = "Apellido"
        ' 
        ' Curso
        ' 
        Curso.HeaderText = "Curso"
        Curso.Name = "Curso"
        ' 
        ' Fecha
        ' 
        Fecha.HeaderText = "Fecha"
        Fecha.Name = "Fecha"
        ' 
        ' Principal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1012, 450)
        Controls.Add(DataGridView1)
        Controls.Add(btnEliminar)
        Controls.Add(btnListar)
        Controls.Add(txtModNombre)
        Controls.Add(txtModApellido)
        Controls.Add(txtModCurso)
        Controls.Add(txtModFecha)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(txtModId)
        Controls.Add(btnModificar)
        Controls.Add(Label1)
        Controls.Add(txtBajaId)
        Controls.Add(lblListar)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblAlta)
        Controls.Add(txtNombre)
        Controls.Add(txtApellido)
        Controls.Add(txtCurso)
        Controls.Add(txtFecha)
        Controls.Add(lblNombre)
        Controls.Add(lblApellido)
        Controls.Add(lblCurso)
        Controls.Add(lblFecha)
        Controls.Add(lblId)
        Controls.Add(txtId)
        Controls.Add(btnAgregar)
        Controls.Add(btnCancelar)
        Name = "Principal"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblCurso As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtCurso As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblAlta As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblListar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBajaId As TextBox
    Friend WithEvents txtModNombre As TextBox
    Friend WithEvents txtModApellido As TextBox
    Friend WithEvents txtModCurso As TextBox
    Friend WithEvents txtModFecha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtModId As TextBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnListar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Curso As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
End Class
