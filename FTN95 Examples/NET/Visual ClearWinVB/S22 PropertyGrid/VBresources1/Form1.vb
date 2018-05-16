Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
  Friend WithEvents label4 As System.Windows.Forms.Label
  Friend WithEvents int32_Box4 As Salford.VisualClearWin.Int32_Box
  Friend WithEvents int32_Box2 As Salford.VisualClearWin.Int32_Box
  Friend WithEvents text_Box2 As Salford.VisualClearWin.Text_Box
  Friend WithEvents int32_Box3 As Salford.VisualClearWin.Int32_Box
  Friend WithEvents text_Box1 As Salford.VisualClearWin.Text_Box
  Friend WithEvents double_Box1 As Salford.VisualClearWin.Double_Box
  Friend WithEvents int32_Box1 As Salford.VisualClearWin.Int32_Box
  Friend WithEvents label3 As System.Windows.Forms.Label
  Friend WithEvents label6 As System.Windows.Forms.Label
  Friend WithEvents label5 As System.Windows.Forms.Label
  Friend WithEvents label2 As System.Windows.Forms.Label
  Friend WithEvents label1 As System.Windows.Forms.Label
  Friend WithEvents property_Grid1 As Salford.VisualClearWin.Property_Grid
  Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents textBox1 As System.Windows.Forms.TextBox
  Friend WithEvents check_Box1 As Salford.VisualClearWin.Check_Box
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.label4 = New System.Windows.Forms.Label
    Me.int32_Box4 = New Salford.VisualClearWin.Int32_Box
    Me.int32_Box2 = New Salford.VisualClearWin.Int32_Box
    Me.text_Box2 = New Salford.VisualClearWin.Text_Box
    Me.int32_Box3 = New Salford.VisualClearWin.Int32_Box
    Me.text_Box1 = New Salford.VisualClearWin.Text_Box
    Me.double_Box1 = New Salford.VisualClearWin.Double_Box
    Me.int32_Box1 = New Salford.VisualClearWin.Int32_Box
    Me.label3 = New System.Windows.Forms.Label
    Me.label6 = New System.Windows.Forms.Label
    Me.label5 = New System.Windows.Forms.Label
    Me.label2 = New System.Windows.Forms.Label
    Me.label1 = New System.Windows.Forms.Label
    Me.property_Grid1 = New Salford.VisualClearWin.Property_Grid
    Me.groupBox1 = New System.Windows.Forms.GroupBox
    Me.textBox1 = New System.Windows.Forms.TextBox
    Me.check_Box1 = New Salford.VisualClearWin.Check_Box
    Me.groupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'label4
    '
    Me.label4.Location = New System.Drawing.Point(357, 256)
    Me.label4.Name = "label4"
    Me.label4.Size = New System.Drawing.Size(48, 13)
    Me.label4.TabIndex = 31
    Me.label4.Text = "Size"
    '
    'int32_Box4
    '
    Me.int32_Box4.Digits = 3
    Me.int32_Box4.Location = New System.Drawing.Point(517, 188)
    Me.int32_Box4.Maximum = 255
    Me.int32_Box4.Minimum = -999
    Me.int32_Box4.Name = "int32_Box4"
    Me.int32_Box4.Size = New System.Drawing.Size(32, 20)
    Me.int32_Box4.TabIndex = 30
    Me.int32_Box4.Text = "0"
    '
    'int32_Box2
    '
    Me.int32_Box2.Digits = 3
    Me.int32_Box2.Location = New System.Drawing.Point(421, 188)
    Me.int32_Box2.Maximum = 255
    Me.int32_Box2.Minimum = -999
    Me.int32_Box2.Name = "int32_Box2"
    Me.int32_Box2.Size = New System.Drawing.Size(32, 20)
    Me.int32_Box2.TabIndex = 29
    Me.int32_Box2.Text = "0"
    '
    'text_Box2
    '
    Me.text_Box2.Location = New System.Drawing.Point(421, 220)
    Me.text_Box2.Name = "text_Box2"
    Me.text_Box2.Size = New System.Drawing.Size(160, 20)
    Me.text_Box2.TabIndex = 27
    Me.text_Box2.Text = ""
    '
    'int32_Box3
    '
    Me.int32_Box3.Digits = 3
    Me.int32_Box3.Location = New System.Drawing.Point(469, 188)
    Me.int32_Box3.Maximum = 255
    Me.int32_Box3.Minimum = -999
    Me.int32_Box3.Name = "int32_Box3"
    Me.int32_Box3.Size = New System.Drawing.Size(32, 20)
    Me.int32_Box3.TabIndex = 24
    Me.int32_Box3.Text = "255"
    Me.int32_Box3.Value = 255
    '
    'text_Box1
    '
    Me.text_Box1.Location = New System.Drawing.Point(421, 132)
    Me.text_Box1.Name = "text_Box1"
    Me.text_Box1.Size = New System.Drawing.Size(112, 20)
    Me.text_Box1.TabIndex = 22
    Me.text_Box1.Text = ""
    '
    'double_Box1
    '
    Me.double_Box1.ExpFigs = 2
    Me.double_Box1.Location = New System.Drawing.Point(421, 100)
    Me.double_Box1.Maximum = 1.0E+60
    Me.double_Box1.Minimum = -1.0E+60
    Me.double_Box1.Name = "double_Box1"
    Me.double_Box1.Size = New System.Drawing.Size(72, 20)
    Me.double_Box1.TabIndex = 19
    Me.double_Box1.Text = "0"
    '
    'int32_Box1
    '
    Me.int32_Box1.Location = New System.Drawing.Point(421, 68)
    Me.int32_Box1.Maximum = 2147483647
    Me.int32_Box1.Minimum = -2147483648
    Me.int32_Box1.Name = "int32_Box1"
    Me.int32_Box1.Size = New System.Drawing.Size(72, 20)
    Me.int32_Box1.TabIndex = 18
    Me.int32_Box1.Text = ""
    '
    'label3
    '
    Me.label3.Location = New System.Drawing.Point(357, 137)
    Me.label3.Name = "label3"
    Me.label3.Size = New System.Drawing.Size(48, 14)
    Me.label3.TabIndex = 23
    Me.label3.Text = "String"
    '
    'label6
    '
    Me.label6.Location = New System.Drawing.Point(357, 224)
    Me.label6.Name = "label6"
    Me.label6.Size = New System.Drawing.Size(48, 13)
    Me.label6.TabIndex = 28
    Me.label6.Text = "Font"
    '
    'label5
    '
    Me.label5.Location = New System.Drawing.Point(357, 192)
    Me.label5.Name = "label5"
    Me.label5.Size = New System.Drawing.Size(48, 16)
    Me.label5.TabIndex = 25
    Me.label5.Text = "Colour"
    '
    'label2
    '
    Me.label2.Location = New System.Drawing.Point(357, 105)
    Me.label2.Name = "label2"
    Me.label2.Size = New System.Drawing.Size(48, 14)
    Me.label2.TabIndex = 21
    Me.label2.Text = "Double"
    '
    'label1
    '
    Me.label1.Location = New System.Drawing.Point(357, 74)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(48, 14)
    Me.label1.TabIndex = 20
    Me.label1.Text = "Integer"
    '
    'property_Grid1
    '
    Me.property_Grid1.CommandsVisibleIfAvailable = True
    Me.property_Grid1.GridAttributes = New String() {"Integer|System.Int32|Numbers|Help for integer", "Double|System.Double|Numbers|Help for double", "String|System.String|Attributes|Help for string", "Logical|System.Boolean|Attributes|Help for logical", "Colour|System.Drawing.Color|Attributes|Help for colour", "Font|System.Drawing.Font|Attributes|Help for font", "Point|System.Drawing.Point|Attributes|Help for point|10,20"}
    Me.property_Grid1.LargeButtons = False
    Me.property_Grid1.LineColor = System.Drawing.SystemColors.ScrollBar
    Me.property_Grid1.Location = New System.Drawing.Point(21, 20)
    Me.property_Grid1.Name = "property_Grid1"
    Me.property_Grid1.Size = New System.Drawing.Size(272, 264)
    Me.property_Grid1.TabIndex = 17
    Me.property_Grid1.Text = "property_Grid1"
    Me.property_Grid1.ViewBackColor = System.Drawing.SystemColors.Window
    Me.property_Grid1.ViewForeColor = System.Drawing.SystemColors.WindowText
    '
    'groupBox1
    '
    Me.groupBox1.Controls.Add(Me.textBox1)
    Me.groupBox1.Controls.Add(Me.check_Box1)
    Me.groupBox1.Location = New System.Drawing.Point(341, 52)
    Me.groupBox1.Name = "groupBox1"
    Me.groupBox1.Size = New System.Drawing.Size(256, 232)
    Me.groupBox1.TabIndex = 26
    Me.groupBox1.TabStop = False
    '
    'textBox1
    '
    Me.textBox1.Enabled = False
    Me.textBox1.Location = New System.Drawing.Point(80, 200)
    Me.textBox1.Name = "textBox1"
    Me.textBox1.ReadOnly = True
    Me.textBox1.Size = New System.Drawing.Size(160, 20)
    Me.textBox1.TabIndex = 1
    Me.textBox1.Text = ""
    '
    'check_Box1
    '
    Me.check_Box1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.check_Box1.Location = New System.Drawing.Point(16, 112)
    Me.check_Box1.Name = "check_Box1"
    Me.check_Box1.Size = New System.Drawing.Size(78, 16)
    Me.check_Box1.TabIndex = 0
    Me.check_Box1.Text = "Logical"
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(618, 304)
    Me.Controls.Add(Me.label4)
    Me.Controls.Add(Me.int32_Box4)
    Me.Controls.Add(Me.int32_Box2)
    Me.Controls.Add(Me.text_Box2)
    Me.Controls.Add(Me.int32_Box3)
    Me.Controls.Add(Me.text_Box1)
    Me.Controls.Add(Me.double_Box1)
    Me.Controls.Add(Me.int32_Box1)
    Me.Controls.Add(Me.label3)
    Me.Controls.Add(Me.label6)
    Me.Controls.Add(Me.label5)
    Me.Controls.Add(Me.label2)
    Me.Controls.Add(Me.label1)
    Me.Controls.Add(Me.property_Grid1)
    Me.Controls.Add(Me.groupBox1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form1"
    Me.Text = "Property Grid"
    Me.groupBox1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
