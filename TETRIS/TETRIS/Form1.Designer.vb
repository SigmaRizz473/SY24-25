<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        Avatar = New PictureBox()
        Timer1 = New Timer(components)
        Enemy = New PictureBox()
        PictureBox1 = New PictureBox()
        Enemy2 = New PictureBox()
        Platform = New PictureBox()
        Enemy3 = New PictureBox()
        CType(Avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Platform, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Avatar
        ' 
        Avatar.Image = CType(resources.GetObject("Avatar.Image"), Image)
        Avatar.Location = New Point(317, 94)
        Avatar.Name = "Avatar"
        Avatar.Size = New Size(84, 98)
        Avatar.SizeMode = PictureBoxSizeMode.StretchImage
        Avatar.TabIndex = 0
        Avatar.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 50
        ' 
        ' Enemy
        ' 
        Enemy.Image = CType(resources.GetObject("Enemy.Image"), Image)
        Enemy.Location = New Point(529, 128)
        Enemy.Name = "Enemy"
        Enemy.Size = New Size(85, 104)
        Enemy.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy.TabIndex = 2
        Enemy.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(114, 112)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(90, 120)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Enemy2
        ' 
        Enemy2.Image = CType(resources.GetObject("Enemy2.Image"), Image)
        Enemy2.Location = New Point(706, 112)
        Enemy2.Name = "Enemy2"
        Enemy2.Size = New Size(85, 104)
        Enemy2.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy2.TabIndex = 4
        Enemy2.TabStop = False
        ' 
        ' Platform
        ' 
        Platform.BackColor = SystemColors.ActiveBorder
        Platform.Location = New Point(-2, 418)
        Platform.Name = "Platform"
        Platform.Size = New Size(899, 105)
        Platform.TabIndex = 5
        Platform.TabStop = False
        ' 
        ' Enemy3
        ' 
        Enemy3.Image = CType(resources.GetObject("Enemy3.Image"), Image)
        Enemy3.Location = New Point(562, 317)
        Enemy3.Name = "Enemy3"
        Enemy3.Size = New Size(85, 104)
        Enemy3.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy3.TabIndex = 6
        Enemy3.TabStop = False
        Enemy3.Tag = "-1"
        ' 
        ' form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._360_F_173470720_YdpslFqysnVYxwtoyfCxnb2nQhVD71hV
        ClientSize = New Size(894, 518)
        Controls.Add(Enemy3)
        Controls.Add(Platform)
        Controls.Add(Enemy2)
        Controls.Add(Avatar)
        Controls.Add(PictureBox1)
        Controls.Add(Enemy)
        Name = "form1"
        Text = "RUN! DIDDY! RUN!"
        CType(Avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).EndInit()
        CType(Platform, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Avatar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Enemy As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Enemy2 As PictureBox
    Friend WithEvents Platform As PictureBox
    Friend WithEvents Enemy3 As PictureBox

End Class
