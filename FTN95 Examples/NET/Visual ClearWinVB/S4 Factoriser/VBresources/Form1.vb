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
  Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
  Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem2_Exit As System.Windows.Forms.MenuItem
  Friend WithEvents textBox1 As System.Windows.Forms.TextBox
  Friend WithEvents label1 As System.Windows.Forms.Label
  Friend WithEvents button1 As System.Windows.Forms.Button
  Friend WithEvents Int32_Box1 As Salford.VisualClearWin.Int32_Box
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.MainMenu1 = New System.Windows.Forms.MainMenu
    Me.MenuItem1 = New System.Windows.Forms.MenuItem
    Me.MenuItem2_Exit = New System.Windows.Forms.MenuItem
    Me.MenuItem3 = New System.Windows.Forms.MenuItem
    Me.MenuItem4 = New System.Windows.Forms.MenuItem
    Me.textBox1 = New System.Windows.Forms.TextBox
    Me.label1 = New System.Windows.Forms.Label
    Me.button1 = New System.Windows.Forms.Button
    Me.Int32_Box1 = New Salford.VisualClearWin.Int32_Box
    Me.SuspendLayout()
    '
    'MainMenu1
    '
    Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem3})
    '
    'MenuItem1
    '
    Me.MenuItem1.Index = 0
    Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2_Exit})
    Me.MenuItem1.Text = "File"
    '
    'MenuItem2_Exit
    '
    Me.MenuItem2_Exit.Index = 0
    Me.MenuItem2_Exit.Text = "Exit"
    '
    'MenuItem3
    '
    Me.MenuItem3.Index = 1
    Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4})
    Me.MenuItem3.Text = "Help"
    '
    'MenuItem4
    '
    Me.MenuItem4.Index = 0
    Me.MenuItem4.Text = "About"
    '
    'textBox1
    '
    Me.textBox1.Location = New System.Drawing.Point(16, 56)
    Me.textBox1.Name = "textBox1"
    Me.textBox1.ReadOnly = True
    Me.textBox1.Size = New System.Drawing.Size(240, 20)
    Me.textBox1.TabIndex = 9
    Me.textBox1.Text = ""
    '
    'label1
    '
    Me.label1.Location = New System.Drawing.Point(16, 19)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(128, 16)
    Me.label1.TabIndex = 8
    Me.label1.Text = "Number to be factorised:"
    '
    'button1
    '
    Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.button1.Location = New System.Drawing.Point(192, 16)
    Me.button1.Name = "button1"
    Me.button1.Size = New System.Drawing.Size(64, 24)
    Me.button1.TabIndex = 7
    Me.button1.Text = "Factorise"
    '
    'Int32_Box1
    '
    Me.Int32_Box1.Location = New System.Drawing.Point(144, 16)
    Me.Int32_Box1.Maximum = 2147483647
    Me.Int32_Box1.Name = "Int32_Box1"
    Me.Int32_Box1.Size = New System.Drawing.Size(32, 20)
    Me.Int32_Box1.TabIndex = 10
    Me.Int32_Box1.Text = ""
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(274, 91)
    Me.Controls.Add(Me.Int32_Box1)
    Me.Controls.Add(Me.textBox1)
    Me.Controls.Add(Me.label1)
    Me.Controls.Add(Me.button1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Menu = Me.MainMenu1
    Me.MinimizeBox = False
    Me.Name = "Form1"
    Me.Text = "Factoriser"
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
