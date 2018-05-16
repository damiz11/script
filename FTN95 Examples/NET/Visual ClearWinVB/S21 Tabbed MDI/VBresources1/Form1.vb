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
  Friend WithEvents imageList2 As System.Windows.Forms.ImageList
  Friend WithEvents tab_Control1 As Salford.VisualClearWin.Tab_Control
  Friend WithEvents menuItemFile As System.Windows.Forms.MenuItem
  Friend WithEvents menuItemNew As System.Windows.Forms.MenuItem
  Friend WithEvents menuItemOpen As System.Windows.Forms.MenuItem
  Friend WithEvents menuItem5 As System.Windows.Forms.MenuItem
  Friend WithEvents menuItemRecentFiles As System.Windows.Forms.MenuItem
  Friend WithEvents menuItemExit As System.Windows.Forms.MenuItem
  Friend WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents imageList1 As System.Windows.Forms.ImageList
  Friend WithEvents main_Menu1 As Salford.VisualClearWin.Main_Menu
  Friend WithEvents statusBar1 As System.Windows.Forms.StatusBar
  Friend WithEvents toolBar1 As System.Windows.Forms.ToolBar
  Friend WithEvents toolBarButton_New As System.Windows.Forms.ToolBarButton
  Friend WithEvents toolBarButton_Open As System.Windows.Forms.ToolBarButton
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
    Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
    Me.tab_Control1 = New Salford.VisualClearWin.Tab_Control
    Me.menuItemFile = New System.Windows.Forms.MenuItem
    Me.menuItemNew = New System.Windows.Forms.MenuItem
    Me.menuItemOpen = New System.Windows.Forms.MenuItem
    Me.menuItem5 = New System.Windows.Forms.MenuItem
    Me.menuItemRecentFiles = New System.Windows.Forms.MenuItem
    Me.menuItemExit = New System.Windows.Forms.MenuItem
    Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
    Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.main_Menu1 = New Salford.VisualClearWin.Main_Menu
    Me.statusBar1 = New System.Windows.Forms.StatusBar
    Me.toolBar1 = New System.Windows.Forms.ToolBar
    Me.toolBarButton_New = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton_Open = New System.Windows.Forms.ToolBarButton
    Me.SuspendLayout()
    '
    'imageList2
    '
    Me.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
    Me.imageList2.ImageSize = New System.Drawing.Size(16, 16)
    Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imageList2.TransparentColor = System.Drawing.Color.White
    '
    'tab_Control1
    '
    Me.tab_Control1.IsMdiContainer = True
    Me.tab_Control1.Location = New System.Drawing.Point(-1, 24)
    Me.tab_Control1.Name = "tab_Control1"
    Me.tab_Control1.Pivoting = Salford.VisualClearWin.Pivot.Full
    Me.tab_Control1.SelectedIndex = 0
    Me.tab_Control1.Size = New System.Drawing.Size(643, 336)
    Me.tab_Control1.TabIndex = 6
    '
    'menuItemFile
    '
    Me.menuItemFile.Index = 0
    Me.menuItemFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItemNew, Me.menuItemOpen, Me.menuItem5, Me.menuItemRecentFiles, Me.menuItemExit})
    Me.menuItemFile.Text = "File"
    '
    'menuItemNew
    '
    Me.main_Menu1.SetCallback(Me.menuItemNew, "New")
    Me.main_Menu1.SetImageIndex(Me.menuItemNew, "0")
    Me.menuItemNew.Index = 0
    Me.main_Menu1.SetMenuTip(Me.menuItemNew, "Creates a new file")
    Me.menuItemNew.Text = "New"
    '
    'menuItemOpen
    '
    Me.main_Menu1.SetCallback(Me.menuItemOpen, "Open")
    Me.main_Menu1.SetImageIndex(Me.menuItemOpen, "1")
    Me.menuItemOpen.Index = 1
    Me.main_Menu1.SetMenuTip(Me.menuItemOpen, "Opens an existing file")
    Me.menuItemOpen.Text = "Open"
    '
    'menuItem5
    '
    Me.main_Menu1.SetCallback(Me.menuItem5, Nothing)
    Me.main_Menu1.SetImageIndex(Me.menuItem5, Nothing)
    Me.menuItem5.Index = 2
    Me.main_Menu1.SetMenuTip(Me.menuItem5, Nothing)
    Me.menuItem5.Text = "-"
    '
    'menuItemRecentFiles
    '
    Me.main_Menu1.SetCallback(Me.menuItemRecentFiles, "RecentFiles4")
    Me.main_Menu1.SetImageIndex(Me.menuItemRecentFiles, "")
    Me.menuItemRecentFiles.Index = 3
    Me.main_Menu1.SetMenuTip(Me.menuItemRecentFiles, "")
    Me.menuItemRecentFiles.Text = "Recent Files"
    '
    'menuItemExit
    '
    Me.main_Menu1.SetCallback(Me.menuItemExit, "Exit")
    Me.main_Menu1.SetImageIndex(Me.menuItemExit, "")
    Me.menuItemExit.Index = 4
    Me.main_Menu1.SetMenuTip(Me.menuItemExit, "Exits from the application")
    Me.menuItemExit.Text = "Exit"
    '
    'imageList1
    '
    Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
    Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
    Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imageList1.TransparentColor = System.Drawing.Color.White
    '
    'main_Menu1
    '
    Me.main_Menu1.ImageBackColor = System.Drawing.SystemColors.Control
    Me.main_Menu1.ImageList = Me.imageList2
    Me.main_Menu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItemFile})
    Me.main_Menu1.TextBackColor = System.Drawing.SystemColors.Window
    '
    'statusBar1
    '
    Me.statusBar1.Location = New System.Drawing.Point(0, 368)
    Me.statusBar1.Name = "statusBar1"
    Me.statusBar1.Size = New System.Drawing.Size(642, 24)
    Me.statusBar1.TabIndex = 5
    '
    'toolBar1
    '
    Me.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
    Me.toolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.toolBarButton_New, Me.toolBarButton_Open})
    Me.toolBar1.ButtonSize = New System.Drawing.Size(16, 16)
    Me.toolBar1.DropDownArrows = True
    Me.toolBar1.ImageList = Me.imageList1
    Me.toolBar1.Location = New System.Drawing.Point(0, 0)
    Me.toolBar1.Name = "toolBar1"
    Me.toolBar1.ShowToolTips = True
    Me.toolBar1.Size = New System.Drawing.Size(642, 28)
    Me.toolBar1.TabIndex = 4
    '
    'toolBarButton_New
    '
    Me.toolBarButton_New.ImageIndex = 0
    Me.toolBarButton_New.ToolTipText = "New"
    '
    'toolBarButton_Open
    '
    Me.toolBarButton_Open.ImageIndex = 1
    Me.toolBarButton_Open.ToolTipText = "Open"
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(642, 392)
    Me.Controls.Add(Me.tab_Control1)
    Me.Controls.Add(Me.statusBar1)
    Me.Controls.Add(Me.toolBar1)
    Me.Menu = Me.main_Menu1
    Me.Name = "Form1"
    Me.Text = "Tabbed MDI"
    Me.ResumeLayout(False)

  End Sub

#End Region

End Class
