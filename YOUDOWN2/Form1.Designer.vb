<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.WebView1 = New EO.WebBrowser.WebView()
        Me.HexTheme1 = New YOUDOWN2.HexTheme()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.WebControl1 = New EO.WinForm.WebControl()
        Me.HexButton2 = New YOUDOWN2.HexButton()
        Me.HexCheckBox2 = New YOUDOWN2.HexCheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MiniaturaPequena = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New YOUDOWN2.AlphaBar()
        Me.HexButton1 = New YOUDOWN2.HexButton()
        Me.TextBox1 = New YOUDOWN2.HexTextBox()
        Me.HexTheme1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiniaturaPequena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Music File | *.mp3"
        Me.SaveFileDialog1.Title = "Save File"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1
        '
        'WebView1
        '
        Me.WebView1.ObjectForScripting = Nothing
        '
        'HexTheme1
        '
        Me.HexTheme1.Controls.Add(Me.PictureBox1)
        Me.HexTheme1.Controls.Add(Me.WebControl1)
        Me.HexTheme1.Controls.Add(Me.HexButton2)
        Me.HexTheme1.Controls.Add(Me.HexCheckBox2)
        Me.HexTheme1.Controls.Add(Me.Label3)
        Me.HexTheme1.Controls.Add(Me.TextBox2)
        Me.HexTheme1.Controls.Add(Me.MiniaturaPequena)
        Me.HexTheme1.Controls.Add(Me.Label2)
        Me.HexTheme1.Controls.Add(Me.ProgressBar1)
        Me.HexTheme1.Controls.Add(Me.HexButton1)
        Me.HexTheme1.Controls.Add(Me.TextBox1)
        Me.HexTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HexTheme1.Location = New System.Drawing.Point(0, 0)
        Me.HexTheme1.Name = "HexTheme1"
        Me.HexTheme1.Size = New System.Drawing.Size(514, 385)
        Me.HexTheme1.TabIndex = 0
        Me.HexTheme1.Text = "Create By S4Lsalsoft"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 265)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(514, 109)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'WebControl1
        '
        Me.WebControl1.BackColor = System.Drawing.Color.White
        Me.WebControl1.Location = New System.Drawing.Point(220, 102)
        Me.WebControl1.Name = "WebControl1"
        Me.WebControl1.Size = New System.Drawing.Size(257, 70)
        Me.WebControl1.TabIndex = 22
        Me.WebControl1.Text = "WebControl1"
        Me.WebControl1.WebView = Me.WebView1
        '
        'HexButton2
        '
        Me.HexButton2.Location = New System.Drawing.Point(220, 178)
        Me.HexButton2.Name = "HexButton2"
        Me.HexButton2.Size = New System.Drawing.Size(137, 37)
        Me.HexButton2.TabIndex = 20
        Me.HexButton2.Text = "Save MP3 File"
        '
        'HexCheckBox2
        '
        Me.HexCheckBox2.Checked = False
        Me.HexCheckBox2.Location = New System.Drawing.Point(385, 188)
        Me.HexCheckBox2.Name = "HexCheckBox2"
        Me.HexCheckBox2.Size = New System.Drawing.Size(92, 16)
        Me.HexCheckBox2.TabIndex = 19
        Me.HexCheckBox2.Text = "Topmost"
        Me.ToolTip1.SetToolTip(Me.HexCheckBox2, "The program will always be on top of the other applications")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "MP3 URL:"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(80, 233)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(424, 20)
        Me.TextBox2.TabIndex = 14
        '
        'MiniaturaPequena
        '
        Me.MiniaturaPequena.BackColor = System.Drawing.Color.Transparent
        Me.MiniaturaPequena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiniaturaPequena.ImageLocation = ""
        Me.MiniaturaPequena.Location = New System.Drawing.Point(12, 102)
        Me.MiniaturaPequena.Name = "MiniaturaPequena"
        Me.MiniaturaPequena.Size = New System.Drawing.Size(190, 113)
        Me.MiniaturaPequena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MiniaturaPequena.TabIndex = 13
        Me.MiniaturaPequena.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(154, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Enter the Video URL"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Image = Nothing
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 374)
        Me.ProgressBar1.Maximum = 100
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.NoRounding = False
        Me.ProgressBar1.Size = New System.Drawing.Size(514, 11)
        Me.ProgressBar1.TabIndex = 4
        Me.ProgressBar1.Text = "AlphaBar1"
        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Visible = False
        '
        'HexButton1
        '
        Me.HexButton1.Location = New System.Drawing.Point(420, 53)
        Me.HexButton1.Name = "HexButton1"
        Me.HexButton1.Size = New System.Drawing.Size(78, 27)
        Me.HexButton1.TabIndex = 1
        Me.HexButton1.Text = "Get Data"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.TextBox1.Location = New System.Drawing.Point(12, 53)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.Multiline = False
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = False
        Me.TextBox1.Size = New System.Drawing.Size(391, 27)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBox1.UseSystemPasswordChar = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(514, 385)
        Me.Controls.Add(Me.HexTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Youtube To MP3"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.HexTheme1.ResumeLayout(False)
        Me.HexTheme1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiniaturaPequena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HexTheme1 As YOUDOWN2.HexTheme
    Friend WithEvents TextBox1 As YOUDOWN2.HexTextBox
    Friend WithEvents ProgressBar1 As YOUDOWN2.AlphaBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents MiniaturaPequena As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents HexCheckBox2 As YOUDOWN2.HexCheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents HexButton2 As YOUDOWN2.HexButton
    Friend WithEvents HexButton1 As YOUDOWN2.HexButton
    Friend WithEvents WebControl1 As EO.WinForm.WebControl
    Friend WithEvents WebView1 As EO.WebBrowser.WebView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
