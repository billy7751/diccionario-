Imports System.IO
Public Class Form4
    Dim imagen As String
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True
        ListView1.Columns.Add("ID", 25)
        ListView1.Columns.Add("Palabra", 150)
        ListView1.Columns.Add("Significado", 150)
        ListView1.Columns.Add("Path Image", 300)
        Dim tot As New StreamReader("C:\Users\ITQ\source\repos\DiccionarioDeb\Di\list\4.txt")
        Dim palabras() As String
        While tot.Peek <> -1
            palabras = tot.ReadLine().ToString.Split("+")
            Dim item As ListViewItem
            item = New ListViewItem(palabras)
            ListView1.Items.Add(item)

        End While

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        imagen = ListView1.SelectedItems.ToString


        Dim v3 As New Form3
        'MsgBox(ListBox2.SelectedIndex)
        Dim id As Integer = TextBox1.Text
        v3.PictureBox1.Image = Image.FromFile(ListView1.Items(id).SubItems(3).Text)
        v3.P.Text = ListView1.Items(id).SubItems(1).Text
        v3.S.Text = ListView1.Items(id).SubItems(2).Text
        TextBox1.Text = ""

        Form4.ActiveForm.Hide()
        v3.Show()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged






    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.ActiveForm.Hide()
        Form1.Show()

    End Sub
End Class