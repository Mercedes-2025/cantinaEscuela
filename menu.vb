Public Class menu
    Dim formularioActual As Form
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AbrirFormularioEnPanel(ventas)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AbrirFormularioEnPanel(platacaja)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer1.Start()


    End Sub
    Public Sub AbrirFormularioEnPanel(f As Form)
        If formularioActual IsNot Nothing Then
            ' Si el formulario es del mismo tipo, no hacer nada
            If formularioActual.GetType() Is f.GetType() Then
                Return
            End If
            ' Cierra el formulario anterior
            formularioActual.Dispose()
        End If

        contGeneral.Controls.Clear()
        f.TopLevel = False
        f.FormBorderStyle = FormBorderStyle.None
        f.Dock = DockStyle.Fill
        contGeneral.Controls.Add(f)
        f.Show()
        formularioActual = f
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = True
        Label4.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirFormularioEnPanel(producto)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirFormularioEnPanel(fiados)
    End Sub

End Class