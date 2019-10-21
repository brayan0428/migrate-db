<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionTablas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvTablas = New System.Windows.Forms.DataGridView()
        Me.Col_Op = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Col_Tabla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_NumRegistros = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Boton = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Col_Columnas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNumTablas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBD = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtServidor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvTablas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTablas
        '
        Me.dgvTablas.AllowUserToAddRows = False
        Me.dgvTablas.AllowUserToDeleteRows = False
        Me.dgvTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTablas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_Op, Me.Col_Tabla, Me.Col_NumRegistros, Me.Col_Boton, Me.Col_Columnas})
        Me.dgvTablas.Location = New System.Drawing.Point(12, 12)
        Me.dgvTablas.Name = "dgvTablas"
        Me.dgvTablas.ReadOnly = True
        Me.dgvTablas.RowHeadersVisible = False
        Me.dgvTablas.Size = New System.Drawing.Size(405, 356)
        Me.dgvTablas.TabIndex = 0
        '
        'Col_Op
        '
        Me.Col_Op.HeaderText = ""
        Me.Col_Op.Name = "Col_Op"
        Me.Col_Op.ReadOnly = True
        Me.Col_Op.Width = 20
        '
        'Col_Tabla
        '
        Me.Col_Tabla.HeaderText = "Tabla"
        Me.Col_Tabla.Name = "Col_Tabla"
        Me.Col_Tabla.ReadOnly = True
        Me.Col_Tabla.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Col_Tabla.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Col_Tabla.Width = 200
        '
        'Col_NumRegistros
        '
        Me.Col_NumRegistros.HeaderText = "# Registros"
        Me.Col_NumRegistros.Name = "Col_NumRegistros"
        Me.Col_NumRegistros.ReadOnly = True
        '
        'Col_Boton
        '
        Me.Col_Boton.HeaderText = "Columnas"
        Me.Col_Boton.Name = "Col_Boton"
        Me.Col_Boton.ReadOnly = True
        Me.Col_Boton.Width = 60
        '
        'Col_Columnas
        '
        Me.Col_Columnas.HeaderText = "Columnas"
        Me.Col_Columnas.Name = "Col_Columnas"
        Me.Col_Columnas.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNumTablas)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtBD)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtServidor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(432, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 166)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información Conexión Actual"
        '
        'txtNumTablas
        '
        Me.txtNumTablas.Enabled = False
        Me.txtNumTablas.Location = New System.Drawing.Point(23, 127)
        Me.txtNumTablas.Name = "txtNumTablas"
        Me.txtNumTablas.Size = New System.Drawing.Size(181, 20)
        Me.txtNumTablas.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "# Tablas"
        '
        'txtBD
        '
        Me.txtBD.Enabled = False
        Me.txtBD.Location = New System.Drawing.Point(23, 87)
        Me.txtBD.Name = "txtBD"
        Me.txtBD.Size = New System.Drawing.Size(181, 20)
        Me.txtBD.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Base de Datos"
        '
        'txtServidor
        '
        Me.txtServidor.Enabled = False
        Me.txtServidor.Location = New System.Drawing.Point(23, 42)
        Me.txtServidor.Name = "txtServidor"
        Me.txtServidor.Size = New System.Drawing.Size(181, 20)
        Me.txtServidor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Servidor"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(432, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 197)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información Migración"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(23, 167)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(181, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "# Tablas a Migrar"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(23, 127)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(181, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nombre Base de Datos"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(23, 42)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(181, 20)
        Me.TextBox3.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Servidor"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(23, 83)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(105, 20)
        Me.TextBox4.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Puerto"
        '
        'GestionTablas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 385)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvTablas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "GestionTablas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Migrate DB - Gestion Tablas"
        CType(Me.dgvTablas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvTablas As DataGridView
    Friend WithEvents Col_Op As DataGridViewCheckBoxColumn
    Friend WithEvents Col_Tabla As DataGridViewTextBoxColumn
    Friend WithEvents Col_NumRegistros As DataGridViewTextBoxColumn
    Friend WithEvents Col_Boton As DataGridViewButtonColumn
    Friend WithEvents Col_Columnas As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNumTablas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBD As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtServidor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
End Class
