Option Strict On

Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim st As String = txtInput.Text
        Dim result As String = ""
        Dim len As Integer = st.Length()
        Dim n As Integer = 0
        Dim ch As Char

        For n = len - 1 To 0 Step -1
            ch = st.Chars(n)
            result = result & ch
        Next


        txtOutput.Text = result
    End Sub
End Class
