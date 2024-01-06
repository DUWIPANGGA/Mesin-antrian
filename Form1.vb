Imports System.Text
Imports System.IO
Imports System.IO.Ports


Public Class Form1
    Private MyForm2 As Form2
    Dim tunda As Integer
    Dim layar As New Form2()
    Dim path As String = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\mp4.txt")
    Public col1 As String
    Public col2 As String
    Public col3 As String
    Public col4 As String
    Public col5 As String
    Public col6 As String

    Private Sub play_Click(sender As Object, e As EventArgs) Handles play.Click
        Dim filePath As String = AppDomain.CurrentDomain.BaseDirectory + "\ID.txt"

        'Mengecek apakah file ada
        If File.Exists(filePath) Then
            ' Membaca teks dari file
            Dim teksDariFile As String = File.ReadAllText(filePath)

            ' Membagi teks dari file menjadi array berdasarkan karakter "/"
            Dim arrayTeks() As String = teksDariFile.Split("/")

            'Try
            If MyForm2 Is Nothing OrElse MyForm2.IsDisposed Then
                ' Jika instance Form2 belum dibuat atau sudah disposed, buat instance baru
                MyForm2 = New Form2()
            End If

            MyForm2.Show()
            'Catch ex As Exception
            'MsgBox(ex)

            ' End Try


        End If
        MyForm2 = New Form2()



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim filePath As String = AppDomain.CurrentDomain.BaseDirectory + "\ID.txt"
        Dim confpath As String = AppDomain.CurrentDomain.BaseDirectory + "\config.txt"
        Dim availablePorts As String() = SerialPort.GetPortNames()
        Dim themepath As String = AppDomain.CurrentDomain.BaseDirectory + "\theme.txt"

        port.Items.AddRange(availablePorts)
        'Mengecek apakah file ada
        If File.Exists(themepath) Then
            Try
                Dim textfromtheme As String = File.ReadAllText(themepath)
                Dim themetext() As String = textfromtheme.Split("/")
                col1 = themetext(0)
                col2 = themetext(1)
                col3 = themetext(2)
                col4 = themetext(3)
                col5 = themetext(4)
                col6 = themetext(5)
                'MsgBox(themetext(0))
                testcolor1.BackColor = ColorTranslator.FromHtml(themetext(0))
                testcolor2.BackColor = ColorTranslator.FromHtml(themetext(1))
                testcolor3.BackColor = ColorTranslator.FromHtml(themetext(2))
                testcolor4.BackColor = ColorTranslator.FromHtml(themetext(3))
                testcolor5.BackColor = ColorTranslator.FromHtml(themetext(4))
                testcolor6.BackColor = ColorTranslator.FromHtml(themetext(5))
            Catch ex As Exception

            End Try
        Else

        End If
        If File.Exists(filePath) Then
            ' Membaca teks dari file
            Dim teksDariFile As String = File.ReadAllText(filePath)
            Dim textfromconf As String = File.ReadAllText(confpath)


            ' Membagi teks dari file menjadi array berdasarkan karakter "/"
            Dim arrayTeks() As String = teksDariFile.Split("/")
            Dim conftext() As String = textfromconf.Split("/")
            Dim auto As Boolean
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
                delay.Text = conftext(0)

                If (conftext(1).Trim = "True") Then
                    auto = True
                    Form2.FormBorderStyle = FormBorderStyle.None
                    Form2.WindowState = FormWindowState.Maximized
                Else
                    auto = False
                End If
                autofull.Checked = auto


            Catch ex As Exception

            End Try

        End If

    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Menampilkan pesan konfirmasi
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menutup aplikasi ini", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Mencegah penutupan form jika pengguna memilih "No"
        If result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Try
            Dim filePath As String = AppDomain.CurrentDomain.BaseDirectory + "\ID.txt"
            Dim confpath As String = AppDomain.CurrentDomain.BaseDirectory + "\config.txt"
            Dim judul As String = "PERINGATAN...!"
            Dim themepath As String = AppDomain.CurrentDomain.BaseDirectory + "\theme.txt"
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
            ElseIf Not (IsNumeric(delay.Text)) Then
                MessageBox.Show("delay harus berupa angka", judul)
            Else
                Dim selectedPort As String = port.SelectedItem.ToString()
                Using writer As New StreamWriter(filePath)
                    writer.WriteLine(ID1.Text & "/" & ID2.Text & "/" & ID3.Text & "/" & ID4.Text & "/" & ID5.Text & "/" & ID6.Text & "/" & selectedPort & "/" & scroling.Text)
                End Using
                Using writer As New StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\mp4.txt")
                    writer.WriteLine(path)
                End Using
                Using writer As New StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\config.txt")
                    writer.WriteLine(delay.Text & "/" & autofull.Checked)
                End Using
                Using writer As New StreamWriter(themepath)
                    writer.WriteLine(col1 & "/" & col2 & "/" & col3 & "/" & col4 & "/" & col5 & "/" & col6)
                End Using


                ' Menampilkan direktori program dalam MessageBox
                MessageBox.Show("berhasil menyimpan data di : " & Environment.NewLine & Environment.NewLine & filePath, "DONE")
            End If
            'My.Computer.Audio.Play(My.Resources.buzz, AudioPlayMode.Background)

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

    Private Sub color1_Click(sender As Object, e As EventArgs) Handles color1.Click
        Dim colors1 As DialogResult
        colors1 = ColorDialog1.ShowDialog()

        If colors1 = Windows.Forms.DialogResult.OK Then
            testcolor1.BackColor = ColorDialog1.Color
            col1 = ColorTranslator.ToHtml(ColorDialog1.Color)
        End If
    End Sub
    Private Sub color2_Click(sender As Object, e As EventArgs) Handles color2.Click
        Dim colors2 As DialogResult
        colors2 = ColorDialog2.ShowDialog()

        If colors2 = Windows.Forms.DialogResult.OK Then
            testcolor2.BackColor = ColorDialog2.Color
            col2 = ColorTranslator.ToHtml(ColorDialog2.Color)
        End If
    End Sub
    Private Sub color3_Click(sender As Object, e As EventArgs) Handles color3.Click
        Dim colors3 As DialogResult
        colors3 = ColorDialog3.ShowDialog()

        If colors3 = Windows.Forms.DialogResult.OK Then
            testcolor3.BackColor = ColorDialog3.Color
            col3 = ColorTranslator.ToHtml(ColorDialog3.Color)
        End If
    End Sub
    Private Sub color4_Click(sender As Object, e As EventArgs) Handles color4.Click
        Dim colors4 As DialogResult
        colors4 = ColorDialog4.ShowDialog()

        If colors4 = Windows.Forms.DialogResult.OK Then
            testcolor4.BackColor = ColorDialog4.Color
            col4 = ColorTranslator.ToHtml(ColorDialog4.Color)
        End If
    End Sub
    Private Sub color5_Click(sender As Object, e As EventArgs) Handles color5.Click
        Dim colors5 As DialogResult
        colors5 = ColorDialog5.ShowDialog()

        If colors5 = Windows.Forms.DialogResult.OK Then
            testcolor5.BackColor = ColorDialog5.Color
            col5 = ColorTranslator.ToHtml(ColorDialog5.Color)
        End If
    End Sub
    Private Sub color6_Click(sender As Object, e As EventArgs) Handles color6.Click
        Dim colors6 As DialogResult
        colors6 = ColorDialog6.ShowDialog()

        If colors6 = Windows.Forms.DialogResult.OK Then
            testcolor6.BackColor = ColorDialog6.Color
            col6 = ColorTranslator.ToHtml(ColorDialog6.Color)
        End If
    End Sub
End Class
