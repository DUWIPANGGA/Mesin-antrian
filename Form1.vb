Imports System.Text
Imports System.IO
Imports System.IO.Ports


Public Class Form1

    Dim layar As New Form2()
    Dim path As String = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\mp4.txt")
    Private Sub play_Click(sender As Object, e As EventArgs) Handles play.Click
        Dim filePath As String = AppDomain.CurrentDomain.BaseDirectory + "\ID.txt"

        ' Mengecek apakah file ada
        If File.Exists(filePath) Then
            ' Membaca teks dari file
            Dim teksDariFile As String = File.ReadAllText(filePath)

            ' Membagi teks dari file menjadi array berdasarkan karakter "/"
            Dim arrayTeks() As String = teksDariFile.Split("/")
            Try
                layar.Hide()
                layar.Show()
            Catch ex As Exception

            End Try
        End If


        'layar.FormBorderStyle = FormBorderStyle.None
        'layar.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim filePath As String = AppDomain.CurrentDomain.BaseDirectory + "\ID.txt"
        Dim availablePorts As String() = SerialPort.GetPortNames()
        port.Items.AddRange(availablePorts)
        ' Mengecek apakah file ada
        If File.Exists(filePath) Then
            ' Membaca teks dari file
            Dim teksDariFile As String = File.ReadAllText(filePath)

            ' Membagi teks dari file menjadi array berdasarkan karakter "/"
            Dim arrayTeks() As String = teksDariFile.Split("/")

            ' Menampilkan bagian-bagian teks dalam text box
            Try
                ID1.Text = arrayTeks(0)
                ID2.Text = arrayTeks(1)
                ID3.Text = arrayTeks(2)
                ID4.Text = arrayTeks(3)
                ID5.Text = arrayTeks(4)
                ID6.Text = arrayTeks(5)
                scroling.Text = arrayTeks(7)
                port.SelectedItem = arrayTeks(6)
                port.Text = arrayTeks(6)
                namepath.Text = path
            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Try
            Dim filePath As String = AppDomain.CurrentDomain.BaseDirectory + "\ID.txt"
            Dim judul As String = "PERINGATAN...!"
            'dim teksToWrite As String = ID1.Text & "/" & ID2.Text & "/" & ID3.Text & "/" & ID4.Text & "/" & ID5.Text & "/" & ID6.Text & "/" & port.Items & "/" & titles.Text & "/" & scroling.Text
            If ID1.Text.Length < 3 Then
                MessageBox.Show("ID 1 salah?", judul)
            ElseIf ID2.Text.Length < 3 Then
                MessageBox.Show("ID 2 salah?", judul)
            ElseIf ID3.Text.Length < 3 Then
                MessageBox.Show("ID 3 salah?", judul)
            ElseIf ID4.Text.Length < 3 Then
                MessageBox.Show("ID 4 salah?", judul)
            ElseIf ID5.Text.Length < 3 Then
                MessageBox.Show("ID 5 salah?", judul)
            ElseIf ID6.Text.Length < 3 Then
                MessageBox.Show("ID 6 salah?", judul)
            Else
                Dim selectedPort As String = port.SelectedItem.ToString()
                Using writer As New StreamWriter(filePath)
                    writer.WriteLine(ID1.Text & "/" & ID2.Text & "/" & ID3.Text & "/" & ID4.Text & "/" & ID5.Text & "/" & ID6.Text & "/" & selectedPort & "/" & scroling.Text)
                End Using
                Using writer As New StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\mp4.txt")
                    writer.WriteLine(path)
                End Using


                ' Menampilkan direktori program dalam MessageBox
                MessageBox.Show("berhasil menyimpan data di : " & Environment.NewLine & Environment.NewLine & filePath, "DONE")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub paths_Click(sender As Object, e As EventArgs) Handles paths.Click
        OpenFileDialog1.ShowDialog()
        path = OpenFileDialog1.FileName


    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        namepath.Text = path
        path = OpenFileDialog1.FileName

    End Sub
End Class
