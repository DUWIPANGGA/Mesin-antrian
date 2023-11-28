<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.main_tipe_loket = New System.Windows.Forms.Label()
        Me.main_tipe_loket_text = New System.Windows.Forms.Label()
        Me.main_number_loket = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.main_loket = New System.Windows.Forms.Label()
        Me.scrolingbox = New System.Windows.Forms.GroupBox()
        Me.scroling_text = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.loket_G = New System.Windows.Forms.GroupBox()
        Me.g = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.loket_F = New System.Windows.Forms.GroupBox()
        Me.f = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.loket_E = New System.Windows.Forms.GroupBox()
        Me.e = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Loket_D = New System.Windows.Forms.GroupBox()
        Me.d = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.loket_C = New System.Windows.Forms.GroupBox()
        Me.c = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.loket_B = New System.Windows.Forms.GroupBox()
        Me.b = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.loket_A = New System.Windows.Forms.GroupBox()
        Me.a = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.scrolingbox.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.loket_G.SuspendLayout()
        Me.loket_F.SuspendLayout()
        Me.loket_E.SuspendLayout()
        Me.Loket_D.SuspendLayout()
        Me.loket_C.SuspendLayout()
        Me.loket_B.SuspendLayout()
        Me.loket_A.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(338, 12)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(441, 253)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.main_tipe_loket)
        Me.GroupBox1.Controls.Add(Me.main_tipe_loket_text)
        Me.GroupBox1.Controls.Add(Me.main_number_loket)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.main_loket)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 253)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'main_tipe_loket
        '
        Me.main_tipe_loket.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.main_tipe_loket.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.main_tipe_loket.ForeColor = System.Drawing.Color.DarkOrange
        Me.main_tipe_loket.Location = New System.Drawing.Point(235, 31)
        Me.main_tipe_loket.Name = "main_tipe_loket"
        Me.main_tipe_loket.Size = New System.Drawing.Size(79, 76)
        Me.main_tipe_loket.TabIndex = 7
        Me.main_tipe_loket.Text = "A"
        '
        'main_tipe_loket_text
        '
        Me.main_tipe_loket_text.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.main_tipe_loket_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.main_tipe_loket_text.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.main_tipe_loket_text.Location = New System.Drawing.Point(-5, 31)
        Me.main_tipe_loket_text.Name = "main_tipe_loket_text"
        Me.main_tipe_loket_text.Size = New System.Drawing.Size(258, 76)
        Me.main_tipe_loket_text.TabIndex = 6
        Me.main_tipe_loket_text.Text = "LOKET"
        '
        'main_number_loket
        '
        Me.main_number_loket.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.main_number_loket.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.main_number_loket.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.main_number_loket.Location = New System.Drawing.Point(113, 144)
        Me.main_number_loket.Name = "main_number_loket"
        Me.main_number_loket.Size = New System.Drawing.Size(174, 91)
        Me.main_number_loket.TabIndex = 4
        Me.main_number_loket.Text = "000"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Location = New System.Drawing.Point(239, 259)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(225, 133)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'main_loket
        '
        Me.main_loket.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.main_loket.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.main_loket.ForeColor = System.Drawing.Color.DarkOrange
        Me.main_loket.Location = New System.Drawing.Point(45, 144)
        Me.main_loket.Name = "main_loket"
        Me.main_loket.Size = New System.Drawing.Size(93, 91)
        Me.main_loket.TabIndex = 8
        Me.main_loket.Text = "A"
        '
        'scrolingbox
        '
        Me.scrolingbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.scrolingbox.BackgroundImage = Global.Mesin_Antrian_Display.My.Resources.Resources.background_scroling
        Me.scrolingbox.Controls.Add(Me.scroling_text)
        Me.scrolingbox.Location = New System.Drawing.Point(-7, 418)
        Me.scrolingbox.Name = "scrolingbox"
        Me.scrolingbox.Size = New System.Drawing.Size(802, 50)
        Me.scrolingbox.TabIndex = 3
        Me.scrolingbox.TabStop = False
        '
        'scroling_text
        '
        Me.scroling_text.BackColor = System.Drawing.Color.Transparent
        Me.scroling_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scroling_text.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.scroling_text.Location = New System.Drawing.Point(-1, 16)
        Me.scroling_text.Name = "scroling_text"
        Me.scroling_text.Size = New System.Drawing.Size(153, 16)
        Me.scroling_text.TabIndex = 0
        Me.scroling_text.Text = "scroling_text halo panda"
        '
        'GroupBox10
        '
        Me.GroupBox10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox10.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox10.Controls.Add(Me.loket_G)
        Me.GroupBox10.Controls.Add(Me.loket_F)
        Me.GroupBox10.Controls.Add(Me.loket_E)
        Me.GroupBox10.Controls.Add(Me.Loket_D)
        Me.GroupBox10.Controls.Add(Me.loket_C)
        Me.GroupBox10.Controls.Add(Me.loket_B)
        Me.GroupBox10.Controls.Add(Me.loket_A)
        Me.GroupBox10.ForeColor = System.Drawing.Color.Crimson
        Me.GroupBox10.Location = New System.Drawing.Point(12, 274)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(767, 130)
        Me.GroupBox10.TabIndex = 4
        Me.GroupBox10.TabStop = False
        '
        'loket_G
        '
        Me.loket_G.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.loket_G.BackColor = System.Drawing.Color.MidnightBlue
        Me.loket_G.BackgroundImage = Global.Mesin_Antrian_Display.My.Resources.Resources._5559852
        Me.loket_G.Controls.Add(Me.g)
        Me.loket_G.Controls.Add(Me.Label30)
        Me.loket_G.Controls.Add(Me.Label31)
        Me.loket_G.Controls.Add(Me.Label32)
        Me.loket_G.Location = New System.Drawing.Point(651, 19)
        Me.loket_G.Name = "loket_G"
        Me.loket_G.Size = New System.Drawing.Size(100, 100)
        Me.loket_G.TabIndex = 14
        Me.loket_G.TabStop = False
        '
        'g
        '
        Me.g.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.g.BackColor = System.Drawing.Color.Transparent
        Me.g.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.g.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.g.Location = New System.Drawing.Point(48, 61)
        Me.g.Name = "g"
        Me.g.Size = New System.Drawing.Size(39, 20)
        Me.g.TabIndex = 9
        Me.g.Text = "000"
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label30.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label30.Location = New System.Drawing.Point(22, 61)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(23, 20)
        Me.Label30.TabIndex = 9
        Me.Label30.Text = "G"
        '
        'Label31
        '
        Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label31.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label31.Location = New System.Drawing.Point(76, 28)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(20, 17)
        Me.Label31.TabIndex = 10
        Me.Label31.Text = "G"
        '
        'Label32
        '
        Me.Label32.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label32.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label32.Location = New System.Drawing.Point(20, 28)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(59, 17)
        Me.Label32.TabIndex = 9
        Me.Label32.Text = "LOKET"
        '
        'loket_F
        '
        Me.loket_F.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.loket_F.BackColor = System.Drawing.Color.MidnightBlue
        Me.loket_F.BackgroundImage = Global.Mesin_Antrian_Display.My.Resources.Resources._5559852
        Me.loket_F.Controls.Add(Me.f)
        Me.loket_F.Controls.Add(Me.Label26)
        Me.loket_F.Controls.Add(Me.Label27)
        Me.loket_F.Controls.Add(Me.Label28)
        Me.loket_F.Location = New System.Drawing.Point(545, 19)
        Me.loket_F.Name = "loket_F"
        Me.loket_F.Size = New System.Drawing.Size(100, 100)
        Me.loket_F.TabIndex = 13
        Me.loket_F.TabStop = False
        '
        'f
        '
        Me.f.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.f.BackColor = System.Drawing.Color.Transparent
        Me.f.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.f.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.f.Location = New System.Drawing.Point(48, 61)
        Me.f.Name = "f"
        Me.f.Size = New System.Drawing.Size(39, 20)
        Me.f.TabIndex = 9
        Me.f.Text = "000"
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label26.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label26.Location = New System.Drawing.Point(22, 61)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(20, 20)
        Me.Label26.TabIndex = 9
        Me.Label26.Text = "F"
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label27.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label27.Location = New System.Drawing.Point(76, 28)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(17, 17)
        Me.Label27.TabIndex = 10
        Me.Label27.Text = "F"
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label28.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label28.Location = New System.Drawing.Point(20, 28)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(59, 17)
        Me.Label28.TabIndex = 9
        Me.Label28.Text = "LOKET"
        '
        'loket_E
        '
        Me.loket_E.BackColor = System.Drawing.Color.MidnightBlue
        Me.loket_E.BackgroundImage = Global.Mesin_Antrian_Display.My.Resources.Resources._5559852
        Me.loket_E.Controls.Add(Me.e)
        Me.loket_E.Controls.Add(Me.Label22)
        Me.loket_E.Controls.Add(Me.Label23)
        Me.loket_E.Controls.Add(Me.Label24)
        Me.loket_E.Location = New System.Drawing.Point(432, 19)
        Me.loket_E.Name = "loket_E"
        Me.loket_E.Size = New System.Drawing.Size(100, 100)
        Me.loket_E.TabIndex = 12
        Me.loket_E.TabStop = False
        '
        'e
        '
        Me.e.BackColor = System.Drawing.Color.Transparent
        Me.e.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.e.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.e.Location = New System.Drawing.Point(48, 61)
        Me.e.Name = "e"
        Me.e.Size = New System.Drawing.Size(39, 20)
        Me.e.TabIndex = 9
        Me.e.Text = "000"
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label22.Location = New System.Drawing.Point(22, 61)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(21, 20)
        Me.Label22.TabIndex = 9
        Me.Label22.Text = "E"
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label23.Location = New System.Drawing.Point(76, 28)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(18, 17)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "E"
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label24.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label24.Location = New System.Drawing.Point(20, 28)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(59, 17)
        Me.Label24.TabIndex = 9
        Me.Label24.Text = "LOKET"
        '
        'Loket_D
        '
        Me.Loket_D.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Loket_D.BackColor = System.Drawing.Color.MidnightBlue
        Me.Loket_D.BackgroundImage = Global.Mesin_Antrian_Display.My.Resources.Resources._5559852
        Me.Loket_D.Controls.Add(Me.d)
        Me.Loket_D.Controls.Add(Me.Label18)
        Me.Loket_D.Controls.Add(Me.Label19)
        Me.Loket_D.Controls.Add(Me.Label20)
        Me.Loket_D.Location = New System.Drawing.Point(333, 19)
        Me.Loket_D.Name = "Loket_D"
        Me.Loket_D.Size = New System.Drawing.Size(100, 100)
        Me.Loket_D.TabIndex = 12
        Me.Loket_D.TabStop = False
        '
        'd
        '
        Me.d.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.d.BackColor = System.Drawing.Color.Transparent
        Me.d.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.d.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.d.Location = New System.Drawing.Point(48, 61)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(39, 20)
        Me.d.TabIndex = 9
        Me.d.Text = "000"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label18.Location = New System.Drawing.Point(22, 61)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(22, 20)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "D"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label19.Location = New System.Drawing.Point(76, 28)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(19, 17)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "D"
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label20.Location = New System.Drawing.Point(20, 28)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 17)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "LOKET"
        '
        'loket_C
        '
        Me.loket_C.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.loket_C.BackColor = System.Drawing.Color.MidnightBlue
        Me.loket_C.BackgroundImage = Global.Mesin_Antrian_Display.My.Resources.Resources._5559852
        Me.loket_C.Controls.Add(Me.c)
        Me.loket_C.Controls.Add(Me.Label14)
        Me.loket_C.Controls.Add(Me.Label15)
        Me.loket_C.Controls.Add(Me.Label16)
        Me.loket_C.Location = New System.Drawing.Point(227, 19)
        Me.loket_C.Name = "loket_C"
        Me.loket_C.Size = New System.Drawing.Size(100, 100)
        Me.loket_C.TabIndex = 12
        Me.loket_C.TabStop = False
        '
        'c
        '
        Me.c.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.c.BackColor = System.Drawing.Color.Transparent
        Me.c.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.c.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.c.Location = New System.Drawing.Point(48, 61)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(39, 20)
        Me.c.TabIndex = 9
        Me.c.Text = "000"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label14.Location = New System.Drawing.Point(22, 61)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 20)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "C"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label15.Location = New System.Drawing.Point(76, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 17)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "C"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(20, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 17)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "LOKET"
        '
        'loket_B
        '
        Me.loket_B.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.loket_B.BackColor = System.Drawing.Color.MidnightBlue
        Me.loket_B.BackgroundImage = Global.Mesin_Antrian_Display.My.Resources.Resources._5559852
        Me.loket_B.Controls.Add(Me.b)
        Me.loket_B.Controls.Add(Me.Label10)
        Me.loket_B.Controls.Add(Me.Label11)
        Me.loket_B.Controls.Add(Me.Label12)
        Me.loket_B.Location = New System.Drawing.Point(121, 19)
        Me.loket_B.Name = "loket_B"
        Me.loket_B.Size = New System.Drawing.Size(100, 100)
        Me.loket_B.TabIndex = 11
        Me.loket_B.TabStop = False
        '
        'b
        '
        Me.b.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.b.BackColor = System.Drawing.Color.Transparent
        Me.b.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.b.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.b.Location = New System.Drawing.Point(48, 61)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(39, 20)
        Me.b.TabIndex = 9
        Me.b.Text = "000"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label10.Location = New System.Drawing.Point(22, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "B"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label11.Location = New System.Drawing.Point(76, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "B"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(20, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 17)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "LOKET"
        '
        'loket_A
        '
        Me.loket_A.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.loket_A.BackColor = System.Drawing.Color.MidnightBlue
        Me.loket_A.BackgroundImage = Global.Mesin_Antrian_Display.My.Resources.Resources._5559852
        Me.loket_A.Controls.Add(Me.a)
        Me.loket_A.Controls.Add(Me.Label8)
        Me.loket_A.Controls.Add(Me.Label6)
        Me.loket_A.Controls.Add(Me.Label5)
        Me.loket_A.Location = New System.Drawing.Point(15, 19)
        Me.loket_A.Name = "loket_A"
        Me.loket_A.Size = New System.Drawing.Size(100, 100)
        Me.loket_A.TabIndex = 4
        Me.loket_A.TabStop = False
        '
        'a
        '
        Me.a.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.a.BackColor = System.Drawing.Color.Transparent
        Me.a.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.a.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.a.Location = New System.Drawing.Point(49, 61)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(39, 20)
        Me.a.TabIndex = 9
        Me.a.Text = "000"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label8.Location = New System.Drawing.Point(22, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "A"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label6.Location = New System.Drawing.Point(76, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "A"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(20, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "LOKET"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = Global.Mesin_Antrian_Display.My.Resources.Resources._5559852
        Me.ClientSize = New System.Drawing.Size(789, 462)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.scrolingbox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Name = "Form2"
        Me.Text = "  "
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.scrolingbox.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.loket_G.ResumeLayout(False)
        Me.loket_F.ResumeLayout(False)
        Me.loket_E.ResumeLayout(False)
        Me.Loket_D.ResumeLayout(False)
        Me.loket_C.ResumeLayout(False)
        Me.loket_B.ResumeLayout(False)
        Me.loket_A.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents main_tipe_loket_text As Label
    Friend WithEvents main_number_loket As Label
    Friend WithEvents main_tipe_loket As Label
    Friend WithEvents main_loket As Label
    Friend WithEvents loket_A As GroupBox
    Friend WithEvents a As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents loket_F As GroupBox
    Friend WithEvents f As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents loket_E As GroupBox
    Friend WithEvents e As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Loket_D As GroupBox
    Friend WithEvents d As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents loket_C As GroupBox
    Friend WithEvents c As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents loket_B As GroupBox
    Friend WithEvents b As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents scroling_text As Label
    Friend WithEvents loket_G As GroupBox
    Friend WithEvents g As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Private WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Private WithEvents GroupBox1 As GroupBox
    Private WithEvents scrolingbox As GroupBox
    Private WithEvents GroupBox10 As GroupBox
End Class
