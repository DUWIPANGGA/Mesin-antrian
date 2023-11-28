Imports System.IO.Ports
Imports System.Text
Imports System.IO
Public Class Form2
    Dim path As String
    Dim sw As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim sh As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim rs As New Resizer
    Dim data As String = "A/000"

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
        Me.TopMost = True
        rs.FindAllControls(Me)
        Dim filePath As String = AppDomain.CurrentDomain.BaseDirectory + "\ID.txt"
        Dim availablePorts As String() = SerialPort.GetPortNames()
        Dim paths As String = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\mp4.txt")
        Try
            ' Mengecek apakah file ada
            If File.Exists(filePath) Then
                ' Membaca teks dari file
                Try
                    Dim teksDariFile As String = File.ReadAllText(filePath)
                    ' Membagi teks dari file menjadi array berdasarkan karakter "/"
                    Dim arrayTeks() As String = teksDariFile.Split("/")
                    SerialPort1.PortName = arrayTeks(6).Trim() ' Replace with the appropriate port name
                    SerialPort1.BaudRate = 9600 ' Adjust to the correct baud rate
                    AddHandler SerialPort1.DataReceived, AddressOf DataReceivedHandler
                    SerialPort1.Open()
                    SerialPort1.Write(teksDariFile)
                    scroling_text.Text = arrayTeks(7)
                    AxWindowsMediaPlayer1.URL = paths
                    AxWindowsMediaPlayer1.Ctlcontrols.play()

                Catch ex As Exception

                End Try

            End If
            ' Open the serial port

        Catch ex As Exception
            MessageBox.Show("Failed to open the serial port: " & ex.Message)
        End Try
    End Sub
    '
    '
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

    Private Sub Timer1_Tick(sender As Object, l As EventArgs) Handles Timer1.Tick
        Try
            If scroling_text.Left > 2000 Then
                scroling_text.Left = 0
            End If
            Dim arrayTeks() As String = data.Split("/")
            scroling_text.Left = scroling_text.Left + 5
            'main_number_loket.Text = arrayTeks(1).Trim()
            main_loket.Text = arrayTeks(0).Trim()
            main_tipe_loket.Text = arrayTeks(0).Trim()
            If arrayTeks(0).Trim() = "A" Then
                a.Text = arrayTeks(1).Trim()
            ElseIf arrayTeks(0).Trim() = "B" Then
                b.Text = arrayTeks(1).Trim()
            ElseIf arrayTeks(0).Trim() = "C" Then
                c.Text = arrayTeks(1).Trim()
            ElseIf arrayTeks(0).Trim() = "D" Then
                d.Text = arrayTeks(1).Trim()
            ElseIf arrayTeks(0).Trim() = "E" Then
                e.Text = arrayTeks(1).Trim()
            ElseIf arrayTeks(0).Trim() = "F" Then
                f.Text = arrayTeks(1).Trim()
            ElseIf arrayTeks(0).Trim() = "G" Then
                g.Text = arrayTeks(1).Trim()
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub scroling_text_Click(sender As Object, e As EventArgs) Handles scroling_text.Click

    End Sub
    Private Sub Form2_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        rs.ResizeAllControls(Me)
    End Sub
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub main_tipe_loket_text_Click(sender As Object, e As EventArgs) Handles main_tipe_loket_text.Click

    End Sub
End Class