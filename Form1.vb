Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myPhrase As String
        Dim Pos As Integer
        Dim n As Integer
        Dim TxtExtract


        myPhrase = TextBox1.Text
        Pos = TextBox2.Text
        n = TextBox3.Text

        TxtExtract = TextBox4.Text

        TxtExtract = MsgBox(Mid(TextBox1.Text, 5, 6))
    End Sub
End Class
