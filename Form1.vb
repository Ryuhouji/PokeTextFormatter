Public Class Form1
    Public NL As String = Environment.NewLine
    Public Line As String = ""
    Public quote As String = Chr(34)
    Public fresh As Boolean = True
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Clipboard.SetText(RichTextBox1.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        RichTextBox1.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If (TextBox1.Text.Length = 34) Then
            Line = TextBox1.Text
            RichTextBox1.Text += "    .string " + quote + Line + quote + Environment.NewLine
            TextBox1.Text = ""
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (TextBox1.Text.Length = 34) Then
            Line = TextBox1.Text
            RichTextBox1.Text += "    .string " + quote + Line + quote + Environment.NewLine
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Line = TextBox1.Text
        If fresh = True Then
            RichTextBox1.Text = ""
            fresh = False
        End If

        RichTextBox1.Text += "    .string " + quote + Line + quote + Environment.NewLine
        TextBox1.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.AcceptsReturn = False
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Line = TextBox1.Text
        If fresh = True Then
            RichTextBox1.Text = ""
            fresh = False
        End If

        RichTextBox1.Text += "    .string " + quote + Line + "$" + quote + Environment.NewLine
        TextBox1.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Line = TextBox1.Text
        If fresh = True Then
            RichTextBox1.Text = ""
            fresh = False
        End If

        RichTextBox1.Text += "    .string " + quote + Line + "\p" + quote + Environment.NewLine
        TextBox1.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Line = TextBox1.Text
        If fresh = True Then
            RichTextBox1.Text = ""
            fresh = False
        End If

        RichTextBox1.Text += "    .string " + quote + Line + "\n" + quote + Environment.NewLine
        TextBox1.Text = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Line = TextBox1.Text
        If fresh = True Then
            RichTextBox1.Text = ""
            fresh = False
        End If

        RichTextBox1.Text += "    .string " + quote + Line + "\l" + quote + Environment.NewLine
        TextBox1.Text = ""
    End Sub
End Class
