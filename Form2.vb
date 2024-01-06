Imports System.IO.Ports
Imports System.Text
Imports System.IO
Imports System.Threading
Imports System.Drawing


Public Class Form2
    Dim path As String = ""
    Dim sw As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim sh As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim rs As New Resizer
    Dim data As String = "A/000"
    Dim lastAntrian As Integer = 0
    Dim delay As Integer = 100

    Public Sub panggilSatuan(antrian As Double)
        Dim angka As Double
        angka = antrian Mod 10
        angka = Int(angka)
        'MsgBox(angka)
        If (angka = 1) Then
            My.Computer.Audio.Play(My.Resources.satu,
                AudioPlayMode.WaitToComplete)
        ElseIf (angka = 2) Then
            My.Computer.Audio.Play(My.Resources.dua,
            AudioPlayMode.WaitToComplete)
        ElseIf (angka = 3) Then
            My.Computer.Audio.Play(My.Resources.tiga,
            AudioPlayMode.WaitToComplete)
        ElseIf (angka = 4) Then
            My.Computer.Audio.Play(My.Resources.empat,
            AudioPlayMode.WaitToComplete)
        ElseIf (angka = 5) Then
            My.Computer.Audio.Play(My.Resources.lima,
            AudioPlayMode.WaitToComplete)
        ElseIf (angka = 6) Then
            My.Computer.Audio.Play(My.Resources.enam,
            AudioPlayMode.WaitToComplete)
        ElseIf (angka = 7) Then
            My.Computer.Audio.Play(My.Resources.tujuh,
            AudioPlayMode.WaitToComplete)
        ElseIf (angka = 8) Then
            My.Computer.Audio.Play(My.Resources.delapan,
            AudioPlayMode.WaitToComplete)
        ElseIf (angka = 9) Then
            My.Computer.Audio.Play(My.Resources.sembilan,
            AudioPlayMode.WaitToComplete)
        ElseIf (angka = 10) Then
            My.Computer.Audio.Play(My.Resources.sepuluh,
            AudioPlayMode.WaitToComplete)
        ElseIf (angka = 11) Then
            My.Computer.Audio.Play(My.Resources.sebelas,
                 AudioPlayMode.WaitToComplete)
        ElseIf (angka = 12) Then
            My.Computer.Audio.Play(My.Resources.dua,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.belas,
             AudioPlayMode.WaitToComplete)
        ElseIf (angka = 13) Then
            My.Computer.Audio.Play(My.Resources.tiga,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.belas,
             AudioPlayMode.WaitToComplete)
        ElseIf (angka = 14) Then
            My.Computer.Audio.Play(My.Resources.empat,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.belas,
             AudioPlayMode.WaitToComplete)
        ElseIf (angka = 15) Then
            My.Computer.Audio.Play(My.Resources.lima,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.belas,
             AudioPlayMode.WaitToComplete)
        ElseIf (angka = 16) Then
            My.Computer.Audio.Play(My.Resources.enam,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.belas,
             AudioPlayMode.WaitToComplete)
        ElseIf (angka = 17) Then
            My.Computer.Audio.Play(My.Resources.tujuh,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.belas,
             AudioPlayMode.WaitToComplete)
        ElseIf (angka = 18) Then
            My.Computer.Audio.Play(My.Resources.delapan,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.belas,
             AudioPlayMode.WaitToComplete)
        ElseIf (angka = 19) Then
            My.Computer.Audio.Play(My.Resources.sembilan,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.belas,
             AudioPlayMode.WaitToComplete)
        ElseIf (angka = 20) Then
            My.Computer.Audio.Play(My.Resources.dua,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.puluh,
             AudioPlayMode.WaitToComplete)
        End If
    End Sub
    Public Sub panggilPuluhan(antrian As Double)
        Dim angka As Double
        angka = antrian / 10
        angka = angka Mod 10
        angka = Int(angka)
        'MsgBox(angka)

        If (angka = 1) Then
            angka = antrian Mod 100
            angka = Int(angka)
            If (angka = 10) Then
                My.Computer.Audio.Play(My.Resources.sepuluh,
                AudioPlayMode.WaitToComplete)
            ElseIf (angka = 11) Then
                My.Computer.Audio.Play(My.Resources.sebelas,
                     AudioPlayMode.WaitToComplete)
            ElseIf (angka = 12) Then
                My.Computer.Audio.Play(My.Resources.dua,
                 AudioPlayMode.WaitToComplete)
                My.Computer.Audio.Play(My.Resources.belas,
                 AudioPlayMode.WaitToComplete)
            ElseIf (angka = 13) Then
                My.Computer.Audio.Play(My.Resources.tiga,
                 AudioPlayMode.WaitToComplete)
                My.Computer.Audio.Play(My.Resources.belas,
                 AudioPlayMode.WaitToComplete)
            ElseIf (angka = 14) Then
                My.Computer.Audio.Play(My.Resources.empat,
                 AudioPlayMode.WaitToComplete)
                My.Computer.Audio.Play(My.Resources.belas,
                 AudioPlayMode.WaitToComplete)
            ElseIf (angka = 15) Then
                My.Computer.Audio.Play(My.Resources.lima,
                 AudioPlayMode.WaitToComplete)
                My.Computer.Audio.Play(My.Resources.belas,
                 AudioPlayMode.WaitToComplete)
            ElseIf (angka = 16) Then
                My.Computer.Audio.Play(My.Resources.enam,
                 AudioPlayMode.WaitToComplete)
                My.Computer.Audio.Play(My.Resources.belas,
                 AudioPlayMode.WaitToComplete)
            ElseIf (angka = 17) Then
                My.Computer.Audio.Play(My.Resources.tujuh,
                 AudioPlayMode.WaitToComplete)
                My.Computer.Audio.Play(My.Resources.belas,
                 AudioPlayMode.WaitToComplete)
            ElseIf (angka = 18) Then
                My.Computer.Audio.Play(My.Resources.delapan,
                 AudioPlayMode.WaitToComplete)
                My.Computer.Audio.Play(My.Resources.belas,
                 AudioPlayMode.WaitToComplete)
            ElseIf (angka = 19) Then
                My.Computer.Audio.Play(My.Resources.sembilan,
                 AudioPlayMode.WaitToComplete)
                My.Computer.Audio.Play(My.Resources.belas,
                 AudioPlayMode.WaitToComplete)
            End If
        ElseIf (angka = 2) Then
            My.Computer.Audio.Play(My.Resources.dua,
                 AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.puluh,
                 AudioPlayMode.WaitToComplete)
        ElseIf (angka = 3) Then
            My.Computer.Audio.Play(My.Resources.tiga,
                 AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.puluh,
                 AudioPlayMode.WaitToComplete)
        ElseIf (angka = 4) Then
            My.Computer.Audio.Play(My.Resources.empat,
                 AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.puluh,
                 AudioPlayMode.WaitToComplete)
        ElseIf (angka = 5) Then
            My.Computer.Audio.Play(My.Resources.lima,
                 AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.puluh,
                 AudioPlayMode.WaitToComplete)
        ElseIf (angka = 6) Then
            My.Computer.Audio.Play(My.Resources.enam,
                 AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.puluh,
                 AudioPlayMode.WaitToComplete)
        ElseIf (angka = 7) Then
            My.Computer.Audio.Play(My.Resources.tujuh,
                 AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.puluh,
                 AudioPlayMode.WaitToComplete)
        ElseIf (angka = 8) Then
            My.Computer.Audio.Play(My.Resources.delapan,
                 AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.puluh,
                 AudioPlayMode.WaitToComplete)
        ElseIf (angka = 9) Then
            My.Computer.Audio.Play(My.Resources.sembilan,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.puluh,
                 AudioPlayMode.WaitToComplete)

        End If
        angka = antrian / 10
        angka = angka Mod 10
        angka = Int(angka)
        If Not (angka = 1) Then
            panggilSatuan(antrian)
        End If
    End Sub
    Public Sub panggilRatusan(antrian As Double)
        Dim angka As Double
        Dim ratusan As Double
        ratusan = antrian / 100
        angka = angka Mod 100
        'MsgBox(angka)
        ratusan = Int(ratusan)
        angka = Int(angka)
        If (ratusan = 1) Then
            My.Computer.Audio.Play(My.Resources.se,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.ratus,
             AudioPlayMode.WaitToComplete)
        ElseIf (ratusan = 2) Then
            My.Computer.Audio.Play(My.Resources.dua,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.ratus,
             AudioPlayMode.WaitToComplete)
        ElseIf (ratusan = 3) Then
            My.Computer.Audio.Play(My.Resources.tiga,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.ratus,
             AudioPlayMode.WaitToComplete)
        ElseIf (ratusan = 4) Then
            My.Computer.Audio.Play(My.Resources.empat,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.ratus,
             AudioPlayMode.WaitToComplete)
        ElseIf (ratusan = 5) Then
            My.Computer.Audio.Play(My.Resources.lima,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.ratus,
             AudioPlayMode.WaitToComplete)
        ElseIf (ratusan = 6) Then
            My.Computer.Audio.Play(My.Resources.enam,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.ratus,
             AudioPlayMode.WaitToComplete)
        ElseIf (angka = 7) Then
            My.Computer.Audio.Play(My.Resources.tujuh,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.ratus,
             AudioPlayMode.WaitToComplete)
        ElseIf (ratusan = 8) Then
            My.Computer.Audio.Play(My.Resources.delapan,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.ratus,
             AudioPlayMode.WaitToComplete)
        ElseIf (ratusan = 9) Then
            My.Computer.Audio.Play(My.Resources.sembilan,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.ratus,
             AudioPlayMode.WaitToComplete)
        End If
    End Sub
    Public Sub panggilRibuan(antrian As Double)
        Dim angka As Double
        angka = antrian / 1000
        angka = angka Mod 1000
        angka = Int(angka)
        If (angka = 1) Then
            My.Computer.Audio.Play(My.Resources.se,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.ribu,
             AudioPlayMode.WaitToComplete)
        ElseIf (angka = 2) Then
            My.Computer.Audio.Play(My.Resources.dua,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.ribu,
             AudioPlayMode.WaitToComplete)
        ElseIf (angka = 3) Then
            My.Computer.Audio.Play(My.Resources.tiga,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.ribu,
             AudioPlayMode.WaitToComplete)
        ElseIf (angka = 4) Then
            My.Computer.Audio.Play(My.Resources.empat,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.ribu,
             AudioPlayMode.WaitToComplete)
        ElseIf (angka = 5) Then
            My.Computer.Audio.Play(My.Resources.lima,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.ribu,
             AudioPlayMode.WaitToComplete)
        ElseIf (angka = 6) Then
            My.Computer.Audio.Play(My.Resources.enam,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.ribu,
             AudioPlayMode.WaitToComplete)
        ElseIf (angka = 7) Then
            My.Computer.Audio.Play(My.Resources.tujuh,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.ribu,
             AudioPlayMode.WaitToComplete)
        ElseIf (angka = 8) Then
            My.Computer.Audio.Play(My.Resources.delapan,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.ribu,
             AudioPlayMode.WaitToComplete)
        ElseIf (angka = 9) Then
            My.Computer.Audio.Play(My.Resources.sembilan,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.ribu,
             AudioPlayMode.WaitToComplete)
        ElseIf (angka = 0) Then
            My.Computer.Audio.Play(My.Resources.dua,
             AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.ribu,
             AudioPlayMode.WaitToComplete)
        End If
    End Sub
    Public Sub panggil(antrian As Double, loket As String)
        'Dim angka As Double
        My.Computer.Audio.Play(My.Resources.nomor_antrian,
        AudioPlayMode.WaitToComplete)
        If (antrian < 20) Then
            panggilSatuan(antrian)
        ElseIf (antrian >= 20 And antrian < 100) Then
            panggilPuluhan(antrian)
            panggilSatuan(antrian)
        ElseIf (antrian >= 100 And antrian < 1000) Then
            panggilRatusan(antrian)
            panggilPuluhan(antrian)

        ElseIf (antrian >= 1000 And antrian < 10000) Then
            panggilRibuan(antrian)
            panggilRatusan(antrian)
            panggilPuluhan(antrian)
            panggilSatuan(antrian)
        End If
        My.Computer.Audio.Play(My.Resources.tunggu,
        AudioPlayMode.WaitToComplete)
        If (loket = "A") Then
            My.Computer.Audio.Play(My.Resources.A,
            AudioPlayMode.WaitToComplete)
        ElseIf (loket = "B") Then
            My.Computer.Audio.Play(My.Resources.B,
                AudioPlayMode.WaitToComplete)
        ElseIf (loket = "C") Then
            My.Computer.Audio.Play(My.Resources.C,
                AudioPlayMode.WaitToComplete)
        ElseIf (loket = "D") Then
            My.Computer.Audio.Play(My.Resources.D,
                AudioPlayMode.WaitToComplete)
        ElseIf (loket = "E") Then
            My.Computer.Audio.Play(My.Resources.E,
                AudioPlayMode.WaitToComplete)
        ElseIf (loket = "F") Then
            My.Computer.Audio.Play(My.Resources.F,
                AudioPlayMode.WaitToComplete)
        ElseIf (loket = "G") Then
            My.Computer.Audio.Play(My.Resources.G,
                AudioPlayMode.WaitToComplete)
        End If
    End Sub
    Private Sub DataReceivedHandler(sender As Object, e As SerialDataReceivedEventArgs)
        ' Handler called when data is received
        Try
            data = SerialPort1.ReadLine() ' Read a line of data from the serial port
            'MessageBox.Show("Serial Data: " & data)


        Catch ex As Exception
            MessageBox.Show("Failed to read serial data: " & ex.Message)
        End Try
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        '
        '
        Me.TopMost = True
        rs.FindAllControls(Me)
        Dim filePath As String = AppDomain.CurrentDomain.BaseDirectory + "\ID.txt"
        Dim availablePorts As String() = SerialPort.GetPortNames()


        If File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\theme.txt") Then
            Dim theme As String = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\theme.txt")
            Dim themetext() As String = theme.Split("/")
            Try
                Me.BackColor = ColorTranslator.FromHtml(themetext(0))
                loket_A.BackColor = ColorTranslator.FromHtml(themetext(1))
                loket_B.BackColor = ColorTranslator.FromHtml(themetext(1))
                loket_C.BackColor = ColorTranslator.FromHtml(themetext(1))
                Loket_D.BackColor = ColorTranslator.FromHtml(themetext(1))
                loket_E.BackColor = ColorTranslator.FromHtml(themetext(1))
                loket_F.BackColor = ColorTranslator.FromHtml(themetext(1))
                loket_G.BackColor = ColorTranslator.FromHtml(themetext(1))
                scrolingbox.BackColor = ColorTranslator.FromHtml(themetext(2))
                main_tipe_loket.ForeColor = ColorTranslator.FromHtml(themetext(3))
                la.ForeColor = ColorTranslator.FromHtml(themetext(3))
                lb.ForeColor = ColorTranslator.FromHtml(themetext(3))
                lc.ForeColor = ColorTranslator.FromHtml(themetext(3))
                ld.ForeColor = ColorTranslator.FromHtml(themetext(3))
                le.ForeColor = ColorTranslator.FromHtml(themetext(3))
                lf.ForeColor = ColorTranslator.FromHtml(themetext(3))
                lg.ForeColor = ColorTranslator.FromHtml(themetext(3))
                main_tipe_loket.ForeColor = ColorTranslator.FromHtml(themetext(3))
                main_tipe_loket_text.ForeColor = ColorTranslator.FromHtml(themetext(4))
                loa.ForeColor = ColorTranslator.FromHtml(themetext(4))
                lob.ForeColor = ColorTranslator.FromHtml(themetext(4))
                loc.ForeColor = ColorTranslator.FromHtml(themetext(4))
                lod.ForeColor = ColorTranslator.FromHtml(themetext(4))
                loe.ForeColor = ColorTranslator.FromHtml(themetext(4))
                lof.ForeColor = ColorTranslator.FromHtml(themetext(4))
                log.ForeColor = ColorTranslator.FromHtml(themetext(4))
                scroling_text.ForeColor = ColorTranslator.FromHtml(themetext(5))
            Catch ex As Exception

            End Try

        Else
            Me.BackColor = Color.DodgerBlue
            loket_A.BackColor = Color.DeepSkyBlue
            loket_B.BackColor = Color.DeepSkyBlue
            loket_C.BackColor = Color.DeepSkyBlue
            Loket_D.BackColor = Color.DeepSkyBlue
            loket_E.BackColor = Color.DeepSkyBlue
            loket_F.BackColor = Color.DeepSkyBlue
            loket_G.BackColor = Color.DeepSkyBlue
            scrolingbox.ForeColor = Color.DarkBlue
            la.ForeColor = Color.Orange
            lb.ForeColor = Color.Orange
            lc.ForeColor = Color.Orange
            ld.ForeColor = Color.Orange
            le.ForeColor = Color.Orange
            lf.ForeColor = Color.Orange
            lg.ForeColor = Color.Orange
            main_tipe_loket.ForeColor = Color.Orange
            main_tipe_loket_text.ForeColor = Color.White
            loa.ForeColor = Color.White
            lob.ForeColor = Color.White
            loc.ForeColor = Color.White
            lod.ForeColor = Color.White
            loe.ForeColor = Color.White
            lof.ForeColor = Color.White
            log.ForeColor = Color.White
            scroling_text.ForeColor = Color.White
        End If

        'Mengecek apakah file ada
        If File.Exists(filePath) Then
            ' Membaca teks dari file
            'Try
            Dim teksDariFile As String = File.ReadAllText(filePath)
            Dim paths As String = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\mp4.txt")
            Dim conf As String = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\config.txt")
            Dim conftext() As String = conf.Split("/")
            ' Membagi teks dari file menjadi array berdasarkan karakter "/"
            Dim arrayTeks() As String = teksDariFile.Split("/")
            conftext = conf.Split("/")
            Dim auto As String = "False"
            delay = Int(conftext(0))
            MsgBox(delay)
            SerialPort1.PortName = arrayTeks(6).Trim() ' Replace with the appropriate port name
            SerialPort1.BaudRate = 9600 ' Adjust to the correct baud rate
            '    AddHandler SerialPort1.DataReceived, AddressOf DataReceivedHandler


            'SerialPort1.Open()
            'SerialPort1.Write(teksDariFile)


            scroling_text.Text = arrayTeks(7)

            AxWindowsMediaPlayer1.URL = paths
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            If (conftext(1).Length > 0) Then
                If (conftext(1).Trim = "True") Then
                    auto = True
                    Me.FormBorderStyle = FormBorderStyle.None
                    Me.WindowState = FormWindowState.Maximized
                Else
                    auto = False
                End If
            End If

            'Catch ex As Exception
            'MsgBox(ex)
            'End Try

        End If
        '
        'Catch ex As Exception
        '
        'End Try
        'Open the serial port
    End Sub
    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Menampilkan pesan konfirmasi
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menutup ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Mencegah penutupan form jika pengguna memilih "No"
        If result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
    Private Sub Form2_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub
    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter
        scroling_text.Left = -200
        Timer1.Start()
        AxWindowsMediaPlayer1.uiMode = "none"
        AxWindowsMediaPlayer1.settings.setMode("Loop", True)
        'OpenFileDialog1.ShowDialog()
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If scroling_text.Left < (Me.Width - (Me.Width + MeasureText(scroling_text.Text))) Then
            scroling_text.Left = Me.Width
        End If
        scroling_text.Left = scroling_text.Left - delay

    End Sub
    Private Function MeasureText(ByVal txt As String) As Integer
        Dim wdth As Integer
        Using gr As Graphics = scroling_text.CreateGraphics
            wdth = gr.MeasureString(txt, scroling_text.Font).Width
        End Using
        Return wdth
    End Function 'Measure length of 'txt' in pixels.
    Private Sub Timer1_Tick(sender As Object, l As EventArgs) Handles Timer1.Tick

        Try

            Dim arrayTeks() As String = data.Split("/")
            Dim angka As Integer = Int(arrayTeks(1).Trim())
            Dim hasilFormat As String = angka.ToString("D3")
            main_number_loket.Text = hasilFormat
            main_tipe_loket.Text = arrayTeks(0).Trim()


            If arrayTeks(0).Trim() = "A" Then
                a.Text = hasilFormat
            ElseIf arrayTeks(0).Trim() = "B" Then
                b.Text = hasilFormat
            ElseIf arrayTeks(0).Trim() = "C" Then
                c.Text = hasilFormat
            ElseIf arrayTeks(0).Trim() = "D" Then
                d.Text = hasilFormat
            ElseIf arrayTeks(0).Trim() = "E" Then
                e.Text = hasilFormat
            ElseIf arrayTeks(0).Trim() = "F" Then
                f.Text = hasilFormat
            ElseIf arrayTeks(0).Trim() = "G" Then
                g.Text = hasilFormat
            End If
            Dim t As New Thread(Sub()
                                    Try
                                        AxWindowsMediaPlayer1.settings.volume = 0
                                        panggil(Int(arrayTeks(1)), arrayTeks(0))
                                        AxWindowsMediaPlayer1.settings.volume = 100
                                    Catch ex As Exception

                                    End Try

                                End Sub)
            If Not (Int(arrayTeks(1)) = (lastAntrian)) Then
                t.Start()
                lastAntrian = Int(arrayTeks(1))
            End If
            Console.ReadLine()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub scroling_text_Click(sender As Object, e As EventArgs) Handles scroling_text.Click

    End Sub
    Private Sub Form2_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles instansi.Click

    End Sub
End Class