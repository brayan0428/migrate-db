Public Class Inicio
    Dim oConsultas
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MotoresBD As New Dictionary(Of String, String)
        MotoresBD.Add("mysql", "MySQL")

        cboMotorDB.DataSource = New BindingSource(MotoresBD, Nothing)
        cboMotorDB.ValueMember = "Key"
        cboMotorDB.DisplayMember = "Value"
    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Try
            If txtUsuario.Text = String.Empty Or txtBD.Text = String.Empty Or txtHost.Text = String.Empty Then
                MsgBox("Debe llenar todos los campos", MsgBoxStyle.Exclamation, "Validación")
                Return
            End If
            Variables.MOTORDB = cboMotorDB.SelectedValue
            Variables.HOST = txtHost.Text
            Variables.USUARIO = txtUsuario.Text
            Variables.CLAVE = txtClave.Text
            Variables.DB = txtBD.Text

            oConsultas = New Consultas
            Dim DtTablas As DataTable = oConsultas.ConsultarTablas
            If IsNothing(DtTablas) = False Then
                If DtTablas.Rows.Count > 0 Then
                    MsgBox("Conexión exitosa", MsgBoxStyle.Information, "Confirmación")
                    Dim frm As New GestionTablas
                    frm.DtTablas = DtTablas
                    frm.Show()
                Else
                    MsgBox("La base de datos seleccionada no tiene tablas para migrar", MsgBoxStyle.Exclamation, "Validación")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class
