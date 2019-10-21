Public Class GestionTablas
    Public DtTablas As DataTable
    Dim oConsultas As New Consultas
    Private Sub GestionTablas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim i As Integer = 0
            For Each tabla As DataRow In DtTablas.Rows
                dgvTablas.Rows.Add()
                dgvTablas.Rows(i).Cells("Col_Op").Value = True
                dgvTablas.Rows(i).Cells("Col_Tabla").Value = ValorColumna(tabla, "nombre")
                dgvTablas.Rows(i).Cells("Col_NumRegistros").Value = ValorColumna(tabla, "registros")
                dgvTablas.Rows(i).Cells("Col_Columnas").Value = String.Empty
                i += 1
            Next
            'dgvTablas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvTablas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan

            txtServidor.Text = Variables.HOST
            txtBD.Text = Variables.DB
            txtNumTablas.Text = DtTablas.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Function ValorColumna(fila As DataRow, tipo As String) As String
        Try
            Dim columna As String = String.Empty
            Select Case Variables.MOTORDB
                Case "mysql"
                    Select Case tipo
                        Case "nombre"
                            columna = "TABLE_NAME"
                        Case "registros"
                            columna = "TABLE_ROWS"
                    End Select
            End Select
            Return fila(columna).ToString.Trim
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub dgvTablas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTablas.CellContentClick
        If e.ColumnIndex = 3 Then
            Dim DtColumnas As DataTable = oConsultas.ConsultarColumnas(dgvTablas.Rows(e.RowIndex).Cells("Col_Tabla").Value)
            If IsNothing(DtColumnas) = False Then
                If DtColumnas.Rows.Count > 0 Then
                    Dim frm As New GestionColumnas
                    frm.DtColumnas = DtColumnas
                    frm.ShowDialog()
                    If frm.xColumnas <> String.Empty Then
                        dgvTablas.Rows(e.RowIndex).Cells("Col_Columnas").Value = frm.xColumnas
                    End If
                Else
                    MsgBox("La tabla seleccionada no tiene columnas", MsgBoxStyle.Exclamation, "Validación")
                End If
            End If
        End If
    End Sub
End Class