Public Class Form1
    Dim b As Integer = 2
    Private Sub Form1()
        Me.BackColor = Color.Yellow
    End Sub



    Private Sub changeButton_Click(sender As Object, e As EventArgs) Handles changeButton.Click
        If Me.BackColor = Color.Yellow Then
            Me.BackColor = Color.Black
        Else
            Me.BackColor = Color.Yellow
        End If
    End Sub
End Class
