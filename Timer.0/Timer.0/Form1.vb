Public Class Form1
    Private x As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (x Mod 2 = 0) Then
            Label1.Visible = True
            Label2.Visible = False
        Else
            Label1.Visible = False
            Label2.Visible = True
        End If
        x = x + 1

        Label3.Text = DateTime.Now.ToString("hh:mm:ss")
        Label4.Text = DateTime.Now.ToLongDateString()

    End Sub

    Private Sub Iniciar_Click(sender As Object, e As EventArgs) Handles Iniciar.Click
        Timer1.Enabled = True

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Enabled = True

    End Sub
End Class
