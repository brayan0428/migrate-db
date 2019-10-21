Imports System.Text
Imports MySql.Data.MySqlClient
Public Class Consultas
    Dim conexion

    Public Sub New()
        conexion = New MySqlConnection(CadenaConex(Variables.MOTORDB))
    End Sub
    Function CadenaConex(MotorDB As String) As String
        Dim Cadena As String = String.Empty
        Select Case MotorDB
            Case "mysql"
                Cadena = "Server=" + Variables.HOST + "; Database=" + Variables.DB + ";user id=" + Variables.USUARIO + "; password=" + Variables.CLAVE
        End Select
        Return Cadena
    End Function

    Function ConsultarTablas() As DataTable
        Try
            Dim Q As New StringBuilder
            Select Case Variables.MOTORDB
                Case "mysql"
                    Q.AppendLine("SELECT * FROM INFORMATION_SCHEMA.tables WHERE TABLE_SCHEMA=@BD and TABLE_TYPE='BASE TABLE'")
            End Select
            Dim oCmmd As New MySqlCommand(Q.ToString, conexion)
            oCmmd.Parameters.AddWithValue("@BD", Variables.DB)
            Dim oDataA As New MySqlDataAdapter(oCmmd)
            Dim oTable As New DataTable
            oDataA.Fill(oTable)
            Return oTable
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function

    Function ConsultarColumnas(Tabla As String) As DataTable
        Try
            Dim Q As New StringBuilder
            Select Case Variables.MOTORDB
                Case "mysql"
                    Q.AppendLine("SELECT COLUMN_NAME,DATA_TYPE FROM information_schema.COLUMNS WHERE TABLE_SCHEMA = @BD AND TABLE_NAME = @TABLE")
            End Select
            Dim oCmmd As New MySqlCommand(Q.ToString, conexion)
            oCmmd.Parameters.AddWithValue("@BD", Variables.DB)
            oCmmd.Parameters.AddWithValue("@TABLE", Tabla)
            Dim oDataA As New MySqlDataAdapter(oCmmd)
            Dim oTable As New DataTable
            oDataA.Fill(oTable)
            Return oTable
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function
End Class

