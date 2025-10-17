Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As New MySqlConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.ConnectionString = "server = localhost; userid = root; password = escuela; database = cantina"
            conn.Open()
            MsgBox("conectado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
