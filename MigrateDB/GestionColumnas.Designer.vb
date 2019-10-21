<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionColumnas
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
        Me.dgvColumnas = New System.Windows.Forms.DataGridView()
        Me.Col_Op = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Col_Columna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_TipoDato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Alias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAceptar = New System.Windows.Forms.Button()
        CType(Me.dgvColumnas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvColumnas
        '
        Me.dgvColumnas.AllowUserToAddRows = False
        Me.dgvColumnas.AllowUserToDeleteRows = False
        Me.dgvColumnas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvColumnas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_Op, Me.Col_Columna, Me.Col_TipoDato, Me.Col_Alias})
        Me.dgvColumnas.Location = New System.Drawing.Point(12, 12)
        Me.dgvColumnas.Name = "dgvColumnas"
        Me.dgvColumnas.RowHeadersVisible = False
        Me.dgvColumnas.Size = New System.Drawing.Size(393, 362)
        Me.dgvColumnas.TabIndex = 0
        '
        'Col_Op
        '
        Me.Col_Op.HeaderText = ""
        Me.Col_Op.Name = "Col_Op"
        '
        'Col_Columna
        '
        Me.Col_Columna.HeaderText = "Columna"
        Me.Col_Columna.Name = "Col_Columna"
        Me.Col_Columna.ReadOnly = True
        '
        'Col_TipoDato
        '
        Me.Col_TipoDato.HeaderText = "Tipo Dato"
        Me.Col_TipoDato.Name = "Col_TipoDato"
        Me.Col_TipoDato.ReadOnly = True
        '
        'Col_Alias
        '
        Me.Col_Alias.HeaderText = "Alias"
        Me.Col_Alias.Name = "Col_Alias"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(167, 383)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 34)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'GestionColumnas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 426)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dgvColumnas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "GestionColumnas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Migrate DB - Gestion Columnas"
        CType(Me.dgvColumnas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvColumnas As DataGridView
    Friend WithEvents Col_Op As DataGridViewCheckBoxColumn
    Friend WithEvents Col_Columna As DataGridViewTextBoxColumn
    Friend WithEvents Col_TipoDato As DataGridViewTextBoxColumn
    Friend WithEvents Col_Alias As DataGridViewTextBoxColumn
    Friend WithEvents btnAceptar As Button
End Class
