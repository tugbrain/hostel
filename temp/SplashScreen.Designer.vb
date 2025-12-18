<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreen
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        pictureBox1 = New PictureBox()
        label1 = New Label()
        label2 = New Label()
        progressBar1 = New ProgressBar()
        label3 = New Label()
        Timer1 = New Timer(components)
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Label4 = New Label()
        CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pictureBox1
        ' 
        pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), Image)
        pictureBox1.Location = New Point(294, 52)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New Size(200, 200)
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBox1.TabIndex = 0
        pictureBox1.TabStop = False
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.ForeColor = Color.White
        label1.Location = New Point(223, 331)
        label1.Name = "label1"
        label1.Size = New Size(292, 25)
        label1.TabIndex = 1
        label1.Text = "Hostel Management System"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label2.ForeColor = Color.White
        label2.Location = New Point(302, 405)
        label2.Name = "label2"
        label2.Size = New Size(180, 22)
        label2.TabIndex = 2
        label2.Text = "Version 1.0.0 © 2025"
        ' 
        ' progressBar1
        ' 
        progressBar1.Location = New Point(192, 463)
        progressBar1.Name = "progressBar1"
        progressBar1.Size = New Size(400, 20)
        progressBar1.Style = ProgressBarStyle.Marquee
        progressBar1.TabIndex = 3
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Font = New Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label3.ForeColor = Color.White
        label3.Location = New Point(365, 510)
        label3.Name = "label3"
        label3.Size = New Size(55, 17)
        label3.TabIndex = 4
        label3.Text = "Loading"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 3000
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Red
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(33, 569)
        Panel1.TabIndex = 5
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Yellow
        Panel2.Location = New Point(33, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(33, 569)
        Panel2.TabIndex = 6
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Green
        Panel3.Location = New Point(66, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(33, 569)
        Panel3.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(130, 279)
        Label4.Name = "Label4"
        Label4.Size = New Size(557, 32)
        Label4.TabIndex = 8
        Label4.Text = "GH TECHNICAL UNIVERSITY COLLEGE"
        ' 
        ' SplashScreen
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(739, 569)
        Controls.Add(Label4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(label3)
        Controls.Add(progressBar1)
        Controls.Add(label2)
        Controls.Add(label1)
        Controls.Add(pictureBox1)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Name = "SplashScreen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SplashScreen"
        CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label1 As Label
    Private WithEvents label2 As Label
    Private WithEvents progressBar1 As ProgressBar
    Private WithEvents label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
End Class