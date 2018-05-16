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
  Friend WithEvents int32_Box1 As Salford.VisualClearWin.Int32_Box
  Friend WithEvents toolTip1 As System.Windows.Forms.ToolTip
  Friend WithEvents decimal_UpDown1 As Salford.VisualClearWin.Decimal_UpDown
  Friend WithEvents textBox1 As System.Windows.Forms.TextBox
  Friend WithEvents label1 As System.Windows.Forms.Label
  Friend WithEvents button1 As System.Windows.Forms.Button
  Friend WithEvents list_Box1 As Salford.VisualClearWin.List_Box
  Friend WithEvents button2 As System.Windows.Forms.Button
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Me.int32_Box1 = New Salford.VisualClearWin.Int32_Box
    Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.decimal_UpDown1 = New Salford.VisualClearWin.Decimal_UpDown
    Me.textBox1 = New System.Windows.Forms.TextBox
    Me.label1 = New System.Windows.Forms.Label
    Me.button1 = New System.Windows.Forms.Button
    Me.list_Box1 = New Salford.VisualClearWin.List_Box
    Me.button2 = New System.Windows.Forms.Button
    CType(Me.decimal_UpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'int32_Box1
    '
    Me.int32_Box1.Location = New System.Drawing.Point(225, 16)
    Me.int32_Box1.Maximum = 2147483647
    Me.int32_Box1.Minimum = -2147483648
    Me.int32_Box1.Name = "int32_Box1"
    Me.int32_Box1.ReadOnly = True
    Me.int32_Box1.Size = New System.Drawing.Size(16, 20)
    Me.int32_Box1.TabIndex = 24
    Me.int32_Box1.Text = ""
    Me.toolTip1.SetToolTip(Me.int32_Box1, "Index of last item inserted.")
    '
    'decimal_UpDown1
    '
    Me.decimal_UpDown1.Location = New System.Drawing.Point(177, 16)
    Me.decimal_UpDown1.Maximum = New Decimal(New Integer() {1, 0, 0, -2147483648})
    Me.decimal_UpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
    Me.decimal_UpDown1.Name = "decimal_UpDown1"
    Me.decimal_UpDown1.Size = New System.Drawing.Size(32, 20)
    Me.decimal_UpDown1.TabIndex = 20
    Me.toolTip1.SetToolTip(Me.decimal_UpDown1, "Index of selected item.")
    Me.decimal_UpDown1.Value = New Decimal(New Integer() {1, 0, 0, -2147483648})
    '
    'textBox1
    '
    Me.textBox1.Location = New System.Drawing.Point(89, 16)
    Me.textBox1.Name = "textBox1"
    Me.textBox1.Size = New System.Drawing.Size(80, 20)
    Me.textBox1.TabIndex = 0
    Me.textBox1.Text = ""
    Me.toolTip1.SetToolTip(Me.textBox1, "Item to insert.")
    '
    'label1
    '
    Me.label1.Location = New System.Drawing.Point(25, 20)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(56, 16)
    Me.label1.TabIndex = 23
    Me.label1.Text = "New Item"
    '
    'button1
    '
    Me.button1.Enabled = False
    Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.button1.Location = New System.Drawing.Point(161, 224)
    Me.button1.Name = "button1"
    Me.button1.Size = New System.Drawing.Size(80, 24)
    Me.button1.TabIndex = 22
    Me.button1.Text = "Remove"
    '
    'list_Box1
    '
    Me.list_Box1.Location = New System.Drawing.Point(25, 48)
    Me.list_Box1.Name = "list_Box1"
    Me.list_Box1.Size = New System.Drawing.Size(216, 160)
    Me.list_Box1.Sorted = True
    Me.list_Box1.TabIndex = 21
    Me.list_Box1.Val = -1
    '
    'button2
    '
    Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.button2.Location = New System.Drawing.Point(25, 224)
    Me.button2.Name = "button2"
    Me.button2.Size = New System.Drawing.Size(80, 24)
    Me.button2.TabIndex = 19
    Me.button2.Text = "Insert"
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(266, 264)
    Me.Controls.Add(Me.decimal_UpDown1)
    Me.Controls.Add(Me.textBox1)
    Me.Controls.Add(Me.label1)
    Me.Controls.Add(Me.button1)
    Me.Controls.Add(Me.list_Box1)
    Me.Controls.Add(Me.button2)
    Me.Controls.Add(Me.int32_Box1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form1"
    Me.Text = "ListBox"
    CType(Me.decimal_UpDown1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
