Public Class Form3
    Public Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Public Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub P_Click(sender As Object, e As EventArgs) Handles P.Click

    End Sub

    Public Sub S_Click(sender As Object, e As EventArgs) Handles S.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim v4 As New Form4
        v4.TextBox1.Text = ""

        Form3.ActiveForm.Hide()
        Form4.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.ActiveForm.Hide()
        Form2.Show()
    End Sub
End Class