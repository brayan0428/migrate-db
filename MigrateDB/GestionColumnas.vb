Public Class GestionColumnas
    Public DtColumnas As DataTable,
           xColumnas As String = String.Empty
    Private Sub GestionColumnas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim i As Integer = 0
            For Each columna As DataRow In DtColumnas.Rows
                dgvColumnas.Rows.Add()
                dgvColumnas.Rows(i).Cells("Col_Op").Value = True
                dgvColumnas.Rows(i).Cells("Col_Columna").Value = ValorColumna(columna, "nombre")
                dgvColumnas.Rows(i).Cells("Col_TipoDato").Value = ValorColumna(columna, "datos")
                dgvColumnas.Rows(i).Cells("Col_Alias").Value = ""
                i += 1
            Next
            dgvColumnas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvColumnas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
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
                            columna = "COLUMN_NAME"
                        Case "datos"
                            columna = "DATA_TYPE"
                    End Select
            End Select
            Return fila(columna).ToString.Trim
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            xColumnas = String.Empty
            Dim numColumnas As Integer = dgvColumnas.Rows.Count,
                cont As Integer = 0
            For Each item As DataGridViewRow In dgvColumnas.Rows
                cont += 1
                If item.Cells("Col_Op").Value Then
                    xColumnas &= item.Cells("Col_Columna").Value
                    If item.Cells("Col_Alias").Value <> String.Empty Then
                        xColumnas &= " as " & item.Cells("Col_Alias").Value
                    End If
                    If cont <> numColumnas Then
                        xColumnas &= ","
                    End If
                End If
            Next
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class