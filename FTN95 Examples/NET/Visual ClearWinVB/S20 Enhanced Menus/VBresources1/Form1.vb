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
  Friend WithEvents menuItem1 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem3 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem4 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem2 As System.Windows.Forms.MenuItem
  Friend WithEvents imageList1 As System.Windows.Forms.ImageList
  Friend WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents menuItem8 As System.Windows.Forms.MenuItem
  Friend WithEvents pictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents menuItem9 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem10 As System.Windows.Forms.MenuItem
  Friend WithEvents statusBar1 As System.Windows.Forms.StatusBar
  Friend WithEvents main_Menu1 As Salford.VisualClearWin.Main_Menu
  Friend WithEvents menuItem6 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem7 As System.Windows.Forms.MenuItem
  Friend WithEvents context_Menu1 As Salford.VisualClearWin.Context_Menu
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
    Me.menuItem1 = New System.Windows.Forms.MenuItem
    Me.menuItem3 = New System.Windows.Forms.MenuItem
    Me.menuItem4 = New System.Windows.Forms.MenuItem
    Me.menuItem2 = New System.Windows.Forms.MenuItem
    Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
    Me.menuItem8 = New System.Windows.Forms.MenuItem
    Me.pictureBox1 = New System.Windows.Forms.PictureBox
    Me.menuItem9 = New System.Windows.Forms.MenuItem
    Me.menuItem10 = New System.Windows.Forms.MenuItem
    Me.statusBar1 = New System.Windows.Forms.StatusBar
    Me.main_Menu1 = New Salford.VisualClearWin.Main_Menu
    Me.menuItem6 = New System.Windows.Forms.MenuItem
    Me.menuItem7 = New System.Windows.Forms.MenuItem
    Me.context_Menu1 = New Salford.VisualClearWin.Context_Menu
    Me.SuspendLayout()
    '
    'menuItem1
    '
    Me.menuItem1.Index = 0
    Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem3, Me.menuItem4, Me.menuItem2})
    Me.menuItem1.Text = "File"
    '
    'menuItem3
    '
    Me.main_Menu1.SetCallback(Me.menuItem3, "Open")
    Me.main_Menu1.SetImageIndex(Me.menuItem3, "0")
    Me.menuItem3.Index = 0
    Me.main_Menu1.SetMenuTip(Me.menuItem3, "Opens a file.")
    Me.menuItem3.Text = "Open"
    '
    'menuItem4
    '
    Me.main_Menu1.SetCallback(Me.menuItem4, Nothing)
    Me.main_Menu1.SetImageIndex(Me.menuItem4, Nothing)
    Me.menuItem4.Index = 1
    Me.main_Menu1.SetMenuTip(Me.menuItem4, Nothing)
    Me.menuItem4.Text = "-"
    '
    'menuItem2
    '
    Me.main_Menu1.SetCallback(Me.menuItem2, "Exit")
    Me.main_Menu1.SetImageIndex(Me.menuItem2, "1")
    Me.menuItem2.Index = 2
    Me.main_Menu1.SetMenuTip(Me.menuItem2, "Exits the application.")
    Me.menuItem2.Text = "Exit"
    '
    'imageList1
    '
    Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
    Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
    Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imageList1.TransparentColor = System.Drawing.Color.White
    '
    'menuItem8
    '
    Me.context_Menu1.SetCallback(Me.menuItem8, "")
    Me.context_Menu1.SetImageIndex(Me.menuItem8, "")
    Me.menuItem8.Index = 0
    Me.context_Menu1.SetMenuTip(Me.menuItem8, "")
    Me.menuItem8.Text = "Cut"
    '
    'pictureBox1
    '
    Me.pictureBox1.Location = New System.Drawing.Point(200, 115)
    Me.pictureBox1.Name = "pictureBox1"
    Me.pictureBox1.TabIndex = 3
    Me.pictureBox1.TabStop = False
    '
    'menuItem9
    '
    Me.context_Menu1.SetCallback(Me.menuItem9, "")
    Me.context_Menu1.SetImageIndex(Me.menuItem9, "")
    Me.menuItem9.Index = 1
    Me.context_Menu1.SetMenuTip(Me.menuItem9, "Copies to the clipboard")
    Me.menuItem9.Text = "Copy"
    '
    'menuItem10
    '
    Me.context_Menu1.SetCallback(Me.menuItem10, "")
    Me.context_Menu1.SetImageIndex(Me.menuItem10, "")
    Me.menuItem10.Index = 2
    Me.context_Menu1.SetMenuTip(Me.menuItem10, "")
    Me.menuItem10.Text = "Paste"
    '
    'statusBar1
    '
    Me.statusBar1.Location = New System.Drawing.Point(0, 241)
    Me.statusBar1.Name = "statusBar1"
    Me.statusBar1.Size = New System.Drawing.Size(296, 24)
    Me.statusBar1.TabIndex = 2
    Me.statusBar1.Text = "Ready"
    '
    'main_Menu1
    '
    Me.main_Menu1.ImageBackColor = System.Drawing.SystemColors.Control
    Me.main_Menu1.ImageList = Me.imageList1
    Me.main_Menu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem6})
    Me.main_Menu1.TextBackColor = System.Drawing.SystemColors.Window
    '
    'menuItem6
    '
    Me.menuItem6.Index = 1
    Me.menuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem7})
    Me.menuItem6.Text = "Help"
    '
    'menuItem7
    '
    Me.main_Menu1.SetCallback(Me.menuItem7, "")
    Me.main_Menu1.SetImageIndex(Me.menuItem7, "2")
    Me.menuItem7.Index = 0
    Me.main_Menu1.SetMenuTip(Me.menuItem7, "Gives information about this application.")
    Me.menuItem7.Text = "About"
    '
    'context_Menu1
    '
    Me.context_Menu1.ImageBackColor = System.Drawing.SystemColors.Control
    Me.context_Menu1.ImageList = Me.imageList1
    Me.context_Menu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem8, Me.menuItem9, Me.menuItem10})
    Me.context_Menu1.TextBackColor = System.Drawing.SystemColors.Window
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(296, 265)
    Me.Controls.Add(Me.pictureBox1)
    Me.Controls.Add(Me.statusBar1)
    Me.Menu = Me.main_Menu1
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
