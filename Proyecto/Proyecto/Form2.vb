Public Class Form2


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        jugadores.SelectedIndex = 0
        ficharoja.Visible = False
        fichaazul.Visible = False
        fichaamarilla.Visible = False
        fichaverde.Visible = False


    End Sub

    Private Sub Dado_Click(sender As Object, e As EventArgs) Handles Dado.Click

        Timer1.Enabled = True
        Timer1.Interval = 300


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim A As Integer
        A = (6 - 1) * Rnd() + 1
        Select Case A
            Case 1
                Dado.Image = My.Resources.Imagenes.dado1
            Case 2
                Dado.Image = My.Resources.Imagenes.dado2
            Case 3
                Dado.Image = My.Resources.Imagenes.dado3
            Case 4
                Dado.Image = My.Resources.Imagenes.dado4
            Case 5
                Dado.Image = My.Resources.Imagenes.dado5
            Case 6
                Dado.Image = My.Resources.Imagenes.dado6

        End Select

        Timer1.Enabled = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles jugadores.SelectedIndexChanged
        Select Case jugadores.SelectedIndex
            Case 0
                ficharoja.Visible = False
                fichaazul.Visible = False
                fichaamarilla.Visible = False
                fichaverde.Visible = False
            Case 1
                ficharoja.Visible = True
                fichaazul.Visible = False
                fichaamarilla.Visible = False
                fichaverde.Visible = False
            Case 2
                ficharoja.Visible = True
                fichaazul.Visible = True
                fichaamarilla.Visible = False
                fichaverde.Visible = False
            Case 3
                ficharoja.Visible = True
                fichaazul.Visible = True
                fichaamarilla.Visible = True
                fichaverde.Visible = False
            Case 4
                ficharoja.Visible = True
                fichaazul.Visible = True
                fichaamarilla.Visible = True
                fichaverde.Visible = True
        End Select



    End Sub

    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("http://www.juegodelaoca.com/Reglamento/reglamento.htm")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F10 Then
            AyudaToolStripMenuItem_Click(Nothing, Nothing)
        End If
    End Sub
End Class