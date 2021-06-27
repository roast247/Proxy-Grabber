<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RoastingLabel = New System.Windows.Forms.Label()
        Me.RoastingPic = New System.Windows.Forms.PictureBox()
        Me.Closebtn = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.getProxy = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.clrList = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.RadioButton3 = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.RadioButton5 = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.RadioButton2 = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.RadioButton1 = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.svList = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Panel1.SuspendLayout()
        CType(Me.RoastingPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.RoastingLabel)
        Me.Panel1.Controls.Add(Me.RoastingPic)
        Me.Panel1.Controls.Add(Me.Closebtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(365, 25)
        Me.Panel1.TabIndex = 0
        '
        'RoastingLabel
        '
        Me.RoastingLabel.AutoSize = True
        Me.RoastingLabel.Location = New System.Drawing.Point(31, 6)
        Me.RoastingLabel.Name = "RoastingLabel"
        Me.RoastingLabel.Size = New System.Drawing.Size(123, 14)
        Me.RoastingLabel.TabIndex = 2
        Me.RoastingLabel.Text = "Roasting Proxy Grabber"
        '
        'RoastingPic
        '
        Me.RoastingPic.BackColor = System.Drawing.Color.Black
        Me.RoastingPic.Image = Global.Roasting_Proxy_Grabber.My.Resources.Resources.proxygrab
        Me.RoastingPic.Location = New System.Drawing.Point(0, 0)
        Me.RoastingPic.Name = "RoastingPic"
        Me.RoastingPic.Size = New System.Drawing.Size(25, 25)
        Me.RoastingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RoastingPic.TabIndex = 1
        Me.RoastingPic.TabStop = False
        '
        'Closebtn
        '
        Me.Closebtn.BackColor = System.Drawing.Color.Red
        Me.Closebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Closebtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.Closebtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Closebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.Closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Closebtn.Location = New System.Drawing.Point(340, 0)
        Me.Closebtn.Name = "Closebtn"
        Me.Closebtn.Size = New System.Drawing.Size(25, 25)
        Me.Closebtn.TabIndex = 0
        Me.Closebtn.Text = "X"
        Me.Closebtn.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ListBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.LimeGreen
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(127, 51)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(227, 242)
        Me.ListBox1.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 14)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Proxies:"
        '
        'getProxy
        '
        Me.getProxy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.getProxy.Location = New System.Drawing.Point(12, 180)
        Me.getProxy.Name = "getProxy"
        Me.getProxy.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.getProxy.Size = New System.Drawing.Size(99, 25)
        Me.getProxy.TabIndex = 36
        Me.getProxy.Values.Text = "Get Proxies"
        '
        'clrList
        '
        Me.clrList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clrList.Location = New System.Drawing.Point(12, 224)
        Me.clrList.Name = "clrList"
        Me.clrList.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.clrList.Size = New System.Drawing.Size(99, 25)
        Me.clrList.TabIndex = 37
        Me.clrList.Values.Text = "Clear List"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(99, 132)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proxy Type"
        '
        'RadioButton4
        '
        Me.RadioButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton4.Location = New System.Drawing.Point(13, 107)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.RadioButton4.Size = New System.Drawing.Size(72, 16)
        Me.RadioButton4.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.RadioButton4.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.TabIndex = 54
        Me.RadioButton4.Values.Text = "Socks 5/4"
        '
        'RadioButton3
        '
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton3.Location = New System.Drawing.Point(13, 19)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.RadioButton3.Size = New System.Drawing.Size(69, 16)
        Me.RadioButton3.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.RadioButton3.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.TabIndex = 55
        Me.RadioButton3.Values.Text = "All Types"
        '
        'RadioButton5
        '
        Me.RadioButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton5.Location = New System.Drawing.Point(13, 85)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.RadioButton5.Size = New System.Drawing.Size(62, 16)
        Me.RadioButton5.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.RadioButton5.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.TabIndex = 53
        Me.RadioButton5.Values.Text = "Socks 4"
        '
        'RadioButton2
        '
        Me.RadioButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton2.Location = New System.Drawing.Point(13, 63)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.RadioButton2.Size = New System.Drawing.Size(62, 16)
        Me.RadioButton2.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.RadioButton2.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.TabIndex = 52
        Me.RadioButton2.Values.Text = "Socks 5"
        '
        'RadioButton1
        '
        Me.RadioButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton1.Location = New System.Drawing.Point(13, 41)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.RadioButton1.Size = New System.Drawing.Size(49, 16)
        Me.RadioButton1.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.RadioButton1.StateCommon.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.TabIndex = 51
        Me.RadioButton1.Values.Text = "Https"
        '
        'svList
        '
        Me.svList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.svList.Location = New System.Drawing.Point(12, 267)
        Me.svList.Name = "svList"
        Me.svList.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.svList.Size = New System.Drawing.Size(99, 25)
        Me.svList.TabIndex = 50
        Me.svList.Values.Text = "Save List"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(365, 302)
        Me.Controls.Add(Me.svList)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.clrList)
        Me.Controls.Add(Me.getProxy)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.RoastingPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Closebtn As Button
    Friend WithEvents RoastingLabel As Label
    Friend WithEvents RoastingPic As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents getProxy As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents clrList As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents svList As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents RadioButton4 As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents RadioButton3 As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents RadioButton5 As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents RadioButton2 As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents RadioButton1 As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
End Class
