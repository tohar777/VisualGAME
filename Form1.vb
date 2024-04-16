Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_MouseClick(sender As Object, e As MouseEventArgs) Handles Button2.MouseClick
        MsgBox("VisualGAME Studio 1 By Shockwave(R)  Version 1.0000   Menu Lang:VB.Net  .NET ver: version 4.7.2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start(".\index.htm")
    End Sub
End Class
