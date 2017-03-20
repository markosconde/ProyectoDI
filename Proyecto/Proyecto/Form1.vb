Public Class Form1

    Dim contador As Integer
    Dim resource As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles encender.Click
        ProgressBar1.Value = 0.0
        ProgressBar1.Maximum = 100
        Timer1.Interval = 40
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If contador < 100 Then
            ProgressBar1.Value = contador
            contador = contador + 1
        Else
            Timer1.Enabled = False

            Form2.Show()
            Me.Close()

        End If
    End Sub

    Private Sub InglésToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InglésToolStripMenuItem.Click
        resource = "en-EN"

        traducirInterfaz(resource)
    End Sub

    Private Sub EspañolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EspañolToolStripMenuItem.Click
        resource = "es-ES"

        traducirInterfaz(resource)
    End Sub
    Private Sub traducirInterfaz(resource As String)
        Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo(resource)
        My.Settings.Save()
        Me.Controls.Clear()
        InitializeComponent()
        Timer1.Stop()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("http://www.juegodelaoca.com/Reglamento/reglamento.htm")
        Catch ex As Exception

        End Try
    End Sub
End Class
